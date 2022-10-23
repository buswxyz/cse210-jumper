class Program{
    Game game = new Game();
    Guess guess = new Guess();
    Jumper jumper = new Jumper();
    Word word = new Word();
    int guessesLeft = 4;

    public void Main(){
        string selectedWord = word.getRandomWord();
        while (guessesLeft > 0){
            jumper.printJumper(guessesLeft);
            game.correctAnswer();
        }
    }
}