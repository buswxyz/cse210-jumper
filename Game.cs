class Game{

Guess playerguess = new Guess();
Word words = new Word();
Jumper jumps = new Jumper();
int guessesLeft = 5;

//find a way to implement the jumper class into guesses remaining and correct answer, so that upon a wrong answer it will give you 
// the new jumper image, and a correct answer will give you the previous one. Likewise, find a way to type out the number of guesses remaining.
    public int guessesRemaining(){
        int guesses = guessesLeft-1;

        return guesses;
    
    }
    public string correctAnswer(){
        string word = words.getRandomWord();
        string playeranswer = playerguess.playerAnswer();
        if (word.Contains(playeranswer)){
            Console.WriteLine($"Congradulations {playeranswer} is indeed a letter in the word, you still have {guesses} remaining");
        }
        else{
            Console.WriteLine($"Unfortunatly {playeranswer} not a letter in the word, you still have {guesses} remaining");
        }
    }
}