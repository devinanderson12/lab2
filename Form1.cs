using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnANS_Click(object sender, EventArgs e)
        {
            double FirstNum1 = Convert.ToDouble(txtNum1.Text);
            double SecondNum2 = Convert.ToDouble(txtNum2.Text);
            double ThirdNum3 = Convert.ToDouble(txtNum3.Text);
            double FourthNum4 = Convert.ToDouble(txtNum4.Text);
            double FifthNum5 = Convert.ToDouble(txtNum5.Text);

            double Average = (FirstNum1 + SecondNum2 + ThirdNum3 + FourthNum4 + FifthNum5) / 5.0;

            lbldisplay6.Text = string.Format("{0,11}{1,11}{2,11}{3,11}{4,11}{5,11}{6,11}{7,11}{8,11}{9,11}{10,11}{11,11}",
                "\n" + "Grade 1:", FirstNum1,
                "\n" + "Grade 2:", SecondNum2,
                "\n" + "Grade 3:", ThirdNum3,
                "\n" + "Grade 4:", FourthNum4,
                "\n" + "Grade 5:", FifthNum5,
                "\n" + "Average:", Average);



            /**
 *
 * Name:devin 
 * Teacher:Mr. Hardman 
 * Assignment #, Program #
 * Date Last Modified: 
 *
 */

        }
    }
}
