namespace PetStore.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using PetStore.Models;

    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        void IEntityTypeConfiguration<User>.Configure(EntityTypeBuilder<User> user)
        {
            user
                .HasIndex(u => u.Email)
                .IsUnique();
        }
    }
}
