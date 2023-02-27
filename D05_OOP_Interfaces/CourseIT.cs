using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D05_OOP_Interfaces
{
    internal class CourseIT : Course, ICourseIT // isto ja se pode fazer para colocar uma nova propriedade em uso
    {

        public bool Exam { get; set; } // nao se pode fazer , tem q ter um interface proprio , mas nao posso ter multi herancas de classes mas de interfaces posso

        public override void ReadCourse()
        {
            base.ReadCourse();

            // adicionar Exam para usar
        }
    }
}
