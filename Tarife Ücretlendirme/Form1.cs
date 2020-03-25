using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tarife_Ücretlendirme
{
    public partial class Form1 : Form
    {
        #region Değişkenler

        double para = 0;
        int dk = 0;

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            dk = int.Parse(maskedTextBox1.Text);

            if (radioButton1.Checked==true)
            {
                if (dk>=1 || dk<=10)
                {
                    para = dk * 0.10;
                }

                else if (dk > 10 || dk <= 30)
                {
                    para = dk * 0.07;
                }

                else if (dk > 30)
                {
                    para = dk * 0.05;
                }
            }

            else if (radioButton2.Checked==true)
            {
                if (dk>=1 || dk<=10)
                {
                    para = dk * 0.07;
                }

                else if (dk > 10 || dk <= 30)
                {
                    para = dk * 0.05;
                }

                else if (dk > 30)
                {
                    para = dk * 0.03;
                }
            }

            label3.Text = para.ToString()+" TL";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
