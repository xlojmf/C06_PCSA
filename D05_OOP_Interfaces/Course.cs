using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D05_OOP_Interfaces
{
    internal class Course : ICourse
    {
        #region Properties
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public string Area { get; set; }

        public virtual string FullCourse => $"Course {CourseID}: {Area} - {CourseName}";
        public Course() { }

        public Course(int courseID, string courseName, string area)
        {
            CourseID = courseID;
            CourseName = courseName;
            Area = area;
        }

        public virtual void ReadCourse()
        {
            Console.WriteLine("readcourse");
        }

        public void ListCourse() { Console.WriteLine("list curso simples"); }

        public void ListCourse(string courseName, string area)
        {
            Console.WriteLine($"{FullCourse}");
        }
        #endregion

    }
}
