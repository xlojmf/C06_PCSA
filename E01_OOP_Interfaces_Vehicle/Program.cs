using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Interfaces_Vehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // classe submarico , classe carro , classe aviao
            // props are VehicleId Description Model - Comum
            // method register, terminate

            // method especifico dive, drive,  fly
            Car car= new Car();
            Submarine submarine= new Submarine();
            Plane plane= new Plane();

            car.RegisterVehicle();
            car.TerminateVehicle();
            car.Drive();

            submarine.RegisterVehicle();
            submarine.TerminateVehicle();
            submarine.Dive();

            plane.RegisterVehicle();
            plane.TerminateVehicle();
            plane.Fly();

            Console.ReadKey();
            

        }
    }
}
