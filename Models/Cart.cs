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

        public void updateQuantity(int id , int soluong)
        {
            var item = items.Find(s => s._shopping_sp.IDSanpham == id);
            if(item != null)
            {
                item._shopping_quantity = soluong;
            }    
        }

        public double tongtien()
        {

            var Total = items.Sum(s => s._shopping_sp.GiaSP * s._shopping_quantity);
            return (double)Total;
         }
        public void Remove(int id)
        {
            items.RemoveAll(s => s._shopping_sp.IDSanpham == id);

        }
        public int Total_quantity_Cart()
        {
            return items.Sum(s => s._shopping_quantity);
        }
        public void ClearCart()
        {
            items.Clear();
        }

    }
}