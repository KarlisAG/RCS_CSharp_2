namespace Day16_MD
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
            this.lblVards = new System.Windows.Forms.Label();
            this.lblUzvards = new System.Windows.Forms.Label();
            this.lblKurss = new System.Windows.Forms.Label();
            this.txtUzvards = new System.Windows.Forms.TextBox();
            this.txtKurss = new System.Windows.Forms.TextBox();
            this.txtVards = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtChoice = new System.Windows.Forms.TextBox();
            this.lblIndex = new System.Windows.Forms.Label();
            this.Vards = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Uzvards = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kurss = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Indekss = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnFilter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVards
            // 
            this.lblVards.AutoSize = true;
            this.lblVards.Location = new System.Drawing.Point(50, 47);
            this.lblVards.Name = "lblVards";
            this.lblVards.Size = new System.Drawing.Size(34, 13);
            this.lblVards.TabIndex = 0;
            this.lblVards.Text = "Vards";
            // 
            // lblUzvards
            // 
            this.lblUzvards.AutoSize = true;
            this.lblUzvards.Location = new System.Drawing.Point(50, 77);
            this.lblUzvards.Name = "lblUzvards";
            this.lblUzvards.Size = new System.Drawing.Size(46, 13);
            this.lblUzvards.TabIndex = 1;
            this.lblUzvards.Text = "Uzvards";
            // 
            // lblKurss
            // 
            this.lblKurss.AutoSize = true;
            this.lblKurss.Location = new System.Drawing.Point(50, 107);
            this.lblKurss.Name = "lblKurss";
            this.lblKurss.Size = new System.Drawing.Size(33, 13);
            this.lblKurss.TabIndex = 2;
            this.lblKurss.Text = "Kurss";
            // 
            // txtUzvards
            // 
            this.txtUzvards.Location = new System.Drawing.Point(102, 69);
            this.txtUzvards.Name = "txtUzvards";
            this.txtUzvards.Size = new System.Drawing.Size(100, 20);
            this.txtUzvards.TabIndex = 2;
            // 
            // txtKurss
            // 
            this.txtKurss.Location = new System.Drawing.Point(102, 99);
            this.txtKurss.Name = "txtKurss";
            this.txtKurss.Size = new System.Drawing.Size(100, 20);
            this.txtKurss.TabIndex = 3;
            // 
            // txtVards
            // 
            this.txtVards.Location = new System.Drawing.Point(102, 39);
            this.txtVards.Name = "txtVards";
            this.txtVards.Size = new System.Drawing.Size(100, 20);
            this.txtVards.TabIndex = 1;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(29, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(566, 13);
            this.lblInfo.TabIndex = 6;
            this.lblInfo.Text = "Sveiki! Ievadiet laukos nepieciesamo par studentu informaciju un izvelaties kadu " +
    "no opcijam un tad sekojiet instrukcijai!";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(208, 40);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(208, 69);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(208, 156);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save to file";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(208, 98);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(104, 23);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(208, 185);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(104, 23);
            this.btnShow.TabIndex = 11;
            this.btnShow.Text = "Show list";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Indekss,
            this.Vards,
            this.Uzvards,
            this.Kurss});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(32, 263);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(333, 261);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(208, 214);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close list";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtChoice
            // 
            this.txtChoice.Location = new System.Drawing.Point(318, 98);
            this.txtChoice.Name = "txtChoice";
            this.txtChoice.Size = new System.Drawing.Size(100, 20);
            this.txtChoice.TabIndex = 14;
            this.txtChoice.Visible = false;
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Location = new System.Drawing.Point(424, 103);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(85, 13);
            this.lblIndex.TabIndex = 15;
            this.lblIndex.Text = "Ievadiet indeksu";
            this.lblIndex.Visible = false;
            // 
            // Vards
            // 
            this.Vards.Text = "Vards";
            this.Vards.Width = 84;
            // 
            // Uzvards
            // 
            this.Uzvards.Text = "Uzvards";
            this.Uzvards.Width = 88;
            // 
            // Kurss
            // 
            this.Kurss.Text = "Kurss";
            // 
            // Indekss
            // 
            this.Indekss.Text = "Indekss";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(208, 127);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(104, 23);
            this.btnFilter.TabIndex = 16;
            this.btnFilter.Text = "Filter by Course";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 536);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.txtChoice);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtVards);
            this.Controls.Add(this.txtKurss);
            this.Controls.Add(this.txtUzvards);
            this.Controls.Add(this.lblKurss);
            this.Controls.Add(this.lblUzvards);
            this.Controls.Add(this.lblVards);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVards;
        private System.Windows.Forms.Label lblUzvards;
        private System.Windows.Forms.Label lblKurss;
        private System.Windows.Forms.TextBox txtUzvards;
        private System.Windows.Forms.TextBox txtKurss;
        private System.Windows.Forms.TextBox txtVards;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtChoice;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.ColumnHeader Indekss;
        private System.Windows.Forms.ColumnHeader Vards;
        private System.Windows.Forms.ColumnHeader Uzvards;
        private System.Windows.Forms.ColumnHeader Kurss;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnFilter;
    }
}

