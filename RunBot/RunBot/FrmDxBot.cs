using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunBot
{
    public partial class FrmDxBot : Form
    {
        private static string amount_of_bnb_to_spend="amount_of_bnb_to_spend = ";
        private static string gasPrice = "gasPrice = ";
        private static string gasLimit = "gasLimit = ";
        private static string presale_address = "presale_address = ";
        private static string number_of_entries = "number_of_entries = ";
        private static string mnemonic = "mnemonic = ";

        public Process process = null;

        /// <summary>
        /// 文件路径
        /// </summary>
        private static string path = Application.StartupPath + "\\.env";

        /// <summary>
        /// 文件内容
        /// </summary>
        string strInfor = string.Empty;
        public FrmDxBot()
        {
            InitializeComponent();
            TextBox.CheckForIllegalCrossThreadCalls = false;
        }

        private void btndraw_Click(object sender, EventArgs e)
        {
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            if (btnLock.Text != "解锁")
            {
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        if (string.IsNullOrEmpty(item.Text))
                            return;
                        if (item.Name == this.txtHours.Name)
                            continue;
                        if (item.Name == this.txtMin.Name)
                            continue;
                        if (item.Name == this.txtS.Name)
                            continue;
                        item.Enabled = false;
                    }
                }
                btnLock.Text = "解锁";
                fileOpen(false);
                SaveToTxtFile();
            }
            else
            {
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Enabled = true;
                    }
                }
                btnLock.Text = "锁定";
    
            }

 
        }

        TimeSpan dtTo = new TimeSpan();
        private void timer1_Tick(object sender, EventArgs e)
        {
              dtTo = dtTo.Subtract(new TimeSpan(0, 0, 1));
            lblShow.Text = dtTo.Hours.ToString() + ":" + dtTo.Minutes.ToString() + ":" + dtTo.Seconds;

            if (dtTo.TotalSeconds <= 0.0)//当倒计时完毕
            {

                Process.Start(AppDomain.CurrentDomain.BaseDirectory + "\\dxBuy.bat");
                lblShow.Text = string.Empty;
                timer1.Enabled = false;   //其中可自行添加相应的提示框或者方法函数
            }
  
        }


        private void btnExecNow_Click(object sender, EventArgs e)
        {
            if (btnLock.Text == "锁定")
            {
                MessageBox.Show("先锁定所有设置！");
                return;
            }

            Process.Start(AppDomain.CurrentDomain.BaseDirectory + "\\dxBuy.bat");

        }

        private void btnExecMore_Click(object sender, EventArgs e)
        {
            if (btnLock.Text == "锁定")
            {
                MessageBox.Show("先锁定所有设置！");
                return;
            }

            for (int i = 0; i < 3; i++)
            {

                Process.Start(AppDomain.CurrentDomain.BaseDirectory + "\\dxBuy.bat");
            }
        }

        private void OutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            //if (!String.IsNullOrEmpty(outLine.Data))
            //{
            //    StringBuilder sb = new StringBuilder(this.txtCmd.Text);
            //    this.txtCmd.Text = sb.AppendLine(outLine.Data).ToString();
            //    this.txtCmd.SelectionStart = this.txtCmd.Text.Length;
            //    this.txtCmd.ScrollToCaret();
            //}
        }

        private void FrmDxBot_Load(object sender, EventArgs e)
        {
            fileOpen(true);
        }
        /// <summary>
        /// 打开、读取文件
        /// </summary>
        private void fileOpen(bool status)
        {
            //打开系统日志文件
            if (!File.Exists(path))
            {
                // 目录/文件不存在，建立目录/文件
                File.CreateText(path);
            }
            //打开文件
            //FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            //通过指定字符编码方式可以实现对汉字的支持，否则在用记事本打开查看会出现乱码
            StreamReader m_streamReader = new StreamReader(path, System.Text.Encoding.GetEncoding("GB2312"));
            //使用StreamReader类来读取文件
            m_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);

            // 从数据流中读取每一行，直到文件的最后一行，并在richTextBox1中显示出内容
           
            string strLine = m_streamReader.ReadLine();



            if (status)
            {
                while (strLine != null)
                {
                    if (strLine.Contains(amount_of_bnb_to_spend))
                    {
                        txtAmount.Text=strLine.Replace(amount_of_bnb_to_spend,"");
                    }
                    if (strLine.Contains(gasPrice))
                    {
                        txtgasPrice.Text = strLine.Replace(gasPrice, "");
                    }
                    if (strLine.Contains(gasLimit))
                    {
                        txtgasLimit.Text = strLine.Replace(gasLimit, "");
                 
                    }
                    if (strLine.Contains(presale_address))
                    {
                        txtPresale_address.Text = strLine.Replace(presale_address, "");
                       
                    }
                    if (strLine.Contains(number_of_entries))
                    {
                        txtnum.Text = strLine.Replace(number_of_entries, "");
                   
                    }
                    if (strLine.Contains(mnemonic))
                    {
                        txtmnemonic.Text = strLine.Replace(mnemonic, "");
                  
                    }
                    strInfor += strLine + "\n";

                    strLine = m_streamReader.ReadLine();
                }
            }
            else
            {
                while (strLine != null)
                {
                    if (strLine.Contains(amount_of_bnb_to_spend))
                    {
                        strLine = amount_of_bnb_to_spend + txtAmount.Text;
                    }
                    if (strLine.Contains(gasPrice))
                    {
                        strLine = gasPrice + txtgasPrice.Text;
                    }
                    if (strLine.Contains(gasLimit))
                    {
                        strLine = gasLimit + txtgasLimit.Text;
                    }
                    if (strLine.Contains(presale_address))
                    {
                        strLine = presale_address + txtPresale_address.Text;
                    }
                    if (strLine.Contains(number_of_entries))
                    {
                        strLine = number_of_entries + txtnum.Text;
                    }
                    if (strLine.Contains(mnemonic))
                    {
                        strLine = mnemonic + txtmnemonic.Text;
                    }
                    strInfor += strLine + "\n";

                    strLine = m_streamReader.ReadLine();
                }
            }
         
            //关闭此StreamReader对象

            m_streamReader.Close();
        }

        //使用文件流的方法
        public static void EditFile(int curLine, string newLineValue, string patch)
        {
            FileStream fs = new FileStream(patch, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs, Encoding.GetEncoding("GB2312"));
            string line = sr.ReadLine();
            StringBuilder sb = new StringBuilder();
            for (int i = 1; line != null; i++)
            {
                sb.Append(line + "\r\n");
                if (i != curLine - 1)
                    line = sr.ReadLine();
                else
                {
                    sr.ReadLine();
                    line = newLineValue;
                }
            }
            sr.Close();
            fs.Close();
            FileStream fs1 = new FileStream(patch, FileMode.Open, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs1);
            sw.Write(sb.ToString());
            sw.Close();
            fs.Close();
        }

        /// <summary>
        /// 保存文件
        /// </summary>
        private void SaveToTxtFile()
        {
            //int buffer = 1024;
            //创建一个文件流，用以写入或者创建一个StreamWriter

            //FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);

            //通过指定字符编码方式可以实现对汉字的支持，否则在用记事本打开查看会出现乱码
            /*改函数很重要由于要将修改的内容覆盖原来的文件内容故设第二个参数为false，
            同时还不能用其他类如FileString来操作文件(多线程占用，不能覆盖修改文件)
             * 例如：new StreamWriter(fs, true, Encoding.GetEncoding("GB2312"));是错误的*/
            StreamWriter m_streamWriter = new StreamWriter(path, false, Encoding.GetEncoding("GB2312"));

            m_streamWriter.Flush();

            // 使用StreamWriter来往文件中写入内容

            m_streamWriter.BaseStream.Seek(0, SeekOrigin.Begin);

            // 把richTextBox1中的内容写入文件

            m_streamWriter.Write(strInfor);

            //关闭此文件

            m_streamWriter.Flush();

            m_streamWriter.Close();
            //清空
            strInfor = string.Empty;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
        }

        private void chcTime_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnTimeExec_Click(object sender, EventArgs e)
        {

            if (btnLock.Text == "锁定")
            {
                MessageBox.Show("先锁定所有设置！");
               
                return;
            }
            dtTo = new TimeSpan(Convert.ToInt32(txtHours.Text), Convert.ToInt32(txtMin.Text), Convert.ToInt32(txtS.Text)-2); //设置开始时间
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Start();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            lblShow.Text = string.Empty;
            timer1.Enabled = false;   //其中可自行添加相应的提示框或者方法函数
        }

        private void txtHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;  //禁止空格键 
            if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length == 0)) return;   //处理负数 
            if (e.KeyChar > 0x20)
            {
                try
                {
                    double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                }
                catch
                {
                    e.KeyChar = (char)0;   //处理非法字符 
                }
            }
        }

        private void chkKnowsPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKnowsPass.Checked)
                txtmnemonic.UseSystemPasswordChar = false;
            else
                txtmnemonic.UseSystemPasswordChar = true;

        }
    }
}
