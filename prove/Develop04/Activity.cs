
using System;

class Activity
{
    private string _name;
    private string _description;
    protected int _duration;
    private string _characters = @"/-\|";

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayStartingMessage()
    {
        _name = _name.Replace("Activity", "").Replace("activity", "");

        Console.WriteLine($"Welcome to the {_name}Activity.");
        Console.WriteLine();
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine();
        Console.WriteLine("How long, in seconds, would you like your session? ");
        _duration = int.Parse(Console.ReadLine());
    }


    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}Activity.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        int i = 0;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.Write(_characters[i]);
            System.Threading.Thread.Sleep(100);
            Console.Write("\b \b");

            i++;
            if (i == _characters.Length)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        int i = seconds;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.Write(i);
            System.Threading.Thread.Sleep(1000);

            // Determine the number of backspaces based on the number of digits in i
            int backspaces = i >= 10 ? 2 : 1;

            // Apply the backspaces
            for (int j = 0; j < backspaces; j++)
            {
                Console.Write("\b \b");
            }

            i--;
        }
    }


}
