namespace Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            Carts = new HashSet<Cart>();
            OrderHs = new HashSet<OrderH>();
        }

        [Key]
        public int P_id { get; set; }

        public int Ram { get; set; }

        public int Storage { get; set; }

        [Required]
        [StringLength(20)]
        public string Color { get; set; }

        public int Price { get; set; }

        public bool Statuss { get; set; }

        public int? CN_id { get; set; }

        public int? S_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cart> Carts { get; set; }

        public virtual Company Company { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderH> OrderHs { get; set; }

        public virtual Store Store { get; set; }
    }
}
