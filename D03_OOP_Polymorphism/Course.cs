/*
    Encapsulation
    Public classe members: methods, properties
    Private class members: fields or attributes; variables

    Inheritance
    Base Class
    Derived Classes

    polymorphism
    same method with diferent signatures


 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D03_OOP_Polymorphism
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
            set { courseName = value.ToUpper(); } //write
        }

        // Bodied expression
        public string Area
        {
            get => area;
            set => area = value.ToUpper();
        }
        #endregion
        // read only
        public virtual string FullCourse => $"Course {CourseId}: {Area} - {CourseName}";

        #region Constructors

        public Course() 
        {
         CourseId= 0;
         CourseName = "";
         Area = "";
        }

        public Course( int courseId, string courseName, string area)
        {
            CourseId = courseId;
            CourseName = courseName;
            Area = area;
        }

        #endregion


        #region Methods
        // read all course values
        public virtual void ReadCourse()
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