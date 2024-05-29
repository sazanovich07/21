using static WinFormsApp1.GameController;

namespace WinFormsApp1
{
    public partial class SettingsForm : Form
    {
        public event Action SaveClicked;
        public event Action GameClicked;
        private int numberOfPlayers;
        private int currentPlayerIndex = 0;
        public bool IsSplitChecked => split.Checked;
        public bool IsOneMoreChecked => oneMore.Checked;
        public SettingsForm()
        {
            InitializeComponent();
            startRoundButton.Enabled = false;
        }
        public void SetNumberOfPlayers(int number)
        {
            numberOfPlayers = number;
        }
        public int NumberOfPlayers => numberOfPlayers;
        public string PlayerName => inputName.Text.Trim();
        public string EnteredNumber => minNum.Text;
        public void ClearFields()
        {
            minNum.Text = "";
            inputName.Text = "";
            split.Checked = false;
            oneMore.Checked = false;
        }
        public void HideControls()
        {
            minNum.Visible = false;
            split.Visible = false;
            oneMore.Visible = false;
            minNumber.Visible = false;
            inputName.Visible = false;
        }
        public void NewHideControls()
        {
            inputName.Visible = false;
            minNumber.Visible = false;
            playerNameLabel.Text = "Введите мин число";
        }
        public string PlayerNameLabel
        {
            set => playerNameLabel.Text = value;
        }
        public string CurrentPlayerLabel
        {
            set => currentPlayerLabel.Text = value;
        }
        public string RoundText
        {
            get => Round.Text;
            set => Round.Text = value;
        }
        public bool StartRoundButtonEnabled
        {
            set => startRoundButton.Enabled = value;
        }
        public bool SaveButtonEnabled
        {
            set => saveButton.Enabled = value;
        }
        public void Save_Click(object sender, EventArgs e)
        {
            SaveClicked?.Invoke();
        }
        public void Start_Click(object sender, EventArgs e)
        {
            GameClicked?.Invoke();
        }
    }
}