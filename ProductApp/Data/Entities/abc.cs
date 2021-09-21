namespace Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("abc")]
    public partial class abc
    {
        public int id { get; set; }

        [StringLength(20)]
        public string name { get; set; }
    }
}
