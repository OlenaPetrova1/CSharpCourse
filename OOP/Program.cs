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
            student1.Print();

            Student student2 = new Student("Petrova", "Olena", "Kyiv", new DateTime(1982,07,21));
            student2.Print();

            Course course1 = new Course();
            //course1.Print();

            Course course2 = new Course("C# course","Shevchuk");
            //course2.Print();

            student2.AddCourse(course2);
            student2.AddCourse(course1);
            student2.Print();

            student1.AddCourse(course2);
            student1.Print();

            student1.DeleteCourse(course2);
            student1.Print();
            student2.Print();
        }
    }


}
