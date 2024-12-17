using Dgland.Core.Abstractions;

namespace Dgland.Core.Entities
{
    public class ProductCategory : BaseEntity
    {
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string MetaKeywords { get; set; }
        public string Url { get; set; }
        public Product Product { get; set; }
        public Guid ProductId { get; set; }
    }
}