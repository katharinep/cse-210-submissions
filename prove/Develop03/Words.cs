public class Words
{
    private string _oneWord;
    private List<string> _wordList;
    private List<bool> _hiddenWord;

    public Words(string text)
    {
        _wordList = new List<string>(text.Split(" "));
        _hiddenWord = new List<bool>( new bool[_wordList.Count]);
    }

    public bool Hide()
    {
        //code here
        return false;
    }

    public string Show()
    {
        //code here
        return "";
    }

    public string GetIsHidden()
    {
        //code here
        return "";
    }

    public string GetRenderedText()
    {
        //code here
        return "";
    }
}