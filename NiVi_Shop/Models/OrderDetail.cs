namespace NiVi_Shop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderDetail")]
    public partial class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }

        public int OrderID { get; set; }

        public int ProductID { get; set; }

        public double Price { get; set; }

        public int? Quantity { get; set; }

        public virtual Orders Order { get; set; }

        public virtual Product Product { get; set; }
    }
}
