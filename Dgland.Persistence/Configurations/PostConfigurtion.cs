
using Dgland.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dgland.Persistence.Configurations
{
    public class PostConfigurtion : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(p => p.Id);
            builder.HasOne(x => x.Product).WithMany(x => x.Posts).HasForeignKey(x => x.ProductId).IsRequired();
            builder.HasMany(x => x.Tags).WithMany(x => x.Posts).UsingEntity<PostTag>();
        }
    }
}
