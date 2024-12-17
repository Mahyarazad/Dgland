
using Dgland.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dgland.Persistence.Configurations
{
    public class ProductCategoryConfigurtion : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.HasKey(p => p.Id);
            builder.HasOne(x=>x.Product).WithMany(x=>x.ProductCategories).HasForeignKey(x=>x.ProductId).IsRequired();
        }
    }
}
