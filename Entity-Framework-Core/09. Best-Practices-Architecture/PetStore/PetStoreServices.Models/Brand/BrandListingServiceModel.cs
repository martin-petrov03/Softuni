namespace PetStoreServices.Models.Brand
{
    public class BrandListingServiceModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Profit { get; set; }

        public decimal Price { get; set; }

        public int BrandId { get; set; }

        public int CategoryId { get; set; }
    }
}
