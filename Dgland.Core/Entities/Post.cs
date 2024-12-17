using Dgland.Core.Abstractions;


namespace Dgland.Core.Entities
{
    public class Post : BaseEntity
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public virtual ICollection<Tag> Tags { get; } = [];
    }
}
