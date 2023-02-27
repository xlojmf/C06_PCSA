using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Interfaces_Vehicle
{
    internal class Car : Vehicle, ICar
    {
        public string Colour { get; set; }

        #region Constructors
        public Car() : base()
        {
            Colour = "";
        }


        public enum Cor 
        {
        Azul,
        Amarelo,
        Verde,      
        }


        public Car(int vehicleId, string model, string description, string colour) : base ( vehicleId, model, description)
        {
            Colour = Cor colour;
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
