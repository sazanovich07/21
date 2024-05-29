namespace WinFormsApp1
{
    public class Bet
    {
        private Player player;
        private Game game;
        public Bet(Player player, int amount, Game game)
        {
            this.player = player;
            this.game = game;
            player.Money -= amount;
            game.totalBank += amount;
        }
    }
}
