using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D05_OOP_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            // nao se pode instanciar classes abstractas
            // Course course = new Course();

            CourseSoftSkills curso= new CourseSoftSkills();

            curso.ReadCourse();
            curso.ListCourse();
            curso.ListCourse("buh");


            Utility.TerminateConsole();


            // CourseIT CourseID CourseName Area
            // CourseIT methods ReadCourse ListCourse(string CourseName string Area)
        }
    }
}
