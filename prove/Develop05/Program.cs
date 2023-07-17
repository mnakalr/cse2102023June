using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;











class Program
{
    static void Main(string[] args)
    {   
        // I exceeded the expections by adding an ActionItem class to establish the amount of actions needed to complete a goal.
        // which makes it easier to track the progress of a goal.
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}
