﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task5dlg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Opacity == 1.0)
            {
                this.Opacity = 0.5;
            }
            else
            {
                this.Opacity = 1.0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.Pink)
            { 
                this.BackColor = Color.Yellow; 
            }
            else
            { 
                this.BackColor = Color.Pink;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("There's message for you: 'hello World!'","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
