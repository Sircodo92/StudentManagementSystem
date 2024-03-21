using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    // Derived class for hybrid students, inherits from the base class Student
    public class HybridStudent : Student
    {
        // Constructor to initialize hybrid student with ID, name, and type
        public HybridStudent(string id, string name, string type) : base(id, name, type)
        {
        }
    }
}
