using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLy
{
    public class HoaDon : connection
    {
        public DataTable getHoaDon(string maBenhNhan)
        {
            conn = new SqlConnection("Data Source=DESKTOP-76IH46T\\SQLEXPRESS;Initial Catalog=quanlibenhvien;Persist Security Info=True;User ID=sa;Password=lethanhtrung");
            string sql = string.Format("select MaHoaDon'Mã hóa đơn', bn.MaBenhNhan'Mã bệnh nhân', TenBenhNhan'Tên bệnh nhân', TienThuoc'Tiền thuốc', TienDichVu'Tiền dịch vụ', TienKhamBenh'Tiền khám bệnh' from HoaDon inner join BenhNhan bn on HoaDon.MaBenhNhan=bn.MaBenhNhan where bn.MaBenhNhan='"+maBenhNhan+"'");
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dtNoiTru = new DataTable();
            da.Fill(dtNoiTru);

            return dtNoiTru;

        }
        public string MaBHYT(string maBenhNhan)
        {
            conn.Open();
            string sql = string.Format("select DoiTuong from BenhNhan where MaBenhNhan='" + maBenhNhan + "'");
            SqlCommand a = new SqlCommand(sql, conn);
            String a1 = (String)a.ExecuteScalar();
            if (a.ExecuteScalar() == null) a1 = "null";
            
            
            conn.Close();
            return a1;
        }
        public bool themHoaDon(QuanLiHoaDon qlhd)
        {
            conn.Open();
            string sql = string.Format("insert into HoaDon(maBenhNhan, TienThuoc, TienDichVu, TienKhamBenh) values ('{0}', {1}, {2}, {3})" ,qlhd.MaBenhNhan, qlhd.TienThuoc, qlhd.TienDichVu, qlhd.TienKhamBenh);
            SqlCommand cmd = new SqlCommand(sql, conn);

            // Query và kiểm tra
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }
       
    }
}
