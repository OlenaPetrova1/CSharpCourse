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
            Student student1 = new Student();
            student1.DescribeYourself();

            Student student2 = new Student("Petrova", "Olena", "Kyiv", new DateTime(1982,07,21));
            student2.DescribeYourself();

            Teacher teacher1 = new Teacher("Oleg","Shevchuk");

            Course course1 = new Course();
            course1.Print();

            Course course2 = new Course("C# course");
            teacher1.AddCourse(course2);
            course2.Print();
            teacher1.AddCourse(course1);
            course1.Print();

            student2.AddCourse(course2);
            //student2.AddCourse(course1);
            //student2.DescribeYourself();
            teacher1.DescribeYourself();
            teacher1.DeleteCourse(course1);
            course1.Print();
            teacher1.DescribeYourself();
            //student1.AddCourse(course2);
            //student1.DescribeYourself();

            //student1.DeleteCourse(course2);
            //student1.DescribeYourself();
            //student2.DescribeYourself();
        }
    }


}
