public class ProfessorMenu {

      public static void ShowProfessorMenu(Professor professor, List<Course> availableCourses){

        while(true){
        Console.WriteLine("1. View Curses");
        Console.WriteLine("2.Add a student to your class");
        Console.WriteLine("3. View List of students in the course");
        Console.WriteLine("4. Grade student");
        Console.WriteLine("5. Create Course");
        Console.WriteLine("6. Exit");

        
        string Choice = Console.ReadLine();

        switch(Choice){
            case "1":
            professor.ViewCursesTaught();
            break;

            case "2":
            professor.AddStudentToClass();
            break;

            case "3":
            professor.ViewStudentsInCourse();
            break;

            case "4":
            professor.GradeStudent();
            
            break;
            case "5":
            professor.CreateCourse();
            
            break;

            case "6":
            Console.WriteLine("Goodbye!");
            return;
            
            default:
            Console.WriteLine("Invalid option, try again");
            break;
        }
        }

    }

}