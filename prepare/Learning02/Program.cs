using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1.company = "Apple";
        job1.job_title = "Software engineering";
        job1.start_year = 2021;
        job1.end_year = 2024;

        Job job2 = new Job();
        job2.company = "Microssoft";
        job2.job_title = "Software engineering";
        job2.start_year = 2017;
        job2.end_year = 2020;

        Resume resume1 = new Resume();
        resume1.jobs.Add(job1);
        resume1.name = "Gabriel Wargha";
        resume1.jobs.Add(job2);
        resume1.display_jobs();
    }


}