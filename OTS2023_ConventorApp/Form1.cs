using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OTS2023_ConventorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbtn_1.Checked)
            {
                MassConventer conventer = new MassConventer();
                txt_2.Text = conventer.Convert(Double.Parse(txt_1.Text)).ToString();
            }
            else if (rbtn_2.Checked)
            {
                LengthConventer conventer = new LengthConventer();
                txt_2.Text = conventer.Convert(Double.Parse(txt_1.Text)).ToString();
            }
            else
            {
                MessageBox.Show("Morate izabrati opciju koju zelite");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lbl_1.Text = "feet";
            lbl_2.Text = "m";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txt_1.Text = "";
            txt_2.Text = "";

            lbl_1.Text = "pounds";
            lbl_2.Text = "kg";
        }
    }
}
