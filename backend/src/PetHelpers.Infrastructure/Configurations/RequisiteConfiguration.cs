using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetHelpers.Domain.Models;

namespace PetHelpers.Infrastructure.Configurations;

public class RequisiteConfiguration : IEntityTypeConfiguration<Requisite>
{
    public void Configure(EntityTypeBuilder<Requisite> builder)
    {
        builder.HasKey(r => r.Id);
        
        builder
            .Property(r => r.Title)
            .HasMaxLength(Requisite.MAX_TITLE_LENGTH)
            .IsRequired();
            
        builder
            .Property(r => r.Description)
            .HasMaxLength(Requisite.MAX_DESCRIPTION_LENGTH)
            .IsRequired();
    }
}