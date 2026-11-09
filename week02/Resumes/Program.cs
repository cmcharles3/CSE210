using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is my Resumes Project.");

        // Create first job.
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Cedar3 Technology";
        job1._startYear = 2020;
        job1._endYear = 2022;

        // CReate a second job
        Job job2 = new Job();
        job2._jobTitle = "Sales Associate";
        job2._company = "Spar";
        job2._startYear = 2018;
        job2._endYear = 2020;

        // Create resume and add jobs
        Resume myResume = new Resume();
        myResume._name = "Charles Chiparo";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Display the resume
        myResume.Display();
    }
}