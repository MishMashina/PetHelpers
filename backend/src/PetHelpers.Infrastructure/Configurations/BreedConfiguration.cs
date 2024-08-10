using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetHelpers.Domain.Constraints;
using PetHelpers.Domain.Models;
using PetHelpers.Domain.Models.Scepies;
using PetHelpers.Domain.Models.Volunteer;

namespace PetHelpers.Infrastructure.Configurations;

public class BreedConfiguration : IEntityTypeConfiguration<Breed>
{
    public void Configure(EntityTypeBuilder<Breed> builder)
    {
        builder.HasKey(b => b.Id);
        
        builder
            .Property(b => b.Title)
            .IsRequired()
            .HasMaxLength(Constraints.MAX_TITLE_LENGTH);

        builder
            .HasMany<Pet>()
            .WithOne();
    }
}