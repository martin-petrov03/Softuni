using System;
using System.Collections;
using System.Collections.Generic;

namespace SoftUniParking
{

    public class Car
    {
        public Car(string make, string model, int horsePower, string registrationNumber)
        {
            Make = make;
            Model = model;
            HorsePower = horsePower;
            RegistrationNumber = registrationNumber;
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public string RegistrationNumber { get; set; }

        public override string ToString()
        {
            string nl = Environment.NewLine;
            string result = $"Make: {Make}" + nl +
                $"Model: {Model}" + nl +
                $"HorsePower: {HorsePower}" + nl +
                $"RegistrationNumber: {RegistrationNumber}";
            return result;
        }
    }
}