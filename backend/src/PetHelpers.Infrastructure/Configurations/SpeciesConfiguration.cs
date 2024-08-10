using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetHelpers.Domain.Constraints;
using PetHelpers.Domain.Models.Scepies;
using PetHelpers.Domain.Models.Volunteer;

namespace PetHelpers.Infrastructure.Configurations;

public class SpeciesConfiguration : IEntityTypeConfiguration<Species>
{
    public void Configure(EntityTypeBuilder<Species> builder)
    {
        builder.HasKey(s => s.Id);
        
        builder
            .Property(s => s.Title)
            .IsRequired()
            .HasMaxLength(Constraints.MAX_TITLE_LENGTH);

        builder
            .HasMany<Breed>()
            .WithOne();

        builder
            .HasMany<Pet>()
            .WithOne()
            .HasForeignKey(p => p.SpeciesID);
    }
}