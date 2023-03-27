using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ADD AND DELETE STUDENTS TO TEACHER
            Teacher teacher1 = new Teacher("Teacher1","");

            var students = new List<Student>()
            {
                new Student("Student1", ""),
                new Student("Student2", ""),
                new Student("Student3", ""),
                new Student("Student4", ""),
                new Student("Student5", "")
            };

            teacher1.Students.AddRange(students);
            teacher1.DescribeYourself();
            Student student6 = new Student("Student6","");
            teacher1.AddStudent(student6);
            teacher1.RemoveStudentByName("Student4");
            teacher1.DescribeYourself();

            //////////////////////////////////////////
            //ADD STUDENTS TO COURSE
            Course course1 = new Course("C# course");
            course1.AddStudentToGroup(student6);
            course1.Students.AddRange(students);
            course1.Print();
            course1.DeleteStudentFromGroup(student6);
            course1.Print();

            ///////////////////////////////////////
            //ADD COURSES TO STUDENT
            var courses = new List<Course>()
            {
                new Course("Course2"),
                new Course("Course3"),
                new Course("Course4")
            };
            Course course5 = new Course("Course5"); 
            student6.Courses.AddRange(courses);
            student6.AddCourse(course5);
            student6.DescribeYourself();
            student6.DeleteCourse(course5);
            student6.DescribeYourself();

            ///////////////////////////////////////////
            //ADD COURSES TO TEACHER
            teacher1.AddCourse(course5);
            teacher1.Courses.AddRange(courses);
            teacher1.DescribeYourself();
        }
    }


}
