using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D03_OOP_Polymorphism
{
    public class CourseIT : Course
    {
        #region Properties
        public bool Exam { get; set; }

        //public new string FullCourse => $"Course {CourseId}: {Area} - {CourseName}, Exame? {Exam}"; // este new é como fosse um overload
        public override string FullCourse => $"Course {CourseId}: {Area} - {CourseName}, Exame? {Exam}"; // este new é como fosse um overload
        #endregion

        #region Constructors
        public CourseIT() :base() 
        {
            Exam= false;
        }
 
        public CourseIT(int courseId, string courseName, string area,bool exam) :base(courseId, courseName, area)
        {
            Exam = exam;
        }



        #endregion

        #region Methods
        public override void ReadCourse() 
        {
        //primeiro invocar o metodo da base classe
        base.ReadCourse();
            // acrescentar o exame
            Console.WriteLine("Course exam (false,true):");
            Exam= Convert.ToBoolean(Console.ReadLine()); // falta as verificacoes
        }


        // herdar listcourse() que lista a fullcourse

        public void ListCourse(DateTime courseDateTime)
        {

            Console.WriteLine($"{FullCourse} ({courseDateTime.ToShortDateString()})");
        }

        #endregion
    }
}
