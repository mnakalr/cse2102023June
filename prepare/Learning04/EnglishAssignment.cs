// This class inherits from the Assignment class
class EnglishAssignment : Assignment
{
    private string _subject;
    
    // Constructor gets the student name, topic, and subject
    public EnglishAssignment(string studentName, string topic, string subject) : base(studentName, topic)
    {
        _subject = subject;
    }

    // Setter method that gets the protected author name from the base class
    public string GetWritingInformation()
    {
        string _author = GetStudentName();
        return $"{_subject} by {_author}";
    }

}