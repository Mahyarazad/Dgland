using Dgland.Core.Abstractions;

namespace Dgland.Core.Entities
{
    public class UserReview : BaseEntity
    {
        public Product Product { get; set; }
        public Guid ProductId { get; set; }
        public int Rate { get; set; }
        public string Body { get; set; }
        public int Likes { get; set; } = 0;
        public int Dislikes { get; set; } = 0;
    }
}