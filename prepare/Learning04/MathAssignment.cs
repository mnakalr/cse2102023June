// this class inherits from Assignment
class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _problems;

    // Constructor gets the student name, topic, textbook section, and problems
    public MathAssignment(string studentName, string topic, string textBookSection, string problems) : base(studentName, topic)
    {
        _textBookSection = textBookSection;
        _problems = problems;
    }

    // Setter method
    public void setTextBookSection(string textBookSection)
    {
        _textBookSection = textBookSection;
    }

    // Getter method
    public string GetTextBookSection()
    {
        return _textBookSection;
    }

    // Setter method
    public void setProblems(string problems)
    {
        _problems = problems;
    }

    // Getter method
    public string GetProblems()
    {
        return _problems;
    }

    public string GetHomeworkList()
    {
        return $"{_textBookSection} {_problems}";
    }
}