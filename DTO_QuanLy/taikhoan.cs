using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class taikhoan
    {
        private string tenDangNhap, matKhau, quyenTruyCap;

        public taikhoan(string tenDangNhap, string matKhau, string quyenTruyCap)
        {
            this.tenDangNhap = tenDangNhap;
            this.matKhau = matKhau;
            this.quyenTruyCap = quyenTruyCap;
        }
        public taikhoan()
        { 
           
        }
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string QuyenTruyCap { get => quyenTruyCap; set => quyenTruyCap = value; }
    }
}
