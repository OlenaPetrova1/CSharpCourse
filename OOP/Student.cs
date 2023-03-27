using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Student : Person
    {
        public Student(string first_name, string last_name, string city, DateTime dob) : base(first_name, last_name, city, dob)
        {
        }

        public Student(string first_name, string last_name) : base(first_name, last_name)
        {
        }

        public Student() : base()
        {
        }

        public override void DescribeYourself()
        {
            Console.WriteLine($"First_Name = {First_Name}, Last_Name = {Last_Name},City = {City}, Age = {Age}");
            if (Courses.Count != 0)
            {
                Console.WriteLine($"Courses for {First_Name} {Last_Name} :");
                foreach (var course in Courses)
                    Console.WriteLine(course.Course_name);
            }
            else Console.WriteLine("There is no courses for this student");
            Console.WriteLine(new String('_', 50));
        }

        public override void AddCourse(Course course)
        {
            this.Courses.Add(course);
        }

        public override void DeleteCourse(Course course)
        {
            this.Courses.Remove(course);
        }

    }

}
