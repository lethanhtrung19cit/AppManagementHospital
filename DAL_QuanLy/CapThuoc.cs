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
    public class CapThuoc : connection
    {
        public DataTable getDonThuoc()
        {
            conn = new SqlConnection("Data Source=DESKTOP-76IH46T\\SQLEXPRESS;Initial Catalog=quanlibenhvien;Persist Security Info=True;User ID=sa;Password=lethanhtrung");
            SqlDataAdapter da = new SqlDataAdapter("select  MaDonThuoc 'Mã đơn thuốc',bn.MaBenhNhan'Mã bệnh nhân', TenBenhNhan 'Tên bệnh nhân', GioiTinh 'Giới tính', NgaySinh'Ngày sinh', DiaChi'Địa chỉ', Thuoc.MaThuoc'Mã thuốc', Thuoc.TenThuoc 'Tên thuốc', LieuDung'Liều dùng', ctdt.GhiChu'Ghi chú',  picture'Ảnh' from Thuoc inner join (ChiTietDonThuoc ctdt inner join BenhNhan bn on ctdt.MaBenhNhan=bn.MaBenhNhan) on Thuoc.MaThuoc=ctdt.MaThuoc", conn);
            DataTable dtDonThuoc = new DataTable();
            da.Fill(dtDonThuoc);

            return dtDonThuoc;

        }
        
        public bool themtaikhoan(Thuoc thuoc)
        {
            conn.Open();
            string sql = string.Format("insert into Thuoc values('{0}', N'{1}', {2}, N'{3}', N'{4}')", thuoc.MaThuoc, thuoc.TenThuoc, thuoc.Gia, thuoc.DonViTinh, thuoc.GhiChu);
            SqlCommand cmd = new SqlCommand(sql, conn);

            // Query và kiểm tra
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }
        public bool suataikhoan(Thuoc thuoc)
        {
            conn.Open();
            string sql = string.Format("update Thuoc set TenThuoc=N'{0}', Gia=N'{1}', DonViTinh=N'{2}', GhiChu=N'{3}' where MaThuoc=N'{4}'", thuoc.TenThuoc, thuoc.Gia, thuoc.DonViTinh, thuoc.GhiChu, thuoc.MaThuoc);
            SqlCommand cmd = new SqlCommand(sql, conn);

            // Query và kiểm tra
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }
        public bool xoataikhoan(string maThuoc)
        {
            conn.Open();
            string sql = string.Format("delete from Thuoc where MaThuoc='{0}'", maThuoc);
            SqlCommand cmd = new SqlCommand(sql, conn);

            // Query và kiểm tra
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }
        public DataTable danhSachThuoc()
        {
            conn = new SqlConnection("Data Source=DESKTOP-76IH46T\\SQLEXPRESS;Initial Catalog=quanlibenhvien;Persist Security Info=True;User ID=sa;Password=lethanhtrung");
            SqlDataAdapter da = new SqlDataAdapter("select MaThuoc'Mã thuốc', TenThuoc'Tên thuốc', Gia 'Giá', DonViTinh'Đơn vị tính', GhiChu'Ghi chú' from Thuoc", conn);
            DataTable dtDonThuoc = new DataTable();
            da.Fill(dtDonThuoc);

            return dtDonThuoc;

        }
        public bool themDonThuoc(QuanLyDonThuoc qldt, string thuocSuDung)
        {
            conn.Open();
            string sql = string.Format("set dateformat dmy insert into ChiTietDonThuoc (MaBenhNhan, MaThuoc, LieuDung, GhiChu) values ('{0}', '{1}', N'{2}', N'{3}')", qldt.MaBenhNhan, qldt.MaThuoc, qldt.LieuDung, qldt.GhiChu);
            SqlCommand cmd = new SqlCommand(sql, conn);
            string sql1 = string.Format("update NoiTru set ThuocSuDung=N'"+thuocSuDung+"'");
            SqlCommand cmd1 = new SqlCommand(sql1, conn);
            // Query và kiểm tra
            if (cmd.ExecuteNonQuery() > 0 && cmd1.ExecuteNonQuery() > 0)
                return true;
            return false;
        }
        public bool thanhtoan(string maBenhNhan)
        {
            conn.Open();
            string sql = string.Format("select GhiChu from ChiTietDonThuoc where MaDonThuoc = '" + maBenhNhan + "'");
            SqlCommand cmd = new SqlCommand(sql, conn);

            if (cmd.ExecuteScalar().Equals("Đã thanh toán")) return true;
            conn.Close();
            return false;

        }
        public bool suaDonThuoc(QuanLyDonThuoc qldt, string maDonThuoc)
        {
            conn.Open();
            string sql = string.Format("set dateformat dmy update ChiTietDonThuoc set MaBenhNhan ='{0}', MaThuoc='{1}', LieuDung=N'{2}', GhiChu=N'{3}' where MaDonThuoc='{4}'", qldt.MaBenhNhan, qldt.MaThuoc, qldt.LieuDung, qldt.GhiChu, maDonThuoc);
            SqlCommand cmd = new SqlCommand(sql, conn);

            // Query và kiểm tra
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }
        public bool xoaDonThuoc(string maDonThuoc)
        {
            conn.Open();
            string sql = string.Format("delete from ChiTietDonThuoc where MaDonThuoc='{0}'", maDonThuoc);
            SqlCommand cmd = new SqlCommand(sql, conn);

            // Query và kiểm tra
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }
        public byte[] image(string maBenhNhan)
        {
            conn.Open();
            string sql = string.Format("select picture from BenhNhan where MaBenhNhan='" + maBenhNhan + "'");
            SqlCommand a = new SqlCommand(sql, conn);
            byte[] a1 = (byte[])a.ExecuteScalar();

            conn.Close();
            return a1;
        }
        public string hoTen(string maBenhNhan)
        {
            conn.Open();
            string sql = string.Format("select TenBenhNhan from BenhNhan where MaBenhNhan='" + maBenhNhan + "'");
            SqlCommand a = new SqlCommand(sql, conn);
            String a1 = (String)a.ExecuteScalar();

            conn.Close();
            return a1;
        }
        public string tenThuoc(string maThuoc)
        {
            conn.Open();
            string sql = string.Format("select TenThuoc from Thuoc where MaThuoc='" + maThuoc + "'");
            SqlCommand a = new SqlCommand(sql, conn);
            String a1 = (String)a.ExecuteScalar();
            conn.Close();
            return a1;
        }
        public DataTable tenThuocBN(string maBenhNhan)
        {
            conn.Open();
            string sql = string.Format("select TenThuoc, Gia from Thuoc inner join ChiTietDonThuoc ctdt on Thuoc.MaThuoc=ctdt.MaThuoc where MaBenhNhan='" + maBenhNhan + "'");
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dtDonThuoc = new DataTable();
            da.Fill(dtDonThuoc);

            return dtDonThuoc;
        }
        public double tongTienThuoc(string maBenhNhan)
        {
            conn.Open();
            string sql = string.Format("select sum(Gia) from Thuoc inner join ChiTietDonThuoc ctdt on Thuoc.MaThuoc=ctdt.MaThuoc where MaBenhNhan='" + maBenhNhan+ "'");
            SqlCommand a = new SqlCommand(sql, conn);
            double a1 = (double)a.ExecuteScalar();
            conn.Close();
            return a1;
        }
        public bool suaThanhToan(string maDonThuoc)
        {
            conn.Open();
            string sql = string.Format("update ChiTietDonThuoc set GhiChu=N'Đã thanh toán' where MaDonThuoc='{0}'", maDonThuoc);
            SqlCommand cmd = new SqlCommand(sql, conn);

            // Query và kiểm tra
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
            conn.Close();
        }
    }
}
