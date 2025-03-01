using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Activity App");
        Console.WriteLine("Choose an activity: ");
        Console.WriteLine("1. Lister Activity");
        Console.WriteLine("2. Breathing Activity");
        Console.WriteLine("3. Reflective Activity");
        Console.WriteLine("4. Exit");
        string answer = Console.ReadLine();
        switch (answer)
        {
            case "1":
                ListerActivity listerActivity = new ListerActivity();
                Timer.pauseWithAnimation(3);
                listerActivity.InteractLister();
                break;
            case "2":
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.InteractBreathing();
                Timer.pauseWithAnimation(3);
                break;
            case "3":
                ReflectionActivity reflectiveActivity = new ReflectionActivity();
                reflectiveActivity.interactReflection();
                Timer.pauseWithAnimation(3);
                break;
            case "4":
                Console.WriteLine("Goodbye!");
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
    }
}
}