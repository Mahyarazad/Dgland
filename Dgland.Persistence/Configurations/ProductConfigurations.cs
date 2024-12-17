using Dgland.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dgland.Persistence.Configurations
{
    public class ProductConfigurations : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.MetaKeywords).HasMaxLength(1000);
            builder.Property(p => p.Description).HasMaxLength(3000);
            builder.Property(p => p.Title).HasMaxLength(128);
            builder.Property(p => p.Name).HasMaxLength(128);
            builder.Property(p => p.SKU).HasMaxLength(128);
            builder.Property(p => p.Brand).HasMaxLength(128);

            builder.HasIndex(p => new { p.Name, p.Brand }, "UniqueIndex_Name_Brand").IsUnique(true);
            builder.HasQueryFilter(p => p.IsDeleted);

            builder.OwnsMany(p => p.Images);
            builder.OwnsMany(p => p.ProductTags);

            builder.HasMany(p => p.ProductCategories).WithOne(x => x.Product).HasForeignKey(x => x.ProductId).IsRequired();
            builder.HasMany(p => p.Posts).WithOne(x => x.Product).HasForeignKey(x => x.ProductId).IsRequired();
            builder.HasMany(p => p.UserReviews).WithOne(x => x.Product).HasForeignKey(x => x.ProductId).IsRequired();

            builder.HasOne(x => x.LineItem).WithOne(x => x.Product).HasForeignKey<LineItem>(x => x.ProductId).IsRequired();

        }
    }
}   
