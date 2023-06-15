using System;


class Program
{   
    //main function for instantiating and running the job and resume classes
    static void Main(string[] args)
    {
        
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";
        job1._startYear = 2020;
        job1._endYear = 2023; 

        Job job2 = new Job();
        job2._jobTitle = "Car washer";
        job2._company = "Microsoft";
        job2._startYear = 2018;
        job2._endYear = 2022; 

        Resume myResume = new Resume();
        myResume._name = "Mwatile";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}