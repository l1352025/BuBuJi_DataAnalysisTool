using System;
using System.Collections.Generic;
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
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }

        // 方法1：在"Properties/Resources.resx"里添加dll文件
        static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            string dllName = args.Name.Contains(",") ? args.Name.Substring(0, args.Name.IndexOf(',')) : args.Name.Replace(".dll", "");
            dllName = dllName.Replace(".", "_");

            if (dllName.EndsWith("_resources")) return null;

            string rootNamespace = Assembly.GetExecutingAssembly().FullName.Split(',')[0];

            System.Resources.ResourceManager rm = new System.Resources.ResourceManager(rootNamespace + ".Properties.Resources", Assembly.GetExecutingAssembly());
            byte[] bytes = (byte[])rm.GetObject(dllName);
            return Assembly.Load(bytes);
        }
    }
}
