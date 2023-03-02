using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D07_CollectionsGenericList
{
    interface ICourse
    {

        #region Properties
        int CourseID { get; }

        string CourseName { get; }

        string Area { get; }
        #endregion

    }
}
