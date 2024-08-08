using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetHelpers.Domain.Models;

namespace PetHelpers.Infrastructure.Configurations;

public class PetConfiguration : IEntityTypeConfiguration<Pet>
{
    public void Configure(EntityTypeBuilder<Pet> builder)
    {
        builder.HasKey(p => p.Id);
        
        builder
            .Property(p => p.Name)
            .HasMaxLength(Pet.MAX_NAME_LENGTH)
            .IsRequired();
        
        builder
            .Property(p => p.Species)
            .HasMaxLength(Pet.MAX_SPECIES_LENGTH)
            .IsRequired();
        
        builder
            .Property(p => p.Description)
            .HasMaxLength(Pet.MAX_DESCRIPTION_LENGTH)
            .IsRequired();
        
        builder
            .Property(p => p.Color)
            .HasMaxLength(Pet.MAX_COLOR_LENGTH)
            .IsRequired();
        
        builder
            .Property(p => p.HealthInfo)
            .HasMaxLength(Pet.MAX_HEALTH_INFO_LENGTH)
            .IsRequired();
        
        builder
            .Property(p => p.Location)
            .HasMaxLength(Pet.MAX_LOCATION_LENGTH)
            .IsRequired();
        
        builder
            .Property(p => p.OwnersPhoneNumber)
            .HasMaxLength(Pet.MAX_OWNERS_PHONE_NUMBER_LENGTH)
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
        
        builder
            .Property(p => p.HelpStatus)
            .IsRequired();

        builder
            .HasMany(p => p.Requisites)
            .WithOne();
        
        builder
            .HasMany(p => p.Photos)
            .WithOne();
    }
}