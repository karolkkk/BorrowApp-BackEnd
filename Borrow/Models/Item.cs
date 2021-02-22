using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Borrow.Models
{
    public class Item
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
        public string Owner { get; set; }
        public decimal Price { get; set; }
        public bool Status { get; set; }
        public byte[] Image { get; set; }

    }
}
