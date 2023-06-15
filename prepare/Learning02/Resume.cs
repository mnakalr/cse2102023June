using System;

//this class creates a resume from the job class
public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    //Displays the various jobs
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: ");

        foreach (Job job in _jobs)
        {
            job.display();
        }

    }
}