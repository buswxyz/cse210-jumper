class Word{

    private List<string> words = new List<string>();
    Random rnd = new Random();

    public Word(){
        createWordList();
    }
    
    private List<string> createWordList(){
        words.Add("sword");
        words.Add("logic");
        words.Add("pyramid");
        words.Add("traveler");
        words.Add("light");
        words.Add("darkness");
        words.Add("bone");
        words.Add("marrow");
        words.Add("taken");
        words.Add("king");
        words.Add("fallen");
        words.Add("captain");
        words.Add("vandal");
        words.Add("dreg");
        words.Add("rifle");
        words.Add("guardian");
        words.Add("hive");
        words.Add("thrall");
        words.Add("knight");
        words.Add("wizard");

        return words;
    }

    private int getRandomIndex(){
        int randomWordIndex = rnd.Next(words.Count);
        return randomWordIndex;
    }

    public string getRandomWord(){
        int index = getRandomIndex();
        string randomWord = words[index];
        return randomWord;
    }
    
}
