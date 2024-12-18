﻿using Dgland.Core.Abstractions;

namespace Dgland.Core.Entities
{
    public class LineItem : BaseEntity
    {
        public Guid OrderId { get; set; } 
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public string UserId { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}