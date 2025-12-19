using System;
using System.Windows.Forms;

namespace ImageViewerApp
{
    static class Program
    {
        [STAThread] // WinForm 必须保留的特性，缺失会导致窗体异常
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 仅启动主窗体 Form1，这是唯一需要在 Program.cs 中运行的窗体
            Application.Run(new Form1());
        }
    }
}