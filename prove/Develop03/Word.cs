class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string Display()
    {
        if (_isHidden)
        {
            return "__";
        }
        else
        {
            return _text;
        }
    }
}
