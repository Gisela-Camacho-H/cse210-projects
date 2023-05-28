public class Scripture
{
    private string _text;
    private List<string> _textList = new List<string>();

    public List<string> ConvertToList(string text)
    {
     List<string> _textList= text.Split(' ').ToList();
     return _textList;
    }

    public void DisplayList(List<string> list)
    {
        foreach (var i in list) {
            Console.Write(i);
        }
    }

    public int RandomWord(List<string> list)
    {
        Random randomGenerator = new Random();

        int number = randomGenerator.Next(0, list.Count);
        return number;
    }

    public string ConvertToUnderscores(string word)
    {
        var underscoredWord = "";
        foreach (var i in word) {
            underscoredWord = underscoredWord + "_";
        }
        return underscoredWord;
    }
}