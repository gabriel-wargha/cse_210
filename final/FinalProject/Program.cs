using System;
using System.Collections.Generic;
using System.Reflection;

public class Program {

    public static void MainMenu(){

        while(true) {
            Console.WriteLine("Welcome to BYUI portal");
            Console.WriteLine("1 Log in as  professor");
            Console.WriteLine("2 Log in as Student");
            Console.WriteLine("3 New Professor");
            Console.WriteLine("4 New student");
            Console.WriteLine("5 Exit")
            Console.WriteLine("Choose an option");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "1":
                    loginAsProfessor();
                    break;

                case "2":
                    loginAsStudent();
                    break;

                case "3":
                    CreateNewProfessor();
                    break;
                
                case "4":
                    CreateNewStudent();
                    break;
                
                
                
                case "5":
                    Console.WriteLine("Goodbye!");
                    break;
                
                default:
                    Console.WriteLine("Invalid option, please try again");
                    break;
                
            }
    }
    }

    public static void 

    public static void Main() {
        // Create a professor
       

    }
}
