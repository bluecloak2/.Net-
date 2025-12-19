namespace ImageViewerApp
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBirthday = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cboWorkStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkSports = new System.Windows.Forms.CheckBox();
            this.chkShopping = new System.Windows.Forms.CheckBox();
            this.chkHome = new System.Windows.Forms.CheckBox();
            this.chkTravel = new System.Windows.Forms.CheckBox();
            this.chkOther = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 控件布局
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";

            this.txtName.Location = new System.Drawing.Point(78, 17);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 23);
            this.txtName.TabIndex = 1;

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "生日";

            this.txtBirthday.Location = new System.Drawing.Point(78, 57);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(200, 23);
            this.txtBirthday.TabIndex = 3;
            this.txtBirthday.Text = "1978年7月11日";

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "性别";

            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(78, 100);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(32, 19);
            this.radMale.TabIndex = 5;
            this.radMale.Text = "男";
            this.radMale.Checked = true;

            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(136, 100);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(32, 19);
            this.radFemale.TabIndex = 6;
            this.radFemale.Text = "女";

            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "工作状态";

            this.cboWorkStatus.Location = new System.Drawing.Point(78, 137);
            this.cboWorkStatus.Name = "cboWorkStatus";
            this.cboWorkStatus.Size = new System.Drawing.Size(200, 23);
            this.cboWorkStatus.TabIndex = 8;

            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "爱好";

            this.chkSports.AutoSize = true;
            this.chkSports.Location = new System.Drawing.Point(78, 180);
            this.chkSports.Name = "chkSports";
            this.chkSports.Size = new System.Drawing.Size(44, 19);
            this.chkSports.TabIndex = 10;
            this.chkSports.Text = "运动";
            this.chkSports.Checked = true;

            this.chkShopping.AutoSize = true;
            this.chkShopping.Location = new System.Drawing.Point(136, 180);
            this.chkShopping.Name = "chkShopping";
            this.chkShopping.Size = new System.Drawing.Size(44, 19);
            this.chkShopping.TabIndex = 11;
            this.chkShopping.Text = "购物";
            this.chkShopping.Checked = true;

            this.chkHome.AutoSize = true;
            this.chkHome.Location = new System.Drawing.Point(194, 180);
            this.chkHome.Name = "chkHome";
            this.chkHome.Size = new System.Drawing.Size(44, 19);
            this.chkHome.TabIndex = 12;
            this.chkHome.Text = "宅家";
            this.chkHome.Checked = true;

            this.chkTravel.AutoSize = true;
            this.chkTravel.Location = new System.Drawing.Point(78, 210);
            this.chkTravel.Name = "chkTravel";
            this.chkTravel.Size = new System.Drawing.Size(44, 19);
            this.chkTravel.TabIndex = 13;
            this.chkTravel.Text = "旅游";
            this.chkTravel.Checked = true;

            this.chkOther.AutoSize = true;
            this.chkOther.Location = new System.Drawing.Point(136, 210);
            this.chkOther.Name = "chkOther";
            this.chkOther.Size = new System.Drawing.Size(44, 19);
            this.chkOther.TabIndex = 14;
            this.chkOther.Text = "其它";

            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "评论内容";

            this.txtComment.Multiline = true;
            this.txtComment.Location = new System.Drawing.Point(23, 275);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(255, 80);
            this.txtComment.TabIndex = 16;
            this.txtComment.Text = "这秋天的风景真是美啊！";

            this.btnOK.Location = new System.Drawing.Point(78, 370);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 30);
            this.btnOK.TabIndex = 17;
            this.btnOK.Text = "确定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);

            this.btnCancel.Location = new System.Drawing.Point(173, 370);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // 窗体属性
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 420);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkOther);
            this.Controls.Add(this.chkTravel);
            this.Controls.Add(this.chkHome);
            this.Controls.Add(this.chkShopping);
            this.Controls.Add(this.chkSports);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboWorkStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radFemale);
            this.Controls.Add(this.radMale);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBirthday);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "用户评论表";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBirthday;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboWorkStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkSports;
        private System.Windows.Forms.CheckBox chkShopping;
        private System.Windows.Forms.CheckBox chkHome;
        private System.Windows.Forms.CheckBox chkTravel;
        private System.Windows.Forms.CheckBox chkOther;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}