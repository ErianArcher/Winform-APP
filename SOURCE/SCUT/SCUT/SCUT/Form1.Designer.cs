namespace SCUT
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colEmpNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmpName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmpSex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmpAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listView3_1 = new System.Windows.Forms.ListView();
            this.cmbBoxNo = new System.Windows.Forms.ComboBox();
            this.cmbBoxName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnQueryWithNo = new System.Windows.Forms.Button();
            this.btnQeuryWithName = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView3_2 = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView3_3 = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(557, 392);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnUpdate);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(549, 366);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Employee";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnQeuryWithName);
            this.tabPage2.Controls.Add(this.btnQueryWithNo);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.cmbBoxName);
            this.tabPage2.Controls.Add(this.cmbBoxNo);
            this.tabPage2.Controls.Add(this.listView3_1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(549, 366);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "query3-1";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colEmpNo,
            this.colEmpName,
            this.colEmpSex,
            this.colEmpAge});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(6, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(537, 319);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colEmpNo
            // 
            this.colEmpNo.Text = "EmpNo";
            this.colEmpNo.Width = 132;
            // 
            // colEmpName
            // 
            this.colEmpName.Text = "EmpName";
            this.colEmpName.Width = 169;
            // 
            // colEmpSex
            // 
            this.colEmpSex.Text = "EmpSex";
            this.colEmpSex.Width = 119;
            // 
            // colEmpAge
            // 
            this.colEmpAge.Text = "EmpAge";
            this.colEmpAge.Width = 112;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.listView3_2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(549, 366);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "query3-2";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.listView3_3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(549, 366);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "query3-3";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // listView3_1
            // 
            this.listView3_1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView3_1.Location = new System.Drawing.Point(6, 6);
            this.listView3_1.Name = "listView3_1";
            this.listView3_1.Size = new System.Drawing.Size(537, 292);
            this.listView3_1.TabIndex = 0;
            this.listView3_1.UseCompatibleStateImageBehavior = false;
            this.listView3_1.View = System.Windows.Forms.View.Details;
            // 
            // cmbBoxNo
            // 
            this.cmbBoxNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxNo.FormattingEnabled = true;
            this.cmbBoxNo.Location = new System.Drawing.Point(94, 304);
            this.cmbBoxNo.Name = "cmbBoxNo";
            this.cmbBoxNo.Size = new System.Drawing.Size(121, 20);
            this.cmbBoxNo.TabIndex = 1;
            // 
            // cmbBoxName
            // 
            this.cmbBoxName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxName.FormattingEnabled = true;
            this.cmbBoxName.Location = new System.Drawing.Point(389, 304);
            this.cmbBoxName.Name = "cmbBoxName";
            this.cmbBoxName.Size = new System.Drawing.Size(121, 20);
            this.cmbBoxName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "员工号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "员工名：";
            // 
            // btnQueryWithNo
            // 
            this.btnQueryWithNo.Location = new System.Drawing.Point(94, 330);
            this.btnQueryWithNo.Name = "btnQueryWithNo";
            this.btnQueryWithNo.Size = new System.Drawing.Size(102, 23);
            this.btnQueryWithNo.TabIndex = 5;
            this.btnQueryWithNo.Text = "以员工号查询";
            this.btnQueryWithNo.UseVisualStyleBackColor = true;
            this.btnQueryWithNo.Click += new System.EventHandler(this.btnQueryWithNo_Click);
            // 
            // btnQeuryWithName
            // 
            this.btnQeuryWithName.Location = new System.Drawing.Point(389, 330);
            this.btnQeuryWithName.Name = "btnQeuryWithName";
            this.btnQeuryWithName.Size = new System.Drawing.Size(75, 23);
            this.btnQeuryWithName.TabIndex = 6;
            this.btnQeuryWithName.Text = "以员工名查询";
            this.btnQeuryWithName.UseVisualStyleBackColor = true;
            this.btnQeuryWithName.Click += new System.EventHandler(this.btnQeuryWithName_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "EmpNo";
            this.columnHeader1.Width = 91;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "EmpName";
            this.columnHeader2.Width = 101;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "CompanyName";
            this.columnHeader3.Width = 125;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Salary";
            this.columnHeader4.Width = 109;
            // 
            // listView3_2
            // 
            this.listView3_2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader5,
            this.columnHeader6});
            this.listView3_2.Location = new System.Drawing.Point(8, 18);
            this.listView3_2.Name = "listView3_2";
            this.listView3_2.Size = new System.Drawing.Size(535, 333);
            this.listView3_2.TabIndex = 0;
            this.listView3_2.UseCompatibleStateImageBehavior = false;
            this.listView3_2.View = System.Windows.Forms.View.Details;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "查询年龄至少40岁员工的总工资：";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "EmpName";
            this.columnHeader5.Width = 89;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Total Salary";
            this.columnHeader6.Width = 103;
            // 
            // listView3_3
            // 
            this.listView3_3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.listView3_3.Location = new System.Drawing.Point(9, 22);
            this.listView3_3.Name = "listView3_3";
            this.listView3_3.Size = new System.Drawing.Size(534, 329);
            this.listView3_3.TabIndex = 0;
            this.listView3_3.UseCompatibleStateImageBehavior = false;
            this.listView3_3.View = System.Windows.Forms.View.Details;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "查询至少具有两份工作的员工：";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "EmpName";
            this.columnHeader7.Width = 138;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Company Name";
            this.columnHeader8.Width = 188;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(53, 331);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(235, 331);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(422, 331);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "EmpNo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 416);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "SCUT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colEmpNo;
        private System.Windows.Forms.ColumnHeader colEmpName;
        private System.Windows.Forms.ColumnHeader colEmpSex;
        private System.Windows.Forms.ColumnHeader colEmpAge;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnQeuryWithName;
        private System.Windows.Forms.Button btnQueryWithNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBoxName;
        private System.Windows.Forms.ComboBox cmbBoxNo;
        private System.Windows.Forms.ListView listView3_1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView3_2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView3_3;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}

