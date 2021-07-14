namespace DCXEMAY.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("SanPham")]
    public partial class SanPham
    {
        [Key]
        [StringLength(255)]
        public string IDSanpham { get; set; }

        public string TenSP { get; set; }

        public int? SoLuong { get; set; }
        [DisplayFormat(DataFormatString = "{0:0,0 vnđ}", ApplyFormatInEditMode = true)]
        public int? GiaSP { get; set; }

        public string MoTa { get; set; }

        public string URLImage { get; set; }

        [StringLength(255)]
        public string IDDanhmuc { get; set; }

        internal static IQueryable<SanPham> Where(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }

        public virtual DanhMuc DanhMuc { get; set; }
        public IEnumerable<DanhMuc> DanhMucs { get; set; }
    }
}
