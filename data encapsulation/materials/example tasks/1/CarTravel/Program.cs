using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTravel
{
    class Program
    {
        static void Main(string[] args)
        {
            var carPark = new Dictionary<string, Car>();

            int carsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carsCount; i++)
            {
                string[] currentCarDetails = Console.ReadLine().Split(' ').ToArray();

                string model = currentCarDetails[0];
                double fuelQuantity = double.Parse(currentCarDetails[1]);
                double consumption = double.Parse(currentCarDetails[2]);

                Car newCar = new Car(model, fuelQuantity, consumption);

                carPark.Add(model, newCar);
            }

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                //Drive BMW-M2 56
                string[] commandArgs = command.Split(' ').ToArray();
                string model = commandArgs[1];
                double distance = double.Parse(commandArgs[2]);

                if (carPark.ContainsKey(model))
                {
                    bool hasTravelled = carPark[model].Drive(distance);

                    if (!hasTravelled)
                    {
                        Console.WriteLine("Insufficient fuel for the drive");
                    }
                }
            }

            foreach (Car car in carPark.Values)
            {
                Console.WriteLine(car);
            }

        }
    }
}
