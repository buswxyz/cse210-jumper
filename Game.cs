class Game{

Guess playerguess = new Guess();
static Word words = new Word();
Jumper jumps = new Jumper();

string word = words.getRandomWord();

//find a way to implement the jumper class into guesses remaining and correct answer, so that upon a wrong answer it will give you 
// the new jumper image, and a correct answer will give you the previous one. Likewise, find a way to type out the number of guesses remaining.
    private int guessesRemaining(int guessesLeft){
        guessesLeft = guessesLeft - 1;
        return guessesLeft;
    }

    public int RightorWrong(int guessesLeft){
        string playerAnswer = playerguess.playerAnswer();
        

        
        if (word.Contains(playerAnswer)){
            Console.WriteLine($"Congratulations {playerAnswer} is indeed a letter in the word, you still have {guessesLeft} remaining");
        }
        else{
            guessesLeft = guessesRemaining(guessesLeft);
            Console.WriteLine($"Unfortunately {playerAnswer} not a letter in the word, you still have {guessesLeft} remaining");
        }
        return guessesLeft;
    }
}