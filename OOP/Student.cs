using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Student
    {
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string City { get; set; }
        public Course[] Courses { get; set; }
        public DateTime DoB { get; set; }
        public int Age
        {
            get { return DateTime.UtcNow.Year - DoB.Year; }
        }

        public void Print()
        {
            Console.WriteLine($"First_Name = {First_Name}, Last_Name = {Last_Name},City = {City}, Age = {Age}");
            var n = Array.IndexOf(Courses, null);
            if (n != 0)
            {
                Console.WriteLine("Courses :");
                for (int i = 0; i < n; i++)
                    Courses[i].Print();
            }
            else Console.WriteLine("There is no courses for this student");
            Console.WriteLine(new String('_',50));
        }

        public Student(string first_name, string last_name, string city, DateTime dob)
        {
            First_Name = first_name;
            Last_Name = last_name;
            City = city;
            DoB = dob;
            Courses = new Course[10];
        }

        public Student(string first_name, string last_name) : this (first_name, last_name, "City", DateTime.MaxValue)
        {
            First_Name = first_name;
            Last_Name = last_name;
        }

        public Student() : this ("Default First Name", "Default Last Name")
        {
        }

        public void AddCourse(Course course)
        {
           var i = Array.IndexOf(Courses, null);
            Courses[i] = course;
            course.AddStudentToGroup();
        }

        public void DeleteCourse(Course course)
        {
            var i = Array.IndexOf(Courses, null) - 1;
            Courses[i] = null;
            course.DeleteStudentFromGroup();
        }

    }

}
