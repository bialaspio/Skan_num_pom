namespace Bierun_numerowanie_operatow
{
    partial class FormMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbIdOperatu = new System.Windows.Forms.RadioButton();
            this.rbNrNaPu = new System.Windows.Forms.RadioButton();
            this.rbDataDDZ = new System.Windows.Forms.RadioButton();
            this.txtIdOperatu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rbKERG = new System.Windows.Forms.RadioButton();
            this.txtDataDDZ = new System.Windows.Forms.TextBox();
            this.txtNrNaPolce = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lab_id_operatu = new System.Windows.Forms.Label();
            this.bt_szukaj = new System.Windows.Forms.Button();
            this.txtSzuKERG = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.grBoxDodajOperat = new System.Windows.Forms.GroupBox();
            this.cmbDodObreb = new System.Windows.Forms.ComboBox();
            this.txt_ogc_fid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDodNrNaPolce = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lab_Id_dod_oper = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.butDodajOperat = new System.Windows.Forms.Button();
            this.dateTPData_dod_do_zas = new System.Windows.Forms.DateTimePicker();
            this.txtDodajKERG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTmp = new System.Windows.Forms.TextBox();
            this.dgvData_pom = new System.Windows.Forms.DataGridView();
            this.butEdytujDane = new System.Windows.Forms.Button();
            this.butDodajWpis = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.labUzytkownik = new System.Windows.Forms.Label();
            this.btZeskanowane = new System.Windows.Forms.Button();
            this.npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            this.maskedTxtData_dod_do_zas = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.grBoxDodajOperat.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData_pom)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbIdOperatu);
            this.groupBox1.Controls.Add(this.rbNrNaPu);
            this.groupBox1.Controls.Add(this.rbDataDDZ);
            this.groupBox1.Controls.Add(this.txtIdOperatu);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.rbKERG);
            this.groupBox1.Controls.Add(this.txtDataDDZ);
            this.groupBox1.Controls.Add(this.txtNrNaPolce);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.bt_szukaj);
            this.groupBox1.Controls.Add(this.txtSzuKERG);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1033, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wyszukiwanie";
            // 
            // rbIdOperatu
            // 
            this.rbIdOperatu.AutoSize = true;
            this.rbIdOperatu.Location = new System.Drawing.Point(284, 40);
            this.rbIdOperatu.Name = "rbIdOperatu";
            this.rbIdOperatu.Size = new System.Drawing.Size(14, 13);
            this.rbIdOperatu.TabIndex = 16;
            this.rbIdOperatu.UseVisualStyleBackColor = true;
            this.rbIdOperatu.CheckedChanged += new System.EventHandler(this.rbIdOperatu_CheckedChanged);
            // 
            // rbNrNaPu
            // 
            this.rbNrNaPu.AutoSize = true;
            this.rbNrNaPu.Location = new System.Drawing.Point(426, 40);
            this.rbNrNaPu.Name = "rbNrNaPu";
            this.rbNrNaPu.Size = new System.Drawing.Size(14, 13);
            this.rbNrNaPu.TabIndex = 13;
            this.rbNrNaPu.UseVisualStyleBackColor = true;
            this.rbNrNaPu.CheckedChanged += new System.EventHandler(this.rbNrNaPu_CheckedChanged);
            // 
            // rbDataDDZ
            // 
            this.rbDataDDZ.AutoSize = true;
            this.rbDataDDZ.Location = new System.Drawing.Point(568, 40);
            this.rbDataDDZ.Name = "rbDataDDZ";
            this.rbDataDDZ.Size = new System.Drawing.Size(14, 13);
            this.rbDataDDZ.TabIndex = 12;
            this.rbDataDDZ.UseVisualStyleBackColor = true;
            this.rbDataDDZ.CheckedChanged += new System.EventHandler(this.rbDataDDZ_CheckedChanged);
            // 
            // txtIdOperatu
            // 
            this.txtIdOperatu.Location = new System.Drawing.Point(165, 36);
            this.txtIdOperatu.Name = "txtIdOperatu";
            this.txtIdOperatu.Size = new System.Drawing.Size(115, 20);
            this.txtIdOperatu.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(160, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Id operatu";
            // 
            // rbKERG
            // 
            this.rbKERG.AutoSize = true;
            this.rbKERG.Location = new System.Drawing.Point(133, 40);
            this.rbKERG.Name = "rbKERG";
            this.rbKERG.Size = new System.Drawing.Size(14, 13);
            this.rbKERG.TabIndex = 11;
            this.rbKERG.UseVisualStyleBackColor = true;
            this.rbKERG.CheckedChanged += new System.EventHandler(this.rbKERG_CheckedChanged);
            // 
            // txtDataDDZ
            // 
            this.txtDataDDZ.Location = new System.Drawing.Point(448, 36);
            this.txtDataDDZ.Name = "txtDataDDZ";
            this.txtDataDDZ.Size = new System.Drawing.Size(115, 20);
            this.txtDataDDZ.TabIndex = 10;
            // 
            // txtNrNaPolce
            // 
            this.txtNrNaPolce.Location = new System.Drawing.Point(308, 36);
            this.txtNrNaPolce.Name = "txtNrNaPolce";
            this.txtNrNaPolce.Size = new System.Drawing.Size(115, 20);
            this.txtNrNaPolce.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(446, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Data dodania do zasobu";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Numer na półce";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox2.Controls.Add(this.lab_id_operatu);
            this.groupBox2.Location = new System.Drawing.Point(678, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 54);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Id operatu";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lab_id_operatu
            // 
            this.lab_id_operatu.AutoSize = true;
            this.lab_id_operatu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_id_operatu.ForeColor = System.Drawing.Color.ForestGreen;
            this.lab_id_operatu.Location = new System.Drawing.Point(6, 12);
            this.lab_id_operatu.Name = "lab_id_operatu";
            this.lab_id_operatu.Size = new System.Drawing.Size(0, 31);
            this.lab_id_operatu.TabIndex = 0;
            // 
            // bt_szukaj
            // 
            this.bt_szukaj.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bt_szukaj.Location = new System.Drawing.Point(594, 18);
            this.bt_szukaj.Name = "bt_szukaj";
            this.bt_szukaj.Size = new System.Drawing.Size(75, 42);
            this.bt_szukaj.TabIndex = 2;
            this.bt_szukaj.Text = "Szukaj";
            this.bt_szukaj.UseVisualStyleBackColor = false;
            this.bt_szukaj.Click += new System.EventHandler(this.bt_szukaj_Click);
            // 
            // txtSzuKERG
            // 
            this.txtSzuKERG.Location = new System.Drawing.Point(4, 36);
            this.txtSzuKERG.Name = "txtSzuKERG";
            this.txtSzuKERG.Size = new System.Drawing.Size(123, 20);
            this.txtSzuKERG.TabIndex = 1;
            this.txtSzuKERG.TextChanged += new System.EventHandler(this.texSzuKERG_TextChanged);
            this.txtSzuKERG.Enter += new System.EventHandler(this.texSzuKERG_Enter);
            this.txtSzuKERG.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSzuKERG_KeyDown);
            this.txtSzuKERG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSzuKERG_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "KERG/Id operatu/Nr na polce";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(24, 148);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvData.Size = new System.Drawing.Size(1033, 261);
            this.dgvData.TabIndex = 1;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            this.dgvData.Sorted += new System.EventHandler(this.dgvData_Sorted);
            // 
            // grBoxDodajOperat
            // 
            this.grBoxDodajOperat.Controls.Add(this.cmbDodObreb);
            this.grBoxDodajOperat.Controls.Add(this.txt_ogc_fid);
            this.grBoxDodajOperat.Controls.Add(this.label8);
            this.grBoxDodajOperat.Controls.Add(this.txtDodNrNaPolce);
            this.grBoxDodajOperat.Controls.Add(this.label5);
            this.grBoxDodajOperat.Controls.Add(this.panel1);
            this.grBoxDodajOperat.Controls.Add(this.butDodajOperat);
            this.grBoxDodajOperat.Controls.Add(this.dateTPData_dod_do_zas);
            this.grBoxDodajOperat.Controls.Add(this.txtDodajKERG);
            this.grBoxDodajOperat.Controls.Add(this.label3);
            this.grBoxDodajOperat.Controls.Add(this.label2);
            this.grBoxDodajOperat.Enabled = false;
            this.grBoxDodajOperat.Location = new System.Drawing.Point(26, 468);
            this.grBoxDodajOperat.Name = "grBoxDodajOperat";
            this.grBoxDodajOperat.Size = new System.Drawing.Size(1033, 75);
            this.grBoxDodajOperat.TabIndex = 2;
            this.grBoxDodajOperat.TabStop = false;
            this.grBoxDodajOperat.Text = "Dodawanie operatu";
            // 
            // cmbDodObreb
            // 
            this.cmbDodObreb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDodObreb.FormattingEnabled = true;
            this.cmbDodObreb.Items.AddRange(new object[] {
            "",
            "[]",
            "687[241401_0.0025]",
            "688[241401_0.0027]",
            "689[241401_0.0033]",
            "7[241401_0.0035]",
            "711[241401_0.0028]",
            "712[241401_0.0026]",
            "713[241401_0.0034]",
            "735[241401_0.0029]",
            "736[241401_0.0024]",
            "737[241401_0.0032]",
            "759[241401_0.0030]",
            "Bieruń Nowy[241401_1.0001]",
            "Bieruń Stary[241401_1.0002]",
            "Bijasowice[241401_1.0003]",
            "Bojszowy Nowe[241404_2.0002]",
            "Bojszowy[241404_2.0001]",
            "Chełm Śląski[241405_2.0001]",
            "Czarnuchowice[241401_1.0004]",
            "Gać[241402_1.0002]",
            "Goławiec[241403_1.0002]",
            "Górki[241403_1.0001]",
            "Hołdunów[241403_1.0003]",
            "Imielin[241402_1.0001]",
            "Jedlina[241404_2.0003]",
            "Kopciowice[241405_2.0002]",
            "Lędziny[241403_1.0004]",
            "Międzyrzecze[241404_2.0004]",
            "Smardzowice[241403_1.0005]",
            "Ściernie[241401_1.0005]",
            "Świerczyniec[241404_2.0005]"});
            this.cmbDodObreb.Location = new System.Drawing.Point(475, 34);
            this.cmbDodObreb.Name = "cmbDodObreb";
            this.cmbDodObreb.Size = new System.Drawing.Size(138, 21);
            this.cmbDodObreb.TabIndex = 14;
            // 
            // txt_ogc_fid
            // 
            this.txt_ogc_fid.Location = new System.Drawing.Point(530, 10);
            this.txt_ogc_fid.Name = "txt_ogc_fid";
            this.txt_ogc_fid.Size = new System.Drawing.Size(24, 20);
            this.txt_ogc_fid.TabIndex = 13;
            this.txt_ogc_fid.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(472, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Obręb";
            // 
            // txtDodNrNaPolce
            // 
            this.txtDodNrNaPolce.Enabled = false;
            this.txtDodNrNaPolce.Location = new System.Drawing.Point(317, 35);
            this.txtDodNrNaPolce.Name = "txtDodNrNaPolce";
            this.txtDodNrNaPolce.Size = new System.Drawing.Size(139, 20);
            this.txtDodNrNaPolce.TabIndex = 10;
            this.txtDodNrNaPolce.TextChanged += new System.EventHandler(this.txtDodNrNaPolce_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nr na półce";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.lab_Id_dod_oper);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(629, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 53);
            this.panel1.TabIndex = 8;
            // 
            // lab_Id_dod_oper
            // 
            this.lab_Id_dod_oper.AutoSize = true;
            this.lab_Id_dod_oper.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_Id_dod_oper.ForeColor = System.Drawing.Color.ForestGreen;
            this.lab_Id_dod_oper.Location = new System.Drawing.Point(14, 15);
            this.lab_Id_dod_oper.Name = "lab_Id_dod_oper";
            this.lab_Id_dod_oper.Size = new System.Drawing.Size(0, 29);
            this.lab_Id_dod_oper.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Id operatu";
            // 
            // butDodajOperat
            // 
            this.butDodajOperat.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.butDodajOperat.Enabled = false;
            this.butDodajOperat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.butDodajOperat.ForeColor = System.Drawing.Color.Red;
            this.butDodajOperat.Location = new System.Drawing.Point(894, 11);
            this.butDodajOperat.Name = "butDodajOperat";
            this.butDodajOperat.Size = new System.Drawing.Size(127, 55);
            this.butDodajOperat.TabIndex = 6;
            this.butDodajOperat.Text = "Zapisz";
            this.butDodajOperat.UseVisualStyleBackColor = false;
            this.butDodajOperat.Click += new System.EventHandler(this.butDodajOperat_Click);
            // 
            // dateTPData_dod_do_zas
            // 
            this.dateTPData_dod_do_zas.AllowDrop = true;
            this.dateTPData_dod_do_zas.CustomFormat = "yyyy-MM-dd";
            this.dateTPData_dod_do_zas.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTPData_dod_do_zas.Location = new System.Drawing.Point(169, 35);
            this.dateTPData_dod_do_zas.MaxDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dateTPData_dod_do_zas.MinDate = new System.DateTime(1890, 1, 1, 0, 0, 0, 0);
            this.dateTPData_dod_do_zas.Name = "dateTPData_dod_do_zas";
            this.dateTPData_dod_do_zas.Size = new System.Drawing.Size(133, 20);
            this.dateTPData_dod_do_zas.TabIndex = 5;
            this.dateTPData_dod_do_zas.Value = new System.DateTime(2020, 2, 13, 0, 0, 0, 0);
            this.dateTPData_dod_do_zas.CloseUp += new System.EventHandler(this.dateTPData_dod_do_zas_CloseUp);
            this.dateTPData_dod_do_zas.ValueChanged += new System.EventHandler(this.dateTPData_dod_do_zas_ValueChanged);
            this.dateTPData_dod_do_zas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dateTPData_dod_do_zas_MouseDown);
            // 
            // txtDodajKERG
            // 
            this.txtDodajKERG.Location = new System.Drawing.Point(21, 35);
            this.txtDodajKERG.Name = "txtDodajKERG";
            this.txtDodajKERG.Size = new System.Drawing.Size(131, 20);
            this.txtDodajKERG.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Data dodania do zasobu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Numer KERG";
            // 
            // txtTmp
            // 
            this.txtTmp.Location = new System.Drawing.Point(24, 614);
            this.txtTmp.Name = "txtTmp";
            this.txtTmp.Size = new System.Drawing.Size(1027, 20);
            this.txtTmp.TabIndex = 3;
            this.txtTmp.Visible = false;
            // 
            // dgvData_pom
            // 
            this.dgvData_pom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData_pom.Location = new System.Drawing.Point(24, 415);
            this.dgvData_pom.Name = "dgvData_pom";
            this.dgvData_pom.Size = new System.Drawing.Size(10, 56);
            this.dgvData_pom.TabIndex = 4;
            this.dgvData_pom.Visible = false;
            // 
            // butEdytujDane
            // 
            this.butEdytujDane.Enabled = false;
            this.butEdytujDane.Location = new System.Drawing.Point(57, 427);
            this.butEdytujDane.Name = "butEdytujDane";
            this.butEdytujDane.Size = new System.Drawing.Size(99, 23);
            this.butEdytujDane.TabIndex = 5;
            this.butEdytujDane.Text = "Włacz edycje";
            this.butEdytujDane.UseVisualStyleBackColor = true;
            this.butEdytujDane.Click += new System.EventHandler(this.butEdytujDane_Click);
            // 
            // butDodajWpis
            // 
            this.butDodajWpis.Location = new System.Drawing.Point(172, 427);
            this.butDodajWpis.Name = "butDodajWpis";
            this.butDodajWpis.Size = new System.Drawing.Size(99, 23);
            this.butDodajWpis.TabIndex = 6;
            this.butDodajWpis.Text = "Dodaj wpis";
            this.butDodajWpis.UseVisualStyleBackColor = true;
            this.butDodajWpis.Click += new System.EventHandler(this.butDodajWpis_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(877, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Użytkownik:";
            // 
            // labUzytkownik
            // 
            this.labUzytkownik.AutoSize = true;
            this.labUzytkownik.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labUzytkownik.Location = new System.Drawing.Point(949, 13);
            this.labUzytkownik.Name = "labUzytkownik";
            this.labUzytkownik.Size = new System.Drawing.Size(0, 13);
            this.labUzytkownik.TabIndex = 8;
            // 
            // btZeskanowane
            // 
            this.btZeskanowane.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btZeskanowane.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btZeskanowane.ForeColor = System.Drawing.Color.Green;
            this.btZeskanowane.Location = new System.Drawing.Point(26, 550);
            this.btZeskanowane.Name = "btZeskanowane";
            this.btZeskanowane.Size = new System.Drawing.Size(1021, 58);
            this.btZeskanowane.TabIndex = 9;
            this.btZeskanowane.Text = "ZESKANOWANE";
            this.btZeskanowane.UseVisualStyleBackColor = false;
            this.btZeskanowane.Click += new System.EventHandler(this.button1_Click);
            // 
            // npgsqlDataAdapter1
            // 
            this.npgsqlDataAdapter1.DeleteCommand = null;
            this.npgsqlDataAdapter1.InsertCommand = null;
            this.npgsqlDataAdapter1.SelectCommand = null;
            this.npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // maskedTxtData_dod_do_zas
            // 
            this.maskedTxtData_dod_do_zas.Location = new System.Drawing.Point(296, 427);
            this.maskedTxtData_dod_do_zas.Mask = "0000-00-00";
            this.maskedTxtData_dod_do_zas.Name = "maskedTxtData_dod_do_zas";
            this.maskedTxtData_dod_do_zas.Size = new System.Drawing.Size(123, 20);
            this.maskedTxtData_dod_do_zas.TabIndex = 10;
            this.maskedTxtData_dod_do_zas.ValidatingType = typeof(System.DateTime);
            this.maskedTxtData_dod_do_zas.Visible = false;
            this.maskedTxtData_dod_do_zas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedTxtData_dod_do_zas_MouseClick);
            this.maskedTxtData_dod_do_zas.TabIndexChanged += new System.EventHandler(this.maskedTextBox1_TabIndexChanged);
            this.maskedTxtData_dod_do_zas.TextChanged += new System.EventHandler(this.maskedTextBox1_TextChanged);
            this.maskedTxtData_dod_do_zas.Leave += new System.EventHandler(this.maskedTextBox1_Leave);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 631);
            this.Controls.Add(this.maskedTxtData_dod_do_zas);
            this.Controls.Add(this.btZeskanowane);
            this.Controls.Add(this.labUzytkownik);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.butDodajWpis);
            this.Controls.Add(this.butEdytujDane);
            this.Controls.Add(this.dgvData_pom);
            this.Controls.Add(this.txtTmp);
            this.Controls.Add(this.grBoxDodajOperat);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1100, 670);
            this.Name = "FormMain";
            this.Text = "Bieruń skanowanie v1.0.3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.grBoxDodajOperat.ResumeLayout(false);
            this.grBoxDodajOperat.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData_pom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lab_id_operatu;
        private System.Windows.Forms.Button bt_szukaj;
        private System.Windows.Forms.TextBox txtSzuKERG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.GroupBox grBoxDodajOperat;
        private System.Windows.Forms.Button butDodajOperat;
        private System.Windows.Forms.DateTimePicker dateTPData_dod_do_zas;
        private System.Windows.Forms.TextBox txtDodajKERG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTmp;
        private System.Windows.Forms.Label lab_Id_dod_oper;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvData_pom;
        private System.Windows.Forms.TextBox txtDodNrNaPolce;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDataDDZ;
        private System.Windows.Forms.TextBox txtNrNaPolce;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button butEdytujDane;
        private System.Windows.Forms.Button butDodajWpis;
        private System.Windows.Forms.RadioButton rbNrNaPu;
        private System.Windows.Forms.RadioButton rbDataDDZ;
        private System.Windows.Forms.RadioButton rbKERG;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labUzytkownik;
        private System.Windows.Forms.RadioButton rbIdOperatu;
        private System.Windows.Forms.TextBox txtIdOperatu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btZeskanowane;
        private System.Windows.Forms.TextBox txt_ogc_fid;
        private System.Windows.Forms.ComboBox cmbDodObreb;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private System.Windows.Forms.MaskedTextBox maskedTxtData_dod_do_zas;
    }
}

