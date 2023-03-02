using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D07_CollectionsGenericList
{
    public class Course : ICourse
    {

        #region Properties
        public int CourseID { get; set; }

        public string CourseName { get; set; }

        public string Area { get; set; }
        #endregion

        #region Constructors
        public Course()
        {

            CourseID = 0;
            CourseName = "";
            Area = "";

        }

        public Course(int courseID, string courseName, string area)
        {

            CourseID = courseID;
            CourseName = courseName;
            Area = area;

        }
        #endregion

    }
}
