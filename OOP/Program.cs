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
            Teacher teacher2 = new Teacher("Teacher2", "");

            var students = new List<Student>()
            {
                new Student("Student1", ""),
                new Student("Student2", ""),
                new Student("Student3", ""),
                new Student("Student4", ""),
                new Student("student5", ""),
                new Student("student35", ""),
            };

            teacher1.Students.AddRange(students);
            teacher2.AddStudentsByFilter(students);    //exception if there is no such student
            teacher1.RemoveStudentByName("Student3");  //exception if there is no such student

            var teachers = new List<Teacher>();
            teachers.Add(teacher1);
            teachers.Add(teacher2);
            /////////////////////////////////////////////
            ////ADD COURSES TO TEACHER
            var courses = new List<Course>()
            {
                new Course("Course1"),
                new Course("Course2"),
                new Course("Course3"),
                new Course("Course4"),
                new Course("Math course"),
                new Course("C# course")
        };

            teacher1.AddCoursesByFilter(courses, "Course");
            teacher2.AddCoursesByFilter(courses, "course");

            //////////////////////////////////////////
            //ADD STUDENTS TO COURSE
            var course1 = courses.Find(x => x.Course_name.Equals("Course1"));
            course1.AddStudentsToGroupByFilter(students, "Student");
            var course2 = courses.Find(x => x.Course_name.Equals("Math course"));
            course2.AddStudentsToGroupByFilter(students, "student");
            var course3 = courses.Find(x => x.Course_name.Equals("Course3"));
            course3.AddStudentsToGroupByFilter(students, "dent");

            /////////////////////////////////////////
            Console.WriteLine("==============================================");
            Console.WriteLine("STUDENTS INFORMATION");
            Console.WriteLine("==============================================");
            foreach (var student in students)
            {
                student.DescribeYourself();
            }
            /////////////////////////////////////////
            Console.WriteLine("==============================================");
            Console.WriteLine("TEACHER INFORMATION");
            Console.WriteLine("==============================================");
            foreach (var teacher in teachers)
            {
                teacher.DescribeYourself();
            }
            /////////////////////////////////////////
            Console.WriteLine("==============================================");
            Console.WriteLine("COURSES INFORMATION");
            Console.WriteLine("==============================================");
            foreach (var course in courses)
            {
                course.Print();
            }

        }
    }

    class StudentNameException : ArgumentException
    {
        public StudentNameException (string message) : base (message)
        {
        }
        
    }


}
