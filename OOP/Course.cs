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
        public int Number_of_students { get; set; }
        public List<Student> Students { get; set; }  

        public Course (string course_name, int course_duration, int number_of_students, Teacher teacher)
        {
            Course_name = course_name;
            Course_duration = course_duration;
            Teacher = teacher;
            Teacher.AddCourse(this);
            Students = new List<Student>();
            Number_of_students = Students.Count;
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
            Console.WriteLine($"Course_name = {Course_name}, Teacher_name = {Teacher.First_Name} {Teacher.Last_Name}, Course_duration = {Course_duration}, Number of students = {Students.Count}");
            Console.WriteLine("List of students for this course :");
            foreach (Student student in Students) Console.WriteLine(student.First_Name);
        }

        public void AddStudentToGroup(Student student)
        {
            this.Students.Add(student);
            this.Number_of_students = this.Students.Count;
            student.Courses.Add(this);
        }

        public void DeleteStudentFromGroup(Student student)
        {
            this.Students.Remove(student);
            this.Number_of_students = this.Students.Count;
            student.Courses.Remove(this);
        }

        //public void SetTeacher(Teacher teacher)
        //{
        //    this.Teacher = teacher;
        //}

    }
}
