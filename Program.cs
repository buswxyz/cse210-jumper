class program{
    Game game = new Game();
    Guess guess = new Guess();
    Jumper jumper = new Jumper();
    Word word = new Word();
    int guessesLeft = 4;

    void Main(){
        string selectedWord = word.getRandomWord();
        while (guessesLeft > 0){
        guessesLeft = game.guessesRemaining(guessesLeft);
        jumper.printJumper(guessesLeft);
        string playerGuess = guess.playerAnswer;
        }
    }

}