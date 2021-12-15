using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO_QuanLy;
namespace DAL_QuanLy
{
    public class ChuyenVien : connection
    {
        public bool themChuyenVien(quanLiChuyenVien qlcv, string maBenhNhan)
        {
            conn.Open();
            string sql = string.Format("insert into ChuyenVien (MaBenhNhan, MaBenhAn, NgayChuyen, NoiDen) values ('{0}', '{1}', '{2}', N'{3}')", qlcv.MaBenhNhan, qlcv.MaBenhAn, qlcv.NgayChuyen, qlcv.NoiDen);
            string sql1 = string.Format("delete from NoiTru where MaBenhNhan='{0}'", maBenhNhan);

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlCommand cmd1 = new SqlCommand(sql1, conn);
            // Query và kiểm tra
            if (cmd.ExecuteNonQuery() > 0 && cmd1.ExecuteNonQuery() > 0)
                return true;
            return false;
        }
    }
}
