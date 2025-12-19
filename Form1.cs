using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageViewerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 初始化文本框（评论区）
            txtComment.Multiline = true;
            txtComment.ScrollBars = ScrollBars.Vertical;
            txtComment.Dock = DockStyle.Fill;
        }

        #region 图像菜单事件（打开、另存为、移除）
        private void 打开OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "图像文件|*.jpg;*.jpeg;*.png;*.bmp;*.gif|所有文件|*.*";
                openFileDialog.Title = "打开图像";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // 加载图像并设置拉伸模式
                        Image image = Image.FromFile(openFileDialog.FileName);
                        pictureBox1.Image = image;
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // 加载图片后拉伸显示
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"打开图像失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void 另存为AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("请先打开一张图像", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JPEG文件|*.jpg|PNG文件|*.png|BMP文件|*.bmp|所有文件|*.*";
                saveFileDialog.Title = "保存图像";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBox1.Image.Save(saveFileDialog.FileName);
                        MessageBox.Show("图像保存成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"保存图像失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void 移除RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox1.Text = "无图像";
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal; // 恢复Normal模式显示文本
        }
        #endregion

        #region 评论菜单事件（添加、清除、字体、背景色）
        private void 添加AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 打开评论对话框
            Form2 commentForm = new Form2();
            if (commentForm.ShowDialog() == DialogResult.OK)
            {
                // 获取评论内容并显示到文本框
                string comment = $"评论人：{commentForm.UserName}\n生日：{commentForm.Birthday}\n性别：{commentForm.Gender}\n工作状态：{commentForm.WorkStatus}\n爱好：{commentForm.Hobbies}\n评论内容：{commentForm.CommentContent}\n{new string('-', 50)}\n";
                txtComment.AppendText(comment);
            }
        }

        private void 清除LClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtComment.Clear();
        }

        private void 字体FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                fontDialog.Font = txtComment.Font;
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    txtComment.Font = fontDialog.Font;
                }
            }
        }

        private void 背景色CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                colorDialog.Color = txtComment.BackColor;
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    txtComment.BackColor = colorDialog.Color;
                }
            }
        }
        #endregion

        #region 退出菜单事件
        private void 退出XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}