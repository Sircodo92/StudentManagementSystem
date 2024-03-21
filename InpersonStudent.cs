using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    // Derived class for in-person students, inherits from the base class Student
    public class InpersonStudent : Student
    {
        // Constructor to initialize in-person student with ID, name, and type
        public InpersonStudent(string id, string name, string type) : base(id, name, type)
        {
        }
    }
}
