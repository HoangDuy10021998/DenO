using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DenO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtSo1.Text);
            double b = double.Parse(txtSo2.Text);
            double c = a - b;
            txtKetqua.Text = c.ToString();
        }
    }
}
