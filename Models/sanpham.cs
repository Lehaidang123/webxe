namespace DCXEMAY.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sanpham")]
    public partial class sanpham
    {
        [StringLength(50)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string id { get; set; }

        public string tiltle { get; set; }

        public string imageurl { get; set; }
    }
}
