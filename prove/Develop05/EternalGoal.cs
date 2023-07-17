public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, float points) : base(shortName, description, points)
    {
    }

    public override string ToString()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        return $"Short Name: {_shortName}\nDescription: {_description}\nStatus: {status}";
    }
}