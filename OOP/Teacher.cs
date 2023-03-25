using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Teacher : Person
    {
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
            Console.WriteLine($"First_Name = {First_Name}, Last_Name = {Last_Name},City = {City}, Age = {Age}");
            var n = Array.IndexOf(Courses, null);
            if (n != 0)
            {
                Console.WriteLine("Courses :");
                for (int i = 0; i < n; i++)
                    Courses[i].Print();
            }
            else Console.WriteLine("There is no courses for this Teacher");
            Console.WriteLine(new String('_', 50));
        }

        public override void AddCourse(Course course)
        {
            var i = Array.IndexOf(Courses, null);
            Courses[i] = course;
            course.Teacher = this;
        }

        public override void DeleteCourse(Course course)
        {
            var i = Array.IndexOf(Courses, null) - 1;
            Courses[i] = null;
            course.Teacher = new Teacher();
        }

    }

}
