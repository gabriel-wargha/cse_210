public class Student : User {
    private string _studentID;
    private List<Course> _enrolledCourses;

    public Student(string id, List<Course> c, string n, string e) : base(n, e){
        _studentID = id;
        _enrolledCourses = c ?? new List<Course>(); // if c is null, create a new list
    }

    public void EnrollInCourse(Course c){
        if (!_enrolledCourses.Contains(c)){
            _enrolledCourses.Add(c);
        }
        else {
            Console.WriteLine("You are already enrolled in this course!");
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
}
