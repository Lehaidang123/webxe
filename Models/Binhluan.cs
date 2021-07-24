using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DCXEMAY.Models
{
    public class Binhluan
    {
        public string Id_binhluan { get; set; }
        public string noidung { get; set; }
        //public string ngaydanhgia { get; set; }
        public string Id_sanpham { get; set; }
        public string Id_user { get; set; }
    }
}