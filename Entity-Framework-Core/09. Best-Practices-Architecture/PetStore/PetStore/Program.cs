namespace PetStore
{
    using PetStore.Data;
    using PetStore.Models;
    using PetStore.Services.Implementation;
    using System;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            using (var data = new PetStoreDbContext())
            {
                for (int i = 0; i < 100; i++)
                {
                    var breed = new Breed
                    {
                        Name = "Breed" + i
                    };

                    data.Breeds.Add(breed);
                }

                data.SaveChanges();

                for (int i = 0; i < 30; i++)
                {
                    var category = new Category
                    {
                        Name = "Category " + i,
                        Description = "Category Description " + i
                    };

                    data.Categories.Add(category);
                }

                data.SaveChanges();

                for (int i = 0; i < 100; i++)
                {
                    var breedId = data
                        .Breeds
                        .OrderBy(c => Guid.NewGuid())
                        .Select(b => b.Id)
                        .FirstOrDefault();

                    var categoryId = data
                        .Categories
                        .OrderBy(c => Guid.NewGuid())
                        .Select(c => c.Id)
                        .FirstOrDefault();

                    var pet = new Pet
                    {
                        DateOfBirth = DateTime.UtcNow.AddDays(-100 + i),
                        Price = 50 + i,
                        Gender = (Gender)(i % 2),
                        Description = "Some description" + i,
                        BreedId = breedId,
                        CategoryId = categoryId
                    };

                    data.Pets.Add(pet);
                }

                data.SaveChanges();
            }
        }
    }
}
