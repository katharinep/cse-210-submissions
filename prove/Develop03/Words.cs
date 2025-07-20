public class Words
{
    private List<string> _wordList;
    private List<bool> _hiddenWord;

    public Words(string text)
    {
        _wordList = new List<string>(text.Split(" "));
        _hiddenWord = new List<bool>(new bool[_wordList.Count]);
    }

    public void Hide()
    {
        Random random = new Random();
        int index = random.Next(_hiddenWord.Count);
        _hiddenWord[index] = true;
    }

    public string GetRenderedText()
    {
        string renderedText = "";
        for (int i = 0; i < _wordList.Count; i++)
        {
            if (_hiddenWord[i] == false)
            {
                renderedText += _wordList[i] + " ";
            }
            else
            {
                renderedText += "_____ ";
            }
        }
        return renderedText;
    }

    public bool AllWordsHidden()
    {
        foreach (bool hidden in _hiddenWord)
        {
            if (!hidden)
                return false;
        }
        return true;
    }
}