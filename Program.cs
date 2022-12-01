class Program{
    static Game game = new Game();
    static Guess guess = new Guess();
    static Jumper jumper = new Jumper();
    static Word wordbank = new Word();
    static int guessesLeft = 4;

    public static void Main(){
        while (guessesLeft > 0){
            guessesLeft = game.RightorWrong(guessesLeft);
            jumper.printJumper(guessesLeft);
        }
    }
}