using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace BuBuJi_DataAnalysisTool
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //在InitializeComponent()之前调用
            //AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);

            //从资源里释放出Dll文件
            RealeseDllToExePath();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }

        // 方法1：在"Properties/Resources.resx"里添加dll文件
        private static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            string dllName = args.Name.Contains(",") ? args.Name.Substring(0, args.Name.IndexOf(',')) : args.Name.Replace(".dll", "");
            dllName = dllName.Replace(".", "_");

            if (dllName.EndsWith("_resources")) return null;

            string rootNamespace = Assembly.GetExecutingAssembly().FullName.Split(',')[0];

            System.Resources.ResourceManager rm = new System.Resources.ResourceManager(rootNamespace + ".Properties.Resources", Assembly.GetExecutingAssembly());
            byte[] bytes = (byte[])rm.GetObject(dllName);
            return Assembly.Load(bytes);
        }

        // 方法2：在工程和引用里添加dll文件，都设置为不复制到本地，工程的dll生成操作选择“嵌入的资源”
        private static Assembly CurrentDomain_AssemblyResolve2(object sender, ResolveEventArgs args)
        {
            string rootNamespace = Assembly.GetExecutingAssembly().FullName.Split(',')[0];
            string resourceName = rootNamespace + "." + new AssemblyName(args.Name).Name + ".dll";

            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
            {

                byte[] assemblyData = new byte[stream.Length];

                stream.Read(assemblyData, 0, assemblyData.Length);

                return Assembly.Load(assemblyData);

            }

        }

        // 方法3：在"Properties/Resources.resx"里添加dll文件，然后调用
        private static void RealeseDllToExePath()
        {
            string path = Path.GetDirectoryName(Application.ExecutablePath);
            string fileName = "";
#if fasle
            byte[] bytes;
            FileStream fs;
            
            if (!File.Exists(path + "\\System.Data.SQLite.dll"))
            {
                bytes = Properties.Resources.System_Data_SQLite;
                fs = File.Create(path + "\\System.Data.SQLite.dll");
                fs.Write(bytes, 0, bytes.Length);
                fs.Close();
            }

            
            if(! File.Exists(path + "\\SQLite.Interop.dll"))
            {
                bytes = Properties.Resources.SQLite_Interop;
                fs = File.Create(path + "\\SQLite.Interop.dll");
                fs.Write(bytes, 0, bytes.Length);
                fs.Close();
            }
#endif
            try
            {
                fileName = path + "\\System.Data.SQLite.dll";
                if (!File.Exists(fileName)) throw new Exception("not exist");

                if (Environment.Is64BitOperatingSystem)
                {
                    fileName = path + "\\x64\\msvcr100.dll";
                    if (!File.Exists(fileName)) throw new Exception("not exist");
                    File.Copy(fileName, path + "\\msvcr100.dll", true);

                    fileName = path + "\\x64\\SQLite.Interop.dll";
                    if (!File.Exists(fileName)) throw new Exception("not exist");
                }
                else
                {
                    fileName = path + "\\x86\\msvcr100.dll";
                    if (!File.Exists(fileName)) throw new Exception("not exist");
                    File.Copy(fileName, path + "\\msvcr100.dll", true);

                    fileName = path + "\\x86\\SQLite.Interop.dll";
                    if (!File.Exists(fileName)) throw new Exception("not exist");
                }
            }
            catch(Exception e)
            {
                if (e.Message == "not exist")
                {
                    MessageBox.Show("找不到文件 " + fileName, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Application.Exit();
                }
            }
        }
    }
}
