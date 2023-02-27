using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Interfaces_Vehicle
{
    internal interface ISubmarine : IVehicle
    {
        bool Pilot { get; }

        void Dive();
        void TerminateVehicle(bool pilot);
    }
}
