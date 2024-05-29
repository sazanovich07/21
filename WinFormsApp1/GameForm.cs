namespace WinFormsApp1
{
    public partial class GameForm : Form
    {
        public event Action RollClicked;
        public event Action BetClicked;
        public event Action StopClicked;
        public GameForm()
        {
            InitializeComponent();
            GameOver.Visible = false;
        }
        public void HideControls()
        {
            bankLabel.Visible = false;
            currentPlayerLabel.Visible = false;
            scoreLabel.Visible = false;
            chipsLabel.Visible = false;
            minimum.Visible = false;
            betButton.Visible = false;
            rollButton.Visible = false;
            stopButton.Visible = false;
            GameOver.Visible = true;
        }
        public string GameOverLabel
        {
            set => GameOver.Text = value;
        }
        public void UpdateCurrentPlayerLabel(string playerName)
        {
            currentPlayerLabel.Text = playerName;
        }
        public void UpdateScoreLabel(string scoreInfo)
        {
            scoreLabel.Text = scoreInfo;
        }
        public void UpdateMinimumLabel(string minNumberInfo)
        {
            minimum.Text = minNumberInfo;
        }
        public void UpdateBankLabel(string bankInfo)
        {
            bankLabel.Text = bankInfo;
        }
        public void ToggleStopButton(bool isEnabled)
        {
            stopButton.Enabled = isEnabled;
        }
        public void EnableRollButton(bool isEnabled)
        {
            rollButton.Enabled = isEnabled;
        }
        public void EnableBetButton(bool isEnabled)
        {
            betButton.Enabled = isEnabled;
        }
        public void DisableBetButton()
        {
            betButton.Enabled = false;
        }
        public string BankLabel
        {
            set => bankLabel.Text= value;
        }
        public string ChipsLabel
        {
            set => chipsLabel.Text = value;
        }
        public string PictureText
        {
            set => pictureBox.ImageLocation = value;
        }
        public bool StopButtonEnabled
        {
            set => stopButton.Enabled = value;
        }
        public bool RollButtonEnabled
        {
            set => rollButton.Enabled = value;
        }
        public bool BetButtonEnabled
        {
            set => betButton.Enabled = value;
        }
        public void Bet_Click(object sender, EventArgs e)
        {
            BetClicked?.Invoke();
        }
        public void Roll_Click(object sender, EventArgs e)
        {
            RollClicked?.Invoke();
        }
        public void Stop_Click(object sender, EventArgs e)
        {
            StopClicked?.Invoke();
        }
    }
}