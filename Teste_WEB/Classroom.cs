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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string nome_log)
        {
            InitializeComponent();
            label1.Text = "Seja bem-vindo(a) " + nome_log;
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
