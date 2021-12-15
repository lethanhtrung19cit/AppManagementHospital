using DAL_QuanLy;
using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_QuanLy
{
    
    public class busTaiKhoan
    {

        sqltaikhoan sqltaikhoan = new sqltaikhoan();
        public string matKhau(taikhoan tk)
        {
            return sqltaikhoan.tentaikhoan(tk);
        }
        public bool suamatkhau(taikhoan tk)
        {
            return sqltaikhoan.suamatkhau(tk);
        }
        public bool xoaTaiKhoan(string tenTaiKhoan)
        {
            return sqltaikhoan.xoataikhoan(tenTaiKhoan);
        }
        public DataTable dsTaiKhoan()
        {
            return sqltaikhoan.getTaiKhoan();
        }
        public bool suataikhoan(taikhoan tk)
        {
            return sqltaikhoan.suataikhoan(tk);
        }
        public bool themtaikhoan(taikhoan tk)
        {
            return sqltaikhoan.themtaikhoan(tk);
        }
        public bool kiemtratontai(string tenDangNhap)
        {
            return sqltaikhoan.kiemtratontai(tenDangNhap);
        }
    }
}
