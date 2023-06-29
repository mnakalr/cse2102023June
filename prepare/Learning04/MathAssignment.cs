class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textBookSection, string problems) : base(studentName, topic)
    {
        _textBookSection = textBookSection;
        _problems = problems;
    }

    public void setTextBookSection(string textBookSection)
    {
        _textBookSection = textBookSection;
    }

    public string GetTextBookSection()
    {
        return _textBookSection;
    }

    public void setProblems(string problems)
    {
        _problems = problems;
    }

    public string GetProblems()
    {
        return _problems;
    }

    public string GetHomeworkList()
    {
        return $"{_textBookSection} {_problems}";
    }
}