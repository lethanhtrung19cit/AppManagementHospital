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
    public class sqltaikhoan : connection
    {
        taikhoan tk = new taikhoan() ;
        public DataTable getTaiKhoan()
        {
            conn = new SqlConnection("Data Source=DESKTOP-76IH46T\\SQLEXPRESS;Initial Catalog=quanlibenhvien;Persist Security Info=True;User ID=sa;Password=lethanhtrung");
            SqlDataAdapter da = new SqlDataAdapter("select TenDangNhap'Tên đăng nhập', MatKhau 'Mật khẩu', QuyenTruyCap 'Quyền truy cập' from TaiKhoan", conn);
            DataTable dtDichVu = new DataTable();
            da.Fill(dtDichVu);

            return dtDichVu;

        }
        public bool themtaikhoan(taikhoan tk)
        {
            conn.Close();
            conn.Open();
            string sql = string.Format("insert into TaiKhoan values(N'{0}', '{1}', N'{2}')", tk.TenDangNhap, tk.MatKhau, tk.QuyenTruyCap);
            SqlCommand cmd = new SqlCommand(sql, conn);

            // Query và kiểm tra
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }
        public bool suataikhoan(taikhoan tk)
        {
            conn.Close();
            conn.Open();
            string sql = string.Format("update TaiKhoan set TenDangNhap=N'{0}', MatKhau='{1}', QuyenTruyCap=N'{2}' where TenDangNhap=N'{3}'", tk.TenDangNhap, tk.MatKhau, tk.QuyenTruyCap, tk.TenDangNhap);
            SqlCommand cmd = new SqlCommand(sql, conn);

            // Query và kiểm tra
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }
        public bool xoataikhoan(string tenDangNhap)
        {
            conn.Close();
            conn.Open();
            string sql = string.Format("delete from TaiKhoan where TenDangNhap=N'{0}'", tenDangNhap);
            SqlCommand cmd = new SqlCommand(sql, conn);

            // Query và kiểm tra
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }
        public string tentaikhoan(taikhoan tk)
        {

            conn.Open();
            string sql = string.Format("select MatKhau from TaiKhoan where TenDangNhap = N'{0}' and QuyenTruyCap = N'{1}'", tk.TenDangNhap, tk.QuyenTruyCap);
            SqlCommand cmd = new SqlCommand(sql, conn);
            String a1 = (String)cmd.ExecuteScalar();
            if (cmd.ExecuteScalar()== null) a1 = "null";
            conn.Close();
            return a1;
           
           
        }
        
        public bool suamatkhau(taikhoan tk)
        {
            conn.Open();
            string sql = string.Format("update TaiKhoan set MatKhau='{0}' where TenDangNhap=N'{1}' and QuyenTruyCap=N'{2}'", tk.MatKhau, tk.TenDangNhap, tk.QuyenTruyCap);
            SqlCommand cmd = new SqlCommand(sql, conn);

            // Query và kiểm tra
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }
        
        public bool kiemtratontai(string tenDangNhap)
        {
            conn.Close();
            conn.Open();
            string sql = string.Format("select TenDangNhap from TaiKhoan where TenDangNhap=N'{0}'", tenDangNhap);
            SqlCommand cmd = new SqlCommand(sql, conn);
            
            if (cmd.ExecuteScalar() == null)                      
                return true;
            return false;
            
        }
    }
}
