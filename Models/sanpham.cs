namespace DCXEMAY.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        internal List<DanhMuc> DanhMucs;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            Oderdetails = new HashSet<Oderdetail>();
        }

        [Key]
        public int IDSanpham { get; set; }

        public string TenSP { get; set; }

        public int? SoLuong { get; set; }
        [DisplayFormat(DataFormatString ="{0:0,0 vnđ}")]
        public int? GiaSP { get; set; }

        public string MoTa { get; set; }

        public string URLImage { get; set; }

        [StringLength(255)]
        public string IDDanhmuc { get; set; }

        public virtual DanhMuc DanhMuc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Oderdetail> Oderdetails { get; set; }
    }
}
