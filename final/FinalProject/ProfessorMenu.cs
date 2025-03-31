public class ProfessorMenu {

      public static void ShowProfessorMenu(Professor professor, List<Course> availableCourses){

        do{
        Console.WriteLine("1. View Curses");
        Console.WriteLine("2. View List of students in the course");
        Console.WriteLine("3. Grade student");
        Console.WriteLine("4. Create Course");
        Console.WriteLine("5. Exit");
        Console.Clear();

        
        string Choice = Console.ReadLine();

        switch(Choice){
            case "1":
            professor.ViewCursesTaught();
            break;

            case "2":
            professor.ViewStudentsInCourse();
            break;

            case "3":
            professor.GradeStudent();
            
            break;
            case "4":
            professor.CreateCourse(availableCourses);
            break;

            case "5":
            Console.WriteLine("Goodbye!");
            break;
            
            default:
            Console.WriteLine("Invalid option, try again");
            break;
        }
        Console.Clear();

        }while(true);
        
    }

}