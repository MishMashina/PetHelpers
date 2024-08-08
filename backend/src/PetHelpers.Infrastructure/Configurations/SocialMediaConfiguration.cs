using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetHelpers.Domain.Models;

namespace PetHelpers.Infrastructure.Configurations;

public class SocialMediaConfiguration : IEntityTypeConfiguration<SocialMedia>
{
    public void Configure(EntityTypeBuilder<SocialMedia> builder)
    {
        builder.HasKey(s => s.Id);
        
        builder
            .Property(p => p.Title)
            .HasMaxLength(SocialMedia.MAX_TITLE_LENGTH)
            .IsRequired();
            
        builder
            .Property(p => p.Link)
            .HasMaxLength(SocialMedia.MAX_LINK_LENGTH)
            .IsRequired();
    }
}