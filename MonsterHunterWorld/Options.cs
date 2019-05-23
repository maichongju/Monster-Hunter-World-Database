using CommandLine;

namespace MonsterHunterWorld
{
    public class Options
    {
        // Reference https://github.com/commandlineparser/commandline
        private static Options _instance;

        public static Options Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Options();
                }
                return _instance;
            }
            set => _instance = value;
        }

        [Option('d', Default = false, HelpText = "Show debug information in log file")]
        public bool Debug { get; set; }

        [Option('o', HelpText = "Filename for copy of log ")]
        public string Log { get; set; }

        [Option('n', HelpText = "Create new log file")]
        public bool NewLog { get; set; }
    }
}