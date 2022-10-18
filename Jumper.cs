class Jumper{

    int guessesLeft = 4;
    public void printJumper(int guessesLeft){
        if(guessesLeft == 4){
            Console.WriteLine( "  ____  ");
            Console.WriteLine(@" /____\ ");
            Console.WriteLine(@" \    / ");
            Console.WriteLine(@"  \  /  ");
            Console.WriteLine( "    O   ");
            Console.WriteLine(@"   /|\  ");
            Console.WriteLine(@"   / \  ");
        }
        else if(guessesLeft == 3){
            Console.WriteLine(@" /____\ ");
            Console.WriteLine(@" \    / ");
            Console.WriteLine(@"  \  /  ");
            Console.WriteLine( "    O   ");
            Console.WriteLine(@"   /|\  ");
            Console.WriteLine(@"   / \  ");
        }
        else if(guessesLeft == 2){
            Console.WriteLine(@" \    / ");
            Console.WriteLine(@"  \  /  ");
            Console.WriteLine( "    O   ");
            Console.WriteLine(@"   /|\  ");
            Console.WriteLine(@"   / \  ");
        }
        else if(guessesLeft == 1){
            Console.WriteLine(@"  \  /  ");
            Console.WriteLine( "    O   ");
            Console.WriteLine(@"   /|\  ");
            Console.WriteLine(@"   / \  ");
        }
        else if(guessesLeft == 0){
            Console.WriteLine( "    x   ");
            Console.WriteLine(@"   /|\  ");
            Console.WriteLine(@"   / \  ");
        }
    }
}