class Game
{

  public BasePlayer PlayerOne { get; set; }
  public BasePlayer PlayerTwo { get; set; }
  private bool Played;

  public Dictionary<string, List<int>> Scores { get; set; }

  public Game(BasePlayer playerOne, BasePlayer playerTwo)
  {

    PlayerOne = playerOne;
    PlayerTwo = playerTwo;
    Scores = new() {
      {PlayerOne.ToString()!, new List<int>()},
      {PlayerTwo.ToString()!, new List<int>()}
    };
  }

  public void StartGame(int turns = 20)
  {
    bool? lastPlay = null;
    for (int i = 0; i < turns; i++)
    {
      var firstChoice = PlayerOne.MakeChoice(lastPlay);
      var secondChoice = PlayerTwo.MakeChoice(firstChoice);
      lastPlay = secondChoice;
      RecordScores(firstChoice, secondChoice);
    }
    Played = true;
  }

  private void RecordScores(bool firstChoice, bool secondChoice)
  {
    if (firstChoice && secondChoice)
    {
      Scores[PlayerOne.ToString()!].Add(3);
      Scores[PlayerTwo.ToString()!].Add(3);
    }

    if (firstChoice && !secondChoice)
    {
      Scores[PlayerOne.ToString()!].Add(0);
      Scores[PlayerTwo.ToString()!].Add(5);
    }

    if (!firstChoice && secondChoice)
    {
      Scores[PlayerOne.ToString()!].Add(5);
      Scores[PlayerTwo.ToString()!].Add(0);
    }

    if (!firstChoice && !secondChoice)
    {
      Scores[PlayerOne.ToString()!].Add(1);
      Scores[PlayerTwo.ToString()!].Add(1);
    }
  }

  public void ShowResults()
  {
    if (!Played)
    {
      Console.WriteLine("No game played yet!");
    }

    var scoreOne = Scores[PlayerOne.ToString()!].Sum();
    var scoreTwo = Scores[PlayerTwo.ToString()!].Sum();
    Console.WriteLine($"{PlayerOne} Score : {scoreOne}");
    Console.WriteLine($"{PlayerTwo} Score : {scoreTwo}");
  }

}