using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day16_MD
{
    public partial class Form1 : Form
    {
        List<Student> stList = new List<Student>();
        ArrayList name = new ArrayList();
        ArrayList surname = new ArrayList();
        ArrayList course = new ArrayList();

        int deleteTimes = 0;
        int editTimes = 0;
        int filterTimes = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int courseIndx = Convert.ToInt32(txtKurss.Text);

                if (courseIndx < 1 || courseIndx > 3)
                {
                    lblIndex.Text = "Studentu kursam ir jabut no 1 lidz 3!";
                }
                else
                {
                    stList.Add(new Student(txtVards.Text, txtUzvards.Text, courseIndx));
                    name.Add(txtVards.Text);
                    surname.Add(txtUzvards.Text);
                    course.Add(txtKurss.Text);
                    lblInfo.Text = "Students veiksmigi pievienots!";
                    UpdateList();
                }
            }
            catch
            {
                lblInfo.Text = "Jums pie kursa ir jaievada vesels cipars!";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtChoice.Visible = true;
            lblIndex.Visible = true;
            if (deleteTimes == 0)
            {
                lblInfo.Text = "Ierakstiet jaunaja loga indeksu no studentu saraksta, kuru Jus velaties izdzest un tad spieziet Delete!";
            }
            else
            {
                try
                {
                    int remove = Convert.ToInt32(txtChoice.Text);
                    listView1.Items.RemoveAt(remove);
                    //stList.RemoveAt(Convert.ToInt32(txtChoice.Text));
                    lblIndex.Text = "Students veiksmigi izdzests!";
                    name.RemoveAt(remove);
                    surname.RemoveAt(remove);
                    course.RemoveAt(remove);
                    UpdateList();
                }
                catch
                {
                    lblInfo.Text = "Ievades kluda!";
                }
            }
            deleteTimes++;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtChoice.Visible = true;
            lblIndex.Visible = true;
            if (editTimes == 0)
            {
                lblInfo.Text = "Ievadiet jaunaja loga indeksu, studentam, kuram velaties mainit informaciju, ievadiet jauno informaciju ieprieksejos logos un spiediet Edit!";
            }
            else
            {
                int choice = Convert.ToInt32(txtChoice.Text);
                name[choice] = txtVards.Text;
                surname[choice] = txtUzvards.Text;
                course[choice] = txtKurss.Text;
                lblInfo.Text = "Informacija veiksmigi redigeta!";
            }
            UpdateList();
            editTimes++;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter(@"C:\Users\akots\Desktop\Programmesana_StreamReadWrite\Day16\Student.txt");
                for (int i = 0; i < name.Count; i++)
                {
                    //stList.Add(new Student(name[i].ToString(), surname[i] as String, Convert.ToInt32(course[i])));
                    sw.Write(i + " - " + name[i] + ", " + surname[i] + ", " + course[i] + "\n");
                }
                sw.Close();
                lblInfo.Text = "Fails saglabats!";
            }
            catch (Exception ex)
            {
                lblInfo.Text = "Radas kluda!" + ex.Message;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
            btnClose.Visible = true;
            UpdateList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            listView1.Visible = false;
            btnClose.Visible = false;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            int i = 0;
            if(filterTimes == 0)
            {
                lblInfo.Text = "Ievadiet Kursa lauka pec kura kursa Jus velaties filtret sarakstu un spiediet Filter!";
            }
            else
            {
                listView1.Items.Clear();
                if (course.Contains(txtKurss.Text))
                {
                    foreach(String c in course)
                    {
                        if(c == txtKurss.Text)
                        {
                            listView1.Items.Add(new ListViewItem(new[] { i.ToString(), name[i].ToString(), surname[i].ToString(), course[i].ToString() }));
                        }
                        i++;
                    }
                    lblInfo.Text = "Filtresana veiksmiga, saraksts atjaunots!";
                }
                else
                {
                    lblInfo.Text = "Neviens students nav tada kursa!";
                }
            }
            filterTimes++;
        }

        private void UpdateList()
        {
            listView1.Items.Clear();
            int i = 0;
            foreach (var a in name)
            {
                listView1.Items.Add(new ListViewItem(new[] { i.ToString(), name[i].ToString(), surname[i].ToString(), course[i].ToString() }));
                i++;
            }
        }
    }
}
