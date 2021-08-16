using System;
using System.Collections.Generic;

namespace DBLab52CarLot
{
    enum CarMake
    {
        Ford, Chevy, Chrysler, Hyundai, Kia
    }
    class Car
    {
        protected CarMake make;
        protected string model;
        protected int year;
        protected decimal price;

        public Car (CarMake aMake, string aModel, int aYear, decimal aPrice)
        {
            make = aMake;
            model = aModel;
            year = aYear;
            price = aPrice;
        }
    }

    class NewCar : Car
    {
        bool extendedWarranty;

        public NewCar(CarMake aMake, string aModel, int aYear, decimal aPrice, bool aextendedWarranty) : base( aMake, aModel, aYear, aPrice)
        {
            extendedWarranty = aextendedWarranty;
        }

        public override string ToString()
        {
            return $"New \tYear: {year} \tMake: {make} \tModel: {model} \tPrice :{price} \tExtended Warranty :{extendedWarranty}";
        }
    }
    class UsedCar : Car
    {
        int numOwners;
        int milleage;

        public UsedCar(CarMake aMake, string aModel, int aYear, decimal aPrice, int anumOwners, int amilleage) :base(aMake, aModel, aYear, aPrice)
        {
            numOwners = anumOwners;
            milleage = amilleage;
        }
        public override string ToString()
        {
            return $"Used \tYear: {year} \tMake: {make} \tModel: {model} \tPrice :{price} \tNumber of Owners: {numOwners} \tMilleage: {milleage}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> newCars = new List<Car>();
            NewCar n1 = new NewCar(CarMake.Ford, "Ranger", 2022, 35000.00m, true);
            newCars.Add(n1);
            n1 = new NewCar(CarMake.Chevy, "Equinox", 2022, 24350.00m, false);
            newCars.Add(n1);
            n1 = new NewCar(CarMake.Chrysler, "300", 2022, 39995.00m, true);
            newCars.Add(n1);
            n1 = new NewCar(CarMake.Hyundai, "Accent", 2022, 17995.00m, false);
            newCars.Add(n1);
            n1 = new NewCar(CarMake.Kia, "Sorento", 2022, 15559.95m, false);
            newCars.Add(n1);

            List<Car> usedCars = new List<Car>();
            UsedCar u1 = new UsedCar(CarMake.Ford, "Probe", 1988, 11995.95m , 5, 399999);
            usedCars.Add(u1);
            u1 = new UsedCar(CarMake.Chevy, "Metro", 1991, 13850.45m , 3, 185631);
            usedCars.Add(u1);
            u1 = new UsedCar(CarMake.Chrysler, "Sebring", 1997, 12450.40m, 1, 96328);
            usedCars.Add(u1);
            u1 = new UsedCar(CarMake.Hyundai, "Tiberon", 2008, 22550.95m, 1, 78963);
            usedCars.Add(u1);
            u1 = new UsedCar(CarMake.Kia, "Stinger", 2019, 33960.45m, 2, 38123);
            usedCars.Add(u1);

            List<Car> Inventory = new List<Car>();
            Inventory.AddRange(newCars);
            Inventory.AddRange(usedCars);
            
            Console.WriteLine("Here is our inventory!");
            foreach (Car car in Inventory)
            {
                Console.WriteLine(car);
            }

            Console.Write("Would you like to (A)dd a car to the inventory or (Q)uit?");
            string resp = Console.ReadLine();
            resp.ToLower();
            if (resp == "a")
            {
                Console.WriteLine("Is this a (N)ew or a (U)sed car?");
                string resp2 = Console.ReadLine();
                resp2.ToLower();
                if (resp2 == "n")
                {
                    Console.WriteLine("What is the make of the car?");
                    Console.WriteLine("What is the model of the car?");
                    Console.WriteLine("What is the year of the car?");
                    Console.WriteLine("What is the price of the car?");
                    Console.WriteLine("Does the car have an extended warranty?");
                }
                else if(resp2 == "u")
                {
                    Console.WriteLine("What is the make of the car?");
                    Console.WriteLine("What is the model of the car?");
                    Console.WriteLine("What is the year of the car?");
                    Console.WriteLine("What is the price of the car?");
                    Console.WriteLine("How many previous owners?");
                    Console.WriteLine("What is the milleage of the car?");
                }
                else
                {
                    return;
                }

                Console.WriteLine("Here is the updated list of cars!");
            }
            else if(resp == "q")
            {
                return;
            }
            

            

        }
    }
}
