using System;
using System.Collections.Generic;

public class Program {
    public static void Main() {
        // Create a professor
        Professor prof = new Professor("P123", new List<Course>(), "Dr. Smith", "smith@email.com");

        // Professor creates a course
        prof.CreateCourse("Math 101", "MTH101");

        // Create a student
        Student student = new Student("S001", new List<Course>(), "Alice", "alice@email.com");

        // Enroll student in the course
        Course mathCourse = prof.GetCourses()[0]; // Get the first course created
        mathCourse.AddStudent(student);

        // Display course details
        Console.WriteLine("\nBefore Removing Course:");
        mathCourse.DisplayCourseInfo();

        // Professor removes the course
        prof.RemoveCourse("MTH101");

        // Check if student was removed
        Console.WriteLine("\nAfter Removing Course:");
        Console.WriteLine("Professor Courses Count: " + prof.GetCourses().Count);
    }
}
