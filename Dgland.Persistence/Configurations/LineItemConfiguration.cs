
using Dgland.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dgland.Persistence.Configurations
{
    public class LineItemConfiguration : IEntityTypeConfiguration<LineItem>
    {
        public void Configure(EntityTypeBuilder<LineItem> builder)
        {
            builder.HasOne(x=>x.Order).WithMany(x=>x.LineItems).HasForeignKey(x=>x.OrderId).IsRequired();
            builder.HasOne(x=>x.Product).WithOne(x=>x.LineItem).HasForeignKey<LineItem>(x=>x.ProductId).IsRequired();
        }
    }
}
