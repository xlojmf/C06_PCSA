using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D03_OOP_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            Course course = new Course();
            CourseIT courseIT = new CourseIT();
            CourseSoftSkills courseSoft = new CourseSoftSkills();

            //BASE
            //course.ReadCourse();
            //course.ListCourse();


            //INHETRITE 
            //courseIT.ReadCourse();
            //courseIT.ListCourse();
            //courseIT.ListCourse(DateTime.Today); // polymorismo a funcionar assinaturas diferentes

            //Herança outro
            courseSoft.ReadCourse();
            courseSoft.ListCourse();
            courseSoft.ListCourse("nivel iniciado");


            Utility.TerminateConsole();

        }
    }
}
