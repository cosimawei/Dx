using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunBot
{
    public partial class FrmPcsBot : Form
    {
        public FrmPcsBot()
        {
            InitializeComponent();
            TextBox.CheckForIllegalCrossThreadCalls = false;
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            SelectPath();
        }
        private string SelectPath() //弹出一个选择目录的对话框
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            txtFolderPath.Text = path.SelectedPath;
            return path.SelectedPath;
        }

        private void btnexecute_Click(object sender, EventArgs e)
        {
            RunCmd("ping www.baidu.com");
        }

        public string RunCmd(string cmd)
        {
            try
            {
                //string strInput = Console.ReadLine();
                Process p = new Process();
                //设置要启动的应用程序
                p.StartInfo.FileName = "cmd.exe";
                //是否使用操作系统shell启动
                p.StartInfo.UseShellExecute = false;
                // 接受来自调用程序的输入信息
                p.StartInfo.RedirectStandardInput = true;
                //输出信息
                p.StartInfo.RedirectStandardOutput = true;
                // 输出错误
                p.StartInfo.RedirectStandardError = true;
                //不显示程序窗口
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.WindowStyle = ProcessWindowStyle.Normal;

                p.OutputDataReceived += new DataReceivedEventHandler(p_OutputDataReceived);
                p.ErrorDataReceived += new DataReceivedEventHandler(p_ErrorDataReceived);
                //启用Exited事件
                p.EnableRaisingEvents = true;
                p.Exited += new EventHandler(Process_Exited);

                //启动程序
                p.Start();
                p.BeginOutputReadLine();
                p.BeginErrorReadLine();
                p.StandardInput.AutoFlush = true;
                //输入命令
                p.StandardInput.WriteLine(cmd);
                p.StandardInput.WriteLine("exit");

                //获取输出信息
                // string strOuput = p.StandardOutput.ReadToEnd();
                //等待程序执行完退出进程
                //p.WaitForExit();
                //p.Close();
                // return strOuput;
                return string.Empty;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private void p_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                ricTextStatus.Text = e.Data + "/n";
               // Console.WriteLine(e.Data);
            }
        }

        private void p_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                ricTextStatus.Text = e.Data + "/n";
                //Console.WriteLine(e.Data);
            }
        }

        private void Process_Exited(object sender, EventArgs e)
        {
            ricTextStatus.Text = "命令执行完毕/n";
            //Console.WriteLine("命令执行完毕"); 
        }
    }
}
