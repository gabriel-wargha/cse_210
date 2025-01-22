public class Resume 
{
    public string name = "";
    public List<Job> jobs = new List<Job>();

    public void display_jobs()
    {
        Console.WriteLine(name);
        Console.WriteLine("Jobs: ");
        foreach (Job j in jobs)
        {   
        j.displayJobDetails();
        }
    }
}