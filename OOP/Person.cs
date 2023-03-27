﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal abstract class Person
    {
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string City { get; set; }
        public List<Course> Courses { get; set;}
        public DateTime DoB { get; set; }
        public int Age
        {
            get { return DateTime.UtcNow.Year - DoB.Year; }
        }

        public virtual void DescribeYourself()
        {
            Console.WriteLine($"First_Name = {First_Name}, Last_Name = {Last_Name},City = {City}, Age = {Age}");
            if (Courses.Count != 0)
            {
                Console.WriteLine($"Courses for {First_Name} {Last_Name} :");
                foreach (var course in Courses)
                    course.Print();
             }
            else Console.WriteLine("There is no courses for this person");
            Console.WriteLine(new String('_', 50));
        }

        public Person(string first_name, string last_name, string city, DateTime dob)
        {
            First_Name = first_name;
            Last_Name = last_name;
            City = city;
            DoB = dob;
            Courses = new List<Course>();
        }

        public Person(string first_name, string last_name) : this(first_name, last_name, "City", DateTime.MaxValue)
        {
            First_Name = first_name;
            Last_Name = last_name;
        }

        public Person() : this("Default First Name", "Default Last Name")
        {
        }

        public abstract void AddCourse(Course course);

        public abstract void DeleteCourse(Course course);

    }
}
