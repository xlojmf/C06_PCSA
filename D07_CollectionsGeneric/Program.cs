using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D07_CollectionsGenericList
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Utility.SetUnicodeConsole();

            #region List: Ints

            List<int> list = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                list.Add(i);
            }
            list.Add(10);

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            #endregion

            #region List: Courses

            List<Course> courses = new List<Course>();
            Course it = new Course(1, "Sql", "IT");
            Course cs = new Course(2, "C#", "IT");

            courses.Add(it);
            courses.Add(cs);

            foreach (Course course in courses)
            {
                Console.WriteLine($"ID: {course.CourseID} - Course Name: {course.CourseName}- Area: {course.Area}");
            }
            #endregion

            Utility.TerminateConsole();

        }
    }
}
