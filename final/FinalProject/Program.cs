using System;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection;

public class Program {

    static List<Course> availableCourses = new List<Course>(); 
    static List<Professor> professors = new List<Professor>();
    static List<Student> students = new List<Student>();



    public static void MainMenu(){

        while(true) {
            Console.WriteLine("Welcome to BYUI portal");
            Console.WriteLine("1 Log in as  professor");
            Console.WriteLine("2 Log in as Student");
            Console.WriteLine("3 New Professor");
            Console.WriteLine("4 New student");
            Console.WriteLine("5 Exit");
            Console.WriteLine("Choose an option");
            string answer = Console.ReadLine();
            Console.Clear();

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
                    return;
                
                default:
                    Console.WriteLine("Invalid option, please try again");
                    break;
                
            }
    }
    }

    public static void CreateNewStudent(){
        Console.WriteLine("Welcome to BYUI! Please provide the information for each question so we can finish your enrollment");

        Console.WriteLine("Type your Name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Type your Email: ");
        string email = Console.ReadLine();
        
        Random r = new Random();
        string iNumber = r.Next(10000, 99999).ToString();

        Console.WriteLine("Create your password");
        string password = Console.ReadLine();

        Student student = new Student(iNumber, password, new List<Course>(), name, email);

        students.Add(student);
        Console.WriteLine($"New Student created successfully!Your I Number is {iNumber}\nPress any key to return to the menu...");
        Console.ReadKey();
        Console.Clear();
    }

    public static void CreateNewProfessor(){
        Console.WriteLine("Welcome to BYUI! Please provide the information for each question so we can finish your enrollment as a professor");

        Console.WriteLine("Type your Name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Type your Email: ");
        string email = Console.ReadLine();

        Console.WriteLine("Create your password");
        string password = Console.ReadLine();
        
        Random r = new Random();
        string idProfessor = r.Next(100, 999).ToString();

        Professor professor = new Professor(idProfessor, password, new List<Course>(), name, email);

        professors.Add(professor);

        Console.WriteLine($"New Professor created successfully! Your id is {idProfessor}\nPress any key to return to the menu...");
        Console.ReadKey();
        Console.Clear();
    }

    public static void loginAsProfessor(){
        int attempts = 0;

        while(attempts < 3){
        Console.WriteLine("What is your 3 digit professor ID");
        String id = Console.ReadLine().Trim();

        Console.WriteLine("What is your password");
        string password = Console.ReadLine().Trim();

        //Search by ID
        Professor professor = professors.FirstOrDefault(p => p.GetProfessorID() == id);

        if(professor != null && professor.GetPassword() == password){
            Console.WriteLine($"Welcome Professor {professor.GetName()}");
           ProfessorMenu.ShowProfessorMenu(professor, availableCourses);
            return;
        }
        else {
            Console.WriteLine("Invalid ID or password. Please try again");
            attempts++;
        }
        Console.WriteLine("Too many failed attempts. Exiting...");
        }
        Console.Clear();
    }

    public static void loginAsStudent(){
        int attempts = 0;

        while(attempts < 3){
        Console.WriteLine("What is your 5 digit student ID");
        String id = Console.ReadLine().Trim();

        Console.WriteLine("What is your password");
        string password = Console.ReadLine().Trim();

        //Search by ID
        Student student = students.FirstOrDefault(s => s.GetINumber() == id);
        Console.WriteLine(id);
        Console.WriteLine(student.GetPassword());

        if(student != null && student.GetPassword() == password){
            Console.WriteLine($"Welcome student {student.GetName()}");
           StudentMenu.ShowStudentMenu(student, availableCourses);
            return;
        }
        else {
            Console.WriteLine("Invalid ID or password. Please try again");
            attempts++;
        }
        Console.WriteLine("Too many failed attempts. Exiting...");
        }
        Console.Clear();

    }

    public static void Main(string[] args) {
        MainMenu();
    }



    }

