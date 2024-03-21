using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    // Base class for all types of students
    public abstract class Student
    {
        // Fields to store student information
        private string id; // Student ID
        private string name; // Student name
        private string type; // Type of student
        private List<string> enrolledCourses; // List to store enrolled courses

        // Constructor to initialize student object with ID, name, and type
        public Student(string id, string name, string type)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.enrolledCourses = new List<string>(); // Initialize the list of enrolled courses
        }

        // Method to enroll a course for the student
        public void EnrollCourse(string course)
        {
            enrolledCourses.Add(course); // Add the course to the list of enrolled courses
        }

        // Method to display student information
        public void DisplayInfo()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Type: " + type);
            Console.WriteLine("Enrolled Courses: " + string.Join(", ", enrolledCourses));
            Console.WriteLine();
        }
    }
}
