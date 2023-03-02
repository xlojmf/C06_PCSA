using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Interfaces_Vehicle
{
    internal class Plane : Vehicle,IPlane
    {
        public enum EnumFuel
        {
            Gsolina,
            Gasoleo,
            Bio
        }

        public EnumFuel TypeFuel { get; set; }

        string IPlane.TypeFuel => throw new NotImplementedException();

        #region Constructors
        public Plane() : base()
        {
            TypeFuel = EnumFuel.Gsolina;
        }

        public Plane(int vehicleId, string model, string description, EnumFuel typefuel) : base(vehicleId, model, description)
        {
            TypeFuel = EnumFuel.Gsolina;
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
