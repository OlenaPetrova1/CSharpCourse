using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Course
    {
        public string Course_name { get; set; }
        public string Teacher_name { get; set; }
        public int Course_duration { get; set; }
        private int Number_of_students { get; set; }

        public Course (string course_name, string teacher_name, int course_duration, int number_of_students)
        {
            Course_name = course_name;
            Teacher_name = teacher_name;
            Course_duration = course_duration;
            Number_of_students = number_of_students;
        }

        public Course (string course_name, string teacher_name, int course_duration) :this(course_name, teacher_name, course_duration,  0)
        {
            Course_name = course_name;
            Teacher_name = teacher_name;
            Course_duration = course_duration;
        }

        public Course(string course_name, string teacher_name) : this (course_name, teacher_name,10)
        {
            Course_name = course_name;
            Teacher_name = teacher_name;
        }

        public Course() : this ("Default course name", "Default teacher_name")
        { 
        }

        public void Print()
        {
            Console.WriteLine($"Course_name = {Course_name}, Teacher_name = {Teacher_name}, Course_duration = {Course_duration}, Number of students = {Number_of_students}");
        }

        public void AddStudentToGroup()
        {
            this.Number_of_students += 1;
        }

        public void DeleteStudentFromGroup()
        {
            this.Number_of_students -= 1;
        }

    }
}
