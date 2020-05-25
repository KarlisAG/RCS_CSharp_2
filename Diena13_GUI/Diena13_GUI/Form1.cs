using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diena13_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Print();
        }
        //events -> textchanged - izdzes tur, lai metodi izdēstu
        public void CheckTextBoxes()
        {
            if(fieldName.Text == "")
            {
                label4.Text = "laukums nav aizpildīts!";
                InitializeComponent();
            }
            else
            {
                label4.Text = "  ";
            }

            if (fieldSurname.Text == "")
            {
                label6.Text = "laukums nav aizpildīts!";
                InitializeComponent();
            }

            if (fieldCourse.Text == "")
            {
                
                label7.Text = "laukums nav aizpildīts!";
                InitializeComponent();
            }
        }
        public void CheckCourse()
        {

        }
        public void Print()
        {
            labelMessage.Text = String.Format(fieldName + " " + fieldSurname + " "+ fieldCourse);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            CheckTextBoxes();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            bool valid = true;//valid = ziliga krasa -gaisi

            if (fieldName.Text.Length < 1 && fieldSurname.Text.Length < 1)
            {
                valid = false;
            }

            int course = 0;

            try//rozigi krasu
            {
                course = Convert.ToInt32(fieldCourse.Text);
            }
            catch
            {
                valid = false;
            }

            if (valid)
            {
                labelMessage.Text = "Veiksmigi!";
            }
            else
            {
                labelMessage.Text = "Nav pareiza ievade";
            }
        }
    }
}
