using System;
using System.Diagnostics;
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
            guna2HtmlLabel1.Text = "Seja bem-vindo(a) " + nome_log + ".";
        }



        private void button1_MouseHover(object sender, EventArgs e)
        {

        }

        private void pct_Bio_Click(object sender, EventArgs e)
        {
            string url = "C:\\Users\\Rogerio_Alexandre\\Desktop\\Expotec\\bio.html";
            try
            {
                Process.Start("chrome.exe", url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir o Google Chrome: " + ex.Message);
            }
        }

        private void pct_Bio_MouseLeave(object sender, EventArgs e)
        {
            pct_Bio.Image = Properties.Resources.Bio_Btn;
        }

        private void pct_Bio_MouseMove(object sender, MouseEventArgs e)
        {
            pct_Bio.Image = Properties.Resources.Component_1;
        }

        private void pct_Fis_Click(object sender, EventArgs e)
        {
            string url = "C:\\Users\\Rogerio_Alexandre\\Desktop\\Expotec\\fis.html";
            try
            {
                Process.Start("chrome.exe", url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir o Google Chrome: " + ex.Message);
            }
        }

        private void pct_Mat_Click(object sender, EventArgs e)
        {
            string url = "C:\\Users\\Rogerio_Alexandre\\Desktop\\Expotec\\mat.html";
            try
            {
                Process.Start("chrome.exe", url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir o Google Chrome: " + ex.Message);
            }
        }

        private void pct_Filo_Click(object sender, EventArgs e)
        {
            string url = "C:\\Users\\Rogerio_Alexandre\\Desktop\\Expotec\\filo.html";
            try
            {
                Process.Start("chrome.exe", url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir o Google Chrome: " + ex.Message);
            }
        }

        private void pct_Quim_Click(object sender, EventArgs e)
        {
            string url = "C:\\Users\\Rogerio_Alexandre\\Desktop\\Expotec\\quim.html";
            try
            {
                Process.Start("chrome.exe", url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir o Google Chrome: " + ex.Message);
            }
        }

        private void pct_Lit_Click(object sender, EventArgs e)
        {
            string url = "C:\\Users\\Rogerio_Alexandre\\Desktop\\Expotec\\lit.html";
            try
            {
                Process.Start("chrome.exe", url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir o Google Chrome: " + ex.Message);
            }
        }

        private void pct_Port_Click(object sender, EventArgs e)
        {
            string url = "C:\\Users\\Rogerio_Alexandre\\Desktop\\Expotec\\port.html";
            try
            {
                Process.Start("chrome.exe", url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir o Google Chrome: " + ex.Message);
            }
        }

        private void pct_Geo_Click(object sender, EventArgs e)
        {
            string url = "C:\\Users\\Rogerio_Alexandre\\Desktop\\Expotec\\geo.html";
            try
            {
                Process.Start("chrome.exe", url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir o Google Chrome: " + ex.Message);
            }
        }

        private void pct_hist_Click(object sender, EventArgs e)
        {
            string url = "C:\\Users\\Rogerio_Alexandre\\Desktop\\Expotec\\hist.html";
            try
            {
                Process.Start("chrome.exe", url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir o Google Chrome: " + ex.Message);
            }
        }

        private void pct_devs_Click(object sender, EventArgs e)
        {
            string url = "C:\\Users\\Rogerio_Alexandre\\Desktop\\Expotec\\devs.html";
            try
            {
                Process.Start("chrome.exe", url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir o Google Chrome: " + ex.Message);
            }
        }

        private void Classroom_Load(object sender, EventArgs e)
        {

        }

        private void pct_mold1_Click(object sender, EventArgs e)
        {
            string url = "C:\\Users\\Rogerio_Alexandre\\Desktop\\Expotec\\bio.html";
            try
            {
                Process.Start("chrome.exe", url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir o Google Chrome: " + ex.Message);
            }
        }

        private void pct_Quim_MouseMove(object sender, MouseEventArgs e)
        {
            pct_Quim.Image = Properties.Resources.Quim_Mold1;
        }

        private void pct_Filo_MouseMove(object sender, MouseEventArgs e)
        {
            pct_Filo.Image = Properties.Resources.Fil_Mold;
        }

        private void pct_Filo_MouseLeave(object sender, EventArgs e)
        {
            pct_Filo.Image = Properties.Resources.FILO_Icon;
        }

        private void pct_devs_MouseMove(object sender, MouseEventArgs e)
        {
            pct_devs.Image = Properties.Resources.Devs_Mold;
        }

        private void pct_devs_MouseLeave(object sender, EventArgs e)
        {
            pct_devs.Image = Properties.Resources.DEVS_Icon;
        }

        private void pct_Lit_MouseMove(object sender, MouseEventArgs e)
        {
            pct_Lit.Image = Properties.Resources.Lit_Mold;
        }

        private void pct_Lit_MouseLeave(object sender, EventArgs e)
        {
            pct_Lit.Image = Properties.Resources.LIT_Icon;
        }

        private void pct_Fis_MouseLeave(object sender, EventArgs e)
        {
            pct_Fis.Image = Properties.Resources.FIS_Icon;
        }

        private void pct_Fis_MouseMove(object sender, MouseEventArgs e)
        {
            pct_Fis.Image = Properties.Resources.Fis_Mold;
        }

        private void pct_Mat_MouseLeave(object sender, EventArgs e)
        {
            pct_Mat.Image = Properties.Resources.MAT_Icon;
        }

        private void pct_Mat_MouseMove(object sender, MouseEventArgs e)
        {
            pct_Mat.Image = Properties.Resources.Mat_Mold;
        }

        private void pct_Quim_MouseLeave(object sender, EventArgs e)
        {
            pct_Quim.Image = Properties.Resources.QUIM_Icon;
        }

        private void pct_Port_MouseMove(object sender, MouseEventArgs e)
        {
            pct_Port.Image = Properties.Resources.Port_Mold;
        }

        private void pct_Port_MouseLeave(object sender, EventArgs e)
        {
            pct_Port.Image = Properties.Resources.PT_Icon;
        }

        private void pct_Geo_MouseLeave(object sender, EventArgs e)
        {
            pct_Geo.Image = Properties.Resources.GEO_Icon;
        }

        private void pct_Geo_MouseMove(object sender, MouseEventArgs e)
        {
            pct_Geo.Image = Properties.Resources.Geo_Mold;
        }

        private void pct_hist_MouseLeave(object sender, EventArgs e)
        {
            pct_hist.Image = Properties.Resources.HIST_Icon;
        }

        private void pct_hist_MouseMove(object sender, MouseEventArgs e)
        {
            pct_hist.Image = Properties.Resources.Hist_Mold;
        }
    }
}
