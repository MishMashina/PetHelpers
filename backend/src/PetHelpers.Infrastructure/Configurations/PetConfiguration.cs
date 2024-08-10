using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetHelpers.Domain.Constraints;
using PetHelpers.Domain.Models;
using PetHelpers.Domain.Models.Volunteer;

namespace PetHelpers.Infrastructure.Configurations;

public class PetConfiguration : IEntityTypeConfiguration<Pet>
{
    public void Configure(EntityTypeBuilder<Pet> builder)
    {
        builder.HasKey(p => p.Id);
        
        builder
            .Property(p => p.Name)
            .HasMaxLength(Constraints.MAX_NAME_LENGTH)
            .IsRequired();
        
        builder
            .Property(p => p.BreedName)
            .HasMaxLength(Constraints.MAX_NAME_LENGTH)
            .IsRequired();
        
        builder
            .Property(p => p.Description)
            .HasMaxLength(Constraints.MAX_DESCRIPTION_LENGTH)
            .IsRequired();

        builder
            .Property(p => p.Color)
            .HasMaxLength(Constraints.MAX_COLOR_LENGTH)
            .IsRequired();

        builder
            .Property(p => p.HealthInfo)
            .HasMaxLength(Constraints.MAX_DESCRIPTION_LENGTH)
            .IsRequired();

        builder
            .Property(p => p.Location)
            .HasMaxLength(Constraints.MAX_LOCATION_LENGTH)
            .IsRequired();

        builder
            .Property(p => p.Weight)
            .IsRequired();

        builder
            .Property(p => p.Height)
            .IsRequired();

        builder
            .Property(p => p.IsCastrated)
            .IsRequired();

        builder
            .Property(p => p.IsVaccinated)
            .IsRequired();

        builder
            .Property(p => p.Birthdate)
            .IsRequired();

        builder
            .Property(p => p.CreationDate)
            .IsRequired();
        
        builder.ComplexProperty(p => p.OwnersPhoneNumber, b =>
        {
            b.IsRequired();
            b.Property(p => p.Number)
                .HasColumnName("owners_phone_number")
                .HasMaxLength(Constraints.MAX_PHONE_NUMBER_LENGTH);
        });

        builder.ComplexProperty(p => p.HelpStatus, b =>
        {
            b.IsRequired();
            b.Property(p => p.Value)
                .HasColumnName("help_status");
        });

        builder
            .HasMany(p => p.Photos)
            .WithOne();
        
        builder.OwnsMany(p => p.Requisites, b => b.ToJson());
    }
}