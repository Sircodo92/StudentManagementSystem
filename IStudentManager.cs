<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    // Singleton class to manage students
    public class IStudentManager
    {
        // Static instance of the IStudentManager class
        private static IStudentManager instance;
        // List to store students
        private List<Student> students;

        // Private constructor to prevent instantiation from outside the class
        private IStudentManager()
        {
            // Initialize the list of students
            students = new List<Student>();
        }

        // Method to get the instance of the IStudentManager class
        public static IStudentManager GetInstance()
        {
            // If the instance is null, create a new instance
            if (instance == null)
            {
                instance = new IStudentManager();
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
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    // Singleton class to manage students
    public class IStudentManager
    {
        // Static instance of the IStudentManager class
        private static IStudentManager instance;
        // List to store students
        private List<Student> students;

        // Private constructor to prevent instantiation from outside the class
        private IStudentManager()
        {
            // Initialize the list of students
            students = new List<Student>();
        }

        // Method to get the instance of the IStudentManager class
        public static IStudentManager GetInstance()
        {
            // If the instance is null, create a new instance
            if (instance == null)
            {
                instance = new IStudentManager();
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
>>>>>>> 5626b2be13e344bc85ed2c33eeb19ca1f823b716
