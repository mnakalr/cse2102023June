using System;

//Class for storing and displaying a job
public class Job
{
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    //Method for displaying the job 
    public void display()
    {
        Console.WriteLine($"Job info:\n{_jobTitle} ({_company}) {_startYear}-{_endYear}.\n");
    }
}