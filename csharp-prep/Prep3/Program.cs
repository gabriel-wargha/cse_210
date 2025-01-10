using System;
class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int randomInt = random.Next(1, 101);
        int magic_number = randomInt;
        Console.Write("What is the magic number: ");
        int answer = int.Parse(Console.ReadLine());

        while (magic_number != answer)
        {
            if (magic_number < answer)
            {
                Console.Write("Try a lower number: ");
                answer = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.Write("Try a higher number: ");
                answer = int.Parse(Console.ReadLine());
            }
        }
        Console.Write("Congratulations, you guessed!! ");


    }
}