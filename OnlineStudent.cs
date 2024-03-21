using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    // Derived class for online students, inherits from the base class Student
    public class OnlineStudent : Student
    {
        // Constructor to initialize online student with ID, name, and type
        public OnlineStudent(string id, string name, string type) : base(id, name, type)
        {
        }
    }
}
