using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetHelpers.Domain.Constraints;
using PetHelpers.Domain.Models.Volunteer;

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
            .HasMaxLength(Constraints.MAX_PATH_LENGTH)
            .IsRequired();
    }
}