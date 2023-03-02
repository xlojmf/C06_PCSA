using D00_Utility;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D06_Collections_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            #region ArrayList: Multi Value
            ArrayList listaMultivalor= new ArrayList();

            listaMultivalor.Add("Colection Array List");
            listaMultivalor.Add(1.5);
            listaMultivalor.Add(true);
            listaMultivalor.Add(DateTime.Now.ToShortDateString());
            listaMultivalor.Add(new DateTime(2023, 02, 28));

            for (int i = 4; i <=6 ; i++)
            {
                listaMultivalor.Add(i);
            }

            foreach(var item in listaMultivalor)
            {
                Console.WriteLine(item);               
            }

            #endregion

            #region ArrayList: Objects

            Course it = new Course(1, "Sql", "IT");
            Course cs =new Course(2, "C#", "IT");

            ArrayList listaCourse = new ArrayList();
            listaCourse.Add(it);
            listaCourse.Add(cs);

            foreach (Course course in listaCourse)
            {
                Console.WriteLine($"ID: {course.CourseID} - Course Name: {course.CourseName}- Area: {course.Area}");
            }



            #endregion








            Utility.TerminateConsole();




        }
    }
}
