namespace PetStore.Services
{
    using System.Collections.Generic;
    using PetStoreServices.Models.Brand;

    public interface IBrandService
    {
        int Create(string name);
        
        IEnumerable<BrandListingServiceModel> SearchByName(string name);
    }
}
