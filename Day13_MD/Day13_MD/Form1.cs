using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day13_MD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            bool valid = true;

            if(txtBoxName.Text.Length == 0 || txtBoxSurname.Text.Length == 0)
            {
                valid = false;
            }

            try
            {
                int number = Convert.ToInt32(txtBoxCourse.Text);
                if(1 <= number && number <= 3)
                {
                    lblOut.Text = "Students validēts! " + "Students, " + txtBoxName.Text  + " " + txtBoxSurname.Text + 
                        ", studēs " + txtBoxCourse.Text + ". kursā!";
                }
                else
                {
                    lblOut.Text = "Kursam ir jābūt no 1 līdz 3!";
                }
            }
            catch
            {
                lblOut.Text = "Pie kursa ir jāievada cipars!";
            }

            if (valid == false)
            {
                lblOut.Text = "Nepareiza ievade!";
            }
        }
    }
}
