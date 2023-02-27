using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Interfaces_Vehicle
{
    internal class Vehicle : IVehicle
    {


        public int VehicleId { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public Vehicle() { }

        public Vehicle(int vehicleId, string model, string descripton) 
        {
        VehicleId= vehicleId;
        Model= model;
        Description= descripton;
        }

        public virtual void RegisterVehicle() 
        {
            Console.WriteLine("Registando Veiculo");
        }

        public virtual void TerminateVehicle() 
        {
            Console.WriteLine("Terminando Função do Veiculo");
        }
       
    }
}
