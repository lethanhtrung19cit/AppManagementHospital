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
    public class XuatVien : connection
    {
        public DataTable thongKeXuatVien(string ngayXuatVien)
        {
            conn = new SqlConnection("Data Source=DESKTOP-76IH46T\\SQLEXPRESS;Initial Catalog=quanlibenhvien;Persist Security Info=True;User ID=sa;Password=lethanhtrung");
            string sql = string.Format("set dateformat dmy select bn.MaBenhNhan'Mã bệnh nhân', TenBenhNhan 'Tên bệnh nhân', GioiTinh 'Giới tính', NgaySinh'Ngày sinh', DiaChi'Địa chỉ', NgayXuatVien'Ngày nhập viện', NgayXuatVien'Ngày xuất viện' from BenhNhan bn inner join XuatVien xv on bn.MaBenhNhan=xv.MaBenhNhan where NgayXuatVien='"+ngayXuatVien+"'");
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dtNoiTru = new DataTable();
            da.Fill(dtNoiTru);

            return dtNoiTru;
        }
        public bool themXuatVien(quanLiXuatVien qlxv)
        {
            conn.Open();
            string sql = string.Format("set dateformat dmy insert into XuatVien(MaBenhNhan, NgayXuatVien) values ('{0}', '{1}')", qlxv.MaBenhNhan, qlxv.NgayXuatVien);
            SqlCommand cmd = new SqlCommand(sql, conn);
            // Query và kiểm tra
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }
    }
}
