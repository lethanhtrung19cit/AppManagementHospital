using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLy;
namespace DAL_QuanLy 
{
    public class NoiTru : connection
    {
        public DataTable getNoiTru()
        {
            conn = new SqlConnection("Data Source=DESKTOP-76IH46T\\SQLEXPRESS;Initial Catalog=quanlibenhvien;Persist Security Info=True;User ID=sa;Password=lethanhtrung");
            SqlDataAdapter da = new SqlDataAdapter("select MaNoiTru'Mã nội trú', bn.MaBenhNhan'Mã bệnh nhân', TenBenhNhan 'Tên bệnh nhân', GioiTinh 'Giới tính', NgaySinh'Ngày sinh', DiaChi'Địa chỉ', MaGiuong'Mã giường', ThuocSuDung'Thuốc sử dụng',DichVuSuDung'Dịch vụ sử dụng', Phong'Phòng', NgayNhapVien'Ngày nhập viện', picture'Ảnh' from NoiTru nt inner join BenhNhan bn on nt.MaBenhNhan=bn.MaBenhNhan", conn);
            DataTable dtNoiTru = new DataTable();
            da.Fill(dtNoiTru);

            return dtNoiTru;

        }
        public DataTable thongKeNoiTru(string ngayNhapVien)
        {
            conn = new SqlConnection("Data Source=DESKTOP-76IH46T\\SQLEXPRESS;Initial Catalog=quanlibenhvien;Persist Security Info=True;User ID=sa;Password=lethanhtrung");
            string sql = ("set dateformat dmy select MaNoiTru'Mã nội trú', bn.MaBenhNhan'Mã bệnh nhân', TenBenhNhan 'Tên bệnh nhân', GioiTinh 'Giới tính', NgaySinh'Ngày sinh', DiaChi'Địa chỉ', MaGiuong'Mã giường', ThuocSuDung'Thuốc sử dụng',DichVuSuDung'Dịch vụ sử dụng', Phong'Phòng', NgayNhapVien'Ngày nhập viện', picture'Ảnh' from NoiTru nt inner join BenhNhan bn on nt.MaBenhNhan=bn.MaBenhNhan where NgayNhapVien='"+ngayNhapVien+"'");
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dtNoiTru = new DataTable();
            da.Fill(dtNoiTru);

            return dtNoiTru;

        }
        public bool themNoiTru(QuanLyNoiTru qlnt)
        {
            conn.Close();
            conn.Open();
            string sql = string.Format("set dateformat dmy insert into NoiTru (MaBenhNhan, MaGiuong, Phong, NgayNhapVien, GhiChu) values ('{0}', '{1}', '{2}', '{3}', '{4}')", qlnt.MaBenhNhan1, qlnt.MaGiuong1, qlnt.Phong1, qlnt.NgayVaoVien1, "Chưa thanh toán");
            SqlCommand cmd = new SqlCommand(sql, conn);
            
            // Query và kiểm tra
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }
        public bool suaNoiTru(QuanLyNoiTru qlnt, string maNoiTru)
        {
            conn.Open();
            string sql = string.Format("set dateformat dmy update NoiTru set MaGiuong ='{0}', ThuocSuDung=N'{1}', DichVuSuDung=N'{2}', Phong='{3}', NgayNhapVien='{4}' where MaNoiTru='{5}'", qlnt.MaGiuong1, qlnt.ThuocSuDung1,qlnt.DichVuSuDung1, qlnt.Phong1, qlnt.NgayVaoVien1, maNoiTru);
            SqlCommand cmd = new SqlCommand(sql, conn);

            // Query và kiểm tra
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }
        public bool xoaNoiTru(string maBenhNhan)
        {
            conn.Open();
            string sql = string.Format("delete from NoiTru where MaNoiTru='{0}'",  maBenhNhan);
            SqlCommand cmd = new SqlCommand(sql, conn);

            // Query và kiểm tra
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }
        public byte[] image(string maBenhNhan)
        {
            conn.Open();
            string sql = string.Format("select picture from BenhNhan where MaBenhNhan='"+maBenhNhan+"'");
            SqlCommand a = new SqlCommand(sql, conn);
            byte[] a1 = (byte[])a.ExecuteScalar();

            conn.Close();
            return a1;
        }
        public string hoTen(string maBenhNhan)
        {
            conn.Open();
            string sql = string.Format("select TenBenhNhan from BenhNhan where MaBenhNhan='" + maBenhNhan+"'");
            SqlCommand a = new SqlCommand(sql, conn);
            String a1 = (String)a.ExecuteScalar();

            conn.Close();
            return a1;
        }
        public string tenBenh(string maBenhNhan)
        {
            conn.Open();
            string sql = string.Format("select ChuanDoanSauCung from BenhNhan bn inner join ChiTietKhamBenh ctkb on bn.MaBenhNhan=ctkb.MaBenhNhan where bn.MaBenhNhan='" + maBenhNhan + "'");
            SqlCommand a = new SqlCommand(sql, conn);
            String a1 = (String)a.ExecuteScalar();
            conn.Close();
            return a1;
        }
        public DateTime ngayNhapVien(string maBenhNhan)
        {
            conn.Open();
            string sql = string.Format("set dateformat dmy select NgayNhapVien from BenhNhan bn inner join NoiTru nt on bn.MaBenhNhan=nt.MaBenhNhan where bn.MaBenhNhan='{0}'", maBenhNhan);
            SqlCommand a = new SqlCommand(sql, conn);
            DateTime a1 = (DateTime)a.ExecuteScalar();
            conn.Close();
            return a1;
        }
       
        public bool suaThanhToan(string maNoiTru)
        {
            
            conn.Open();
            string sql = string.Format("update NoiTru set GhiChu=N'Đã thanh toán' where MaNoiTru='{0}'", maNoiTru);
            SqlCommand cmd = new SqlCommand(sql, conn);

            // Query và kiểm tra
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;           
        }
        public bool thanhtoan(string maBenhNhan)
        {
            conn.Open();
            string sql = string.Format("select GhiChu from NoiTru where MaNoiTru = '" + maBenhNhan + "'");         
            SqlCommand cmd = new SqlCommand(sql, conn);
            
            if (cmd.ExecuteScalar().Equals("Đã thanh toán")) return true;
            conn.Close();
            return false;
            
        }
    }
}
