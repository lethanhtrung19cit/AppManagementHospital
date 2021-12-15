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
    public class KhamBenh : connection
    {
        public bool themCTKB(ChiTietKhamBenh ctkb, Danhsachchokham dsck)
        {
            conn.Open();
            string sql = string.Format("set dateformat dmy insert into ChiTietKhamBenh(MaKhamBenh, CanNang, NhomMau, NhietDo, Mach, HuyetAp, NhipTho, TinhTrang, ChuanDoanSoBo, ChuanDoanSauCung, HuongDieuTri, MaBacSi, BacSiPhuTrach, MaBenhNhan, NgayKham, PhongKham, GhiChu) values('{0}', {1}, '{2}', {3}, {4}, {5}, {6}, N'{7}', N'{8}', N'{9}', N'{10}', '{11}', N'{12}', '{13}', '{14}', '{15}', N'{16}')",ctkb.MaKhambenh, ctkb.CanNang, ctkb.NhomMau, ctkb.NhietDo, ctkb.Mach, ctkb.HuyetAp, ctkb.NhipTho, ctkb.TinhTrang, ctkb.ChuanDoanSoBo, ctkb.ChuanDoanSauCung, ctkb.HuongDieuTri, ctkb.MaBacSi, ctkb.BacSiPhuTrach, ctkb.MaBenhNhan, ctkb.NgayKham, ctkb.PhongKham, "Chưa thanh toán");
            SqlCommand cmd = new SqlCommand(sql, conn);
            string sql1 = string.Format("delete from dsck where MaBenhNhan='{0}'", dsck.MaBenhNhan);
            SqlCommand cmd1 = new SqlCommand(sql1, conn);
            // Query và kiểm tra
            if (cmd.ExecuteNonQuery() > 0 && cmd1.ExecuteNonQuery() > 0)
                return true;
            return false;
            conn.Close();
        }
        //public
        public bool suaThanhToan(string maKhamBenh)
        {
            conn.Open();
            string sql = string.Format("update ChiTietKhamBenh set GhiChu=N'Đã thanh toán' where MaKhamBenh='{0}'", maKhamBenh);
            SqlCommand cmd = new SqlCommand(sql, conn);
           
            // Query và kiểm tra
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
            conn.Close();
        }
        public string tenBenh(string maKhamBenh)
        {
            conn.Open();
            string sql = string.Format("select ChuanDoanSauCung from ChiTietKhamBenh where MaKhamBenh='{0}'", maKhamBenh);
            SqlCommand a = new SqlCommand(sql, conn);
            String a1 = (String)a.ExecuteScalar();
            conn.Close();

            return a1;
        }
        public DataTable getKhoaKham()
        {
            conn = new SqlConnection("Data Source=DESKTOP-76IH46T\\SQLEXPRESS;Initial Catalog=quanlibenhvien;Persist Security Info=True;User ID=sa;Password=lethanhtrung");
            SqlDataAdapter da = new SqlDataAdapter("select Khoa from KhoaBacSi", conn);
            DataTable dtNoiTru = new DataTable();
            da.Fill(dtNoiTru);

            return dtNoiTru;

        }
        
        public DataTable tenBacSi(string khoa)
        {
            conn = new SqlConnection("Data Source=DESKTOP-76IH46T\\SQLEXPRESS;Initial Catalog=quanlibenhvien;Persist Security Info=True;User ID=sa;Password=lethanhtrung");
            string sql = string.Format("select BacSi from KhoaBacSi where Khoa = N'{0}'", khoa);
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dtNoiTru = new DataTable();
            da.Fill(dtNoiTru);

            return dtNoiTru;
        }
        
    }
}
