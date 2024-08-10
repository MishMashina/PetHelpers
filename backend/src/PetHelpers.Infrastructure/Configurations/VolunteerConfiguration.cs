using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetHelpers.Domain.Constraints;
using PetHelpers.Domain.Models.Volunteer;

namespace PetHelpers.Infrastructure.Configurations;

public class VolunteerConfiguration : IEntityTypeConfiguration<Volunteer>
{
    public void Configure(EntityTypeBuilder<Volunteer> builder)
    {
        builder.HasKey(v => v.Id);
        
        builder
            .Property(v => v.Description)
            .HasMaxLength(Constraints.MAX_DESCRIPTION_LENGTH)
            .IsRequired();

        builder.ComplexProperty(p => p.PhoneNumber, b =>
        {
            b.IsRequired();
            b.Property(p => p.Number)
                .HasColumnName("phone_number")
                .HasMaxLength(Constraints.MAX_PHONE_NUMBER_LENGTH);
        });

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

        builder.ComplexProperty(p => p.FullName, b =>
        {
            b.IsRequired();
            b.Property(p => p.FirstName)
                .HasColumnName("first_name")
                .HasMaxLength(Constraints.MAX_NAME_LENGTH);
            b.Property(p => p.LastName)
                .HasColumnName("last_name")
                .HasMaxLength(Constraints.MAX_NAME_LENGTH);
        });
        
        builder
            .HasMany(v => v.OwnedPets)
            .WithOne();
        
        builder.OwnsMany(v => v.Requisites, b => b.ToJson());
                       
        builder.OwnsMany(v => v.SocialMedias, b => b.ToJson());
    }
}