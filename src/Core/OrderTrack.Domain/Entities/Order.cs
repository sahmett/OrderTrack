using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTrack.Domain.Entities
{
    public class Order
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid CustomerId { get; set; }
        public Guid ProductId { get; set; } // producta ek referans
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Status { get; set; }

        public Address Address { get; set; }
        public Product Product { get; set; }
        public Customer Customer { get; set; } // müşteriye ek referans

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}

