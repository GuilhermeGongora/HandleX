using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_WEB
{
    public partial class Classroom : Form
    {
        public Classroom()
        {
            InitializeComponent();
        }

        public Classroom(string nome_log)
        {
            InitializeComponent();
            label1.Text = "Seja bem-vindo(a) " + nome_log;
        }

       

        private void button1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void pct_Bio_MouseHover(object sender, EventArgs e)
        {

        }

        private void pct_Bio_Click(object sender, EventArgs e)
        {
            string url = "C:\\Users\\Rogerio_Alexandre\\Desktop\\Expotec\\BIO\\bio.html";
            try
            {
                Process.Start("chrome.exe", url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir o Google Chrome: " + ex.Message);
            }
        }
    }
}
