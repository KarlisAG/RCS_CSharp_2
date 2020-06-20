namespace Day22_MD
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.EmployeeID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmployeeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmployeeSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DepartmentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Salary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.JobID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxDepartmentID = new System.Windows.Forms.TextBox();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.textBoxJobID = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelDepartmentID = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.labelJobID = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.labelSuccess = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EmployeeID,
            this.EmployeeName,
            this.EmployeeSurname,
            this.DepartmentID,
            this.Salary,
            this.JobID});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(585, 318);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // EmployeeID
            // 
            this.EmployeeID.Text = "Employee ID";
            this.EmployeeID.Width = 73;
            // 
            // EmployeeName
            // 
            this.EmployeeName.Text = "Name";
            this.EmployeeName.Width = 141;
            // 
            // EmployeeSurname
            // 
            this.EmployeeSurname.Text = "Surname";
            this.EmployeeSurname.Width = 125;
            // 
            // DepartmentID
            // 
            this.DepartmentID.Text = "Department ID";
            this.DepartmentID.Width = 90;
            // 
            // Salary
            // 
            this.Salary.Text = "Salary";
            this.Salary.Width = 85;
            // 
            // JobID
            // 
            this.JobID.Text = "Job ID";
            this.JobID.Width = 66;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(688, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(688, 38);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 20);
            this.textBoxSurname.TabIndex = 2;
            // 
            // textBoxDepartmentID
            // 
            this.textBoxDepartmentID.Location = new System.Drawing.Point(688, 64);
            this.textBoxDepartmentID.Name = "textBoxDepartmentID";
            this.textBoxDepartmentID.Size = new System.Drawing.Size(100, 20);
            this.textBoxDepartmentID.TabIndex = 3;
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(688, 90);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(100, 20);
            this.textBoxSalary.TabIndex = 4;
            // 
            // textBoxJobID
            // 
            this.textBoxJobID.Location = new System.Drawing.Point(688, 116);
            this.textBoxJobID.Name = "textBoxJobID";
            this.textBoxJobID.Size = new System.Drawing.Size(100, 20);
            this.textBoxJobID.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(644, 15);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Name:";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(630, 41);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(52, 13);
            this.labelSurname.TabIndex = 7;
            this.labelSurname.Text = "Surname:";
            // 
            // labelDepartmentID
            // 
            this.labelDepartmentID.AutoSize = true;
            this.labelDepartmentID.Location = new System.Drawing.Point(603, 67);
            this.labelDepartmentID.Name = "labelDepartmentID";
            this.labelDepartmentID.Size = new System.Drawing.Size(79, 13);
            this.labelDepartmentID.TabIndex = 8;
            this.labelDepartmentID.Text = "Department ID:";
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(643, 90);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(39, 13);
            this.labelSalary.TabIndex = 9;
            this.labelSalary.Text = "Salary:";
            // 
            // labelJobID
            // 
            this.labelJobID.AutoSize = true;
            this.labelJobID.Location = new System.Drawing.Point(644, 119);
            this.labelJobID.Name = "labelJobID";
            this.labelJobID.Size = new System.Drawing.Size(38, 13);
            this.labelJobID.TabIndex = 10;
            this.labelJobID.Text = "Job ID";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(688, 142);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 23);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Location = new System.Drawing.Point(12, 336);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(87, 23);
            this.buttonShowAll.TabIndex = 12;
            this.buttonShowAll.Text = "Show All";
            this.buttonShowAll.UseVisualStyleBackColor = true;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(603, 170);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(318, 13);
            this.labelError.TabIndex = 13;
            this.labelError.Text = "Jums laukos (DepartmenID, Salary, JobID) ir jaievada veseli cipari!";
            this.labelError.Visible = false;
            // 
            // labelSuccess
            // 
            this.labelSuccess.AutoSize = true;
            this.labelSuccess.Location = new System.Drawing.Point(603, 197);
            this.labelSuccess.Name = "labelSuccess";
            this.labelSuccess.Size = new System.Drawing.Size(157, 13);
            this.labelSuccess.TabIndex = 14;
            this.labelSuccess.Text = "Darbinieks veiksmigi pievienots!";
            this.labelSuccess.Visible = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(105, 336);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(86, 23);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelSuccess);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonShowAll);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelJobID);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.labelDepartmentID);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxJobID);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.textBoxDepartmentID);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxDepartmentID;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.TextBox textBoxJobID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelDepartmentID;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.Label labelJobID;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.ColumnHeader EmployeeID;
        private System.Windows.Forms.ColumnHeader EmployeeName;
        private System.Windows.Forms.ColumnHeader EmployeeSurname;
        private System.Windows.Forms.ColumnHeader DepartmentID;
        private System.Windows.Forms.ColumnHeader Salary;
        private System.Windows.Forms.ColumnHeader JobID;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelSuccess;
        private System.Windows.Forms.Button buttonDelete;
    }
}

