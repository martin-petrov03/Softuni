namespace PetStore.Services
{    
    using PetStoreServices.Models.Brand;

    public interface IToyService
    {
        void BuyFromDistributor(string name, string description, decimal distributorPrice, double profit, int brandId, int categoryId);

        void BuyFromDistributor(BrandListingServiceModel model);

        void SellToyToUser(int toyId, int userId);

        bool Exists(int toyId);
    }
}
