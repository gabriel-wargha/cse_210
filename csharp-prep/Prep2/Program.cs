using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your score: ");
        float score = float.Parse(Console.ReadLine());
        string letter;

        if (score > 90 || score == 90)
        {
            letter = "A";
        }
        else if (score > 80 || score == 80)
        {
         letter = "B";
        }
         else if (score > 70 || score == 70)
        {
         letter = "C";
        }
         else if (score > 60 || score == 60)
        {
         letter = "D";
        }
        else 
        {
         letter = "F";
        }

        if (score > 70 || score == 70){
            Console.WriteLine("Congratulations, you passed!!!");
        }
        else {
            Console.WriteLine("You reproved, try next time");
        }
        Console.WriteLine($"Your score it was {score} and your grade {letter}");
    }
}