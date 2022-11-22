class Guess{

    public string playerAnswer(){
        Console.Write("Pick a letter (a-z): )");
        return Console.ReadLine() ?? "";
    }
}