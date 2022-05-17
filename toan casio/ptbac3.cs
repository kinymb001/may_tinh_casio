using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class ptbac3 : Form
    {
        public ptbac3()
        {
            InitializeComponent();
        }

        double a, b, c, d, delta, k, x1, x2, x3, x0, x, X;

        private void txt_d_TextChanged(object sender, EventArgs e)
        {
            lbl_pt.Text = txt_a.Text + "x^3 + " + txt_b.Text + "x^2 + " + txt_c.Text + "x + " + txt_d.Text + " = 0";
        }

        private void txt_c_TextChanged(object sender, EventArgs e)
        {
            lbl_pt.Text = txt_a.Text + "x^3 + " + txt_b.Text + "x^2 + " + txt_c.Text + "x + " + txt_d.Text + " = 0";
        }

        private void txt_b_TextChanged(object sender, EventArgs e)
        {
            lbl_pt.Text = txt_a.Text + "x^3 + " + txt_b.Text + "x^2 + " + txt_c.Text + "x + " + txt_d.Text + " = 0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_a.Clear();
            txt_b.Clear();
            txt_c.Clear();
            txt_d.Clear();
            lbl_kq.Text = "";
            lbl_pt.Text = "";
            txt_a.Focus();
        }

        private void txt_a_TextChanged(object sender, EventArgs e)
        {
            lbl_pt.Text = txt_a.Text + "x^3 + " + txt_b.Text + "x^2 + " + txt_c.Text + "x + " + txt_d.Text + " = 0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txt_a.Text);
            b = Convert.ToDouble(txt_b.Text);
            c = Convert.ToDouble(txt_c.Text);
            d = Convert.ToDouble(txt_d.Text);

            delta = Math.Pow(b, 2) - 3 * a * c;
            k = (9 * a * b * c - 2 * Math.Pow(b, 3) - 27 * Math.Pow(a, 2) * d) / (2 * Math.Sqrt(Math.Abs(Math.Pow(delta, 3))));

            if (delta > 0)
            {
                if (Math.Abs(k) <= 1)
                {
                    x1 = (2 * Math.Sqrt(delta) * Math.Cos((Math.Acos(k) / 3)) - b) / (3 * a);
                    x2 = (2 * Math.Sqrt(delta) * Math.Cos((Math.Acos(k) / 3 - (2 * Math.PI / 3))) - b) / (3 * a);
                    x3 = (2 * Math.Sqrt(delta) * Math.Cos((Math.Acos(k) / 3 + (2 * Math.PI / 3))) - b) / (3 * a);
                    //printf("pt co 3 ngiem:\n%.2f\n%.2f\n%.2f", x1, x2, x3);
                    lbl_kq.Text = "phuong trinh co 3 nghiem phan biet:\nx1= " + x1 + "\nx2=" + x2 + "\nx3=" + x3;
                }
                else
                {
                    x0 = ((Math.Sqrt(delta) * Math.Abs(k)) / (3 * a * k)) * (Math.Pow(Math.Abs(k) + Math.Sqrt(Math.Pow(k, 2) - 1), 1 / 3) + Math.Pow(Math.Abs(k) - Math.Sqrt(Math.Pow(k, 2) - 1), 1 / 3)) - (b / (3 * a));
                    //printf("pt co nghiem duy nhat: %.2f", x0);
                    lbl_kq.Text = "phương trình có nghiệm duy nhất:\nx0 = " + x0;
                }
            }


            if (delta == 0)
            {
                X = (-b + Math.Pow(Math.Pow(b, 3) - 27 * Math.Pow(a, 2) * d, 1 / 3)) / (3 * a);
                //printf("pt co nghiem boi: %.2f", X);
                lbl_kq.Text = "phương trình có nghiệm bội:\nX = " + X;
            }
            if (delta < 0)
            {
                x = (Math.Sqrt(Math.Abs(delta)) / (3 * a)) * (Math.Pow(k + Math.Sqrt(Math.Pow(k, 2) + 1), 1 / 3) + Math.Pow(k - Math.Sqrt(Math.Pow(k, 2) + 1), 1 / 3)) - (b / (3 * a));
               // printf("pt co nghiem duy nhat: %.2f", x);
            }
        }

    }
}
