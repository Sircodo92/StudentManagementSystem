using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    // Factory class to create different types of students
    public class StudentFactory
    {
        // Method to create a student based on the type provided
        public static Student CreateStudent(string id, string name, string type)
        {
            // Switch statement to determine the type of student to create
            switch (type)
            {
                // If the type is "InpersonStudent", create and return an instance of InpersonStudent
                case "InpersonStudent":
                    return new InpersonStudent(id, name, type);
                // If the type is "OnlineStudent", create and return an instance of OnlineStudent
                case "OnlineStudent":
                    return new OnlineStudent(id, name, type);
                // If the type is "HybridStudent", create and return an instance of HybridStudent
                case "HybridStudent":
                    return new HybridStudent(id, name, type);
                // If the type does not match any known types, return null
                default:
                    return null;
            }
        }
    }
}
