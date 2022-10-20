class Guess{

    words Word = new words();
    public string playerAnswer(){
    Console.Write("Pick a letter)");
    return Console.ReadLine() ?? "";
    }

    public bool correct(){
        string word = Word.chosenWord();
        if( playerAnswer() = )
    }
}