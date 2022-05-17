using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class luonggiac : Form
    {
        public luonggiac()
        {
            InitializeComponent();
        }
        double rad;
        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();//Download source code tại Sharecode.vn
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt1cos.Clear();
            txt1cotan.Clear();
            txt1tan.Clear();
            txt1sin.Clear();

            //            lblnhap2.Text = "";

            txt1.Focus();
        }


        private void btn1sin_Click(object sender, EventArgs e)
        {
            if (txt1.Text != "")
            {
                txt1sin.Text = "....";
                 double   sin1 = Convert.ToDouble(txt1.Text);
                    sin1 = Math.Sin((sin1 *  Math.PI)/180);
                   txt1sin.Text = sin1.ToString();
            }
            else txt1.Text = "....";
        }

        private void btn1cos_Click(object sender, EventArgs e)
        {
            if (txt1.Text != "")
            {
                txt1cos.Text = "....";
                double cos1 = Convert.ToDouble(txt1.Text);
                cos1 = Math.Cos((cos1 * Math.PI) / 180);
                txt1cos.Text = cos1.ToString();
            }
            else txt1cos.Text = "....";
        }

        private void btn1tan_Click(object sender, EventArgs e)
        {
            if (txt1.Text != "")
            {
                txt1tan.Text = "....";
                double tan1 = Convert.ToDouble(txt1.Text);
                tan1 = Math.Tan((tan1 * Math.PI) / 180);
                txt1tan.Text = tan1.ToString();
            }
            else txt1tan.Text = "....";
        }

        private void btn1cotan_Click(object sender, EventArgs e)
        {
            if (txt1.Text != "")
            {
                txt1cotan.Text = "....";
                double cotan1 = Convert.ToDouble(txt1.Text);
                cotan1 = 1/(Math.Tan((cotan1 * Math.PI) / 180));
                txt1cotan.Text = cotan1.ToString();
            }
            else txt1cotan.Text = "....";
        }

    }
}