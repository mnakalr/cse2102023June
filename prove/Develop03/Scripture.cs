



class Scripture
{
    public Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string stringText)
    {
        _reference = reference;
        _words = new List<Word>();
        List<string> newWords = stringText.Split().ToList();

        foreach(string word in newWords)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }

    public void HideRandomWord()
    {
        Random random = new Random();

        List<Word> NotHiddenWords = new List<Word>();
        foreach(Word word in _words)
        {

            if (!word.IsHidden())
            {
                NotHiddenWords.Add(word);
            }
        }
        if (NotHiddenWords.Count > 0)
        {
            int randomIndex = random.Next(0, NotHiddenWords.Count);
            NotHiddenWords[randomIndex].Hide();
        }
       
    }

    public string GetVerseText()
    {
        string verseText = "";
        foreach (Word word in _words)
        {
            verseText += word.IsHidden() ? "__" : word.Display();
            verseText += " ";
        }
        return verseText.Trim();
    }

    public string Display()
    {
        string displayText = _reference.Display() + ": ";

        foreach(Word word in _words)
        {
            displayText += word.Display() + " ";
        }
        return displayText;
    }

    public bool AllTheWordAreHidden()
    {
        foreach(Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}

