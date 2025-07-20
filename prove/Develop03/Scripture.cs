public class Scripture
{
    private Reference _reference;
    private Words _words;

    public Scripture(Reference reference)
    {
        _reference = reference;
        _words = new Words(reference.FullText());
    }

    public void HideWords()
    {
        _words.Hide();
    }

    public string GetRenderedText()
    {

        return $"{_reference.DisplayScripture()}\n{_words.GetRenderedText()}";
    }

    public bool AllHidden()
    {
        return _words.AllWordsHidden();
    }
}