using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetHelpers.Domain.Constraints;
using PetHelpers.Domain.Models;

namespace PetHelpers.Infrastructure.Configurations;

public class VolunteerConfiguration : IEntityTypeConfiguration<Volunteer>
{
    public void Configure(EntityTypeBuilder<Volunteer> builder)
    {
        builder.HasKey(v => v.Id);

        builder
            .Property(v => v.FullName)
            .HasMaxLength(Constraints.MAX_NAME_LENGTH)
            .IsRequired();

        builder
            .Property(v => v.Description)
            .HasMaxLength(Constraints.MAX_DESCRIPTION_LENGTH)
            .IsRequired();

        builder
            .Property(v => v.PhoneNumber)
            .HasMaxLength(Constraints.MAX_PHONE_NUMBER_LENGTH)
            .IsRequired();

        builder
            .Property(v => v.YearsOfExperience)
            .IsRequired();

        builder
            .Property(v => v.PetsFoundHome)
            .IsRequired();

        builder
            .Property(v => v.PetsLookingForHome)
            .IsRequired();

        builder
            .Property(v => v.PetsInTreatment)
            .IsRequired();
        
        builder
            .HasMany(v => v.OwnedPets)
            .WithOne();
    }
}