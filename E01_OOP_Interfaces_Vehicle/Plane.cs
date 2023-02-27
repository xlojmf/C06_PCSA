using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Interfaces_Vehicle
{
    internal class Plane : Vehicle,IPlane
    {
        public string TypeFuel { get; set; }

        #region Constructors
        public Plane() : base()
        {
            TypeFuel = "";
        }

        public Plane(int vehicleId, string model, string description, string typefuel) : base(vehicleId, model, description)
        {
            TypeFuel = typefuel;
        }
        #endregion

        #region Methods
        public override void RegisterVehicle()
        {
            Console.WriteLine("plane register");
        }
        #endregion

        public override void TerminateVehicle()
        {
            Console.WriteLine("plane terminate");
        }

        public void Fly()
        {
            Console.WriteLine("Adoro fly");
        }
    }
}
