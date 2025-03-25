public class Professor : User {
    private string _professorID;
    private List<Course> _coursesTaught;

    public Professor(string id, List<Course> c, string n, string e): base(n, e){
        _professorID = id;
        _coursesTaught = c ?? new List<Course>();
    }

    public void CreateCourse(string courseName, string courseID){
    Course newCourse = new Course(courseName, courseID, this);

    if(!_coursesTaught.Contains(newCourse)){
        _coursesTaught.Add(newCourse);
    }
    else
    {
        Console.WriteLine("This course already exists");
    }
    }
    public void RemoveCourse(Course c){
        if(_coursesTaught.Contains(c)){
            foreach (Student s in c.GetStudents())
            {
                s.DropCourse(c);
            }
            _coursesTaught.Remove(c);
        }
        else {
            Console.WriteLine("You are not teaching this Course");
        }

    }

    public void RemoveCourse(string courseID){
        Course courseToRemove = _coursesTaught.Find(c => c.GetCourseCode() == courseID);

        if(courseToRemove != null){
            RemoveCourse(courseToRemove);
        }
        else{
            Console.WriteLine("Course ID not found");
        }

    }


    public List<Course> GetCourses(){
        return _coursesTaught;
    }

    public void AssignAssignment(Course c, Assignment a){
        if(_coursesTaught.Contains(c)){
            c.AddAssignment(a);}
        else{
            Console.WriteLine("You are not teaching this Course");
        }
    }

}
