using System;
using System.Xml.XPath;

class Program
{
    static void display_message(){
        Console.WriteLine("Welcome to the program!");
    }
    static string get_name(){
        string name = "";
        Console.Write("What is your name");
        name = Console.ReadLine();
        return name;
    }
    static int get_number(){
        int number = 0;
        Console.Write("What is your favorite number: ");
        number = int.Parse(Console.ReadLine());
        return number;
    }

    static int square_number(int n)
    {
        int square = n*n;
        return square;
    }

    static void display_result(string name, int number){
        Console.Write($"{name}, the square of your favorite number is {number}");
    }

    static void Main(string[] args)
    {
        string name = "";
        int number = 0;
        int square = 1;
        display_message();
        name = get_name();
        number = get_number();
        square = square_number(number);
        display_result(name, square);


    }
}