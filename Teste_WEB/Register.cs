using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Teste_WEB
{
    public partial class Form_Registration : Form
    {
        SqlDataReader dr;
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-K1FQ5IFR;Initial Catalog=Auth;Integrated Security=True");
        String con_reg = @"Data Source=LAPTOP-K1FQ5IFR;Initial Catalog=Auth;Integrated Security=True";

        public Form_Registration()
        {
            InitializeComponent();
        }
        public Form_Registration(string nome_log)
        {
            InitializeComponent();
            txt_User.Text = nome_log; 
        }
        private static Regex email_validation()
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }
        static Regex validate_emailaddress = email_validation();
        private void Registration_Load(object sender, EventArgs e)
        {
            txt_Senha.UseSystemPasswordChar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

           
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_User.Clear();
            txt_Senha.Clear();
            txt_User.Focus();
        }

        private void btn_registro_Click(object sender, EventArgs e)
        {
            
        }
        void clear()
        {
            txt_User.Text = txt_Senha.Text = "";
        }

        private void btn_registro_Click_1(object sender, EventArgs e)
        {
            if (txt_User.Text == "" || txt_Senha.Text == "" || txt_Email.Text == "" || cmb_Sexo.Text == "")
                Msg_Data.Show();
            if (validate_emailaddress.IsMatch(txt_Email.Text) != true)
            {
                lbl_email.Text = "Email inválido, insira um email válido.";
                return;
            }
            using (SqlConnection sqlCon = new SqlConnection(con_reg))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("UserReg", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@Usuario", txt_User.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Senha", txt_Senha.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Email", txt_Email.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Sexo", cmb_Sexo.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                guna2MessageDialog1.Show();
                Classroom destino = new Classroom(txt_User.Text);
                this.Hide();
                destino.Show();
                clear();

            }
        }

        private void btn_limpar_Click_1(object sender, EventArgs e)
        {
            txt_User.Clear();
            txt_Senha.Clear();
            txt_Email.Clear();
            lbl_email.Text = "";
            cmb_Sexo.SelectedIndex = -1;
            txt_User.Focus();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = Msg_Box.Show();
            if (dialogo == DialogResult.Yes)
            Application.Exit();
        }

        private void guna2Shapes1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (CheckBox_Show.Checked)
            {
                CheckBox_Show.Image = Properties.Resources.icon_v;
                txt_Senha.UseSystemPasswordChar = false;
            }
            else
            {
                CheckBox_Show.Image = Properties.Resources.icon_n_visivel;
                txt_Senha.UseSystemPasswordChar = true;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Login destino_log = new Login();
            this.Hide();
            destino_log.Show();
        }
    }
    }

