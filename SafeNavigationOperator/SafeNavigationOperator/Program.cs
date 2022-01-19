using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeNavigationOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars bmwM3 = new Cars();
            bmwM3.Brand = "BMW";
            bmwM3.Model = "M3";
            bmwM3.Price = 60_000;

            Cars mercedesAmgGt = new Cars();
            mercedesAmgGt.Brand = "Mercedes";
            mercedesAmgGt.Model = "AMG GT";
            mercedesAmgGt.Price = 150_000;

            Cars porscheCarreraGT = new Cars();
            porscheCarreraGT.Brand = "Porsche";
            porscheCarreraGT.Model = "Carrera GT";
            porscheCarreraGT.Price = 500_000;

            Cars ferrariEnzo = new Cars();
            //ferrariEnzo.Brand = "Ferrari";
            //ferrariEnzo.Model = "Enzo";
            //ferrariEnzo.Price = 2_500_000;

            Console.WriteLine("Car Information");
            Cars.DisplayCarDetails(bmwM3);
            Cars.DisplayCarDetails(porscheCarreraGT);
            Cars.DisplayCarDetails(mercedesAmgGt);
            Cars.DisplayCarDetails(ferrariEnzo);


            List<Cars> listofCars = new List<Cars>();
            //List<Cars> listofCars = null;
            listofCars.Add(bmwM3);
            listofCars.Add(mercedesAmgGt);
            listofCars.Add(porscheCarreraGT);
            //listofCars.Add(ferrariEnzo);

            int? count = 0;
            count = listofCars?.Count;
            Console.WriteLine(count);
        }
    }

    class Cars
    {
        private string carBrand;
        private string carModel;
        private decimal carPrice;

        public string Model
        {
            get => carModel;
            set => carModel = value;
        }
        public string Brand
        {
            get => carBrand;
            set => carBrand = value;
        }
        public decimal Price
        {
            get => carPrice;
            set => carPrice = value;
        }

        public static void DisplayCarDetails(Cars car)
        {
            //if (car.Brand != null)
            //    Console.WriteLine(car.Brand);
            //if (car.Model != null)
            //    Console.WriteLine(car.Model);
            //if (car.Price != null)
            //    Console.WriteLine(car.Price);

            Console.WriteLine(car?.Brand);
            Console.WriteLine(car?.Model);
            Console.WriteLine(car?.Price);


            Console.WriteLine("--------------");
        }
    }
}
