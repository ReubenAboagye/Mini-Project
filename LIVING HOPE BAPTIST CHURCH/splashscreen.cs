﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIVING_HOPE_BAPTIST_CHURCH
{
    public partial class splashscreen : Form
    {
        public splashscreen()
        {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if (panel2.Width >= 800)
            {
                timer1.Stop();
                Form1 li = new Form1();
                li.Show();
                this.Hide();
            }
        }
    }
}
