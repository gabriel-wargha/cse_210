using System.Timers;

public class Activity
{
    private string _title;
    private string _desc;

    private int _duration;

    //Methods 

    public Activity (string title, string desc)
    {
    _title = title;
    _desc = desc;
    }   

    public int GetDuration(){
    return _duration;
    }

    public void InteractPrologue(){

        Console.WriteLine($"Welcome to {_title} Activity");
        Console.WriteLine($"{_desc}");
        Console.WriteLine("How long in seconds do you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Timer.setTime(_duration);
        Console.WriteLine("Get ready ....");
    }

    public void InteractEpilogue(){
        Console.WriteLine($"Thank you for participating in {_title} Activity. Your session lasted for {_duration} seconds");
        //Timer
    }

}
