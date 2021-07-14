using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunBot
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {

            
            var filePath = FindFilePath("node.exe", "");
            if (filePath.Contains("not found"))
            {
                MessageBox.Show("您的电脑缺少该程序所需组件nodejs,点击确定进行安装。安装需要等待，安装成功后重新打开本程序","提示",MessageBoxButtons.OK);
                Process.Start(Application.StartupPath + "\\node.msi");
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FrmDxBot());
            }
   
        }
        public static string FindFilePath(string file, string localPath)
        {
            file = Environment.ExpandEnvironmentVariables(file);
            if (!File.Exists(file))
            {
                if (Path.GetDirectoryName(file) == String.Empty)
                {
                    foreach (string test in (Environment.GetEnvironmentVariable("PATH") ?? "").Split(';'))
                    {
                        string path = test.Trim();
                        if (!string.IsNullOrEmpty(path) && File.Exists(path = Path.Combine(path, file)))
                            return Path.GetFullPath(path);
                    }
                }

                file = Path.Combine(localPath, file);
                if (File.Exists(file)) return file;

                return $"[{ Path.GetFileName(file) }] not found.";
            }

            return Path.GetFullPath(file);
        }
    }
}
