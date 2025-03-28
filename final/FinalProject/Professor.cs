public class Professor : User {
    private string _professorID;

    private string _password;
    private List<Course> _coursesTaught;



    public Professor(string id, string password, List<Course> c, string n, string e): base(n, e){
        _password = password;
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

            List<Student> studentsToRemove = new List<Student>(c.GetStudents());

            foreach (Student s in studentsToRemove)
            {
                s.DropCourse(c);
            }
            _coursesTaught.Remove(c);
            Console.WriteLine($"Course {c.GetCourseCode} removed successfully!");
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

    public string GetPassword() {
    return _password;
}
    public string GetProfessorID() {
    return _professorID;
}

public void ViewCursesTaught(){
    foreach(Course course in _coursesTaught)
    {
        Console.WriteLine($"{course.GetCourseName()}");
    }
}
public void AddStudentToClass(){

    Console.WriteLine("Choose the class that you want to add a student");

    for(int i = 0; i<_coursesTaught.Count;i++)
    {
        Console.WriteLine($"{i+1} {_coursesTaught[i]}");
    }
    string input = Console.ReadLine();

    if(int.TryParse(input, out int CourseIndex) && CourseIndex > 0 && CourseIndex <= _coursesTaught.Count)
    {
        Course selectedCourse = _coursesTaught[CourseIndex - 1];

        Console.WriteLine("What is the code of the student that you want to add to your class");
        String studentID = Console.ReadLine();
        Student student = Student.FindStudentByID(studentID); 


        if(student != null){
        selectedCourse.AddStudent(student);
        Console.WriteLine($"Student {student.GetName()} was added to the class {selectedCourse.GetCourseName()}");
        }
        else {
            Console.WriteLine("Student not found");
        }
    } else {
        Console.WriteLine("Course not found");
    }

}

public void ViewStudentsInCourse(){
     Console.WriteLine("Choose the class that you want to see the list of students");

    for(int i = 0; i<_coursesTaught.Count;i++)
    {
        Console.WriteLine($"{i+1} {_coursesTaught[i]}");
    }
    string input = Console.ReadLine();

    if(int.TryParse(input, out int CourseIndex) && CourseIndex > 0 && CourseIndex <= _coursesTaught.Count)
    {
        Course selectedCourse = _coursesTaught[CourseIndex - 1];

        foreach(Student student in selectedCourse.GetStudents())
        {
            Console.WriteLine($"{student.GetName()}");
        }
    }
    else
    {
        Console.WriteLine("Invalid Course");
    }
}

public void GradeStudent(){
     Console.WriteLine("Choose the class that you want to garde a student");

    for(int i = 0; i<_coursesTaught.Count;i++)
    {
        Console.WriteLine($"{i+1} {_coursesTaught[i]}");
    }
    string input = Console.ReadLine();

    if(int.TryParse(input, out int CourseIndex) && CourseIndex > 0 && CourseIndex <= _coursesTaught.Count)
    {
        Course selectedCourse = _coursesTaught[CourseIndex - 1];
        List<Student> students = selectedCourse.GetStudents();

        for(int i = 0; i<students.Count;i++)
        {
            Console.WriteLine($"{i+1} {students[i].GetName()}");
        }
        Console.WriteLine("What student do you want to grade: Enter the number");
        string choice = Console.ReadLine();

        if(int.TryParse(choice, out int studentIndex) && studentIndex > 0 && studentIndex <= students.Count)
        {
            Student selectedStudent = students[studentIndex - 1];
       

        Console.WriteLine("What is the grade: ");
        string grade = Console.ReadLine();

        selectedStudent.SetGrade(selectedCourse, grade);
        Console.WriteLine($"Grade {grade} was assigned for course {selectedCourse.GetCourseName()} to {selectedStudent.GetName()}");
        }
        else {
            Console.WriteLine("Invalid Student");
        }

    }
    else
    {
        Console.WriteLine("Invalid Course");
    }
}

}

