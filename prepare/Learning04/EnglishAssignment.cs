class EnglishAssignment : Assignment
{
    private string _subject;
    

    public EnglishAssignment(string studentName, string topic, string subject) : base(studentName, topic)
    {
        _subject = subject;
    }

    public string GetWritingInformation()
    {
        string _author = GetStudentName();
        return $"{_subject} by {_author}";
    }

}