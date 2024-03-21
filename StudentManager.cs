using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    // Singleton class to manage students
    public class StudentManager
    {
        // Static instance of the StudentManager class
        private static StudentManager instance;
        // List to store students
        private List<Student> students;

        // Private constructor to prevent instantiation from outside the class
        private StudentManager()
        {
            // Initialize the list of students
            students = new List<Student>();
        }

        // Method to get the instance of the StudentManager class
        public static StudentManager GetInstance()
        {
            // If the instance is null, create a new instance
            if (instance == null)
            {
                instance = new StudentManager();
            }
            // Return the instance
            return instance;
        }

        // Method to add a student to the list of students
        public void AddStudent(Student student)
        {
            students.Add(student); // Add the student to the list
        }

        // Method to display information of all students
        public void DisplayAllStudents()
        {
            // Iterate through each student in the list
            foreach (Student student in students)
            {
                // Display information of the student
                student.DisplayInfo();
            }
        }
    }
}
