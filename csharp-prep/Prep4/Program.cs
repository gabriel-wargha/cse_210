using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;
        int sum = 0;
        int average = 0;
        int qtd = 0;
        int new_number = 0;
        int higher = 0;



        Console.Write("Enter a list of numbers, type 0 when you finished: ");
        number = int.Parse(Console.ReadLine());

        while(number != 0)
        {   
            qtd += 1;
            sum += number;
            numbers.Add(number);
            Console.Write("Enter a number: ");
            new_number = int.Parse(Console.ReadLine());

            if(new_number>number)
            {
                higher = new_number;
            }
            number = new_number;
        }
            average = sum/qtd;

            Console.WriteLine($"The sum of number is {sum}");
            Console.WriteLine($"The average is {average}");
            Console.WriteLine($"The higher number is {higher}");


    }
}