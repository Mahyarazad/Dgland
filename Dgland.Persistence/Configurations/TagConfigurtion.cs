
using Dgland.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dgland.Persistence.Configurations
{
    public class TagConfigurtion : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.HasKey(p => p.Id);
            builder.HasMany(x => x.Posts).WithMany(x => x.Tags).UsingEntity<PostTag>();
        }
    }
}
