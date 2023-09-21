﻿using System;
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
            pct_Bio.Image = Properties.Resources.Biology;
        }

        private void pct_Bio_MouseMove(object sender, MouseEventArgs e)
        {
            pct_Bio.Image = Properties.Resources.icon_email;
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
    }
}
