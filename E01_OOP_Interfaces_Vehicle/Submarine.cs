using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Interfaces_Vehicle
{
    internal class Submarine : Vehicle, ISubmarine
    {
        public bool Pilot { get; set; }

        #region Constructors
        public Submarine() : base()
        {
            Pilot = true;
        }

        public Submarine(int vehicleId, string model, string description, bool pilot) : base(vehicleId, model, description)
        {
            Pilot = pilot;
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
            Console.WriteLine("Terminate Sub");           
        }

        public void TerminateVehicle(bool pilot)
        {
            if (pilot == true)
                { Console.WriteLine("Submarino anda"); }
            else
                {
                    Console.WriteLine("vai afundar");
                }
        }

        public void Dive()
        {
            Console.WriteLine("Adoro Mergulhar");
        }
    }
}
