class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference()
    {
        _book = "John";
        _chapter = 1;
        _startVerse = 15;
    }
    public Reference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public string Display()
    {   
        if (_endVerse == 0)
        {
            return $"Scripture Reference: {_book} {_chapter}:{_startVerse}";
        }
        else
        {
            return $"Scripture Reference: {_book} {_chapter}:{_startVerse} - {_endVerse}";
        }
    }
}