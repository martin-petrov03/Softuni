using AutoMapper;
using AutoMapper.QueryableExtensions;
using CarDealer.Data;
using CarDealer.Dtos.Export;
using CarDealer.Dtos.Import;
using CarDealer.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace CarDealer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Mapper.Initialize(cfg => cfg.AddProfile<CarDealerProfile>());

            using (var db = new CarDealerContext())
            {
                var result = GetCarsWithTheirListOfParts(db);

                Console.WriteLine(result);
            }
        }

        public static string ImportSuppliers(CarDealerContext context, string inputXml)
        {
            var xmlSerializer = 
                new XmlSerializer(typeof(ImportSupplierDto[]),
                new XmlRootAttribute("Suppliers"));

            using (var reader = new StringReader(inputXml))
            {
                var supplierDtos = (ImportSupplierDto[])xmlSerializer.Deserialize(reader);

                var suppliers = Mapper.Map<Supplier[]>(supplierDtos);
                context.Suppliers.AddRange(suppliers);
                context.SaveChanges();

                return $"Successfully imported {suppliers.Length}";
            }
        }

        public static string ImportParts(CarDealerContext context, string inputXml)
        {
            var xmlSerializer = 
                new XmlSerializer(typeof(ImportPartDto[]),
                new XmlRootAttribute("Parts"));

            ImportPartDto[] partDtos;
            using (var reader = new StringReader(inputXml))
            {
                partDtos = ((ImportPartDto[])xmlSerializer
                    .Deserialize(reader))
                    .Where(p => context.Suppliers.Any(s => s.Id == p.SupplierId))
                    .ToArray();

                var parts = Mapper.Map<Part[]>(partDtos);

                context.Parts.AddRange(parts);
                context.SaveChanges();

                return $"Successfully imported {parts.Length}";
            }

            
        }
        
        public static string ImportCars(CarDealerContext context, string inputXml)
        {
            var xmlSerializer = 
                new XmlSerializer(typeof(ImportCarDto[]),
                new XmlRootAttribute("cars"));

            ImportCarDto[] carsDtos;

            using (var reader = new StringReader(inputXml))
            {
                carsDtos = ((ImportCarDto[])xmlSerializer
                    .Deserialize(reader));
            }

            List<Car> cars = new List<Car>();
            List<PartCar> partCars = new List<PartCar>();

            foreach (var carDto in carsDtos)
            {
                var car = new Car()
                {
                    Make = carDto.Make,
                    Model = carDto.Model,
                    TravelledDistance = carDto.TravelledDistance
                };

                var parts = carDto
                    .Parts
                    .Where(pdto => context.Parts.Any(p => p.Id == pdto.Id))
                    .Select(p => p.Id)
                    .Distinct();

                foreach (var partId in parts)
                {
                    var partCar = new PartCar()
                    {
                        PartId = partId,
                        Car = car
                    };

                    partCars.Add(partCar);
                }

                cars.Add(car);
            }

            context.Cars.AddRange(cars);
            context.PartCars.AddRange(partCars);
            context.SaveChanges();

            return $"Successfully imported {cars.Count}";
        }

        public static string GetLocalSuppliers(CarDealerContext context)
        {
            StringBuilder sb = new StringBuilder();

            var suppliers = context
                .Suppliers
                .Where(s => !s.IsImporter)
                .ProjectTo<ExportLocalSuppliersDto>()
                .ToArray();

            var xmlSerializer =
                new XmlSerializer(typeof(ExportLocalSuppliersDto[]),
                new XmlRootAttribute("suppliers"));

            using (var writer = new StringWriter(sb))
            {
                xmlSerializer.Serialize(writer, suppliers);
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetCarsWithTheirListOfParts(CarDealerContext context)
        {
            StringBuilder sb = new StringBuilder();

            var cars = context
                .Cars
                .OrderByDescending(c => c.TravelledDistance)
                .ThenBy(c => c.Model)
                .Take(5)
                .ProjectTo<ExportCarDto>()
                .ToArray();

            XmlSerializer xmlSerializer = 
                new XmlSerializer(typeof(ExportCarDto[]),
                new XmlRootAttribute("cars"));

            using (var writer = new StringWriter(sb))
            {
                xmlSerializer.Serialize(writer, cars);
            }

            return sb.ToString().TrimEnd();
        }
    }
}