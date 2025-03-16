using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int totalScore = 0;

    static void RecordGoalEvent(Goal goal)
    {
        goal.RecordEvent();
        totalScore += goal.CalculatePoints();  // Add points
        Console.WriteLine($"🏆 Total Score: {totalScore}\n");
    }

    static void SaveGoals(List<Goal> goals)
    {
        using (StreamWriter file = new StreamWriter("goals.txt", true))
        {
            foreach (Goal goal in goals)
            {
                file.WriteLine(goal.Save());
            }
        }
        Console.WriteLine("✅ Goals saved to file.");
    }

    static void LoadGoals()
    {
        string[] lines = File.ReadAllLines("goals.txt");

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            if (!goals.Any(g => g.GetTitle() == parts[2]))  // Check by title to avoid duplicates
            {
                Goal goal;
                switch (parts[0])
                {
                    case "Simple":
                        goal = new Simple(int.Parse(parts[1]), parts[2], parts[3]);
                        break;
                    case "Eternal":
                        goal = new Eternal(int.Parse(parts[1]), parts[2], parts[3]);
                        break;
                    case "Checklist":
                        goal = new CheckList(int.Parse(parts[1]), parts[2], parts[3], int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));
                        break;
                    default:
                        continue;
                }
                goal.Load(line);
                goals.Add(goal);
            }
        }
        Console.WriteLine("Goals loaded successfully.");
    }

    static void RecordEvent(List<Goal> goals)
    {
        Console.WriteLine("\n--- Select a goal to record event ---");

        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].getType()} - {goals[i].GetTitle()}");
        }

        Console.Write("Choose the goal number to record the event: ");
        int choice = int.Parse(Console.ReadLine());

        if (choice < 1 || choice > goals.Count)
        {
            Console.WriteLine("Invalid choice, please try again.");
            return;
        }

        Goal selectedGoal = goals[choice - 1];

        selectedGoal.RecordEvent();
        totalScore += selectedGoal.CalculatePoints();
        Console.WriteLine($"🏆 Total Score: {totalScore}\n");
    }

    static void CreatNewGoal()
    {
        Console.WriteLine("📝 Enter the title of the goal:");
        string title = Console.ReadLine();
        Console.WriteLine("📝 Enter the description of the goal:");
        string description = Console.ReadLine();
        Console.WriteLine("📝 Enter the points for the goal:");
        int points = int.Parse(Console.ReadLine());
        Console.WriteLine("📝 Choose the type of goal:");
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Eternal");
        Console.WriteLine("3. Checklist");
        string type = Console.ReadLine();
        Goal goal;
        switch (type)
        {
            case "1":
                goal = new Simple(points, title, description);
                break;

            case "2":
                goal = new Eternal(points, title, description);
                break;

            case "3":
                Console.WriteLine("📝 Enter the current count:");
                int currentCount = int.Parse(Console.ReadLine());
                Console.WriteLine("📝 Enter the target count:");
                int targetCount = int.Parse(Console.ReadLine());
                Console.WriteLine("📝 Enter the bonus points:");
                int bonus = int.Parse(Console.ReadLine());
                goal = new CheckList(points, title, description, currentCount, targetCount, bonus);
                break;

            default:
                Console.WriteLine("Invalid option. Try again.");
                return;
        }
        goals.Add(goal);
        Console.WriteLine("✅ Goal created successfully.");
    }

    static void ListGoals(List<Goal> goals)
    {
        Console.WriteLine("\n--- Your Goals ---");
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals to display.");
        }
        else
        {
            foreach (Goal goal in goals)
            {
                goal.Display();
            }
        }
    }

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("📝 Choose an option:");
            Console.WriteLine("1. Add a goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goals to file");
            Console.WriteLine("4. Load goals from file");
            Console.WriteLine("5. Record an event");
            Console.WriteLine("6. Motiviational Quote");
            Console.WriteLine("7. Exit");

            string option = Console.ReadLine();
            Console.Clear();

            switch (option)
            {
                case "1":
                    CreatNewGoal();
                    break;

                case "2":
                    ListGoals(goals);
                    break;

                case "3":
                    SaveGoals(goals);
                    break;

                case "4":
                    LoadGoals();
                    break;

                case "5":
                    RecordEvent(goals);
                    break;

                case "6":
                    Console.WriteLine("🌟 'The only way to achieve the impossible is to believe it is possible.' - Charles Kingsleigh");
                    break;

                case "7":
                    Console.WriteLine("Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }
}