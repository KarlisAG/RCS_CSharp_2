using System;
using System.Collections;
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
        ListView lstBackup = new ListView();
        int lastClicked = 0;
        String lastAdded;
        int lstLength;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lastClicked = 1;
            //ListCopy();
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
                        lastAdded = txtIn.Text;
                    }
                    else
                    {
                        for (int i = 0; i < lstMain.Items.Count; i++)
                        {
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
                            lastAdded = txtIn.Text;
                        }
                        
                    }
                    
                    
                }
            }
            lstLength = lstMain.Items.Count;
            txtIn.Clear();
            AddTimes++;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lastClicked = 2;
            //ListCopy();
            int times = 0;
            txtChoice.Visible = true;
            if (times == 0)
            {
                //lblInfo.Text = "Ar kursoru iezimejiet elementu saraksta, kuru velaties izdzest un tad spiediet Delete";
                lblInfo.Text = "Zemak ierakstiet elementa indeksu, kuru velaties iznemt";
            }
            else
            {
                int choice;
                try
                {
                    choice = Convert.ToInt32(txtChoice);
                    lstMain.Items.RemoveAt(choice);
                }
                catch
                {
                    lblInfo.Text = "Ievades kluda";
                }
                

                //foreach (ListViewItem item in lstMain.SelectedItems)
                //{
                //    item.Remove();
                //}
            }
            txtIn.Clear();
            txtChoice.Clear();
            times++;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            lastClicked = 3;
            //ListCopy();

        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            //lblInfo.Text = lastClicked + " " + lastAdded;
            switch (lastClicked)
            {
                case 1:
                    lstMain.Items.RemoveAt(lstLength - 1);
                    break;
                case 2:

                    break;
            }
            //lstMain.Clear();
            //for (int i = 0; i < listView1.Items.Count; i++)
            //{
            //    lstMain.Items[i] = listView1.Items[i];
            //}
        }

        private void ListCopy()
        {
            listView1.Items.Clear();
            //string[] lst = new string[lstMain.Items.Count];
            //lstMain.Items.CopyTo(lst, 0);
            //for (int i = 0; i < lst.Length; i++)
            //{
            //    listView1.Items.Add(lst[i]);
            //}
            //foreach(String str in lst)
            //{
            //    var items = new ListViewItem();
            //    items.Text = str;
            //    listView1.Items.Add(items);
            //}
            //lstBackup.Clear();

            //listView1 = (ListViewItem)lst.Clone();
            //listView1.Clear();
            //for (int i = 0; i < lstMain.Items.Count - 1; i++)
            //{
            //    listView1.Items.Add(lstMain.Items[i]);
            //}
            //foreach (ListViewItem a in lstMain.Items)
            //{
            //    lst.Add(a);
            //}
            //foreach (ListViewItem b in lst)
            //{
            //    listView1.Items.Add(b);
            //}
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
