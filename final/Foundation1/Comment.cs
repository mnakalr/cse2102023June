class Comment
{
    private string _text;
    private string _author;
    private DateTime _date;

    public Comment(string text, string author, DateTime date)
    {
        _text = text;
        _author = author;
        _date = date;
    }

    public void SetText(string text)
    {
        _text = text;
    }
    public string GetText()
    {
        return _text; 
    }

    public void SetAuthor(string author)
    {
        _author = author;
    }
    public string GetAuthor()
    { 
        return _author; 
    } 

    public void SetDate(DateTime date) 
    { 
        _date = date; 
    }
    public DateTime GetDate() 
    { 
        return _date; 
    }
}