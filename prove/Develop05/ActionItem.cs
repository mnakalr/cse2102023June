public class ActionItem
{
    private string _description;
    private DateTime _dueDate;
    private TimeSpan _duration;
    private bool _isComplete;

    public ActionItem(string description, DateTime dueDate, TimeSpan duration)
    {
        _description = description;
        _dueDate = dueDate;
        _duration = duration;
        _isComplete = false;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void MarkComplete()
    {
        _isComplete = true;
    }

    public void SetDueDate(DateTime dueDate)
    {
        _dueDate = dueDate;
    }

    public DateTime GetDueDate()
    {
        return _dueDate;
    }

    public void SetDuration(TimeSpan duration)
    {
        _duration = duration;
    }

    public TimeSpan GetDuration()
    {
        return _duration;
    }

    public bool IsOverdue()
    {
        return DateTime.Now > _dueDate;
    }

    public bool IsComplete()
    {
        return _isComplete;
    }

    public override string ToString()
    {
        string completionStatus = _isComplete ? "[X]" : "[ ]";
        return $"{completionStatus} {_description}\nDue Date: {_dueDate}\nDuration: {_duration}";
    }
}