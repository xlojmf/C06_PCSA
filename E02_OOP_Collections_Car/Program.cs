﻿using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02_OOP_Collections_Car
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            Car cars= new Car();

            List<Car> listacars = cars.CreateCarsList();

            listacars.Add(cars.CreateCar());
            
            cars.ListCarList(listacars);

            Utility.TerminateConsole();
        }
    }
}
