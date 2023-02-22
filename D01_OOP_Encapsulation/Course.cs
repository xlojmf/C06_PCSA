/*
 Encapsulation
    Public classe members: methods, properties
    Private class members: fields or attributes; variables
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_OOP_Encapsulation
{
    public class Course
    {

        #region Fields

        private string courseName; // supporte da propriedade clássica
        private string area; // suporte da propriedade bodied-exprenssion ( => )

        #endregion

        #region Properties
        // Auto implemented  - prop
        public int CourseId { get; set; }

        // Classica - propfull
        public string CourseName
        {
            get { return courseName; } //read
            set { courseName = value; } //write
        }

        // Bodied expression
        public string Area
        {
            get => area ;
            set => area = value;
        }
        #endregion
        // read only
        public string FullCourse => $"Course {CourseId}: {Area} - {CourseName}";


        #region Methods
        // read all course values
        public void ReadCourse() 
        {
            #region CourseId
            Console.WriteLine("Course id:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int courseId))
            {
                CourseId = courseId;
            }
            else
            {
                CourseId = 0;
            }

            #endregion

            #region Area
            Console.WriteLine("Area:");
            Area = Console.ReadLine();

            #endregion

            #region CourseName
            Console.WriteLine("CourseName:");
            CourseName = Console.ReadLine();
            #endregion

        }
        //list course info
        public void ListCourse() 
        {
            Console.WriteLine(FullCourse);
        }

        #endregion


    }
}
