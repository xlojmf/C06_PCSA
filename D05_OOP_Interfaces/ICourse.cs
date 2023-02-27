using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D05_OOP_Interfaces
{
    internal interface ICourse
    {
        #region Properties
        int CourseID { get; }    
        string CourseName { get; }
        string Area { get; }
        #endregion




        #region Methods

        void ReadCourse();
        void ListCourse();
        void ListCourse(string courseName, string area);

        #endregion
    }
}
