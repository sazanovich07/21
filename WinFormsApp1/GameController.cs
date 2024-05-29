namespace WinFormsApp1
{
    public class GameController
    {
        private GameForm gameForm;
        private SettingsForm SettingsForm;
        private SettingController SettingController;
        private Random random = new Random();
        private Game game;
        private bool betsPlaced = false;
        private List<int> roundPlayer = new List<int>();
        private List<Player> players => game.players;
        private List<Player> allPlayers;
        private bool allPlayersInitialized = false;
        public GameController(GameForm gameForm, Game game)
        {
            this.gameForm = gameForm;
            this.game = game;
        }
        public void GameUpdateUI()
        {
            Player currentPlayer = game.players[game.currentPlayerIndex];

            gameForm.UpdateCurrentPlayerLabel($"{currentPlayer.Name}");
            gameForm.ChipsLabel = ($"Баланс: {currentPlayer.Money}");
            gameForm.UpdateScoreLabel($"Количество очков в раунде: {currentPlayer.TotalScore}");
            gameForm.UpdateBankLabel($"Банк: {game.totalBank}");
            gameForm.ToggleStopButton(currentPlayer.TotalScore >= game.minNumber);

            if (game.OneMoreBet)
            {
                gameForm.EnableRollButton(true);
                gameForm.DisableBetButton();
            }
            else
            {
                gameForm.EnableRollButton(betsPlaced);
                gameForm.EnableBetButton(!betsPlaced);
            }
        }
        public void Bet()
        {
            gameForm.RollButtonEnabled = true;
            if (!betsPlaced)
            {
                Player currentPlayer = game.players[game.currentPlayerIndex];
                currentPlayer.PlaceBet(1, game);
                gameForm.ChipsLabel = $"Баланс: {currentPlayer.Money}";
                gameForm.BankLabel = $"Банк: {game.totalBank}";
                gameForm.BetButtonEnabled = false;
                betsPlaced = true;
                GameUpdateUI();
            }
        }
        public void Roll()
        {
            gameForm.BetButtonEnabled = false;
            int roll = random.Next(1, 7);
            //int roll = 4;

            gameForm.PictureText = $@"C:\Users\xxx\source\repos\WinFormsApp1\WinFormsApp1\Properties\{roll}.png";
            Player currentPlayer = game.players[game.currentPlayerIndex];
            currentPlayer.TotalScore += roll;
            if (currentPlayer.TotalScore > 21)
            {
                gameForm.UpdateScoreLabel($"Количество очков в раунде: {currentPlayer.TotalScore}");
                MessageBox.Show($"Игрок {currentPlayer.Name} проиграл!", "Проигрыш", MessageBoxButtons.OK, MessageBoxIcon.Information);
                game.currentPlayerIndex = (game.currentPlayerIndex + 1) % game.players.Count;
                roundPlayer.Add(1);

                if (roundPlayer.Count == game.players.Count || (game.OneMoreRound && roundPlayer.Count == game.PlayersInTieRound))
                {
                    RoundResult();
                    roundPlayer.Clear();
                    game.OneMoreRound = false;
                }

                gameForm.PictureText = @"C:\Users\xxx\source\repos\WinFormsApp1\WinFormsApp1\Properties\0.png";
                gameForm.BetButtonEnabled = true;
                betsPlaced = false;
            }
            GameUpdateUI();
        }
        public void Stop()
        {
            Player currentPlayer = game.players[game.currentPlayerIndex];
            game.currentPlayerIndex = (game.currentPlayerIndex + 1) % game.players.Count;
            gameForm.PictureText = @"C:\Users\xxx\source\repos\WinFormsApp1\WinFormsApp1\Properties\0.png";
            gameForm.BetButtonEnabled = true;
            betsPlaced = false;
            roundPlayer.Add(1);

            if (roundPlayer.Count == game.players.Count)
            {
                RoundResult(); 
                roundPlayer.Clear();
            }

            if (game.OneMoreRound && roundPlayer.Count == game.PlayersInTieRound)
            {
                RoundResult();
                roundPlayer.Clear();
                game.OneMoreRound = false;
            }

            GameUpdateUI();
        }
        public void RoundResult()
        {
            PlayerResult(players);

            var eligiblePlayers = game.players.Where(player => player.TotalScore <= 21).ToList();

            if (eligiblePlayers.Count == 0)
            {
                StartNewSettingsForm();
                return;
            }

            var maxScore = eligiblePlayers.Max(player => player.TotalScore);
            var winners = eligiblePlayers.Where(player => player.TotalScore == maxScore).ToList();

            if (winners.Count > 0)
            {
                if (game.isSplit)
                {
                    HandleSplitWinners(winners);
                }
                else if (!game.isSplit && winners.Count > 1)
                {
                    HandleOneMoreRoundWinners(winners);
                }
                else if (!game.isSplit && winners.Count == 1)
                {
                    SetupNewGameForTieRound(winners);
                }
            }

            if (game.OneMoreBet == false)
            {
                game.RemovePlayer();
            }

            if (game.players.Count < 2)
            {
                gameForm.HideControls();
                if (game.players.Count == 1)
                {
                    gameForm.GameOverLabel = $"Игрок {game.players[0].Name} победил!";
                }
                else if (game.players.Count == 0)
                {
                    gameForm.GameOverLabel = $"Победителей нет :(";
                }
            }

            if (game.players.Count > 1 && game.OneMoreBet == false)
            {
                StartNewSettingsForm();
            }
            GameUpdateUI();
        }
        public static void PlayerResult(List<Player> players)
        {
            string scoresMessage = "Результаты раунда:\n";
            for (int i = 0; i < players.Count; i++)
            {
                scoresMessage += $"{players[i].Name}: {players[i].TotalScore}\n";
            }
            MessageBox.Show(scoresMessage, "Результаты раунда", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void ShowWinner(List<Player> winners)
        {
            if (game.isSplit)
            {
                string winnersNames = string.Join(", ", winners.Select(winner => winner.Name));
                string message = winners.Count == 1 ? $"Поздравляем игрока {winnersNames} с победой!" : $"Поздравляем игроков {winnersNames} с победой!";
                MessageBox.Show(message, "Победа", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!game.isSplit)
            {
                string winnersNames = string.Join(", ", winners.Select(winner => winner.Name));
                MessageBox.Show($"Победители {winnersNames} играют дополнительный раунд!", "Дополнительный раунд", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void PayWinners(List<Player> winners)
        {
            int splitMoney = game.totalBank / winners.Count;
            foreach (Player winner in winners)
            {
                winner.Money += splitMoney;
            }
            game.totalBank -= (splitMoney * winners.Count);
        }
        public void HandleSplitWinners(List<Player> winners)
        {
            ShowWinner(winners);
            PayWinners(winners);
        }
        public void HandleOneMoreRoundWinners(List<Player> winners)
        {
            game.OneMoreRound = true;
            game.OneMoreBet = true;
            game.PlayersInTieRound = winners.Count;

            ShowWinner(winners);

            var newGame = new Game();
            foreach (var winner in winners)
            {
                newGame.AddPlayer(winner.Name, winner.Money);
            }

            newGame.totalBank = game.totalBank;
            newGame.minNumber = game.minNumber;

            if (!allPlayersInitialized)
            {
                allPlayers = new List<Player>(game.players);
                allPlayersInitialized = true;
            }

            game = newGame;
            gameForm.RollButtonEnabled = true;
            gameForm.BetButtonEnabled = false;
            game.OneMoreBet = true;
            GameUpdateUI();
        }
        public void SetupNewGameForTieRound(List<Player> winners)
        {
            PayWinners(winners);

            if (allPlayersInitialized)
            {
                foreach (var player in game.players)
                {
                    var allPlayer = allPlayers.FirstOrDefault(p => p.Name == player.Name);
                    if (allPlayer != null && allPlayer.Money != player.Money)
                    {
                        allPlayer.Money = player.Money;
                    }
                }

                var newGame = new Game();

                foreach (var player in allPlayers)
                {
                    newGame.AddPlayer(player.Name, player.Money);
                }

                game = newGame;
                game.minNumber = 1;
            }

            game.OneMoreRound = false;
            game.OneMoreBet = false;

            MessageBox.Show($"Поздравляем игрока {winners[0].Name} с победой!", "Победа", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void SetPlayerNames()
        {
            var playerNamesList = players.Select(p => p.Name).ToList();

            string firstPlayerName = playerNamesList.First();
            playerNamesList.RemoveAt(0);
            playerNamesList.Add(firstPlayerName);

            var playerBetList = players.Select(p => p.Money).ToList();

            int firstPlayerBet = playerBetList.First();
            playerBetList.RemoveAt(0);
            playerBetList.Add(firstPlayerBet);

            game.players.Clear();
            for (int i = 0; i < playerNamesList.Count; i++)
            {
                string playerName = playerNamesList[i];
                int playerBet = playerBetList[i];
                game.AddPlayer(playerName, playerBet);
            }
        }
        public void StartNewSettingsForm()
        {
            SettingsForm = new SettingsForm();
            SettingController = new SettingController(SettingsForm, game);
            SettingsForm.SetNumberOfPlayers(players.Count);
            SettingsForm.SaveClicked += SettingController.SaveSettings;
            SettingsForm.GameClicked += SettingController.StartAllSettingsForm;
            SettingsForm.FormClosed += (sender, args) => gameForm.Close();
            gameForm.Hide();
            SettingsForm.Show();
            SetPlayerNames();
            SettingsForm.NewHideControls();
            SettingsForm.CurrentPlayerLabel = players[0].Name;
            if (SettingsForm.Controls["minNum"] is TextBox minNum)
            {
                minNum.Left -= 420;
            }
        }
    }
}