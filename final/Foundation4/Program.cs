using System;
using System.Collections.Generic;

namespace Foundation4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Activity> activities = new List<Activity>();

            DateTime date = new DateTime(2022, 11, 3);

            activities.Add(new Running(date, 30, 3.0));
            activities.Add(new Running(date, 30, 4.8));
            activities.Add(new StationaryBicycles(date, 30, 6.0));
            activities.Add(new StationaryBicycles(date, 30, 9.7));
            activities.Add(new Swimming(date, 30, 30));
            activities.Add(new Swimming(date, 30, 50));

            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}



