using System;
using System.Collections.Generic;

namespace SoftUniParking
{

    class Parking
    {
        private Dictionary<string, Car> cars;
        private int capacity;

        public Parking(int capacity)
        {
            cars = new Dictionary<string, Car>();
            this.capacity = capacity;
        }

        public int Count
        {
            get { return cars.Count; }
        }

        public string AddCar(Car car)
        {
            if (cars.ContainsKey(car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }
            else if (cars.Count == capacity)
            {
                return "Parking is full!";
            }
            cars.Add(car.RegistrationNumber, car);

            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
        }

        public string RemoveCar(string carNumber)
        {
            if (!cars.ContainsKey(carNumber))
            {
                return "Car with that registration number, doesn't exist!";
            }
            cars.Remove(carNumber);

            return $"Successfully removed {carNumber}";
        }

        public Car GetCar(string carNumber)
        {
            if (!cars.ContainsKey(carNumber))
            {
                return null;
            }
            return cars[carNumber];
        }

        public void RemoveSetOfRegistrationNumber(List<string> carNumbers)
        {
            carNumbers.ForEach(n => RemoveCar(n));
        }
    }
}