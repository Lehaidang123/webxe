namespace DCXEMAY.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Oder")]
    public partial class Oder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Oder()
        {
            Oderdetails = new HashSet<Oderdetail>();
        }

        [Key]
        public int Idoder { get; set; }

        public DateTime? NGay { get; set; }

        [StringLength(255)]
        public string Diachi { get; set; }

        [StringLength(255)]
        public string Tenkh { get; set; }
        [StringLength(255)]
        public string sdt { get; set; }

        [StringLength(255)]
        public string mail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Oderdetail> Oderdetails { get; set; }
    }
}
