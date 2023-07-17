using System;
using System.Collections.Generic;

public class GoalCalendar
{
    private Dictionary<DateTime, List<string>> calendar;

    public GoalCalendar()
    {
        calendar = new Dictionary<DateTime, List<string>>();
    }

    public void AddGoal(DateTime date, string goal)
    {
        if (calendar.ContainsKey(date))
        {
            calendar[date].Add(goal);
        }
        else
        {
            calendar[date] = new List<string> { goal };
        }
    }

    public void DisplayCalendar(int year, int month, int day, int viewOption)
    {
        DateTime startDate;
        DateTime endDate;

        if (viewOption == 0) // Monthly view
        {
            startDate = new DateTime(year, month, 1);
            endDate = startDate.AddMonths(1).AddDays(-1);
        }
        else if (viewOption == 1) // Weekly view
        {
            DateTime currentDate = new DateTime(year, month, day);
            int dayOfWeek = (int)currentDate.DayOfWeek;
            startDate = currentDate.AddDays(-dayOfWeek);
            endDate = startDate.AddDays(6);
        }
        else // Daily view
        {
            startDate = new DateTime(year, month, day);
            endDate = startDate;
        }

        Console.WriteLine($"Calendar for {startDate.ToString("MMMM yyyy")}");
        Console.WriteLine();

        for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
        {
            Console.WriteLine(date.ToString("dddd, MMMM d"));

            if (calendar.ContainsKey(date))
            {
                List<string> goals = calendar[date];
                Console.WriteLine($"Total Action Items: {goals.Count}");

                foreach (string goal in goals)
                {
                    Console.WriteLine($"- {goal}");
                }
            }
            else
            {
                Console.WriteLine("No Action Items");
            }

            Console.WriteLine();
        }
    }

}
