namespace PetStore.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using PetStore.Models;

    class ToyOrderConfiguration : IEntityTypeConfiguration<ToyOrder>
    {
        public void Configure(EntityTypeBuilder<ToyOrder> toyOrder)
        {
            toyOrder.HasKey(to => new
            {
                to.ToyId,
                to.OrderId
            });

            toyOrder
                .HasOne(to => to.Toy)
                .WithMany(f => f.Orders)
                .HasForeignKey(to => to.ToyId)
                .OnDelete(DeleteBehavior.Restrict);

            toyOrder
                .HasOne(to => to.Order)
                .WithMany(o => o.Toy)
                .HasForeignKey(to => to.OrderId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
