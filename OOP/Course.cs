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
        public Teacher Teacher{ get; set; }
        public int Course_duration { get; set; }
        private int Number_of_students { get; set; }

        public Course (string course_name, int course_duration, int number_of_students, Teacher teacher)
        {
            Course_name = course_name;
            Course_duration = course_duration;
            Number_of_students = number_of_students;
            Teacher = teacher;
            Teacher.AddCourse(this);
 
        }

        public Course (string course_name, int course_duration) :this(course_name, course_duration,0,new Teacher())
        {
            Course_name = course_name;
            Course_duration = course_duration;
        }

        public Course(string course_name) : this (course_name,10)
        {
            Course_name = course_name;
        }

        public Course() : this ("Default course name")
        { 
        }

        public void Print()
        {
            Console.WriteLine($"Course_name = {Course_name}, Teacher_name = {Teacher.First_Name} {Teacher.Last_Name}, Course_duration = {Course_duration}, Number of students = {Number_of_students}");
        }

        public void AddStudentToGroup()
        {
            this.Number_of_students += 1;
        }

        public void DeleteStudentFromGroup()
        {
            this.Number_of_students -= 1;
        }

        //public void SetTeacher(Teacher teacher)
        //{
        //    this.Teacher = teacher;
        //}

    }
}
