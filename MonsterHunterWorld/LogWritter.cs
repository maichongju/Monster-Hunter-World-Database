using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace MonsterHunterWorld
{
    public class LogWritter
    {
        private static LogWritter _instance;

        public static LogWritter Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LogWritter();
                }
                return _instance;
            }
        }

        private string LogFilePath = string.Empty;
        public static string UserDefineLogPath = null;
        private string DefaultLogPath => Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Log.log";

        //Path.IsPathRooted Method https://docs.microsoft.com/en-us/dotnet/api/system.io.path.ispathrooted?view=netstandard-2.1
        //File.Create Method https://docs.microsoft.com/en-us/dotnet/api/system.io.file.create?view=netframework-4.8

        public LogWritter()
        {
            // If user did set the path
            if (!String.IsNullOrEmpty(Options.Instance.Log))
            {
                // user is enter a absolute path
                if (Path.IsPathRooted(Options.Instance.Log))
                {
                    LogFilePath = Options.Instance.Log;
                }
                else
                // User enter a relevant path
                {
                    LogFilePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\" + Options.Instance.Log;
                }
            }
            // User did not define -o switch for the log file. Use the default log file
            else
            {
                LogFilePath = DefaultLogPath;
            }

            try
            {
                if (!File.Exists(LogFilePath))
                {
                    using (File.Create(LogFilePath)) { };
                }
                else
                {
                    // If user want to create a new log file
                    if (Options.Instance.NewLog)
                    {
                        // Delete the old log file
                        File.Delete(LogFilePath);
                        // Create new log file
                        using (File.Create(LogFilePath)) { };
                    }
                }
            }
            // Exception handle
            catch (Exception ex)
            {
                string ExceptionString = String.Empty;
                if (ex is UnauthorizedAccessException)
                {
                    ExceptionString = $"Do not have write permission for {LogFilePath}";
                }
                else
                {
                    ExceptionString = $"{LogFilePath} is an invalid path";
                }
                LogFilePath = DefaultLogPath;
                Write(ExceptionString, LogCategory.Error);
                Write($"Log Path Change to {LogFilePath}", LogCategory.Error);
            }
            //The Exists method should not be used for path validation,
            //this method merely checks if the file specified in path exists. Passing an invalid path to Exists returns false.
        }

        public void Write(string LogMessage, LogCategory Category)
        {
            try
            {
                using (StreamWriter w = File.AppendText(LogFilePath))
                {
                    w.Write($"{Category} {DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()} {LogMessage}\r\n");
                }
            }
            catch (Exception)
            // If the log file cannot open, then it will output an error message to console
            // and write log to console
            {
                Console.Error.WriteLine($"Cannot open file {LogFilePath}");
                Console.WriteLine($"{Category} {DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()} {LogMessage}");
            }
        }

        /// <summary>
        /// Will try to open the log file
        /// </summary>
        /// <returns>True if file can be found, otherwise it will return false</returns>
        public void OpenLogFile()
        {
            if (!File.Exists(LogFilePath))
            {
                MessageBox.Show($"Log file Can not be found {LogFilePath}", "Log File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            System.Diagnostics.Process.Start(LogFilePath);
        }
    }

    public class LogCategory
    {
        private LogCategory(string value)
        {
            Value = value;
        }

        public string Value { get; set; }
        public static LogCategory Info => new LogCategory("I.");
        public static LogCategory Warning => new LogCategory("W.");
        public static LogCategory Error => new LogCategory("E.");
        public static LogCategory Debug => new LogCategory("D.");

        public override string ToString()
        {
            return Value;
        }
    }
}