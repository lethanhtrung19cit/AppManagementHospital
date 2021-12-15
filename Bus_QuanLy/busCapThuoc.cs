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
    public class busCapThuoc
    {
        CapThuoc ct = new CapThuoc();
        
        public bool xoaThuoc(string tenTaiKhoan)
        {
            return ct.xoataikhoan(tenTaiKhoan);
        }
        
        public bool suaThuoc(Thuoc thuoc)
        {
            return ct.suataikhoan(thuoc);
        }
        public bool thanhtoan(string maDonthuoc)
        {
            return ct.thanhtoan(maDonthuoc);
        }
        public bool themThuoc(Thuoc thuoc)
        {
            return ct.themtaikhoan(thuoc);
        }   
        public DataTable getCapThuoc()
        {
            return ct.getDonThuoc();
        }
       
        public byte[] image(string maBenhNhan)
        {
            return ct.image(maBenhNhan);
        }
        public string tenThuoc(string maThuoc)
        {
            return ct.tenThuoc(maThuoc);
        }
        public DataTable tenThuocBN(string maBenhNhan)
        {
            return ct.tenThuocBN(maBenhNhan);
        }
        public string hoTen(string maBenhNhan)
        {
            return ct.hoTen(maBenhNhan);
        }
        public bool themDonThuoc(QuanLyDonThuoc qlct, string thuocSuDung)
        {
            return ct.themDonThuoc(qlct, thuocSuDung);

        }
        public bool suaDonThuoc(QuanLyDonThuoc qlct, string maDonThuoc)
        {
            return ct.suaDonThuoc(qlct, maDonThuoc);
        }
        public bool xoaDonThuoc(string maDonThuoc)
        {
            return ct.xoaDonThuoc(maDonThuoc);
        }
        public double tongTienThuoc(string maBenhNhan)
        {
            return ct.tongTienThuoc(maBenhNhan);
        }
        public bool suaThanhToan(string maDonThuoc)
        {
            return ct.suaThanhToan(maDonThuoc);
        }
        public DataTable danhSachThuoc()
        {
            return ct.danhSachThuoc();
        }
    }
}
