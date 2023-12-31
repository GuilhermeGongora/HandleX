﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_WEB
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (guna2CircleProgressBar1.Value == 100)
            {
                timer1.Stop();
                Form_Registration f = new Form_Registration();
                f.Show();
                this.Hide();
            }
            else
            {
                guna2CircleProgressBar1.Value += 1;
                label1.Text = "Carregando..." + guna2CircleProgressBar1.Value.ToString() + "%";
            }
        }

    }
}
