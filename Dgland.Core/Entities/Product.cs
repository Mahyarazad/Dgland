using Dgland.Core.Abstractions;


namespace Dgland.Core.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string MetaKeywords { get; set; }
        public string Url { get; set; }
        public string Brand { get; set; }
        public string SKU { get; set; }
        public int StockQuantity { get; set; }
        public decimal UnitPrice { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<ProductTag> ProductTags { get; set; }
        public virtual ICollection<ProductCategory> ProductCategories { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<UserReview> UserReviews { get; set; }
        public LineItem LineItem { get; set; }
        public string? ManufacturePhone { get; set; }
        public bool IsDeleted { get; private set; } = false;
        public Guid UserId { get; init; }

        public void MarkAsDeleted()
        {
            IsDeleted = true;
        }

        public void MarkAvailable()
        {
            IsDeleted = false;
        }
    }
}
