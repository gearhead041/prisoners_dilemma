
var titForTat = new TitForTat();
var alwaysDefect = new AlwaysDefect();
var theJoss = new Joss();

var game = new Game(theJoss, titForTat);
game.StartGame(200);
game.ShowResults();