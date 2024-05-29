namespace WinFormsApp1
{
    public partial class StartForm : Form
    {
        public event Action StartGameClicked;
        public StartForm()
        {
            InitializeComponent();
        }
        public string EnteredNumber => inputPlayer.Text;
        private void StartGame_Click(object sender, EventArgs e)
        {
            StartGameClicked?.Invoke();
        }
    }
}