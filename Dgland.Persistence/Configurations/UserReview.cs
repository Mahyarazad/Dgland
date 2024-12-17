
using Dgland.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dgland.Persistence.Configurations
{
    public class UserReviewConfigurtion : IEntityTypeConfiguration<UserReview>
    {
        public void Configure(EntityTypeBuilder<UserReview> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Body).HasMaxLength(3000);
            builder.HasOne(x=>x.Product).WithMany(x=>x.UserReviews).HasForeignKey(x=>x.ProductId).IsRequired();  
        }
    }
}
