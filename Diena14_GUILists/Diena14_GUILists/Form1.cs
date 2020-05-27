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
        //.ToCharArray - pārveido stringu uz char masīvu!!
        private void btnTest_Click(object sender, EventArgs e)
        {
            lstTest.View = View.Details;
            lstTest.Items.Add("elements");//strādā kā parasts sarkast
            //skaitlī ir jāparveido uz stringu, savādāk sarakstā neņems
            lstTest.Items[0].SubItems.Add("aa");//kas ir subitems???
            lstTest.Items[0].SubItems.Add("bb");
            //subitems ir kā kkādas detaļas; vērtības, kuras sadalītas ar komatu; var iedomāties kā saturu ar punktiem un apakšpunktiem

            lstTest.Items.Add(Convert.ToString(2));
        }
    }
}
