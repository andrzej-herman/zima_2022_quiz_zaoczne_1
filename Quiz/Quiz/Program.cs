
using Quiz;

// tworzymy obiekt typu Game
var game = new Game();

// tworzymy obiekt typu Message
var messages = new Messages();

// wyswietlamy powitanie
messages.DisplayWelcomeScreen();

// losujemy pytanie z aktualnej kategorii
game.GetQuestion();

// wyswietlamy pytanie
game.CurrentQuestion.Display();















