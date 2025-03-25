public class OnlineCourse : Course {

    private string _platform;
    private string _meetingLink;
    public OnlineCourse(string name, string code, Professor p, string platform, string meetingLink) : base(name, code, p){
        _platform = platform;
        _meetingLink = meetingLink;
    }

    public override void DisplayInfo(Course c){
        Console.WriteLine($"Welcome to the course {c.GetCourseName()}");
        Console.WriteLine($"You can watch the class using {_platform} and the link is:  {_meetingLink}");
    }
}