public class StudentMenu {

    
      public static void ShowStudentMenu(Student student, List<Course> availableCourses){
        while(true){
        Console.WriteLine("1. View Curses");
        Console.WriteLine("2. Enroll in a course");
        Console.WriteLine("3. See my grades");
        Console.WriteLine("4. Exit");

        
        string Choice = Console.ReadLine();

        switch(Choice){
            case "1":
            student.ViewCourses();
            break;
            case "2":
            student.EnrollInCourse(availableCourses);
            break;
            case "3":
            student.SeeGrades();

            break;
            case "4":
            Console.WriteLine("Goodbye!");
            return;
            
            default:
            Console.WriteLine("Invalid option, try again");
            break;
        }
        }

    }

}