namespace PetStore.Services
{
    using System;
    using System.Collections.Generic;
    using PetStore.Models;
    using PetStoreServices.Models.Pet;

    public interface IPetService
    {
        IEnumerable<PetListingServiceModel> All();
        void BuyPet(Gender gender, DateTime dateTime, decimal price, string description, int breedId, int categoryId);

        void SellPet(int petId, int userId);

        bool Exists(int petId);
    }
}
