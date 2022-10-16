namespace SnakeGameTDDTests
{
    public class Player
    {
        public string name;
        public int score = 0;

        public Player(string n)
        {
            if (string.IsNullOrEmpty(n))
                throw new NullEmptyNameException("Vous ne pouvez pas donner un nom vide ou null");
            else
                name = n;
        }

        public class NullEmptyNameException : Exception
        {
            public NullEmptyNameException(string message) : base(message)
            {

            }
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
             this.name = name;
        }

        public int GetScore()
        {
            return this.score;
        }

        public void SetScore(int score)
        {
            this.score = score;
        }
    }
}