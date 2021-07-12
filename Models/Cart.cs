using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DCXEMAY.Models
{
    public class CartItem
    {
        public SanPham _shopping_sp { get; set; }
        public int _shopping_quantity { get; set; }
    }

    public class Cart
    {
        List<CartItem> items = new List<CartItem>();
        public IEnumerable<CartItem> Items
        {
            get { return items; }
        }
        public void Add(SanPham sp, int _soluong=1)
        {
            var item = items.FirstOrDefault(s => s._shopping_sp.IDSanpham == sp.IDSanpham);
            if(item == null)
            {
                items.Add(new CartItem
                {
                    _shopping_sp = sp,
                    _shopping_quantity=_soluong
                });
              
            }
            else
            {
                item._shopping_quantity += _soluong;
            }
        }

    }
}