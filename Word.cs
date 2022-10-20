class Word{

    private List<string> words = new List<string>();
    Random rnd = new Random();
    
    private List<string> createWordList(){
        words.Add("Sword");
        words.Add("Logic");
        words.Add("Pyramid");
        words.Add("Traveler");
        words.Add("Light");
        words.Add("Darkness");
        words.Add("Bone");
        words.Add("Marrow");
        words.Add("Taken");
        words.Add("King");
        words.Add("Fallen");
        words.Add("Captain");
        words.Add("Vandal");
        words.Add("Dreg");
        words.Add("Rifle");
        words.Add("Guardian");
        words.Add("Hive");
        words.Add("Thrall");
        words.Add("Knight");
        words.Add("Wizard");

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
