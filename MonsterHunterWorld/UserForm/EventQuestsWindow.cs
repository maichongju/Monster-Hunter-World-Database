using System.Windows.Forms;

namespace MonsterHunterWorld.UserForm
{
    public partial class EventQuestsWindow : UserControl
    {
        private static EventQuestsWindow _instance;

        public static EventQuestsWindow Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EventQuestsWindow();
                }
                return _instance;
            }
        }

        private readonly string URL = "http://game.capcom.com/world/steam/us/schedule.html";

        public EventQuestsWindow()
        {
            InitializeComponent();
            WebBrowser.Navigate(URL);
        }
    }
}