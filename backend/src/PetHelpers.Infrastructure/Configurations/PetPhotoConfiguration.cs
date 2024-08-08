using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetHelpers.Domain.Models;

namespace PetHelpers.Infrastructure.Configurations;

public class PetPhotoConfiguration : IEntityTypeConfiguration<PetPhoto>
{
    public void Configure(EntityTypeBuilder<PetPhoto> builder)
    {
        builder.HasKey(p => p.Id);
        
        builder
            .Property(p => p.IsMain)
            .IsRequired();
        
        builder
            .Property(p => p.Path)
            .HasMaxLength(PetPhoto.MAX_PATH_LENGTH)
            .IsRequired();
    }
}