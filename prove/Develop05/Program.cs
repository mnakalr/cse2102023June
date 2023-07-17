using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

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

class GoalManager
{
    private List<Goal> _goals;

    public GoalManager()
    {
        _goals = new List<Goal>();
    }

    public void Start()
    {
        Console.WriteLine("Welcome to the Goal Manager!");
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1. Add a goal");
        Console.WriteLine("2. Add an action item");
        Console.WriteLine("3. Mark an action item complete");
        Console.WriteLine("4. Display all goals");
        Console.WriteLine("5. Exit");

        string input = Console.ReadLine();
        switch (input)
        {
            case "1":
                AddGoal();
                break;
            case "2":
                AddActionItem();
                break;
            case "3":
                MarkActionItemComplete();
                break;
            case "4":
                DisplayAllGoals();
                break;
            case "5":
                Exit();
                break;
            default:
                Console.WriteLine("Invalid input");
                Start();
                break;
        }
    }

    public void AddGoal()
    {
        Console.WriteLine("Choose the type of goal:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Checklist Goal");
        Console.WriteLine("3. Eternal Goal");

        string goalTypeInput = Console.ReadLine();
        if (!int.TryParse(goalTypeInput, out int goalType) || goalType < 1 || goalType > 3)
        {
            Console.WriteLine("Invalid input. Please choose a valid goal type.");
            AddGoal();
            return;
        }

        Console.WriteLine("Enter a short name for the goal");
        string shortName = Console.ReadLine();
        Console.WriteLine("Enter a description for the goal");
        string description = Console.ReadLine();
        Console.WriteLine("Enter total points for this goal");
        float points = float.Parse(Console.ReadLine());

        Goal goal;
        switch (goalType)
        {
            case 1:
                goal = new SimpleGoal(shortName, description, points);
                break;
            case 2:
                goal = new ChecklistGoal(shortName, description, points);
                break;
            case 3:
                goal = new EternalGoal(shortName, description, points);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                Start();
                return;
        }

        _goals.Add(goal);
        Console.WriteLine("Goal added successfully!");

        // Prompt to add action items
        AddActionItem();
        // Display all goals
        DisplayAllGoals();
        System.Threading.Thread.Sleep(3000);

        Start();
    }



    public void AddActionItem()
    {
        Console.WriteLine("Available Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. Short Name: {_goals[i].GetShortName()}, Description: {_goals[i].GetDescription()}");
        }

        Console.WriteLine("Enter the number of the goal to add an action item");
        int goalNumber;
        while (!int.TryParse(Console.ReadLine(), out goalNumber) || goalNumber < 1 || goalNumber > _goals.Count)
        {
            Console.WriteLine("Invalid input. Enter the number of the goal to add an action item");
        }

        Goal goal = _goals[goalNumber - 1];

        Console.WriteLine("Enter a description for the action item");
        string description = Console.ReadLine();
        Console.WriteLine("Enter a due date for the action item (yyyy-mm-dd)");
        DateTime dueDate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Enter a duration for the action item (hh:mm:ss)");
        TimeSpan duration = TimeSpan.Parse(Console.ReadLine());

        ActionItem actionItem = new ActionItem(description, dueDate, duration);
        goal.AddActionItem(actionItem);
        Console.WriteLine("Action item added successfully!");

        // Prompt for adding another action item
        Console.WriteLine("Do you want to add another action item? (y/n)");
        string response = Console.ReadLine().ToLower();
        if (response == "y")
        {
            AddActionItem();
        }
        else
        {
            Start();
        }
    }



  public void MarkActionItemComplete()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals found. Please add a goal first.");
            Start();
        }
        else
        {
            Console.WriteLine("Available Goals:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Short Name: {_goals[i].GetShortName()}, Description: {_goals[i].GetDescription()}");
            }

            Console.WriteLine("Enter the number of the goal to mark an action item as complete");
            int goalNumber;
            while (!int.TryParse(Console.ReadLine(), out goalNumber) || goalNumber < 1 || goalNumber > _goals.Count)
            {
                Console.WriteLine("Invalid input. Enter the number of the goal to mark an action item as complete");
            }

            Goal goal = _goals[goalNumber - 1];

            Console.WriteLine("Available Action Items:");
            List<ActionItem> actionItems = goal.GetActionItems();
            if (actionItems.Count == 0)
            {
                Console.WriteLine("No action items found for this goal.");
                Start();
            }
            else
            {
                for (int i = 0; i < actionItems.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {_goals[goalNumber - 1].GetShortName()} - {actionItems[i].GetDescription()}");
                }

                Console.WriteLine("Enter the number of the action item to mark as complete");
                int actionItemNumber;
                while (!int.TryParse(Console.ReadLine(), out actionItemNumber) || actionItemNumber < 1 || actionItemNumber > actionItems.Count)
                {
                    Console.WriteLine("Invalid input. Enter the number of the action item to mark as complete");
                }

                ActionItem actionItem = actionItems[actionItemNumber - 1];
                actionItem.MarkComplete();
                Console.WriteLine("Action item marked as complete!");

                Start();
            }
        }
    }



    public void DisplayAllGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals found");
            Start();
        }
        else
        {
            foreach (Goal goal in _goals)
            {
                goal.Display();
                Console.WriteLine();
            }
            Start();
        }
        
    }

    public void DisplayAllActionItems()
    {
        foreach (Goal goal in _goals)
        {
            goal.DisplayActionItems();
            Console.WriteLine();
        }
        Start();
    }

   public void SaveGoalsToFile(string filePath)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (Goal goal in _goals)
                {
                    writer.WriteLine(goal.GetShortName());
                    writer.WriteLine(goal.GetDescription());
                    writer.WriteLine(goal.GetPoints());
                    writer.WriteLine(goal.IsComplete());
                    writer.WriteLine(goal.GetActionItems().Count);
                    
                    foreach (ActionItem actionItem in goal.GetActionItems())
                    {
                        writer.WriteLine(actionItem.GetDescription());
                        writer.WriteLine(actionItem.GetDueDate().ToString("yyyy-MM-dd"));
                        writer.WriteLine(actionItem.GetDuration().ToString(@"hh\:mm\:ss"));
                        writer.WriteLine(actionItem.IsComplete());
                    }
                }
            }

            Console.WriteLine("Goals saved to file successfully!");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error occurred while saving goals to file: " + e.Message);
        }
    }

    public void LoadGoalsFromFile(string filePath)
    {
        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                _goals.Clear();

                while (!reader.EndOfStream)
                {
                    string shortName = reader.ReadLine();
                    string description = reader.ReadLine();
                    float points = float.Parse(reader.ReadLine());
                    bool isComplete = bool.Parse(reader.ReadLine());
                    int actionItemCount = int.Parse(reader.ReadLine());

                    Goal goal = new Goal(shortName, description, points);
                    goal.MarkComplete(); // Mark the goal as complete if it was saved as complete in the file

                    for (int i = 0; i < actionItemCount; i++)
                    {
                        string actionItemDescription = reader.ReadLine();
                        DateTime dueDate = DateTime.Parse(reader.ReadLine());
                        TimeSpan duration = TimeSpan.Parse(reader.ReadLine()); // Fixed line
                        bool isActionItemComplete = bool.Parse(reader.ReadLine());

                        ActionItem actionItem = new ActionItem(actionItemDescription, dueDate, duration);
                        if (isActionItemComplete)
                        {
                            actionItem.MarkComplete();
                        }

                        goal.AddActionItem(actionItem);
                    }

                    _goals.Add(goal);
                }
            }

            Console.WriteLine("Goals loaded from file successfully!");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error occurred while loading goals from file: " + e.Message);
        }
    }


    

    

    public void Exit()
    {
        Console.WriteLine("Goodbye!");
    }
}

public class SimpleGoal : Goal
{
    public SimpleGoal(string shortName, string description, float points) : base(shortName, description, points)
    {
    }
}

public class ChecklistGoal : Goal
{
    public ChecklistGoal(string shortName, string description, float points) : base(shortName, description, points)
    {
    }
}

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

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}
