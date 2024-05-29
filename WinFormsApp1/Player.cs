namespace WinFormsApp1
{
    public class Player
    {
        public string Name { get; }
        public int Money { get; set; }
        public int TotalScore { get; set; }
        public Bet PlayerBet { get; set; }
        public Player(string name, int money)
        {
            Name = name;
            Money = money;
            TotalScore = 0;
        }
        public void PlaceBet(int amount, Game game)
        {
            PlayerBet = new Bet(this, amount, game);
        }
    }
}
