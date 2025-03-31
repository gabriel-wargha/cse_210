using System.Data;
using System.Security.Cryptography.X509Certificates;

public class Student : User {
    private string _studentID;

    private string _password;
    private List<Course> _enrolledCourses;

    public static List<Student> _allStudents = new List<Student>();

    private Dictionary<Course, string> _grades;


    public Student(string id, string password,  List<Course> c, string n, string e) : base(n, e){
        _password = password;
        _studentID = id;
        _enrolledCourses = c ?? new List<Course>(); // if c is null, create a new list
        _grades = new Dictionary<Course, string>();
        _allStudents.Add(this); 
    }

    public string GetGrade(Course course){
        if(_grades.ContainsKey(course)){
        return _grades[course];     
        } 
        return "No grades assigned";
    }

     public string SetGrade(Course course, string grade){
        if(_grades.ContainsKey(course)){
        _grades[course] = grade;
        } 
        return "No grades assigned";
    }



    public void EnrollInCourse(List<Course> availableCourses){
        if(availableCourses.Count == 0){
            Console.WriteLine("Not available Courses to enroll in");
            return;
        }

        Console.WriteLine("Available Courses: ");
        for(int i = 0; i<availableCourses.Count;i++){
            Console.WriteLine($"{i + 1}");
            availableCourses[i].DisplayInfo(availableCourses[i]);
            Console.WriteLine("");
        }

        Console.WriteLine("Choose the Course that you want to enroll in: ");
        string input = Console.ReadLine();
        
       if(int.TryParse(input, out int courseIndex) && courseIndex > 0 && courseIndex <= availableCourses.Count){
        Course selectedCourse = availableCourses[courseIndex - 1];

        if(_enrolledCourses.Contains(selectedCourse)){
            Console.WriteLine("You are already enrolled in this course");
        } else {
            selectedCourse.AddStudent(this);
            Console.WriteLine($"You are successfully enrolled in {selectedCourse.GetCourseName()}");
        }
       }

       else {
        Console.WriteLine("Invalid option please try again");
       }

    }



    public void DropCourse(Course c){
        if(!_enrolledCourses.Contains(c)){
            Console.WriteLine("You are not enrolled in this course!");
        }
        else{
            _enrolledCourses.Remove(c);
            c.RemoveStudent(this);
        }
    }

    public List<Course> GetCourses(){

        return _enrolledCourses;

    }

    public string GetPassword() {
    return _password;
}

    public string GetINumber() {
    return _studentID;
}

public void ViewCourses() {
    if(_enrolledCourses.Count == 0){
        Console.WriteLine("You are not enrolled in any Course");
    }
    else{
        Console.WriteLine("Enrolled Courses");

        foreach(Course course in _enrolledCourses)
        {
            course.DisplayInfo(course);
        }
    }

}

public static Student FindStudentByID(string id){
    return _allStudents.FirstOrDefault(student => student.GetINumber() == id);
}

 public void SeeGrades(){
    Console.WriteLine("Your grades");
    
    if(_grades.Count == 0){
        Console.WriteLine("You do not have any grade to see");
    } 
    else{
        foreach(var entry in _grades){
            Console.WriteLine($"{entry.Key.GetCourseName()}: {entry.Value} ");
        }
    }

     
}

public void ForceAddCourse(Course c){
    if(!_enrolledCourses.Contains(c)){
        _enrolledCourses.Add(c);
    }
}

public void InitializeGrade(Course course){
    if(!_grades.ContainsKey(course)){
        _grades.Add(course, "Not graded yet");
    }
}

}
