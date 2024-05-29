namespace WinFormsApp1
{
    public class Game
    {   
        public List<Player> players { get; private set; }
        public int currentPlayerIndex { get; set; }
        public int totalBank { get; set; }
        public int minNumber { get; set; }
        public bool isSplit { get; set; }
        public bool OneMoreBet { get; set; }
        public bool OneMoreRound { get; set; }
        public int PlayersInTieRound { get; set; }
        public Game()
        {
            players = new List<Player>();
            currentPlayerIndex = 0;
            totalBank = 0;
            minNumber = 0;
            isSplit = false;
            OneMoreBet = false;
            OneMoreRound = false;
            PlayersInTieRound = 0;
        }
        public void AddPlayer(string name, int startingMoney)
        {
            players.Add(new Player(name, startingMoney));
        }
        public void RemovePlayer()
        {
            var playersToRemove = players.Where(player => player.Money <= 0).ToList();
            foreach (var player in playersToRemove)
            {
                MessageBox.Show($"Игрок {player.Name} выбывает из игры!", "Выбытие", MessageBoxButtons.OK, MessageBoxIcon.Information);
                players.Remove(player);
            }
        }
    }
}
