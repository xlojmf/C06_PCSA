using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D05_OOP_Interfaces
{
    internal class CourseSoftSkills : Course, ICourseSoftSkills   // tambem é possivel herdar interfaces de interfaces e depois usar, o problema é que no derivado temos que implementar todo
    {
        public string SubArea { get; set; }


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
