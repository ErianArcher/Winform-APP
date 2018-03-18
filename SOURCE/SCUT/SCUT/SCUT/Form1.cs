using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SCUT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void populateEmployee()
        {

            string sql = @"SELECT * FROM [Employee]";
            DataSet ds = DBUtil.queryData(sql);
            listView1.BeginUpdate();
            listView1.Items.Clear();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                ListViewItem item = new ListViewItem(dr[0].ToString());
                item.SubItems.Add(dr[1].ToString());
                item.SubItems.Add(dr[2].ToString());
                item.SubItems.Add(dr[3].ToString());
                listView1.Items.Add(item);
            }
            listView1.EndUpdate();

        }

        private void populateCmbBox()
        {
            cmbBoxNo.Items.Clear(); cmbBoxNo.Items.Add(""); cmbBoxNo.SelectedIndex = 0;
            cmbBoxName.Items.Clear(); cmbBoxName.Items.Add(""); cmbBoxName.SelectedIndex = 0;

            string sql = @"SELECT [EmpNo], [EmpName] FROM [Employee]";
            DataSet ds = DBUtil.queryData(sql);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                cmbBoxNo.Items.Add(dr[0].ToString());
                cmbBoxName.Items.Add(dr[1].ToString());
            }
        }

        private void populateQuery3_2()
        {
            string sql = @"SELECT [Employee].[EmpNo], [Employee].[EmpName], SUM([Works].[Salary]) AS '总工资'
            FROM [Employee], [Works]
            WHERE [Employee].[EmpNo] = [Works].[EmpNo] AND [Employee].[EmpAge] >= 40
            GROUP BY [Employee].[EmpNo], [Employee].[EmpName]
            ORDER BY '总工资' DESC";
            DataSet ds = DBUtil.queryData(sql);
            listView3_2.BeginUpdate();
            listView3_2.Items.Clear();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                ListViewItem item = new ListViewItem(dr[0].ToString());
                item.SubItems.Add(dr[1].ToString());
                item.SubItems.Add(dr[2].ToString());
                listView3_2.Items.Add(item);
            }
            listView3_2.EndUpdate();
        }

        private void populateQuery3_3()
        {
            string sql = @"SELECT e.[EmpName], c.[CmpName]
            FROM [Employee] AS e, [Company] AS c, [Works] AS w, (SELECT [EmpNo] FROM [Works] GROUP BY [EmpNo] HAVING COUNT([EmpNo]) > 1) AS a
            WHERE e.[EmpNo] = a.[EmpNo] AND e.[EmpNo] = w.[EmpNo] AND w.[CmpNo] = c.[CmpNo]
            GROUP BY e.[EmpName], c.[CmpName]";
            DataSet ds = DBUtil.queryData(sql);
            listView3_3.BeginUpdate();
            listView3_3.Items.Clear();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                ListViewItem item = new ListViewItem(dr[0].ToString());
                item.SubItems.Add(dr[1].ToString());
                listView3_3.Items.Add(item);
            }
            listView3_3.EndUpdate();
        }

        private void tabControl1_Selecting(Object sender, TabControlCancelEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 0: populateEmployee(); break;
                case 1: populateCmbBox(); break;
                case 2: populateQuery3_2(); break;
                case 3: populateQuery3_3(); break;
                default: break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            populateEmployee();
            populateCmbBox();
            populateQuery3_2();
            populateQuery3_3();
            tabControl1.Selecting += new TabControlCancelEventHandler(tabControl1_Selecting);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent();
            intent.dict["type"] = "add";
            List<string> empNos = new List<string>(listView1.Items.Count);
            foreach (ListViewItem item in listView1.Items)
            {
                empNos.Add(item.SubItems[0].Text);
            }
            intent.dict["empNos"] = empNos;
            InputForm inputForm = new InputForm(intent);

            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                string sql = string.Format(@"INSERT INTO [Employee] VALUES ('{0}','{1}','{2}',{3})",
                    intent.dict["empNo"], intent.dict["empName"], intent.dict["empSex"], intent.dict["empAge"]);
                DBUtil.execCommand(sql);
                populateEmployee();
            }

            inputForm.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 1)
            {
                MessageBox.Show("所选择的员工不为1");
                return;
            }
            ListViewItem selectedItem = listView1.SelectedItems[0];
            string originNo = selectedItem.SubItems[0].Text;

            Intent intent = new Intent();
            intent.dict["type"] = "update";
            intent.dict["selectedItem"] = selectedItem;
            List<string> empNos = new List<string>(listView1.Items.Count-1);
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Equals(selectedItem)) continue;
                empNos.Add(item.SubItems[0].Text);
            }
            intent.dict["empNos"] = empNos;
            InputForm inputForm = new InputForm(intent);

            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                string valueStr = "";
                
                if (!intent.dict["empNo"].ToString().Equals(selectedItem.SubItems[0].Text))
                {
                    valueStr += string.Format(@"[EmpNo] = '{0}',", intent.dict["empNo"]);
                    selectedItem.SubItems[0].Text = intent.dict["empNo"].ToString();
                }
                else if (!intent.dict["empName"].ToString().Equals(selectedItem.SubItems[1].Text))
                {
                    valueStr += string.Format(@"[EmpName] = '{0}',", intent.dict["empName"]);
                    selectedItem.SubItems[1].Text = intent.dict["empName"].ToString();
                }
                else if (!intent.dict["empSex"].ToString().Equals(selectedItem.SubItems[2].Text))
                {
                    valueStr += string.Format(@"[EmpSex] = '{0}',", intent.dict["empSex"]);
                    selectedItem.SubItems[2].Text = intent.dict["empSex"].ToString();
                }
                else if (!intent.dict["empAge"].ToString().Equals(selectedItem.SubItems[3].Text))
                {
                    valueStr += string.Format(@"[EmpAge] = '{0}',", intent.dict["empAge"]);
                    selectedItem.SubItems[3].Text = intent.dict["empAge"].ToString();
                }

                if (valueStr.Length == 0)
                {
                    MessageBox.Show("没有修改");
                    return;
                }
                else valueStr = valueStr.Substring(0, valueStr.Length - 1);

                string sql = string.Format(@"UPDATE [Employee] SET {0} WHERE [EmpNo]='{1}'",
                    valueStr, originNo);
                DBUtil.execCommand(sql);
                //populateEmployee();
            }

            inputForm.Dispose();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count < 1)
            {
                MessageBox.Show("没有被选中的员工");
                return;
            }
            string sql = @"DELETE FROM [Employee] WHERE [EmpNo] IN(";
            listView1.BeginUpdate();
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                string empNo = item.SubItems[0].Text;
                sql += string.Format("'{0}', ", empNo);
                listView1.Items.Remove(item);
            }
            listView1.EndUpdate();
            sql = sql.Substring(0, sql.Length - 2) + ")";
            DBUtil.execCommand(sql);
        }

        private void btnQueryWithNo_Click(object sender, EventArgs e)
        {
            if (cmbBoxNo.SelectedIndex == 0)
            {
                MessageBox.Show("请选择员工号以查询员工信息");
                return;
            }

            string empNo = cmbBoxNo.Text;
            string sql = string.Format(@"SELECT Employee.EmpNo, Employee.EmpName,
            CASE WHEN Company.CmpName IS NULL THEN '' ELSE Company.CmpName END,
            CASE WHEN Works.Salary IS NULL THEN 0 ELSE Works.Salary END
            FROM ([Employee] Left JOIN [Works] ON [Employee].[EmpNo] = [Works].[EmpNo]) LEFT JOIN [Company] ON [Works].[CmpNo] = [Company].[CmpNo]
            WHERE [Employee].[EmpNo] = '{0}';", empNo);
            DataSet ds = DBUtil.queryData(sql);
            listView3_1.BeginUpdate();
            listView3_1.Items.Clear();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                ListViewItem item = new ListViewItem(dr[0].ToString());
                item.SubItems.Add(dr[1].ToString());
                item.SubItems.Add(dr[2].ToString());
                item.SubItems.Add(dr[3].ToString());
                listView3_1.Items.Add(item);
            }
            listView3_1.EndUpdate();
        }

        private void btnQeuryWithName_Click(object sender, EventArgs e)
        {
            if (cmbBoxName.SelectedIndex == 0)
            {
                MessageBox.Show("请选择员工号以查询员工信息");
                return;
            }

            string empName = cmbBoxName.Text;
            string sql = string.Format(@"SELECT Employee.EmpNo, Employee.EmpName,
            CASE WHEN Company.CmpName IS NULL THEN '' ELSE Company.CmpName END,
            CASE WHEN Works.Salary IS NULL THEN 0 ELSE Works.Salary END
            FROM ([Employee] Left JOIN [Works] ON [Employee].[EmpNo] = [Works].[EmpNo]) LEFT JOIN [Company] ON [Works].[CmpNo] = [Company].[CmpNo]
            WHERE [Employee].[EmpName] = '{0}';", empName);
            DataSet ds = DBUtil.queryData(sql);
            listView3_1.BeginUpdate();
            listView3_1.Items.Clear();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                ListViewItem item = new ListViewItem(dr[0].ToString());
                item.SubItems.Add(dr[1].ToString());
                item.SubItems.Add(dr[2].ToString());
                item.SubItems.Add(dr[3].ToString());
                listView3_1.Items.Add(item);
            }
            listView3_1.EndUpdate();
        }


    }
}
