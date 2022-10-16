namespace SnakeGameTDDTests;

[TestClass]
public class SnakeGameTDDTests
{
    Game _game;
    Player player1 = new Player("Lucas");
    Player player2 = new Player("Alex");
    List<Player> playerList = new List<Player>();

    public SnakeGameTDDTests()
    {
        _game = new Game(playerList);
        _game.Push(player1);
        _game.Push(player2);

    }

    [TestMethod]
    public void CanStart()
    {
        _game.StartGame();
        Assert.IsTrue(_game.start);
    }

    [TestMethod]
    public void CanFinish()
    {
        _game.FinishGame();
        Assert.IsFalse(_game.start);
    }

    [TestMethod]
    [DataRow("")]
    [DataRow(null)]
    public void NamesCanNotBeEmptyOrNull(string name)
    {
        Assert.ThrowsException<Player.NullEmptyNameException>(() => new Player(name));
    }

    [TestMethod]
    public void PlayersStartWith0Score()
    {
        Assert.AreEqual(0, player1.score);
        Assert.AreEqual(0, player2.score);
    }

    [TestMethod]
    public void PlayersCanRollDice()
    {
        _game.RollDice(player1);
        Assert.AreNotEqual(0, player1.score);
        _game.RollDice(player2);
        Assert.AreNotEqual(0, player2.score);
    }

    [TestMethod]
    public void PlayerWinTheGame()
    {
        player1.score = 50;
        Assert.IsTrue(_game.PlayerWinTheGame(player1));
        Assert.IsFalse(_game.start);
    }

    [TestMethod]
    [DataRow(51)]
    [DataRow(54)]
    public void PlayerReturnTo25(int score)
    {
        player1.score = score;
        _game.DoesPlayerReturnTo25Score(player1);
        Assert.AreEqual(25, player1.score);
    }

    [TestMethod]
    public void GameStartWithTwoPlayers()
    {
        _game.StartGame();
        Assert.AreEqual(2, playerList.Count);
    }

    [TestMethod]
    public void PlayerDoesNotHaveZeroScoreSuringPlay()
    {
        _game.Start();
        Assert.AreNotEqual(0, player1.score);
        Assert.AreNotEqual(0, player2.score);
    }

    [TestMethod]
    public void IfNbCasesIs50()
    {
        _game.StartGame();
        Assert.AreEqual(50, _game.nbCases);
    }

    [TestMethod]
    public void IfPlayerListIsEmpty()
    {
        _game.StartGame();
        _game.Pop(player1);
        _game.Pop(player2);
        Assert.AreEqual(0, _game.players.Count);
    }

    [TestMethod]
    public void PushPlayer()
    {
        _game.StartGame();
        Player player3 = new Player("Bernard");
        _game.Push(player3);
        Assert.AreEqual(3, _game.players.Count);
    }

    [TestMethod]
    public void PopPlayer()
    {
        _game.StartGame();
        _game.Pop(player2);
        Assert.AreEqual(1, _game.players.Count);
    }

    [TestMethod]
    public void PushAndPopPlayer()
    {
        _game.StartGame();
        Player player3 = new Player("Hervé");
        _game.Push(player3);
        _game.Pop(player3);
        Assert.AreEqual(2, _game.players.Count);
    }

    [TestMethod]
    public void PopAndPushPlayer()
    {
        _game.StartGame();
        _game.Pop(player2);
        Player player3 = new Player("Hervé");
        _game.Push(player3);
        Assert.AreEqual(2, _game.players.Count);
    }

    [TestMethod]
    public void GetNameOfPlayer()
    {
        _game.StartGame();
        string player1name = player1.GetName();
        Assert.AreEqual("Lucas", player1name);

        string player2name = player2.GetName();
        Assert.AreEqual("Alex", player2name);
    }

    [TestMethod]
    public void GetScoreOfPlayer()
    {
        _game.StartGame();
        int player1score = player1.GetScore();
        Assert.AreEqual(0, player1score);

        int player2score = player2.GetScore();
        Assert.AreEqual(0, player2score);
    }

    [TestMethod]
    [DataRow("Bernard")]
    [DataRow("Julie")]
    public void SetNameOfPlayer(string name)
    {
        _game.StartGame();
        player1.SetName(name);

        Assert.AreEqual(name, player1.name);
    }

    [TestMethod]
    [DataRow(12)]
    [DataRow(14)]
    public void SetScoreOfPlayer(int sc)
    {
        _game.StartGame();
        player2.SetScore(sc);

        Assert.AreEqual(sc, player2.score);
    }
}
