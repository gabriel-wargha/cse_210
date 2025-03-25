public class Course {
    private string _courseName;
    private string _courseCode;

    private Professor _professor;
    private List<Student> _studentsEnrolled;

    private List<Assignment> _assignments;

    public Course(string name, string code, Professor p){
        _courseName = name;
        _courseCode = code;
        _professor = p;
        _studentsEnrolled = new List<Student>();
        _assignments = new List<Assignment>();
    }

    public void AddAssignment(Assignment a){
        _assignments.Add(a);
        Console.WriteLine($"Assignment {a.GetTitle()} added to {_courseName}");
    }

    public List<Assignment> GetAssignments(){
        return _assignments;
    }

    public void AddStudent(Student s){

        if (!_studentsEnrolled.Contains(s)){
            _studentsEnrolled.Add(s);
            s.EnrollInCourse(this);
        }
        else {
            Console.WriteLine("Student is already enrolled in this course!");
        }
    }

    public void RemoveStudent(Student s){
        if (!_studentsEnrolled.Contains(s)){
            Console.WriteLine("Student is not enrolled in this course!");
        }
        else {
            _studentsEnrolled.Remove(s);
        }
    }

    public void DisplayCourseInfo(){
        Console.WriteLine("Course Name: " + _courseName);
        Console.WriteLine("Course Code: " + _courseCode);
        Console.WriteLine("Professor: " + _professor.GetName());
        Console.WriteLine("Students Enrolled: ");
        foreach(Student s in _studentsEnrolled){
            Console.WriteLine(s.GetName());
        }
    }

    public List<Student> GetStudents(){
        return new List<Student>(_studentsEnrolled);
    }

    public string GetCourseCode(){
        return _courseCode;
    }

    public String GetCourseName(){
        return _courseName;
    }

    public virtual void DisplayInfo(Course c){
        
    }


}
