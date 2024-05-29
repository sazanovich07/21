namespace WinFormsApp1
{
    public class SettingController
    {
        private SettingsForm SettingsForm;
        private GameForm gameForm;
        private int currentPlayerIndex = 0;
        private List<int> enteredNumbers = new List<int>();
        private List<string> playerNames = new List<string>();
        private int minNumber;
        private Game game;
        private bool isSplit;
        private int splitCount = 0;
        private int oneMoreCount = 0;
        private Random random = new Random();
        public SettingController(SettingsForm SettingsForm, Game game)
        {
            this.game = game;
            this.SettingsForm = SettingsForm;
        }
        public void SaveSettings()
        {
            if (game.minNumber == 0)
            {
                FirstSetting();
            }

            else if (game.minNumber != 0)
            {
                NewSetting();
            }
        }
        public void FirstSetting() 
        {
            string playerName = SettingsForm.PlayerName;

            if (string.IsNullOrWhiteSpace(playerName))
            {
                MessageBox.Show("Введите имя игрока.");
                return;
            }

            if (playerNames.Contains(playerName))
            {
                MessageBox.Show("Имя игрока должно быть уникальным.");
                return;
            }

            string enteredNumberString = SettingsForm.EnteredNumber;

            if (string.IsNullOrWhiteSpace(enteredNumberString))
            {
                MessageBox.Show("Введите число.");
                return;
            }

            if (!int.TryParse(enteredNumberString, out int enteredNumber))
            {
                MessageBox.Show("Введите корректное целое число.");
                return;
            }

            if (enteredNumber < 1 || enteredNumber > 21)
            {
                MessageBox.Show("Введите целое число от 1 до 21.");
                return;
            }

            if (!SettingsForm.IsSplitChecked && !SettingsForm.IsOneMoreChecked)
            {
                MessageBox.Show("Выберите один из вариантов.");
                return;
            }

            if (SettingsForm.IsSplitChecked)
            {
                splitCount++;
            }

            if (SettingsForm.IsOneMoreChecked)
            {
                oneMoreCount++;
            }

            playerNames.Add(playerName);
            enteredNumbers.Add(enteredNumber);
            SettingsForm.ClearFields();

            currentPlayerIndex++;
            if (currentPlayerIndex >= SettingsForm.NumberOfPlayers)
            {
                CalculateMinimumNumber(enteredNumbers);
                UpdateUI();
            }
            else
            {
                var nextPlayerName = game.players[currentPlayerIndex].Name;
                SettingsForm.CurrentPlayerLabel = nextPlayerName;
            }
        }
        public void NewSetting()
        {
            string enteredNumberString = SettingsForm.EnteredNumber;

            if (string.IsNullOrWhiteSpace(enteredNumberString))
            {
                MessageBox.Show("Введите число.");
                return;
            }

            if (!int.TryParse(enteredNumberString, out int enteredNumber))
            {
                MessageBox.Show("Введите корректное целое число.");
                return;
            }

            if (enteredNumber < 1 || enteredNumber > 21)
            {
                MessageBox.Show("Введите целое число от 1 до 21.");
                return;
            }

            if (!SettingsForm.IsSplitChecked && !SettingsForm.IsOneMoreChecked)
            {
                MessageBox.Show("Выберите один из вариантов.");
                return;
            }

            if (SettingsForm.IsSplitChecked)
            {
                splitCount++;
            }

            if (SettingsForm.IsOneMoreChecked)
            {
                oneMoreCount++;
            }

            enteredNumbers.Add(enteredNumber);
            SettingsForm.ClearFields();

            currentPlayerIndex++;
            if (currentPlayerIndex >= SettingsForm.NumberOfPlayers)
            {
                CalculateMinimumNumber(enteredNumbers);
                UpdateUI();
            }
            else
            {
                var nextPlayerName = game.players[currentPlayerIndex].Name;
                SettingsForm.CurrentPlayerLabel = nextPlayerName;
            }
        }
        public void UpdateUI()
        {
            SettingsForm.HideControls();
            SettingsForm.PlayerNameLabel = $"Минимальное число: {minNumber}";
            SettingsForm.CurrentPlayerLabel = "Начинайте игру";
            DetermineRoundType();
            SettingsForm.StartRoundButtonEnabled = true;
            SettingsForm.SaveButtonEnabled = false;
        }
        public int CalculateMinimumNumber(List<int> enteredNumbers)
        {
            double average = enteredNumbers.Average();
            minNumber = (int)Math.Floor(average);
            game.minNumber = minNumber;
            return minNumber;
        }
        public string DetermineRoundType()
        {
            string roundText;
            if (splitCount > oneMoreCount)
            {
                roundText = "Поделить банк";
            } 
            else if (splitCount < oneMoreCount)
            {
                roundText = "Сыграть доп раунд";
            }
            else
            {
                int rand = random.Next(2);
                roundText = rand == 1 ? "Поделить банк" : "Сыграть доп раунд";
            }
            SettingsForm.RoundText = roundText;
            isSplit = SettingsForm.RoundText == "Поделить банк";
            game.isSplit = isSplit;
            return roundText;
        }
        public void StartAllSettingsForm()
        {
            if (playerNames.Count != 0)
            {
                game.players.Clear();

                foreach (var kvp in playerNames)
                {
                    game.AddPlayer(kvp, 10);
                }
                playerNames.Clear();
            }

            foreach (var player in game.players)
            {
                player.TotalScore = 0;
            }

            gameForm = new GameForm();
            gameForm.UpdateMinimumLabel($"Минимальное число: {minNumber}");

            GameController gameController = new GameController(gameForm, game);

            gameForm.RollClicked += gameController.Roll;
            gameForm.BetClicked += gameController.Bet;
            gameForm.StopClicked += gameController.Stop;
            gameForm.FormClosed += (sender, args) => SettingsForm.Close();
            SettingsForm.Hide();
            gameForm.Show();

            gameController.GameUpdateUI();
        }
    }
}