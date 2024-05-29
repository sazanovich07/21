namespace WinFormsApp1
{
    public class StartController
    {
        private StartForm startForm;
        private SettingsForm SettingsForm;
        private SettingController settingController;
        private Game game;
        public void Start(StartForm startForm)
        {
            this.startForm = startForm;
            startForm.StartGameClicked += StartFormHandler;
        }
        public void StartFormHandler()
        {
            int numberOfPlayers;
            if (int.TryParse(startForm.EnteredNumber, out numberOfPlayers))
            {
                if (numberOfPlayers >= 2 && numberOfPlayers <= 6)
                {
                    game = new Game();
                    for (int i = 1; i <= numberOfPlayers; i++)
                    {
                        game.AddPlayer($"Player {i}", 10);
                    }
                    SettingsForm = new SettingsForm();
                    settingController = new SettingController(SettingsForm, game);
                    SettingsForm.SetNumberOfPlayers(numberOfPlayers);
                    SettingsForm.SaveClicked += settingController.SaveSettings;
                    SettingsForm.GameClicked += settingController.StartAllSettingsForm;
                    SettingsForm.FormClosed += (sender, args) => startForm.Close();
                    startForm.Hide();
                    SettingsForm.Show();
                    SettingsForm.CurrentPlayerLabel = "Player 1";

                }
                else
                {
                    MessageBox.Show("Количество игроков должно быть от 2 до 6.");
                }
            }
            else
            {
                MessageBox.Show("Введите правильное число.");
            }
        }
    }
}