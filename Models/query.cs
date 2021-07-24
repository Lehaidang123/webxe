using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DCXEMAY.Models
{
    public class query
    {
        SqlDataAdapter db = new SqlDataAdapter();

        public bool Createcmt(Binhluan model, string Id_sanpham)
        {

            //string sql1 = " insert into BinhLuan(NoiDung,IDSanpham,ID) values(N'" + model.noidung + "','" + Id_sanpham + "','" + model.Id_user + "')";
            //SqlConnection con = db.GetConnection();

            //SqlCommand cmd1 = new SqlCommand(sql1, con);

            //con.Open();

            //var kq1 = cmd1.ExecuteNonQuery();

            //con.Close();

            //return kq1 > 0;

        }
    }
}