using System;
using System.Collections.Generic;

namespace CMPG323_Project2_API.Models
{
    public partial class OrderDetail
    {
        public short OrderDetailsId { get; set; }
        public short OrderId { get; set; }
        public short ProductId { get; set; }
        public int Quantity { get; set; }
        public int? Discount { get; set; }

        public virtual Order Order { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
