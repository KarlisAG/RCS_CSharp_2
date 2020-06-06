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

        int deleteTimes = 0;
        int editTimes = 0;
        int filterTimes = 0;
        int loadTimes = 0;
        bool isVisible = false;

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
                        lblInfo.Text = "Students veiksmigi pievienots!";
                        UpdateList();
                        ClearAllTxt();
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
                    stList.RemoveAt(remove);
                    listView2.Items.RemoveAt(remove);
                    lblIndex.Text = "Students veiksmigi izdzests!";
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
                                stList[choice].setName(txtVards.Text);//nevis ar =, bet iekavas vajadzēja un ierakstit jauno vertibu
                                stList[choice].setSurname(txtUzvards.Text);
                                stList[choice].setCourse(jaunKurss);
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
                ClearAllTxt();
            }
            UpdateList();
            editTimes++;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter(@"C:\Users\akots\Desktop\Programmesana_StreamReadWrite\Day16\Student.txt");

                foreach(Student st in stList)
                {
                    sw.WriteLine($"{st.getName()},{st.getSurname()},{st.getCourse()}");
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
            if (isVisible)
            {
                listView1.Visible = false;
                btnShow.Text = "Show list";
                isVisible = false;
            }
            else
            {
                listView1.Visible = true;
                btnShow.Text = "Close list";
                isVisible = true;
                UpdateList();
            }
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (filterTimes == 0)
            {
                lblInfo.Text = "Ievadiet Kursa lauka pec kura kursa Jus velaties filtret sarakstu un spiediet Filter!";
            }
            else
            {
                listView2.Items.Clear();
                int y = 0;
                foreach (var student in stList)
                {

                    try
                    {
                        int course = Convert.ToInt32(txtKurss.Text);
                        if (student.getCourse().Equals(course))
                        {
                            String name = student.getName();
                            String surname = student.getSurname();
                            int cours = student.getCourse();
                            listView2.Items.Add($"{i} {name} {surname} {cours}");
                        }
                        else
                        {
                            lblInfo.Text = "Neviens students nav tada kursa!";
                        }
                    }
                    catch
                    {
                        lblInfo.Text = "Jums kursa lauka bija jaievada cipars!";
                    }
                    y++;
                }
            }
            txtKurss.Clear();
            filterTimes++;
        }    
    

        private void UpdateList()
        {
            listView2.Items.Clear();
            int y = 0;
            foreach(var st in stList)
            {
                listView2.Items.Add($"{y} {st.getName()} {st.getSurname()} {st.getCourse()}");
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
                    stList.Clear();
                    while ((line = sr.ReadLine()) != null)
                    {
                        String[] lineArr = line.Split(',');
                        String name = lineArr[0];
                        String surname = lineArr[1];
                        int course = Convert.ToInt32(lineArr[2]);
                        Student st = new Student(name, surname, course);
                        stList.Add(st);
                    }
                    lblInfo.Text = "Fails veiksmigi ieladets un saraksts atjaunots!";
                    UpdateList();
                    sr.Close();
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
                while ((line = sr.ReadLine()) != null)
                {
                    String[] lineArr = line.Split(',');
                    try
                    {
                        int courseNum = Convert.ToInt32(lineArr[2]);
                        if(courseNum >= 1 && courseNum <= 3)
                        {
                            if (lineArr.Length != 3)
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
        public void ClearAllTxt()
        {
            txtVards.Clear();
            txtUzvards.Clear();
            txtKurss.Clear();
            txtChoice.Clear();
        }
    }  
}
