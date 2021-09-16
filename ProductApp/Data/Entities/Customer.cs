namespace Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            Logins = new HashSet<Login>();
        }

        public int Id { get; set; }

        [StringLength(100)]
        public string F_Name { get; set; }

        [StringLength(100)]
        public string L_Name { get; set; }

        [StringLength(100)]
        public string Dob { get; set; }

        [StringLength(100)]
        public string Mobile { get; set; }

        [StringLength(225)]
        public string Email { get; set; }

        [StringLength(225)]
        public string Locations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Login> Logins { get; set; }
    }
}
