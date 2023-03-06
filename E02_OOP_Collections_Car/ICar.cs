using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static E02_OOP_Collections_Car.Car;

namespace E02_OOP_Collections_Car
{
    public interface ICar
    {
        EnumBrand? Brand { get;}
        EnumModel? Model { get; }
        EnumColour? Colour { get; }
        string Matricula { get; }
        string Cilindrada { get; }
        int MaxSpeed { get;}
        DateTime RegisterDate { get; }

        Car CreateCar();
        void StopCar(Car car);
        void AcellCar(int speed, Car car);
        void ReduceSpeedCar(int speed, Car car);
        EnumBrand GetCarBrand();
        EnumModel GetCarModel();
        EnumColour GetCarColour();
        List<Car> CreateCarsList();
        void ListCarList(List<Car> car);
    }
}
