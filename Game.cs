class Game{

Guess playerguess = new Guess();
Word words = new Word();
Jumper jumps = new Jumper();

//find a way to implement the jumper class into guesses remaining and correct answer, so that upon a wrong answer it will give you 
// the new jumper image, and a correct answer will give you the previous one. Likewise, find a way to type out the number of guesses remaining.
    private int guessesRemaining(int guessesLeft){
        guessesLeft = guessesLeft - 1;
        return guessesLeft;
    }

    public void correctAnswer(){
        string word = words.getRandomWord();
        string playerAnswer = playerguess.playerAnswer();
        int guessesLeft = 4;

        
        if (word.Contains(playerAnswer)){
            Console.WriteLine($"Congratulations {playerAnswer} is indeed a letter in the word, you still have {guessesLeft} remaining");

        }
        else{
            guessesLeft = guessesRemaining(guessesLeft);
            Console.WriteLine($"Unfortunately {playerAnswer} not a letter in the word, you still have {guessesLeft} remaining");
        }
    }
}