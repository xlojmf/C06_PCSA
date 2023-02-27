using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Interfaces_Vehicle
{
    internal class Submarine : Vehicle, ISubmarine
    {
        public string Type { get; set; }

        #region Constructors
        public Submarine() : base()
        {
            Type = "";
        }

        public Submarine(int vehicleId, string model, string description, string type) : base(vehicleId, model, description)
        {
            Type = type;
        }
        #endregion

        #region Methods
        public override void RegisterVehicle()
        {
            Console.WriteLine("register sub");
        }
        #endregion

        public override void TerminateVehicle()
        {
            Console.WriteLine("terminate sub");
        }

        public void Dive()
        {
            Console.WriteLine("Adoro Mergulhar");
        }
    }
}
