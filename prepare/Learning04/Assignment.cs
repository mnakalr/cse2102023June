//This is the base class for the MathAssignment and EnglishAssignment classes
class Assignment
{
    // Fields
    protected string _studentName;
    protected string _topic;

    // Constructor
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Setter method
    public void setName(string studentName)
    {
        _studentName = studentName;
    }

    // Getter method
    public string GetStudentName()
    {
        return _studentName;
    }

    // Setter method
    public void setTopic(string topic)
    {
        _topic = topic;
    }

    // Getter method
    public string GetTopic()
    {
        return _topic;
    }

    public string Getsummary()
    {
        return $"{_studentName} - {_topic}";
    }
}