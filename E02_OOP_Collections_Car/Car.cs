using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace E02_OOP_Collections_Car
{
    public class Car : ICar
    {

        #region Properties
        public enum EnumBrand
        {
            BMW,
            Dacia,
            Tesla
        }       
        public enum EnumModel 
        {
            Z4,
            I4,
            Sandero,
            Spring,
            Model3,
            Roadster       
        }
        public enum EnumColour
        {
            Azul,
            Amarelo,
            Verde,
            Vermelho,
            Cinza
        }

        public EnumBrand? Brand { get; set; }
        public EnumModel? Model { get; set; }
        public EnumColour? Colour { get; set; }
        string Matricula { get; set; }
        string Cilindrada { get; set; }
        int MaxSpeed { get; set; }
        DateTime RegisterDate { get; set; }

        string ICar.Matricula => throw new NotImplementedException();

        string ICar.Cilindrada => throw new NotImplementedException();

        int ICar.MaxSpeed => throw new NotImplementedException();

        DateTime ICar.RegisterDate => throw new NotImplementedException();
        #endregion

        #region Constructors
        public Car() 
        {
            Brand = null;
            Model = null;
            Colour = null;
            Matricula = string.Empty;
            Cilindrada = string.Empty;
            MaxSpeed = 0;
            RegisterDate = DateTime.MinValue;
        
        }
        public Car(EnumBrand brand, EnumModel model, string cilindrada)
        {
            Brand = EnumBrand.BMW;
            Model = EnumModel.Z4;
            Cilindrada = "100cc";
        }
        public Car(EnumBrand brand, EnumModel model ,EnumColour colour, string matricula, string cilindrada, int maxSpeed, DateTime registerDate)
        {
            Brand = brand;
            Model = model;
            Colour = colour;
            Matricula = matricula;
            Cilindrada = cilindrada;
            MaxSpeed = maxSpeed;
            RegisterDate = registerDate;
        }
        #endregion

        #region Destructor - Carro para a Sucata
        ~Car()
        {
            Console.WriteLine("Carro para a Sucata");
        }
        #endregion

        #region Methods
        public Car CreateCar()
        {
            EnumBrand brand = GetCarBrand();
            EnumModel model = GetCarModel();
            EnumColour colour = GetCarColour();

            Console.WriteLine("Enter the car's registration number:");
            string matricula = Console.ReadLine();

            Console.WriteLine("Enter the car's engine displacement:");
            string cilindrada = Console.ReadLine();

            Console.WriteLine("Enter the car's maximum speed:");
            int maxSpeed = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the car's registration date (yyyy-mm-dd):");
            DateTime registerDate = DateTime.Parse(Console.ReadLine());

            return new Car(brand, model, colour, matricula, cilindrada, maxSpeed, registerDate);
        }
        public void StopCar(Car car)
        {
            MaxSpeed = 0;
        }
        public void AcellCar(int speed, Car car)
        {
            //Acelerar: incrementa a velocidade com o valor de aceleração;
        }
        public void ReduceSpeedCar(int speed, Car car)
        {     
            //Desacelerar: decrementa a velocidade com o valor de desaceleração;
        }
        public EnumBrand GetCarBrand()
        {
            Console.WriteLine("Choose the car's brand:");
            EnumBrand brand;
            while (true)
            {
                Console.WriteLine("1. BMW");
                Console.WriteLine("2. Dacia");
                Console.WriteLine("3. Tesla");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        brand = EnumBrand.BMW;
                        break;
                    case "2":
                        brand = EnumBrand.Dacia;
                        break;
                    case "3":
                        brand = EnumBrand.Tesla;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please choose 1, 2 or 3");
                        continue;
                }
                break;
            }
            return brand;
        }
        public EnumModel GetCarModel()
        {
            Console.WriteLine("Choose the car's model:");
            EnumModel model;
            while (true)
            {
                Console.WriteLine("1. Z4");
                Console.WriteLine("2. I4");
                Console.WriteLine("3. Spring");
                Console.WriteLine("4. Model3");
                Console.WriteLine("5. Roadster");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        model = EnumModel.Z4;
                        break;
                    case "2":
                        model = EnumModel.I4;
                        break;
                    case "3":
                        model = EnumModel.Spring;
                        break;
                    case "4":
                        model = EnumModel.Model3;
                        break;
                    case "5":
                        model = EnumModel.Roadster;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please choose 1, 2, 3, 4, or 5.");
                        continue;
                }
                break;
            }
            return model;
        }
        public EnumColour GetCarColour()
        {
            Console.WriteLine("Choose the car's colour:");
            EnumColour colour;
            while (true)
            {
                Console.WriteLine("1. Azul");
                Console.WriteLine("2. Amarelo");
                Console.WriteLine("3. Verde");
                Console.WriteLine("4. Vermelho");
                Console.WriteLine("5. Cinza");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        colour = EnumColour.Azul;
                        break;
                    case "2":
                        colour = EnumColour.Amarelo;
                        break;
                    case "3":
                        colour = EnumColour.Verde;
                        break;
                    case "4":
                        colour = EnumColour.Vermelho;
                        break;
                    case "5":
                        colour = EnumColour.Cinza;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please choose 1, 2, 3, 4, or 5.");
                        continue;
                }
                break;
            }
            return colour;
        }     
        public List<Car> CreateCarsList()
        {
            List<Car> carList = new List<Car>();
            carList.Add(new Car(EnumBrand.BMW, EnumModel.Z4, EnumColour.Verde, "22-hh-30", "2000cc", 180, new DateTime(2022, 2, 15)));
            carList.Add(new Car(EnumBrand.Dacia, EnumModel.Sandero, EnumColour.Vermelho, "22-hh-31", "1800cc", 200, new DateTime(2021, 5, 10)));
            carList.Add(new Car(EnumBrand.Tesla, EnumModel.Roadster, EnumColour.Cinza, "22-hh-32", "5000cc", 300, new DateTime(2023, 1, 1)));
            carList.Add(new Car(EnumBrand.Tesla, EnumModel.Model3, EnumColour.Amarelo, "22-hh-33", "3000cc", 240, new DateTime(2022, 8, 20)));
            carList.Add(new Car(EnumBrand.Dacia, EnumModel.Spring, EnumColour.Azul, "22-hh-34", "4000cc", 260, new DateTime(2021, 8, 20)));

            return carList;
        }
        public void ListCarList(List<Car> car) 
        {
            foreach (Car item in car)
            {
                Console.WriteLine($"Brand: {item.Brand}\nModel: {item.Model}\nColour: {item.Colour}\nLicense Plate: {item.Matricula}\nCilindrada: {item.Cilindrada}\nMax Speed: {item.MaxSpeed}\nRegistration Date: {item.RegisterDate}\n\n");
            }
        }

        #endregion


    }
}
