using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    class Program
    {
        static void Main(string[] args)
        {
            int countEngineInfoLines = int.Parse(Console.ReadLine());

            var cars = new List<Car>();
            var engines = new List<Engine>();

            for (int i = 0; i < countEngineInfoLines; i++)
            {
                string[] engineInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = engineInfo[0];
                int power = int.Parse(engineInfo[1]);

                Engine currentEngine = new Engine(model, power);
                if (engineInfo.Length == 3)
                {
                    int displacement;
                    if (int.TryParse(engineInfo[2], out displacement))
                    {
                        currentEngine.Displacement = displacement;
                    }
                    else
                    {
                        currentEngine.Efficiency = engineInfo[2];
                    }
                }
                else if (engineInfo.Length == 4)
                {
                    int displacement = int.Parse(engineInfo[2]);
                    string efficiency = engineInfo[3];

                    currentEngine.Displacement = displacement;
                    currentEngine.Efficiency = efficiency;
                }

                engines.Add(currentEngine);
            }

            int countCarsInfoLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < countCarsInfoLines; i++)
            {
                string[] line = Console.ReadLine()
                    .Split();
                string carModel = line[0];
                var engine = engines.FirstOrDefault(e => e.Model == line[1]);
                Car currentCar = new Car(carModel, engine);

                if (line.Length == 3)
                {
                    int weight;
                    if (int.TryParse(line[2], out weight))
                    {
                        currentCar.Weight = weight;
                    }
                    else
                    {
                        currentCar.Color = line[2];
                    }
                }
                else if (line.Length == 4)
                {
                    int weight = int.Parse(line[2]);
                    string color = line[3];

                    currentCar.Weight = weight;
                    currentCar.Color = color;
                }

                cars.Add(currentCar);
            }

            foreach (var car in cars)
            {
                PrintCarModelEngineAndEngineProperties(car);
                PrintCarWeightAndColor(car);
            }
        }
        private static void PrintCarWeightAndColor(Car car)
        {
            if (car.Weight == 0)
            {
                Console.WriteLine($"  Weight: n/a");
            }
            else
            {
                Console.WriteLine($"  Weight: {car.Weight}");
            }

            if (car.Color == null)
            {
                Console.WriteLine($"  Color: n/a");
            }
            else
            {
                Console.WriteLine($"  Color: {car.Color}");
            }
        }

        private static void PrintCarModelEngineAndEngineProperties(Car car)
        {
            Console.WriteLine($"{car.Model}:");
            Console.WriteLine($"  {car.Engine.Model}:");
            Console.WriteLine($"    Power: {car.Engine.EnginePower}");

            if (car.Engine.Displacement == 0)
            {
                Console.WriteLine($"    Displacement: n/a");
            }
            else
            {
                Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
            }

            if (car.Engine.Efficiency == null)
            {
                Console.WriteLine($"    Efficiency: n/a");
            }
            else
            {
                Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
            }
        }
    }
}