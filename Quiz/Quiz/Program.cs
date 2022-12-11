
using Quiz;


// tworzymy obiekt typu Game
var game = new Game();

// tworzymy obiekt typu Message
var messages = new Messages();

// wyswietlamy powitanie
messages.DisplayWelcomeScreen();

// losujemy pytanie z aktualnej kategorii
game.GetQuestion();

// wyswietlamy pytanie i pobieramy klawisz wciśniety przez Użytkownika
int playerAnswer = game.CurrentQuestion.Display();

// sprawdzamy poprawność odpowiedzi
bool correct = game.CheckPlayerAnswer(playerAnswer);

// logika rozdzielona na dwa wątki w zalezności od tego czy gracz odpowidział dobrze lub nie
if (correct)
{
    // DOBRZE
}
else
{
    messages.DisplayFailAndGameOver();
}
















