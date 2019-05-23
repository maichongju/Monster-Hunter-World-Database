using System.Windows.Forms;

namespace MonsterHunterWorld.UserForm
{
    public partial class WelcomeWindow : UserControl
    {
        // Make sure there is only one instance exist
        private static WelcomeWindow _instance;

        public static WelcomeWindow Instance
        {
            get
            {
                if (_instance == null) _instance = new WelcomeWindow();
                return _instance;
            }
        }

        public WelcomeWindow()
        {
            InitializeComponent();
        }
    }
}