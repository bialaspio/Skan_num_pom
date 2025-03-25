using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace Bierun_numerowanie_operatow
{

    public partial class FormLogin : Form
    {
        private NpgsqlConnection conn;
        private NpgsqlCommand cmd;
        private DataTable dt;
        private string select_query;

        public int uzytkownik_id;
        public string uzytkownik;

        // Podlacznie do bazy postgresa 
        public string connecting = String.Format("Server={0};Port={1};" +
        "Database={2};User Id ={3}; Password={4};", "__host__", 5432, "__dbname__", "__user__", "__passwd__");
        //"Database={2};User Id ={3}; Password={4};", "sql.tmce.nazwa.pl", 5432, "tmce_operaty", "tmce_operaty", "R@q711%D!42WxY&");
        //"Database={2};User Id ={3}; Password={4};", "crait", 5432, "Bierun_operaty_v02", "postgres", "aaaaaa");


        public FormLogin()
        {
            InitializeComponent();
            
        }

        private void btLogowanie_Click(object sender, EventArgs e)
        {

            // Retrieve all rows
            select_query = "SELECT id,user_ FROM users where user_ = '"+txtNazUzytkownika.Text +"' and pass = '"+txtHaslo.Text+"';";
            try
            {
                conn = new NpgsqlConnection(connecting);
                conn.Open();
                cmd = new NpgsqlCommand(select_query, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvLogowanie.DataSource = null;
                dgvLogowanie.DataSource = dt;
                uzytkownik_id = Int32.Parse(dgvLogowanie.Rows[0].Cells[0].Value.ToString());
                uzytkownik = dgvLogowanie.Rows[0].Cells[1].Value.ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error :" + ex.Message);
            }

            if (uzytkownik_id > 0)
            {
               this.Hide();
               FormMain FMain = new FormMain(this);
               FMain.Owner = this;
               FMain.Show();
            }
            else {
                MessageBox.Show("Błędne dane logowania. \n Sprawdz nazwę użytkownika i hasło ");
            }

        }

        private void btZamknij_Click(object sender, EventArgs e)
        {
            this.Hide();
            System.Windows.Forms.Application.Exit();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void txtNazUzytkownika_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
