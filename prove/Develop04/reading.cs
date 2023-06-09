public class Reading : Activity
{

    private IDictionary<int, string> _reading_prompt = new Dictionary<int, string>() {
	{0, "---- Don't give up when dark times come. The more storms you face in life, the stronger you’ll be. Hold on. Your greater is coming. ---- "},
	{1, "---- Laugh now, cry later. ---- "},
	{2, "---- Cheer up, my dear. After every storm comes the sun. Happiness is waiting for you ahead. ---- "},
    {3, "---- What doesn't kill you makes you stronger. ---- "},
	{4, "---- Everything you want is on the other side of fear. ---- "},
    {5, "---- Sometimes when things are falling apart, they may actually be falling into the right place. ---- "},
    {6, "---- Our greatest glory is not in ever failing, but in rising every time we fail. ---- "},
    {7, "---- Stop searching the world for treasure, the real treasure is in yourself. ---- "},
    {8, "---- Life is too short for us to dwell on sadness. Cheer up and live life to the fullest. ---- "}
};
    public void DisplayQuotes()
    {
        Random randomGenerator = new Random();

        int number = randomGenerator.Next(0, 5);

        string prompt =  _reading_prompt[number];
        Console.Write(prompt);
    }
}