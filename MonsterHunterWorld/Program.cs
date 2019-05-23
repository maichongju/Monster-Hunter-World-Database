using CommandLine;
using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace MonsterHunterWorld
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(String[] args)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
            // Parser command line
            Parser.Default.ParseArguments<Options>(args)
                .WithParsed(options =>
                { Options.Instance = options; });
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(UserForm.MainForm.Instance);
        }
    }
}