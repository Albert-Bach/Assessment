using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Models
{
    internal class Order
    {
        public long Id { get; set; }

        public long PetId { get; set; }

        public long Quantity { get; set; }

        public DateTimeOffset ShipDate { get; set; }

        public OrderStatus Status { get; set; }

        public bool Complete { get; set; }


    }
}
