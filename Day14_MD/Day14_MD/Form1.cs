using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day14_MD
{
    public partial class Form1 : Form
    {
        int AddTimes = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (AddTimes == 0)
            {
                lblInfo.Text = "Ierakstiet kreisaja loga elementu, kuru velaties pievienot sarakstam un tad atkal spiediet Add!";
            }
            else
            {

                if (txtIn.Text == "")
                {

                }
                else
                {
                    bool contains = false;
                    if(lstMain.Items.Count == 0)
                    {
                        lstMain.Items.Add(txtIn.Text);
                        lblInfo.Text = "Elements pievienots!";
                    }
                    else
                    {
                        for (int i = 0; i < lstMain.Items.Count; i++)
                        {
                        //taisit citu ciklu/ klat likt masivu?
                            if (lstMain.Items[i].Text == txtIn.Text)
                            {
                                lblInfo.Text = "Tads elements jau atrodas saraksta!";
                                contains = true;
                            }
                        }
                        if (!contains)
                        {
                            lstMain.Items.Add(txtIn.Text);
                            lblInfo.Text = "Elements pievienots!";
                        }
                        
                    }
                    
                    
                }
            }
            AddTimes++;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int times = 0;
            if (times == 0)
            {
                lblInfo.Text = "Ar kursoru iezimejiet elementu saraksta, kuru velaties izdzest un tad spiediet Delete";
            }
            else
            {
                foreach (ListViewItem item in lstMain.SelectedItems)
                {
                    item.Remove();
                }
            }
            times++;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnUndo_Click(object sender, EventArgs e)
        {

        }

        private void ListCopy()
        {
            for(int i = 0; i < lstMain.Items.Count; i++)
            {
                lstBackup = lstMain;
            }
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
/* pasniedzēja variants
        pie add

       if (inputBox.Text != ""){
        lstElements.Items.Add(inputBox.Text)}

        pie delete
        foreach(ListViewItem item in lstElements.SelectedItems)
        {
        //piekļūst pie aktra itema kas ir selektots - kas ir pie lista, pats cilvēks var iekrāsot un tad uzspiest uz pogu
        item.Remove();
        }

        pie edit

        lstElements.SelectedItems[0].Text = inputBox.Text;
        */
