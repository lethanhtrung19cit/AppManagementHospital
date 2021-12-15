using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO_QuanLy;
namespace DAL_QuanLy
{
    public class DichVu : connection
    {
        public DataTable getDichVu()
        {
            conn = new SqlConnection("Data Source=DESKTOP-76IH46T\\SQLEXPRESS;Initial Catalog=quanlibenhvien;Persist Security Info=True;User ID=sa;Password=lethanhtrung");
            SqlDataAdapter da = new SqlDataAdapter("select  bn.MaBenhNhan 'Mã bệnh nhân', TenBenhNhan'Tên bệnh nhân', TenDichVu 'Tên dịch vụ', ThanhGia 'Thành giá', DonViTinh 'Đơn vị tính', SoLanSuDung 'Số lần sử dụng', TongTien 'Tổng tiền', ctdv.GhiChu 'Ghi chú', picture 'Ảnh' from BenhNhan bn inner join (ChiTietDichVu ctdv inner join DichVu dv on ctdv.MaDichVu = dv.MaDichVu) on bn.MaBenhNhan = ctdv.MaBenhNhan", conn);
            DataTable dtDichVu = new DataTable();
            da.Fill(dtDichVu);

            return dtDichVu;

        }
        public bool themDichVu(QuanLyDichVu thuoc)
        {
            conn.Open();
            string sql = string.Format("insert into DichVu values('{0}', N'{1}', {2}, N'{3}', N'{4}')", thuoc.MaDichVu, thuoc.TenDichVu, thuoc.ThanhGia, thuoc.DonViTinh, thuoc.GhiChu1);
            SqlCommand cmd = new SqlCommand(sql, conn);

            // Query và kiểm tra
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }
        public bool suadichvu(QuanLyDichVu thuoc)
        {
            conn.Open();
            string sql = string.Format("update DichVu set TenDichVu=N'{0}', ThanhGia=N'{1}', DonViTinh=N'{2}', GhiChu=N'{3}' where MaDichVu=N'{4}'", thuoc.TenDichVu, thuoc.ThanhGia, thuoc.DonViTinh, thuoc.GhiChu1, thuoc.MaDichVu);
            SqlCommand cmd = new SqlCommand(sql, conn);

            // Query và kiểm tra
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }
        public bool xoataikhoan(string maDichVu)
        {
            conn.Open();
            string sql = string.Format("delete from DichVu where MaDichVu='{0}'", maDichVu);
            SqlCommand cmd = new SqlCommand(sql, conn);

            // Query và kiểm tra
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }
        public DataTable danhSachDivhVu()
        {
            conn = new SqlConnection("Data Source=DESKTOP-76IH46T\\SQLEXPRESS;Initial Catalog=quanlibenhvien;Persist Security Info=True;User ID=sa;Password=lethanhtrung");
            SqlDataAdapter da = new SqlDataAdapter("select MaDichVu'Mã dịch vụ', TenDichVu 'Tên dịch vụ', ThanhGia 'Thành giá', DonViTinh 'Đơn vị tính', GhiChu 'Ghi chú' from dichvu", conn);
            DataTable dtDichVu = new DataTable();
            da.Fill(dtDichVu);

            return dtDichVu;

        }
        public bool themSDDV(QuanLyDichVu dv, string tenDichVu)
        {
            conn.Open();
            string sql = string.Format("insert into ChiTietDichVu (MaBenhNhan, MaDichVu, SoLanSuDung, TongTien) values ('{0}', '{1}', {2}, {3})", dv.MaBenhNhan, dv.MaDichVu, 1, dv.TongTien);
            string sql1 = string.Format("update NoiTru set DichVuSuDung=N'" + tenDichVu + "'");
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlCommand cmd1 = new SqlCommand(sql1, conn);
            // Query và kiểm tra
            if (cmd.ExecuteNonQuery() > 0 && cmd1.ExecuteNonQuery() > 0)
                return true;
            return false;
        }
        public bool suaSoLanSuDung(int count, string maBenhNhan, string maDichVu, double tongTien)
        {
            conn.Open();
            string sql = string.Format("update ChiTietDichVu set SoLanSuDung={0}, TongTien={1} where MaBenhNhan='{2}' and MaDichVu='{3}'", count, tongTien, maBenhNhan, maDichVu);
            SqlCommand cmd = new SqlCommand(sql, conn);

            // Query và kiểm tra
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }
        public int soLanSuDung(string maDichVu, string maBenhNhan)
        {
            conn.Open();
            string sql = string.Format("select sum(SoLanSuDung) from ChiTietDichVu where MaBenhNhan='{0}' and MaDichVu='{1}'", maBenhNhan, maDichVu);
            SqlCommand a = new SqlCommand(sql, conn);
           
            int a1 = (int)a.ExecuteScalar();
            
            conn.Close();
            return a1;
        }
        public int tonTaisoLanSuDung(string maDichVu, string maBenhNhan)
        {
            conn.Open();
            string sql = string.Format("select count(SoLanSuDung) from ChiTietDichVu where MaBenhNhan='{0}' and MaDichVu='{1}'", maBenhNhan, maDichVu);
            SqlCommand a = new SqlCommand(sql, conn);

            int a1 = (int)a.ExecuteScalar();

            conn.Close();
            return a1;
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
        public string tenDichVu(string maDichVu)
        {
            conn.Open();
            string sql = string.Format("select TenDichVu from DichVu where MaDichVu='" + maDichVu + "'");
            SqlCommand a = new SqlCommand(sql, conn);
            string a1 =(string) a.ExecuteScalar();

            conn.Close();
            return a1;
        }
        public double dongia(string maDichVu)
        {
            conn.Open();
            //string sql = string.Format("select ThanhGia from DichVu where MaDichVu='" + maDichVu + "'");
            string sql = string.Format("select ThanhGia from DichVu where MaDichVu='XN'");
            SqlCommand a = new SqlCommand(sql, conn);
            double a1 = (double)a.ExecuteScalar();

            conn.Close();
            return a1;
           
           
        }
        public int tonTaiDichVu(string maBenhNhan)
        {
            conn.Open();
            string sql = string.Format("select count(TongTien) from ChiTietDichVu where MaBenhNhan='" + maBenhNhan + "'");
            SqlCommand a = new SqlCommand(sql, conn);
            int a1 = (int)a.ExecuteScalar();

            conn.Close();
            return a1;
        }
        public double tienDichVu(string maBenhNhan)
        {
            conn.Open();
            string sql = string.Format("select sum(TongTien) from ChiTietDichVu where MaBenhNhan='" + maBenhNhan + "'");
            SqlCommand a = new SqlCommand(sql, conn);
            double a1 = (double)a.ExecuteScalar();

            conn.Close();
            return a1;
        }
        public bool suaThanhToan(string maChiTietDV)
        {
            conn.Open();
            string sql = string.Format("update ChiTietDichVu set GhiChu=N'Đã thanh toán' where MaChiTietDV='{0}'", maChiTietDV);
            SqlCommand cmd = new SqlCommand(sql, conn);

            // Query và kiểm tra
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
            conn.Close();
        }
    }
}
