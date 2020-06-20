using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Day22_MD
{
    public partial class Form1 : Form
    {
        DBConnection db = new DBConnection();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length < 1 && textBoxSurname.Text.Length < 1 && textBoxDepartmentID.Text.Length < 1 && textBoxSalary.Text.Length < 1 && textBoxJobID.Text.Length < 1)
            {
                labelError.Text = "Visiem laukiem ir jabut aizpilditiem!";
            }
            else
            {
                String name = textBoxName.Text;
                String surname = textBoxSurname.Text;

                String departmentID = textBoxDepartmentID.Text;
                bool check = CheckNumber(departmentID);
                String salary = textBoxSalary.Text;
                bool check1 = CheckNumber(salary);
                String jobID = textBoxJobID.Text;
                bool check2 = CheckNumber(jobID);

                if (check || check1 || check2)
                {
                    MySqlDataAdapter dataAdapter = db.MinMaxSalary(jobID);//aizvietot ar DataTable
                    DataTable table = new DataTable();
                    dataAdapter.Fill(table);
                    int minSalary = Convert.ToInt32(table.Rows[0][0]);
                    int maxSalary = Convert.ToInt32(table.Rows[0][1]); 

                    int salaryInt = Convert.ToInt32(salary);

                    if (salaryInt < minSalary )
                    {
                        labelError.Visible = true;
                        labelError.Text = "Alga ir mazaka par mazako!";
                    }
                    else if(salaryInt > maxSalary)
                    {
                        labelError.Visible = true;
                        labelError.Text = "Alga ir lielaka par lielako!";
                    }
                    else
                    {
                        db.AddEmployees(name, surname, departmentID, salary, jobID);
                        labelSuccess.Visible = true;
                        labelSuccess.Text = "Darbinieks veiksmigi pievienots!";
                        labelError.Visible = false;
                        ClearTextBoxes();
                        UpdateList();
                    }
                }
                else
                {
                    labelSuccess.Visible = false;
                    labelError.Visible = true;
                    labelError.Text = "Jums laukos (DepartmenID, Salary, JobID) ir jaievada veseli cipari!";
                }
                
            }
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            UpdateList();
        }

        private bool CheckNumber(String number) 
        {
            try
            {
                Convert.ToInt32(number);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void ClearTextBoxes()
        {
            textBoxName.Clear();
            textBoxSurname.Clear();
            textBoxDepartmentID.Clear();
            textBoxSalary.Clear();
            textBoxJobID.Clear();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            foreach (int i in listView1.SelectedIndices)
            {
                int ID = Convert.ToInt32(listView1.Items[i].Text);
                db.DeleteEmployees(ID);
            }
            UpdateList();
        }

        private void UpdateList()
        {
            listView1.Items.Clear();
            MySqlDataAdapter dataAdapter = db.GetEmployees();//aizietot ar DataTable
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            int y = 0;
            foreach (DataRow row in table.Rows)
            {
                listView1.Items.Add(row.Field<int>(0).ToString());
                listView1.Items[y].SubItems.Add(row.Field<String>(1));
                listView1.Items[y].SubItems.Add(row.Field<String>(2));
                listView1.Items[y].SubItems.Add(row.Field<int>(3).ToString());
                listView1.Items[y].SubItems.Add(row.Field<int>(4).ToString());
                listView1.Items[y].SubItems.Add(row.Field<int>(5).ToString());
                y++;
            }
        }
    }
}
