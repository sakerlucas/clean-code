using static System.Formats.Asn1.AsnWriter;

namespace SnakeGameTDDTests
{
    internal class Game
    {
        public bool start = false;
        public List<Player> players = new List<Player>();
        public Player player1 = new Player("Jean");
        public Player player2 = new Player("Alex");
        public int nbCases;

        public Game(List<Player> playerList)
        {
            players = playerList;
            nbCases = 50;
        }

        internal void Push(Player player)
        {
            players.Add(player);
        }

        internal void Pop(Player player)
        {
            players.Remove(player);
        }

        internal void Start()
        {
            StartGame();

            while (start)
            {
                PlayTurnByTurn();

                if (!start)
                    break;
            }
        }

        public void FinishGame()
        {
            start = false;
        }

        internal void RollDice(Player player)
        {
            Random aleatoire = new Random();
            int valeur = aleatoire.Next(1, 7);

            player.score += valeur;
        }

        internal bool PlayerWinTheGame(Player player)
        {
            if (player.score == 50) {
                FinishGame();
                return true;
            }

            return false;
        }

        internal void DoesPlayerReturnTo25Score(Player player)
        {
            if (player.score > 50)
                player.score = 25;
        }

        internal void PlayTurnByTurn()
        {
            foreach (Player player in players)
            {
                RollDice(player);

                if (PlayerWinTheGame(player))
                    break;

                DoesPlayerReturnTo25Score(player);

            }
        }

        internal void StartGame()
        {
            start = true;
        }
    }
}