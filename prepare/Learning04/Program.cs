using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("John", "C#");
        Console.WriteLine(assignment.getSummary());
    }
}