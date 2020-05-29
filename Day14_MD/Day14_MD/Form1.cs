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
        int DeleteTimes = 0;
        int EditTimes = 0;

        int lastClicked = 0;

        String lastAdded;
        String lastDeleted;
        int removedAt;
        String beforeEdit;
        int beforeEditAt;

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
            txtChoice.Visible = true;
            if (DeleteTimes == 0)
            {
                lblInfo.Text = "Zemak ierakstiet elementa indeksu, kuru velaties iznemt";
            }
            else
            {
                int choice;
                try
                {
                    choice = Convert.ToInt32(txtChoice.Text);
                    removedAt = choice;
                    lastDeleted = lstMain.Items[choice].Text;
                    lstMain.Items[choice].Remove();
                }
                catch
                {
                    lblInfo.Text = "Ievades kluda";
                }
            }
            txtIn.Clear();
            txtChoice.Clear();
            DeleteTimes++;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            lastClicked = 3;
            //ListCopy();
            txtChoice.Visible = true;
            if(EditTimes == 0)
            {
                lblInfo.Text = "Zemaka lauka ierakstiet, kura indeksa elementu jus valaties mainit un kreisaja lauka ierakstiet ar ko jus to velaties aizvietot, tad spiediet Edit!";
            }
            else
            {
                int choice;
                try
                {
                    bool contains = false;
                    for (int i = 0; i < lstMain.Items.Count; i++)
                    {
                        if (lstMain.Items[i].Text == txtIn.Text)
                        {
                            lblInfo.Text = "Jus nedrikstat veidot dublikatus!";
                            contains = true;
                        }
                    }
                    if (!contains)
                    {
                        choice = Convert.ToInt32(txtChoice.Text);
                        beforeEdit = lstMain.Items[choice].Text;
                        beforeEditAt = choice;
                        lstMain.Items[choice].Text = txtIn.Text;
                    }
                }
                catch
                {
                    lblInfo.Text = "Ievades kluda";
                }
                
            }
            txtIn.Clear();
            txtChoice.Clear();
            EditTimes++;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            switch (lastClicked)
            {
                case 1:
                    try
                    {
                        lstMain.Items.RemoveAt(lstLength - 1);
                    }
                    catch
                    {
                        lblInfo.Text = "Jus nevarat veikt Undo darbibu divas reizes pec kartas bez nekadam pastarpinatam darbibam!";
                    }
                    break;
                case 2:
                    bool contains = false;
                    for (int i = 0; i < lstMain.Items.Count; i++)
                    {
                        if (lstMain.Items[i].Text == lastDeleted)
                        {
                            contains = true;
                        }
                    }
                    if (!contains)
                    {
                        lstMain.Items.Insert(removedAt, lastDeleted);
                    }
                    break;
                case 3:
                    try
                    {
                        lstMain.Items[beforeEditAt].Text = beforeEdit;
                    }
                    catch
                    {
                        lblInfo.Text = "Jums ir javeic kadas Edit izmainas kada/-os elementa/-os pirms varat veikt Undo darbibu!";
                    }
                    break;
                case 0:
                    lblInfo.Text = "Jums ir javeic kadas izmainas saraksta pirms varat veikt Undo darbibu!";
                    break;
                default:
                    break;
            }
        }

        private void ListCopy()
        {
            //listView1.Items.Clear();
            //string[] lst = new string[lstMain.Items.Count];
            //lstMain.Items.CopyTo(lst, 0);
            //
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
            //lstMain.Clear();
            //for (int i = 0; i < listView1.Items.Count; i++)
            //{
            //    lstMain.Items[i] = listView1.Items[i];
            //}
        }
    }
}