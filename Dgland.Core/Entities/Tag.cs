using Dgland.Core.Abstractions;

namespace Dgland.Core.Entities
{
    public class Tag : BaseEntity
    {
        public string Value { get; set; }
        public virtual ICollection<Post> Posts { get; } = [];
    }
}
