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
        [Key]
        [StringLength(255)]
        public string IDSanpham { get; set; }

        public string TenSP { get; set; }

        public int? SoLuong { get; set; }
        [DisplayFormat(DataFormatString = "{0:C0}", ApplyFormatInEditMode = true)]
        public int? GiaSP { get; set; }

        public string MoTa { get; set; }

        public string URLImage { get; set; }

        [StringLength(255)]
        public string IDDanhmuc { get; set; }

        public virtual DanhMuc DanhMuc { get; set; }
        public IEnumerable<DanhMuc> DanhMucs { get; set; }
    }
}
