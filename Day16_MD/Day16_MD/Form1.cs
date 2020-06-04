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
        int loadTimes = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtVards.Text.Length < 1 || txtUzvards.Text.Length < 1 || txtKurss.Text.Length < 1)
            {
                lblInfo.Text = "Jums ir jaaizpilda lauki!";
            }
            else
            {
                try
                {
                    int courseIndx = Convert.ToInt32(txtKurss.Text);

                    if (courseIndx < 1 || courseIndx > 3)
                    {
                        lblInfo.Text = "Studentu kursam ir jabut no 1 lidz 3!";
                    }
                    else
                    {
                        stList.Add(new Student(txtVards.Text, txtUzvards.Text, courseIndx));
                        name.Add(txtVards.Text);
                        surname.Add(txtUzvards.Text);
                        course.Add(txtKurss.Text);
                        lblInfo.Text = "Students veiksmigi pievienots!";
                        UpdateList();
                        txtVards.Clear();
                        txtUzvards.Clear();
                        txtKurss.Clear();
                    }
                }
                catch
                {
                    lblInfo.Text = "Jums pie kursa ir jaievada vesels cipars!";
                }
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
            txtChoice.Clear();
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
                try
                {
                    int choice = Convert.ToInt32(txtChoice.Text);

                    try
                    {
                        int jaunKurss = Convert.ToInt32(txtKurss.Text);
                        if (jaunKurss < 1 || jaunKurss > 3)
                        {
                            lblInfo.Text = "Studentu kursam ir jabut no 1 lidz 3!";
                        }
                        else
                        {
                            if (txtVards.Text.Length < 1 || txtUzvards.Text.Length < 1)
                            {
                                lblInfo.Text = "Jums ir jaaizpilda lauki!";
                            }
                            else
                            {
                                name[choice] = txtVards.Text;
                                surname[choice] = txtUzvards.Text;
                                course[choice] = jaunKurss;
                                lblInfo.Text = "Informacija veiksmigi redigeta!";
                            }
                        }
                    }
                    catch
                    {
                        lblInfo.Text = "Jums kursa lauka bija jaievada vesels cipars no 1 lidz 3!";
                    }
                }
                catch
                {
                    lblInfo.Text = "Jums jaunaja lauka bija jaievada pareizais indekss!";
                }
                txtVards.Clear();
                txtUzvards.Clear();
                txtKurss.Clear();
                txtChoice.Clear();
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
                    sw.Write(i + "- " + name[i] + ", " + surname[i] + ", " + course[i] + "\n");
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
            txtKurss.Clear();
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

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (loadTimes == 0)
            {
                LoadFile();
                listView1.Visible = true;
            }
            else
            {
                lblInfo.Text = "Jus jau saja sesija ieladejat failu. Vai Jus velaties to atkartoti ieladet un parrakstit to pari esosajam sarakstam? (Ievadiet y/n Varda loga)";
                String choice = txtVards.Text;
                switch (choice.ToLower())
                {
                    case "y":
                        LoadFile();
                        listView1.Visible = true;
                        break;
                    case "n":
                        break;
                    default:
                        lblInfo.Text = "Jums bija jaievada simbols y vai n!";
                        break;
                }
            }
            txtVards.Clear();
            loadTimes++;
        }
        public void LoadFile()
        {

            if (CheckFile())//ar to metodi parbaudu vai faila ietverta informacija atbilst noformejumam
            {
                StreamReader sr = new StreamReader(@"C:\Users\akots\Desktop\Programmesana_StreamReadWrite\Day16\Student.txt");
                try
                {
                    String line = String.Empty;
                    name.Clear();
                    surname.Clear();
                    course.Clear();
                    char[] delimiters = { '-', ' ', ',' };
                    while ((line = sr.ReadLine()) != null)
                    {
                        String[] lineArr = line.Split(delimiters);
                        name.Add(lineArr[2]);//ja ir divi delimiteri pec kartas, tad vins izveido empty stringu!!!, tpc indeksi ir tadi..
                        surname.Add(lineArr[4]);
                        course.Add(lineArr[6]);
                    }
                    lblInfo.Text = "Fails veiksmigi ieladets un saraksts atjaunots!";
                    UpdateList();
                    sr.Close();//ja neaiztaisa, tad viena sesija nevar ieladet un tad saglabat!!
                }
                catch (Exception ex)
                {
                    lblInfo.Text = "Kluda! " + ex.Message;
                    sr.Close();
                }
                sr.Close();
            }
        }
        public bool CheckFile()
        {
            bool allOk = true;
            StreamReader sr = new StreamReader(@"C:\Users\akots\Desktop\Programmesana_StreamReadWrite\Day16\Student.txt");
            try
            {
                String line = String.Empty;
                char[] delimiters = { '-', ' ', ',' };
                while ((line = sr.ReadLine()) != null)
                {
                    String[] lineArr = line.Split(delimiters);
                    bool convertInd = false;
                    try
                    {
                        convertInd = Int32.TryParse(lineArr[0], out int numberInd);
                        int courseNum = Convert.ToInt32(lineArr[6]);
                        if(courseNum >= 1 && courseNum <= 3)
                        {
                            if (lineArr.Length != 7 && !convertInd && lineArr[1] != "" && lineArr[3] != "" && lineArr[5] != "")
                            {
                                allOk = false;
                                lblInfo.Text = "Faila nav pareizi noformeta informacija!";
                            }
                        }
                        else
                        {
                            allOk = false;
                            lblInfo.Text = "Faila informacija netika ieladeta, jo ievaditajam kursam ir jabut no 1 lidz 3!";
                        }
                    }
                    catch (Exception ex)
                    {
                        allOk = false;
                        lblInfo.Text = "Linijas pirmajam un pedejam elementam ir jabut cipariem!" + ex.Message;
                    }
                }
                sr.Close();
                if (allOk)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                lblInfo.Text = "Kluda! " + ex.Message;
                sr.Close();
                return false;
            }
        }
    }  
}
