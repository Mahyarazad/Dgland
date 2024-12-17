using Dgland.Core.Abstractions;

namespace Dgland.Core.Entities
{
    public class Order : BaseEntity
    {
        public DateTime OrderDate { get; set; }
        public string UserId { get; set; }
        public string CustomerName { get; set; }
        public string CutomerEmail { get; set; }
        public virtual ICollection<LineItem> LineItems { get; set; }
    }
}
