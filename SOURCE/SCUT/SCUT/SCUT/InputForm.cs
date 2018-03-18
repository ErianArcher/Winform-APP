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
    public partial class InputForm : Form
    {
        private Intent _intent = null;
        public Intent intent
        {
            get { return _intent; }
        }

        public InputForm(Intent newIntent)
        {
            InitializeComponent();
            this._intent = newIntent;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string empNo = txtEmpNo.Text.Trim();
            string empName = txtEmpName.Text.Trim();
            string empSex = null;
            string empAge = txtEmpAge.Text.Trim();

            if (!isValid("员工号：", empNo) ||
                !isValid("员工姓名：", empName) ||
                !isValid("员工年龄：", empAge))
            {
                //this.DialogResult = DialogResult.Cancel;
                return;
            }

            if (radBtnMale.Checked == true) empSex = "男";
            else if (radBtnFemale.Checked == true) empSex = "女";
            else
            {
                MessageBox.Show("请选择性别");
                //this.DialogResult = DialogResult.Cancel;
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(empAge, @"^\d*$"))
            {
                MessageBox.Show("请在年龄栏输入数字，且不能为负数");
                //this.DialogResult = DialogResult.Cancel;
                return;
            }

            foreach (string str in (List<string>)_intent.dict["empNos"])
            {
                if (str.Equals(empNo))
                {
                    MessageBox.Show("此员工号已存在");
                    return;
                }
            }

            this.DialogResult = DialogResult.OK;
            _intent.dict["empNo"] = empNo;
            _intent.dict["empName"] = empName;
            _intent.dict["empSex"] = empSex;
            _intent.dict["empAge"] = empAge;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void InputForm_Load(object sender, EventArgs e)
        {
            if (_intent.dict["type"].ToString().Equals("add"))
            {
                // Do Nothing
            }
            else if (_intent.dict["type"].ToString().Equals("update"))
            {
                ListViewItem item = (ListViewItem)_intent.dict["selectedItem"];
                txtEmpNo.Text = item.SubItems[0].Text;
                txtEmpName.Text = item.SubItems[1].Text;
                txtEmpAge.Text = item.SubItems[3].Text;
                string sex = item.SubItems[2].Text;
                if (sex.Equals("男"))
                    radBtnMale.Checked = true;
                else if (sex.Equals("女"))
                    radBtnFemale.Checked = true;
            }
        }

        private bool isValid(string atrr, string str)
        {
            if (string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str))
            {
                MessageBox.Show(atrr + "不能为空或全为空格");
                return false;
            }

            return true;
        }
    }
}
