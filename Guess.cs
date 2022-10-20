class Guess{

    public string playerAnswer(){
    Console.Write("Pick a letter)");
    return Console.ReadLine() ?? "";
    }
}