using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_WEB
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlDataReader dr;
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-K1FQ5IFR;Initial Catalog=Auth;Integrated Security=True");
        String con_reg = @"Data Source=LAPTOP-K1FQ5IFR;Initial Catalog=Auth;Integrated Security=True";
        private static Regex email_validation()
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }
        static Regex validate_emailaddress = email_validation();
        public Login(string nome_log)
        {
            InitializeComponent();
            txt_User.Text = nome_log;
        }

        private void Registration_User_Load(object sender, EventArgs e)
        {
            txt_Senha.UseSystemPasswordChar = true;
        }
      
        private void guna2ImageCheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (guna2ImageCheckBox1.Checked)
            {
                guna2ImageCheckBox1.Image = Properties.Resources.icon_v;
                txt_Senha.UseSystemPasswordChar = false;
            }
            else
            {
                guna2ImageCheckBox1.Image = Properties.Resources.icon_n_visivel;
                txt_Senha.UseSystemPasswordChar = true;
            }
        }

        private void btn_registro_Click(object sender, EventArgs e)
        {
            String username, user_password;

            username = txt_Email.Text;
            user_password = txt_Senha.Text;

            if (txt_Email.Text == "" || txt_Senha.Text == "")
                Msg_Pass.Show();
            if (validate_emailaddress.IsMatch(txt_Email.Text) != true)
            {
                lbl_email.Text = "Email inválido!";
                return;
            }
            try
            {
                String query = "SELECT * FROM Register_TB WHERE Email = '" + txt_Email.Text + "' AND Senha = '" + txt_Senha.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    username = txt_Email.Text;
                    user_password = txt_Senha.Text;
                    Classroom Form1 = new Classroom(txt_User.Text);
                    Form1.Show();
                    this.Hide();
                }
                else
                {
                    Msg_Wrong.Show();
                    txt_Email.Clear();
                    txt_Senha.Clear();
                    txt_Email.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro de cadastro");
            }
            finally
            {
                conn.Close();
            }
        }

        private void lbl_con_Click(object sender, EventArgs e)
        {
            Form_Registration destino_reg = new Form_Registration();
            this.Hide();
            destino_reg.Show();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = Msg_Close.Show();
            if (dialogo == DialogResult.Yes)
                Application.Exit();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_Email.Clear();
            txt_Senha.Clear();
            txt_User.Clear();
            lbl_email.Text = "";
        }
    }
}
