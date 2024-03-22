namespace StudentManagementSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create instances of different types of students using Factory Method
            Student inPersonStudent = StudentFactory.CreateStudent("1", "John", "InpersonStudent");
            Student onlineStudent = StudentFactory.CreateStudent("2", "Alice", "OnlineStudent");
            Student hybridStudent = StudentFactory.CreateStudent("3", "Bob", "HybridStudent");


            // Enroll students in courses
            inPersonStudent.EnrollCourse("Mathematics");
            inPersonStudent.EnrollCourse("Physics");
            inPersonStudent.EnrollCourse("Biology");

            onlineStudent.EnrollCourse("Chemistry");
            onlineStudent.EnrollCourse("Computer Science");
            onlineStudent.EnrollCourse("English");

            hybridStudent.EnrollCourse("History");
            hybridStudent.EnrollCourse("Geography");
            hybridStudent.EnrollCourse("Economics");

            // Add students to the IStudentManager
            IStudentManager studentManager = IStudentManager.GetInstance(); // Singleton
            studentManager.AddStudent(inPersonStudent);
            studentManager.AddStudent(onlineStudent);
            studentManager.AddStudent(hybridStudent);

            // Display information of all students
            studentManager.DisplayAllStudents();

        }
    }
}
