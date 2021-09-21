namespace Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cart")]
    public partial class Cart
    {
        [Key]
        public int A_id { get; set; }

        [StringLength(100)]
        public string UserName { get; set; }

        public int? P_id { get; set; }

        public virtual Product Product { get; set; }
    }
}
