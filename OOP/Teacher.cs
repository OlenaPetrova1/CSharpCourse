using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Teacher : Person
    {
        public List<Student> Students = new List<Student>();
        public Teacher(string first_name, string last_name, string city, DateTime dob) : base(first_name, last_name, city, dob)
        {
        }

        public Teacher(string first_name, string last_name) : base(first_name, last_name)
        {
        }

        public Teacher() : base()
        {
        }

        public override void DescribeYourself()
        {
            Console.WriteLine($"First_Name = {First_Name}, Last_Name = {Last_Name},City = {City}, Age = {Age}, Number of students = {Students.Count}");
            if (Courses.Count != 0)
            {
                Console.WriteLine($"Courses for {First_Name} {Last_Name} :");
                foreach (var course in Courses)
                    Console.WriteLine(course.Course_name);
            }
            else Console.WriteLine("There is no courses for this teacher");
            if (Students.Count != 0)
            {
                Console.WriteLine($"List of students for {First_Name} {Last_Name} :");
                foreach (var student in Students)
                     Console.WriteLine(student.First_Name);
            }
            Console.WriteLine(new String('_', 50));
        }

        public override void AddCourse(Course course)
        {
            this.Courses.Add(course);
            course.Teacher = this;
        }

        public override void DeleteCourse(Course course)
        {
            this.Courses.Remove(course);
            course.Teacher = new Teacher();
        }

        public void AddStudent(Student student)
        {
            this.Students.Add(student);
        }
         
        public void RemoveStudentByName(string name)
        {
            foreach (var st in Students)
                if (st.First_Name == name)
                {
                    Students.Remove(st);
                    break;
                }
        }


    }

}
