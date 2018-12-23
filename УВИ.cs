﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace d1
{
    public partial class УВИ : Form
    {
        public УВИ()
        {
            InitializeComponent();
            button1.Visible = false;
		}

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void overwatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "image/b.jpg";
            pictureBox2.ImageLocation = "image/c.jpg";
            button1.Visible = true;
        }

        private void paladinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "image/d2.png";
            pictureBox2.ImageLocation = "image/dddd1.jpg";
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
			{
				Пик form2 = new Пик();
				form2.ShowDialog();
				this.Show();
			}
        }
    }
}
