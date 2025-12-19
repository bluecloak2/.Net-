using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ImageViewerApp
{
    public partial class Form2 : Form
    {
        // 公共属性：存储用户输入的评论信息
        public string UserName { get; set; }
        public string Birthday { get; set; }
        public string Gender { get; set; }
        public string WorkStatus { get; set; }
        public string Hobbies { get; set; }
        public string CommentContent { get; set; }

        public Form2()
        {
            InitializeComponent();
            // 初始化工作状态下拉框
            cboWorkStatus.Items.AddRange(new string[] { "全职", "兼职", "自由职业", "无业" });
            cboWorkStatus.SelectedIndex = 0;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // 验证必填项
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("请输入姓名", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtBirthday.Text))
            {
                MessageBox.Show("请输入生日", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBirthday.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtComment.Text))
            {
                MessageBox.Show("请输入评论内容", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtComment.Focus();
                return;
            }

            // 收集用户输入
            UserName = txtName.Text;
            Birthday = txtBirthday.Text;
            Gender = radMale.Checked ? "男" : "女";
            WorkStatus = cboWorkStatus.SelectedItem.ToString();

            // 收集爱好（复选框）
            List<string> hobbies = new List<string>();
            if (chkSports.Checked) hobbies.Add("运动");
            if (chkShopping.Checked) hobbies.Add("购物");
            if (chkHome.Checked) hobbies.Add("宅家");
            if (chkTravel.Checked) hobbies.Add("旅游");
            if (chkOther.Checked) hobbies.Add("其它");
            Hobbies = string.Join("、", hobbies);

            CommentContent = txtComment.Text;

            // 关闭对话框并返回确认结果
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}