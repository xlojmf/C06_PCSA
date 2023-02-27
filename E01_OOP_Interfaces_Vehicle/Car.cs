using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Interfaces_Vehicle
{
    internal class Car : Vehicle, ICar
    {
        public string Type { get; set; }

        #region Constructors
        public Car() : base()
        {
            Type = "";
        }

        public Car(int vehicleId, string model, string description, string type) : base ( vehicleId, model, description)
        {
            Type = type;
        }
        #endregion

        #region Methods
        public override void RegisterVehicle()
        {
            Console.WriteLine("register car");
        }
        #endregion

        public override void TerminateVehicle()
        {
            Console.WriteLine("terminate car");
        }

        public void Drive()
        {
            Console.WriteLine("Adoro Conduzir");
        }
    }
}
