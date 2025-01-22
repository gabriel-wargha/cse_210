
public class Job {
    public string company = "";
    public string job_title = "";
    public int start_year = 0;

    public int end_year = 0;

    public void displayJobDetails (){
        Console.WriteLine($"{job_title} ({company}) {start_year}-{end_year}");
    }
}
