using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Npgsql;
using NLog;

namespace Bierun_numerowanie_operatow
{
    public partial class FormMain : Form
    {
        private readonly FormLogin fr_log;
        private string select_query;
        private string update_query;
        private string insert_query;
        private string szukane;
        private string KERG;
        private string Id_Operatu;
        private string Nr_na_polce;
        private DateTime Data_DDZ;
        private DateTime Data_out;
        private string Obreb;
        private string Ogc_fid;
        private string tabla_rok_z_id;
        private string result_str;
        private string id_w_rok;
        private string rok;
        private string Data_DDZ_str;
        private string tmp;
        private int flaga_dodaj;
        private int flaga_edytuj;
        private string KERG_pob;
        private string Id_Operatu_pob;
        private string Nr_na_polce_pob;
        private string Data_DDZ_str_pob;
        private string Obreb_pob;
        private string rok_pob;
        private string dodaj_maska;

        private NpgsqlConnection conn;
        private NpgsqlCommand cmd;
        private DataTable dt;
        private DataTable dt_l;

        private static readonly Logger _loger = LogManager.GetLogger("mojeLogowanieNazwa");

        // Podlacznie do bazy postgresa 
        public string connecting = String.Format("Server={0};Port={1};" +
        "Database={2};User Id ={3}; Password={4};", "sql.tmce.nazwa.pl", 5432, "tmce_BierunOp2023", "tmce_BierunOp2023", "dtv4LjZuPHfo801");

        public FormMain(FormLogin fr_log)
        {
            this.fr_log = fr_log;
            InitializeComponent();
            _loger.Info($"Zalogowano {fr_log.uzytkownik}.");
        }

        private void bt_szukaj_Click(object sender, EventArgs e)
        {
            lab_id_operatu.Text = "";
            grBoxDodajOperat.Enabled = false;

            if (rbKERG.Checked)
            {
                szukane = txtSzuKERG.Text;
                select_query = $"Select * from owb_V01 where ID_Pracy like '%{szukane}%' or ID_Operatu like '%{szukane}%' or Data_przyjecia_do_zasobu like '%{szukane}%' or Nr_Operatu_na_polce like '%{szukane}%';";
            }
            else if (rbIdOperatu.Checked)
            {
                szukane = txtIdOperatu.Text;
                select_query = $"Select * from owb_V01 where ID_Operatu like '%{szukane}%';";
            }
            else if (rbDataDDZ.Checked)
            {
                szukane = txtDataDDZ.Text;
                select_query = $"Select * from owb_V01 where Data_przyjecia_do_zasobu like '%{szukane}%';";
            }
            else if (rbNrNaPu.Checked)
            {
                szukane = txtNrNaPolce.Text;
                select_query = $"Select * from owb_V01 where Nr_Operatu_na_polce like '%{szukane}%';";
            }

            Select_dgv(select_query);

            butEdytujDane.Enabled = dgvData.Rows.Count > 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connecting);
            flaga_dodaj = 0;
            flaga_edytuj = 0;
            txtDataDDZ.Text = "";
            txtNrNaPolce.Text = "";
            txtSzuKERG.Text = "";
            txtSzuKERG.Enabled = true;
            txtNrNaPolce.Enabled = false;
            txtDataDDZ.Enabled = false;
            rbKERG.Checked = true;
            labUzytkownik.Text = fr_log.uzytkownik;
            btZeskanowane.Enabled = false;
        }

        private void Select_dgv(string query_sql)
        {
            try
            {
                conn.Open();
                using (cmd = new NpgsqlCommand(query_sql, conn))
                {
                    dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    dgvData.DataSource = dt;

                    dgvData.Columns["ogc_fid"].Visible = false;
                    dgvData.Columns["edkerg"].Visible = false;
                    dgvData.Columns["eddataddz"].Visible = false;
                    dgvData.Columns["ednronp"].Visible = false;
                    dgvData.Columns["edidoperat"].Visible = false;
                    dgvData.Columns["edobreb"].Visible = false;
                    dgvData.Columns["zeskanowane"].Visible = false;
                    dgvData.Columns["modyfikujacy"].Visible = false;
                    dgvData.Columns["skanujacy"].Visible = false;
                    dgvData.Columns["pudelko"].Visible = false;
                    dgvData.Columns["rok_prz_do_zas"].Visible = false;
                    dgvData.Columns["mark_prev_part"].Visible = false;

                    foreach (DataGridViewRow row in dgvData.Rows)
                    {
                        if (row.Cells[14].Value.ToString().Length > 0)
                        {
                            row.DefaultCellStyle.BackColor = Color.LemonChiffon;
                        }

                        if (row.Cells[14].Value.ToString() == "Tak")
                        {
                            row.DefaultCellStyle.BackColor = Color.GreenYellow;
                        }

                        if (row.Cells[9].Value.ToString() == "Tak")
                        {
                            row.Cells[1].Style.ForeColor = Color.DarkMagenta;
                        }

                        if (row.Cells[10].Value.ToString() == "Tak")
                        {
                            row.Cells[2].Style.ForeColor = Color.DarkMagenta;
                        }

                        if (row.Cells[11].Value.ToString() == "Tak")
                        {
                            row.Cells[3].Style.ForeColor = Color.DarkMagenta;
                        }

                        if (row.Cells["EdIDOperat"].Value.ToString() == "Tak")
                        {
                            row.Cells["ID_Operatu"].Style.ForeColor = Color.DarkMagenta;
                        }

                        if (row.Cells["EdObreb"].Value.ToString() == "Tak")
                        {
                            row.Cells["obreb"].Style.ForeColor = Color.DarkMagenta;
                        }

                        if (row.Cells[20].Value.ToString() == "TAK")
                        {
                            row.DefaultCellStyle.BackColor = Color.Red;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Select_id(string query_sql)
        {
            try
            {
                conn.Open();
                using (cmd = new NpgsqlCommand(query_sql, conn))
                {
                    dt_l = new DataTable();
                    dt_l.Load(cmd.ExecuteReader());
                    dgvData_pom.DataSource = dt_l;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void pobierz_najm_id_w_rok(int rok)
        {
            tabla_rok_z_id = "id_w_rok_" + rok;
            _loger.Info($"tabla_rok_z_id = {tabla_rok_z_id}");
            select_query = $"select min(id_w_rok) from {tabla_rok_z_id} where wyk = 0;";
            Select_id(select_query);
            _loger.Info($"Select_id({select_query})");
        }

        private void rezerwuj_id(string rok, string id_w_rok)
        {
            tabla_rok_z_id = "id_w_rok_" + rok;
            _loger.Info($"tabla_rok_z_id = {tabla_rok_z_id}");
            update_query = $"UPDATE {tabla_rok_z_id} set wyk=2 where id_w_rok = {id_w_rok};";
            _loger.Info($"update_query = {update_query}");
            try
            {
                conn.Open();
                using (cmd = new NpgsqlCommand(update_query, conn))
                {
                    int recordAffected = cmd.ExecuteNonQuery();
                    _loger.Info($"recordAffected = {recordAffected}");

                    if (recordAffected > 0)
                    {
                        MessageBox.Show("Zarezerwowano nr operatu");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btZeskanowane.Enabled = false;
            if (e.RowIndex == -1)
            {
                tmp = "a";
            }
            else
            {
                if (dgvData.Rows[e.RowIndex].Cells[4].Value != null)
                {
                    dgvData.CurrentRow.Selected = true;
                    Id_Operatu = dgvData.Rows[e.RowIndex].Cells[4].Value.ToString();
                }

                if (!string.IsNullOrEmpty(Id_Operatu))
                {
                    lab_id_operatu.ForeColor = Color.ForestGreen;
                    lab_id_operatu.Text = Id_Operatu;
                    grBoxDodajOperat.Enabled = false;

                    Ogc_fid = dgvData.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txt_ogc_fid.Text = Ogc_fid;

                    KERG = dgvData.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtDodajKERG.Text = KERG;

                    Obreb = dgvData.Rows[e.RowIndex].Cells[8].Value.ToString();
                    cmbDodObreb.Text = Obreb;

                    Nr_na_polce = dgvData.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtDodNrNaPolce.Text = Nr_na_polce;

                    if (string.IsNullOrEmpty(Nr_na_polce))
                    {
                        txtDodNrNaPolce.Enabled = true;
                    }

                    if (Obreb == "[]")
                    {
                        cmbDodObreb.Enabled = true;
                    }

                    Data_DDZ = DateTime.ParseExact(dgvData.Rows[e.RowIndex].Cells[2].Value.ToString(), "yyyy-MM-dd", CultureInfo.InvariantCulture);
                    dateTPData_dod_do_zas.Value = Data_DDZ;

                    lab_Id_dod_oper.Text = Id_Operatu;
                }
                else
                {
                    flaga_edytuj = 1;
                    flaga_dodaj = 0;
                    butDodajWpis.Enabled = false;
                    butEdytujDane.Enabled = false;
                    lab_id_operatu.ForeColor = Color.Red;
                    lab_id_operatu.Text = "Brak Id operatu";
                    lab_Id_dod_oper.Text = "";
                    Nr_na_polce = dgvData.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtDodNrNaPolce.Text = Nr_na_polce;
                    grBoxDodajOperat.Enabled = true;

                    Ogc_fid = dgvData.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txt_ogc_fid.Text = Ogc_fid;

                    KERG_pob = txtDodajKERG.Text;
                    Id_Operatu_pob = lab_Id_dod_oper.Text;
                    Nr_na_polce_pob = txtDodNrNaPolce.Text;
                    Data_DDZ_str_pob = dateTPData_dod_do_zas.Value.ToString("yyyy-MM-dd");
                    Obreb_pob = cmbDodObreb.Text;

                    KERG = dgvData.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtDodajKERG.Text = KERG;
                    txtDodajKERG.Enabled = false;

                    if (dgvData.Rows[e.RowIndex].Cells[2].Value == null || string.IsNullOrWhiteSpace(dgvData.Rows[e.RowIndex].Cells[2].Value.ToString()))
                    {
                        Data_DDZ = DateTime.ParseExact(DateTime.Now.ToString("yyyy-MM-dd"), "yyyy-MM-dd", CultureInfo.InvariantCulture);
                        dateTPData_dod_do_zas.Value = Data_DDZ;
                        dateTPData_dod_do_zas.Enabled = true;
                    }
                    else
                    {
                        Data_DDZ = DateTime.ParseExact(dgvData.Rows[e.RowIndex].Cells[2].Value.ToString(), "yyyy-MM-dd", CultureInfo.InvariantCulture);
                        dateTPData_dod_do_zas.Value = Data_DDZ;
                        dateTPData_dod_do_zas.Enabled = false;
                    }
                }
                tmp = dgvData.Rows[e.RowIndex].Cells["zeskanowane"].Value.ToString();
                if (dgvData.Rows[e.RowIndex].Cells["zeskanowane"].Value.ToString() == "Nie")
                {
                    btZeskanowane.Enabled = true;
                }
                rok_pob = dateTPData_dod_do_zas.Value.Year.ToString();
            }
        }

        private void dateTPData_dod_do_zas_CloseUp(object sender, EventArgs e)
        {
            if (dateTPData_dod_do_zas.Enabled)
            {
                if (dateTPData_dod_do_zas.Value == Data_DDZ)
                {
                    butDodajOperat.Enabled = false;
                }
                else
                {
                    rok = dateTPData_dod_do_zas.Value.Year.ToString();
                    _loger.Info($"rok = {rok}");
                    _loger.Info($"rok_pob = {rok_pob}");
                    if (rok != rok_pob)
                    {
                        butDodajOperat.Enabled = true;
                        _loger.Info($"pobierz_najm_id_w_rok({dateTPData_dod_do_zas.Value.Year})");
                        pobierz_najm_id_w_rok(dateTPData_dod_do_zas.Value.Year);
                        id_w_rok = dgvData_pom.Rows[0].Cells[0].Value.ToString();
                        _loger.Info($"id_w_rok = {id_w_rok}");
                        lab_Id_dod_oper.Text = $"P.2414.{rok}.{id_w_rok}";
                        _loger.Info($"lab_Id_dod_oper.Text = {lab_Id_dod_oper.Text}");
                        _loger.Info($"rezerwuj_id({rok}, {id_w_rok})");
                        rezerwuj_id(rok, id_w_rok);
                    }
                }
            }
            else
            {
                butDodajOperat.Enabled = false;
            }
        }
        //----------------------------------------
        /*
        private void butDodajOperat_Click(object sender, EventArgs e)
        {

            Ogc_fid = txt_ogc_fid.Text;
            KERG = txtDodajKERG.Text;
            Id_Operatu = lab_Id_dod_oper.Text;
            Nr_na_polce = txtDodNrNaPolce.Text;
            Data_DDZ_str = dateTPData_dod_do_zas.Value.ToString("yyyy-MM-dd");
            // Data_DDZ_str = maskedTxtData_dod_do_zas.Text;

            //Obreb = txtDodObreb.Text;
            Obreb = cmbDodObreb.Text;
            lab_id_operatu.Text = "";



            if (flaga_edytuj == 1)
            {
                insert_query = "insert into owb_v01_history select *, now() from owb_v01 where ogc_fid =" + Ogc_fid + ";";
                try
                {
                    conn.Open();
                    cmd = new NpgsqlCommand(insert_query, conn);
                    int recordAffected = cmd.ExecuteNonQuery();
                    if (Convert.ToBoolean(recordAffected))
                    {
                        MessageBox.Show("Dodano wpis do tabeli historii");
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Error :" + ex.Message);
                }
                //  Obreb = txtDodObreb.Text;
                //  Obreb = txtDodObreb.Text;
                //update_query = "UPDATE OWB_V01 set Data_przyjecia_do_zasobu = '" + Data_DDZ_str + "', Nr_Operatu_na_polce ='" + Nr_na_polce + "' , ID_Operatu ='" + Id_Operatu + "', obreb ='" + Obreb + "' where ID_Pracy like '" + KERG + "';";
                //update_query = "UPDATE OWB_V01 set ID_Pracy = '" + KERG+"', Data_przyjecia_do_zasobu = '" + Data_DDZ_str + "', Nr_Operatu_na_polce ='" + Nr_na_polce + "' , ID_Operatu ='" + Id_Operatu + "', obreb ='" + Obreb + "' where ogc_fid = " + txt_ogc_fid.Text + ";";
                //update_query = "UPDATE OWB_V01 set ID_Pracy = '" + KERG + "', Data_przyjecia_do_zasobu = '" + Data_DDZ_str + "', Nr_Operatu_na_polce ='" + Nr_na_polce + "' , ID_Operatu ='" + Id_Operatu + "', obreb ='" + Obreb + "', modyfikujacy ='" + labUzytkownik.Text + "' where ogc_fid = " + txt_ogc_fid.Text + ";";
                update_query = "UPDATE OWB_V01 set Data_przyjecia_do_zasobu = '" + Data_DDZ_str + "', ID_Operatu ='" + Id_Operatu + "', modyfikujacy ='" + labUzytkownik.Text + "' where ogc_fid = " + txt_ogc_fid.Text + ";";
                txtTmp.Text = update_query;
                try
                {
                    conn.Open();
                    cmd = new NpgsqlCommand(update_query, conn);
                    int recordAffected = cmd.ExecuteNonQuery();
                    if (Convert.ToBoolean(recordAffected))
                    {
                        MessageBox.Show("Dane zostały zaktualizowane");
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Error :" + ex.Message);
                }
                //EdKERG, ''::varchar as EdDataDDZ,''::varchar as EdNrONP,''::varchar as EdIDOperat,''::varchar as EdObreb,     
                //Oznaczenie co bylo edytowane
                if (KERG_pob != txtDodajKERG.Text)
                {
                    //update_query = "UPDATE OWB_V01 set EdKERG = 'Tak' where ID_Pracy like '" + txtDodajKERG.Text + "';";
                    update_query = "UPDATE OWB_V01 set EdKERG = 'Tak' where ogc_fid = " + txt_ogc_fid.Text + ";";
                    try
                    {
                        conn.Open();
                        cmd = new NpgsqlCommand(update_query, conn);
                        int recordAffected = cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        MessageBox.Show("Error :" + ex.Message);
                    }
                }

                //if (Data_DDZ_str_pob != maskedTxtData_dod_do_zas.Text)
                if (Data_DDZ_str_pob != dateTPData_dod_do_zas.Value.ToString("yyyy-MM-dd"))
                {
                    update_query = "UPDATE OWB_V01 set EdDataDDZ = 'Tak' where ogc_fid = " + txt_ogc_fid.Text + ";";
                    try
                    {
                        conn.Open();
                        cmd = new NpgsqlCommand(update_query, conn);
                        int recordAffected = cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        MessageBox.Show("Error :" + ex.Message);
                    }
                }

                if (Id_Operatu_pob != lab_Id_dod_oper.Text)
                {
                    update_query = "UPDATE OWB_V01 set EdIDOperat = 'Tak' where ogc_fid = " + txt_ogc_fid.Text + ";";
                    try
                    {
                        conn.Open();
                        cmd = new NpgsqlCommand(update_query, conn);
                        int recordAffected = cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        MessageBox.Show("Error :" + ex.Message);
                    }
                }

                if (Nr_na_polce_pob != txtDodNrNaPolce.Text)
                {
                    update_query = "UPDATE OWB_V01 set EdNrONP = 'Tak' where ogc_fid = " + txt_ogc_fid.Text + ";";
                    try
                    {
                        conn.Open();
                        cmd = new NpgsqlCommand(update_query, conn);
                        int recordAffected = cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        MessageBox.Show("Error :" + ex.Message);
                    }
                }

                //   if (Obreb_pob != txtDodObreb.Text)
                if (Obreb_pob != cmbDodObreb.Text)
                {
                    update_query = "UPDATE OWB_V01 set EdObreb = 'Tak' where ogc_fid = " + txt_ogc_fid.Text + ";";
                    try
                    {
                        conn.Open();
                        cmd = new NpgsqlCommand(update_query, conn);
                        int recordAffected = cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        MessageBox.Show("Error :" + ex.Message);
                    }
                }
                // Id_Operatu = lab_Id_dod_oper.Text;
                // Nr_na_polce = txtDodNrNaPolce.Text;
                // Data_DDZ_str = dateTPData_dod_do_zas.Value.ToString("yyyy-MM-dd");
                // Obreb = txtDodObreb.Text;

            }

            if (flaga_dodaj == 1)
            {

                update_query = "INSERT INTO OWB_V01 (ogc_fid, ID_Pracy, Data_przyjecia_do_zasobu, Nr_Operatu_na_polce, ID_Operatu, obreb,zeskanowane) VALUES ((select max(ogc_fid)+1 from OWB_V01),'" + KERG + "','" + Data_DDZ_str + "','" + Nr_na_polce + "','" + Id_Operatu + "','" + Obreb + "','Nie');";
                txtTmp.Text = update_query;
                try
                {
                    conn.Open();
                    cmd = new NpgsqlCommand(update_query, conn);
                    int recordAffected = cmd.ExecuteNonQuery();
                    if (Convert.ToBoolean(recordAffected))
                    {
                        MessageBox.Show("Wpis dodany do bazy");
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Error :" + ex.Message);
                }
            }

            szukane = Id_Operatu;
            select_query = "Select *from owb_V01 where ID_Operatu like '" + szukane + "';";
            Select_dgv(select_query);
            flaga_dodaj = 0;
            flaga_edytuj = 0;
            butEdytujDane.Enabled = false;
            butDodajOperat.Enabled = false;
            grBoxDodajOperat.Enabled = false;
        }
        */
        private void butDodajOperat_Click(object sender, EventArgs e)
        {
            Ogc_fid = txt_ogc_fid.Text;
            KERG = txtDodajKERG.Text;
            Id_Operatu = lab_Id_dod_oper.Text;
            Nr_na_polce = txtDodNrNaPolce.Text;
            Data_DDZ_str = dateTPData_dod_do_zas.Value.ToString("yyyy-MM-dd");
            Obreb = cmbDodObreb.Text;
            lab_id_operatu.Text = "";

            try
            {
                conn.Open();

                if (flaga_edytuj == 1)
                {
                    insert_query = $"INSERT INTO owb_v01_history SELECT *, now() FROM owb_v01 WHERE ogc_fid = {Ogc_fid};";
                    using (cmd = new NpgsqlCommand(insert_query, conn))
                    {
                        int recordAffected = cmd.ExecuteNonQuery();
                        if (recordAffected > 0)
                        {
                            MessageBox.Show("Dodano wpis do tabeli historii");
                        }
                    }

                    update_query = $"UPDATE OWB_V01 SET Data_przyjecia_do_zasobu = '{Data_DDZ_str}', ID_Operatu = '{Id_Operatu}', modyfikujacy = '{labUzytkownik.Text}' WHERE ogc_fid = {Ogc_fid};";
                    using (cmd = new NpgsqlCommand(update_query, conn))
                    {
                        int recordAffected = cmd.ExecuteNonQuery();
                        if (recordAffected > 0)
                        {
                            MessageBox.Show("Dane zostały zaktualizowane");
                        }
                    }

                    UpdateEdytowanePola();
                }
                else if (flaga_dodaj == 1)
                {
                    update_query = $"INSERT INTO OWB_V01 (ogc_fid, ID_Pracy, Data_przyjecia_do_zasobu, Nr_Operatu_na_polce, ID_Operatu, obreb, zeskanowane) VALUES ((SELECT MAX(ogc_fid) + 1 FROM OWB_V01), '{KERG}', '{Data_DDZ_str}', '{Nr_na_polce}', '{Id_Operatu}', '{Obreb}', 'Nie');";
                    using (cmd = new NpgsqlCommand(update_query, conn))
                    {
                        int recordAffected = cmd.ExecuteNonQuery();
                        if (recordAffected > 0)
                        {
                            MessageBox.Show("Wpis dodany do bazy");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            szukane = Id_Operatu;
            select_query = $"SELECT * FROM owb_V01 WHERE ID_Operatu LIKE '{szukane}';";
            Select_dgv(select_query);
            flaga_dodaj = 0;
            flaga_edytuj = 0;
            butEdytujDane.Enabled = false;
            butDodajOperat.Enabled = false;
            grBoxDodajOperat.Enabled = false;
        }

        private void UpdateEdytowanePola()
        {
            if (KERG_pob != txtDodajKERG.Text)
            {
                update_query = $"UPDATE OWB_V01 SET EdKERG = 'Tak' WHERE ogc_fid = {Ogc_fid};";
                ExecuteNonQuery(update_query);
            }

            if (Data_DDZ_str_pob != dateTPData_dod_do_zas.Value.ToString("yyyy-MM-dd"))
            {
                update_query = $"UPDATE OWB_V01 SET EdDataDDZ = 'Tak' WHERE ogc_fid = {Ogc_fid};";
                ExecuteNonQuery(update_query);
            }

            if (Id_Operatu_pob != Id_Operatu)
            {
                update_query = $"UPDATE OWB_V01 SET EdIDOperat = 'Tak' WHERE ogc_fid = {Ogc_fid};";
                ExecuteNonQuery(update_query);
            }

            if (Nr_na_polce_pob != Nr_na_polce)
            {
                update_query = $"UPDATE OWB_V01 SET EdNrONP = 'Tak' WHERE ogc_fid = {Ogc_fid};";
                ExecuteNonQuery(update_query);
            }

            if (Obreb_pob != Obreb)
            {
                update_query = $"UPDATE OWB_V01 SET EdObreb = 'Tak' WHERE ogc_fid = {Ogc_fid};";
                ExecuteNonQuery(update_query);
            }
        }

        private void ExecuteNonQuery(string query)
        {
            try
            {
                using (cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void texSzuKERG_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void butDodajWpis_Click(object sender, EventArgs e)
        {
            rok_pob = "0";
            flaga_dodaj = 1;
            flaga_edytuj = 0;
            grBoxDodajOperat.Enabled = true;
            butEdytujDane.Enabled = false;
            txtDodajKERG.Enabled = true;
            txtDodajKERG.Text = "";
            txtIdOperatu.Text = "";
            txtDodNrNaPolce.Text = "";
            // txtDodObreb.Text = "";
            lab_Id_dod_oper.Text = "";
            lab_id_operatu.Text = "";
            dgvData.DataSource = null;
            dateTPData_dod_do_zas.Value = DateTime.ParseExact("2023-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            cmbDodObreb.SelectedIndex = cmbDodObreb.FindStringExact("");
            btZeskanowane.Enabled = false;

        }

        private void butEdytujDane_Click(object sender, EventArgs e)
        {
            flaga_edytuj = 1;
            flaga_dodaj = 0;
            grBoxDodajOperat.Enabled = true;
            txtDodajKERG.Enabled = true;
            butDodajOperat.Enabled = true;

            KERG_pob = txtDodajKERG.Text;
            Id_Operatu_pob = lab_Id_dod_oper.Text;
            Nr_na_polce_pob = txtDodNrNaPolce.Text;
            Data_DDZ_str_pob = dateTPData_dod_do_zas.Value.ToString("yyyy-MM-dd");
            // Data_DDZ_str_pob =maskedTxtData_dod_do_zas.Text;
            Obreb_pob = cmbDodObreb.Text;
            //Obreb_pob = txtDodObreb.Text;
        }
        private void rbKERG_CheckedChanged(object sender, EventArgs e)
        {
            txtDataDDZ.Text = "";
            txtNrNaPolce.Text = "";
            txtSzuKERG.Text = "";
            txtIdOperatu.Text = "";
            txtIdOperatu.Enabled = false;
            txtSzuKERG.Enabled = true;
            txtNrNaPolce.Enabled = false;
            txtDataDDZ.Enabled = false;
        }

        private void rbNrNaPu_CheckedChanged(object sender, EventArgs e)
        {
            txtDataDDZ.Text = "";
            txtNrNaPolce.Text = "";
            txtSzuKERG.Text = "";
            txtIdOperatu.Text = "";
            txtIdOperatu.Enabled = false;
            txtNrNaPolce.Enabled = true;
            txtDataDDZ.Enabled = false;
            txtSzuKERG.Enabled = false;
        }

        private void rbDataDDZ_CheckedChanged(object sender, EventArgs e)
        {
            txtDataDDZ.Text = "";
            txtNrNaPolce.Text = "";
            txtSzuKERG.Text = "";
            txtIdOperatu.Text = "";
            txtIdOperatu.Enabled = false;
            txtDataDDZ.Enabled = true;
            txtNrNaPolce.Enabled = false;
            txtSzuKERG.Enabled = false;
        }

        private void rbIdOperatu_CheckedChanged(object sender, EventArgs e)
        {
            txtDataDDZ.Text = "";
            txtNrNaPolce.Text = "";
            txtSzuKERG.Text = "";
            txtIdOperatu.Text = "";
            txtIdOperatu.Enabled = true;
            txtNrNaPolce.Enabled = false;
            txtDataDDZ.Enabled = false;
            txtSzuKERG.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                update_query = "UPDATE owb_V01 set zeskanowane = 'Tak',skanujacy = '" + labUzytkownik.Text + "',data_skan = now() where ogc_fid = " + txt_ogc_fid.Text + ";";
                conn.Open();
                cmd = new NpgsqlCommand(update_query, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvData_pom.DataSource = null;
                dgvData_pom.DataSource = dt;
                conn.Close();
                select_query = "select *from owb_V01 where ogc_fid = " + txt_ogc_fid.Text + ";";
                Select_dgv(select_query);
                btZeskanowane.Enabled = false;

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error :" + ex.Message);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void dateTPData_dod_do_zas_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void txtSzuKERG_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtSzuKERG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                szukane = txtSzuKERG.Text;
                //select_query = "Select ID_Pracy, Data_przyjecia_do_zasobu, Nr_Operatu_na_polce , ID_Operatu ,Zakonczona ,Zaniechana ,Obreb  from owb_V01 where ID_Pracy like '%" + szukane + "%';";
                //select_query = "Select * from owb_V01 where ID_Pracy like '%" + szukane + "%';";
                select_query = "Select * from owb_V01 where ID_Pracy like '%" + szukane + "%' or ID_Operatu like '%" + szukane + "%' or Data_przyjecia_do_zasobu like '%" + szukane + "%' or Nr_Operatu_na_polce like '%" + szukane + "%';";

                Select_dgv(select_query);

                if (dgvData.Rows.Count == 0)
                {
                    butEdytujDane.Enabled = false;
                }
            }
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
            if (!DateTime.TryParseExact(maskedTxtData_dod_do_zas.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out Data_out))
            {
                if (maskedTxtData_dod_do_zas.Text == "    -  -")
                {
                }
                else
                {
                    maskedTxtData_dod_do_zas.Text = "";
                    MessageBox.Show("Program przyjmuje jedynie liczby \ndo trzech miejsc po przecinku !!!", "Błąd danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void maskedTxtData_dod_do_zas_MouseClick(object sender, MouseEventArgs e)
        {

            maskedTxtData_dod_do_zas.Select();
            maskedTxtData_dod_do_zas.Select(0, 0);
        }

        private void dgvData_Sorted(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dgvData.Rows)
            {

                if (row.Cells[14].Value.ToString().Length > 0)
                {
                    row.DefaultCellStyle.BackColor = Color.LemonChiffon;
                }

                //Oznacznie zeskanowanych 
                if (row.Cells[13].Value.ToString() == "Tak")
                {
                    row.DefaultCellStyle.BackColor = Color.GreenYellow;
                }

                // Zmiana KERG 
                if (row.Cells[8].Value.ToString() == "Tak")
                {
                    row.Cells[1].Style.ForeColor = Color.DarkMagenta;

                }
                // Data przyjecia do zapobu 
                if (row.Cells[9].Value.ToString() == "Tak")
                {
                    row.Cells[2].Style.ForeColor = Color.DarkMagenta;

                }
                // Numer na polce
                if (row.Cells[10].Value.ToString() == "Tak")
                {
                    row.Cells[3].Style.ForeColor = Color.DarkMagenta;

                }
                // Id operatu 
                if (row.Cells["EdIDOperat"].Value.ToString() == "Tak")
                {
                    row.Cells["ID_Operatu"].Style.ForeColor = Color.DarkMagenta;
                }
                // Id operatu 
                if (row.Cells["EdObreb"].Value.ToString() == "Tak")
                {
                    row.Cells["obreb"].Style.ForeColor = Color.DarkMagenta;
                }
            }
        }

        private void txtDodNrNaPolce_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
