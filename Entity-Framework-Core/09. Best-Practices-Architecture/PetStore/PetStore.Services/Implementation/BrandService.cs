namespace PetStore.Services.Implementation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using PetStore.Data;
    using PetStore.Models;
    using PetStoreServices.Models.Brand;

    public class BrandService : IBrandService
    {
        private readonly PetStoreDbContext data;

        public BrandService(PetStoreDbContext data) => this.data = data;

        public int Create(string name)
        {
            if (name.Length > DataValidation.NameMaxLength)
            {
                throw new InvalidOperationException($"Brand name cannot be more than {DataValidation.NameMaxLength} characters.");
            }

            if (this.data.Brands.Any(br => br.Name == name))
            {
                throw new InvalidOperationException($"Brand name {name} already exists.");
            }

            var brand = new Brand
            {
                Name = name
            };

            this.data.Brands.Add(brand);
            this.data.SaveChanges();

            return brand.Id;
        }

        public IEnumerable<BrandListingServiceModel> SearchByName(string name)
            => this.data
                .Brands
                .Where(br => br.Name.ToLower().Contains(name.ToLower()))
                .Select(br => new BrandListingServiceModel
                {
                    Id = br.Id,
                    Name = br.Name
                })
                .ToList();        
    }
}
