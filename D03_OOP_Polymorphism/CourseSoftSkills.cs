using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D03_OOP_Polymorphism
{
    internal class CourseSoftSkills : Course
    {
        #region Properties
        public string SubArea { get; set; }

        //public new string FullCourse => $"Course {CourseId}: {Area} ({SubArea}) - {CourseName}"; // este new é como fosse um overload
        public override string FullCourse => $"Course {CourseId}: {Area} ({SubArea}) - {CourseName}"; // este new é como fosse um overload
    #endregion

        #region Constructors
        public CourseSoftSkills() : base()
        {
            SubArea = "";
        }

        public CourseSoftSkills(int courseId, string courseName, string area, string subArea) : base(courseId, courseName, area)
        {
            SubArea = subArea;
        }
        #endregion

        #region Methods
        public override void ReadCourse()
        {
            //primeiro invocar o metodo da base classe
            base.ReadCourse();
            // acrescentar o exame
            Console.WriteLine("Subarea?:");
            SubArea = Console.ReadLine(); // falta as verificacoes
        }
        #endregion

        public void ListCourse(string nivel)
        {
            Console.WriteLine($"{FullCourse} ({nivel})");
        }

    }
}
