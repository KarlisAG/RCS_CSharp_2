using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diena14_GUILists
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBox.Text.Length == 0)
            {

            }
            else
            {
                lst.Items.Add(txtBox.Text);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtBoxNumber.Text.Length == 0)
            {
                if (txtBox.Text.Length == 0)
                {

                }
                else
                {
                    txtBoxNumber.Visible = true;
                    lblMessage.Text = "Ievadiet elemta indeksu, kuru velaties izdzest spiediet Delete!";
                    
                }
            }
            else
            {
                lblMessage.Text = "Ievadiet elemta indeksu, kuru velaties izdzest un spiediet Delete!";
                txtBoxNumber.Visible = true;
                try
                {
                    int choice = Convert.ToInt32(txtBoxNumber.Text);
                    lst.Items[choice - 1].Remove();
                }
                catch
                {
                    lblMessage.Text = "Jums ir jāievada cipars!";
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtBoxNumber.Text.Length == 0)
            {
                if (txtBox.Text.Length == 0)
                {

                }
                else
                {
                    txtBoxNumber.Visible = true;
                    lblMessage.Text = "Ievadiet elemta indeksu, kuru velaties rediget un spiediet Edit!";
                }
            }
            else
            {
                lblMessage.Text = "Ievadiet elemta indeksu, kuru velaties rediget un spiediet Edit!";
                txtBoxNumber.Visible = true;
                try
                {
                    int choice = Convert.ToInt32(txtBoxNumber.Text);
                    lblMessage.Text = "Ievadiet jauna elementa tekstu zemak!";
                    txtBoxEdit.Visible = true;
                    lst.Items[choice - 1].Text = txtBoxEdit.Text;
                }
                catch
                {

                }

            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }
        
        //.ToCharArray - pārveido stringu uz char masīvu!!
        //private void btnTest_Click(object sender, EventArgs e)
        //{
        //    lstTest.View = View.Details;//nosaka kā uz lietām skatās/tiek siplajotas?!
        //    lstTest.Items.Add("elements");//strādā kā parasts sarkast
        //    //skaitlī ir jāparveido uz stringu, savādāk sarakstā neņems
        //    lstTest.Items[0].SubItems.Add("aa");//kas ir subitems???
        //    lstTest.Items[0].SubItems.Add("bb");
        //    //subitems ir kā kkādas detaļas; vērtības, kuras sadalītas ar komatu; var iedomāties kā saturu ar punktiem un apakšpunktiem

        //    lstTest.Items.Add(Convert.ToString(2));
        //}



    }
}
