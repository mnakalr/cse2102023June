public class Goal
{
    public string _shortName;
    public string _description;
    public List<ActionItem> _actionItems;
    public bool _isComplete;
    public float _points;

    public Goal(string shortName, string description, float points)
    {
        _shortName = shortName;
        _description = description;
        _actionItems = new List<ActionItem>();
        _isComplete = false;
        _points = points;
    }

    public void AddActionItem(ActionItem actionItem)
    {
        _actionItems.Add(actionItem);
    }

    public void MarkComplete()
    {
        _isComplete = true;
    }

    public List<ActionItem> GetActionItems()
    {
        return _actionItems;
    }

    public void SetShortName(string shortName)
    {
        _shortName = shortName;
    }

    public string GetShortName()
    {
        return _shortName;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetPoints(float points)
    {
        _points = points;
    }

    public float GetPoints()
    {
        return _points;
    }

    public bool IsComplete()
    {
        return _isComplete;
    }

    public bool IsOverdue()
    {
        if (_actionItems.Count > 0)
        {
            return _actionItems[^1].IsOverdue();
        }
        return false;
    }

    public string CheckProgress()
    {
        int countComplete = 0;
        int countOverdue = 0;
        float pointsPerActionItem = _points / _actionItems.Count;

        if (_isComplete)
        {
            return $"{_shortName} is Complete. You got {_points} points from this goal.";
        }
        else
        {
            foreach (ActionItem actionItem in _actionItems)
            {
                if (actionItem.IsOverdue())
                {
                    countOverdue++;
                }

                if (actionItem.IsComplete())
                {
                    countComplete++;
                }
            }

            float result = (countComplete * pointsPerActionItem) - ((countOverdue / 2f) * pointsPerActionItem);
            return $"{_shortName} is Incomplete. Progress: {countComplete}/{_actionItems.Count} action items, {countOverdue} overdue. You have earned {result} points.";
        }
    }

    

    public override string ToString()
    {
        string status = _isComplete ? "Complete" : "Incomplete";
        string actionItems = string.Join("\n", _actionItems.Select(item => item.ToString()));
        return $"Short Name: {_shortName}\nDescription: {_description}\nStatus: {status}\nAction Items:\n{actionItems}";
    }

    public void Display()
    {
        Console.WriteLine(this.ToString());
    }

    public void DisplayActionItems()
    {
        foreach (ActionItem actionItem in _actionItems)
        {
            Console.WriteLine(actionItem.ToString());
        }
    }

    public void DisplayActionItems(DateTime startDate, DateTime endDate, bool isComplete)
    {
        foreach (ActionItem actionItem in _actionItems)
        {
            if (!actionItem.IsOverdue() && actionItem.GetDueDate() >= startDate && actionItem.GetDueDate() <= endDate && actionItem.IsComplete() == isComplete)
            {
                Console.WriteLine(actionItem.ToString());
            }
        }
    }
}