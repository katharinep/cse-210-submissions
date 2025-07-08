public class Scripture
{
    private Reference _reference;
    private Words _words;

    public Scripture(Reference reference)
    {
        _reference = reference;
    }

    public void HideWords()
    {
        _words.Hide();
    }

    public string GetFullText()
    {
        Reference reference = new Reference();
        Reference newScripture = reference.RandomScripture();
    }
    public string GetRenderedText()
    {

        return "";
    }
}