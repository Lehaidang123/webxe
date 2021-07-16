namespace DCXEMAY.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Oderdetail")]
    public partial class Oderdetail
    {
        public int ID { get; set; }

        public int? soluong { get; set; }

        public string gia { get; set; }

        public int? IDSanpham { get; set; }

        public int? Idoder { get; set; }

        public virtual Oder Oder { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
