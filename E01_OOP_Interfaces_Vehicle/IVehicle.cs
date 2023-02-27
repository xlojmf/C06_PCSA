using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Interfaces_Vehicle
{
    internal interface IVehicle
    {
        int VehicleId { get; }
        string Description { get; }
        string Model { get; }

        void RegisterVehicle();
        void TerminateVehicle();
    }
}
