using DAL_QuanLy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLy;
namespace Bus_QuanLy
{
    public class busNoiTru
    {
        NoiTru nt = new NoiTru();        
        public DataTable getNoiTru()
        {
            return nt.getNoiTru();
        }
        public DataTable getThongKeNhapVien(string ngayNhapVien)
        {
            return nt.thongKeNoiTru(ngayNhapVien);
        }
        public byte[] image(string maBenhNhan)
        {
            return nt.image(maBenhNhan);
        }
        public string tenBenh(string maBenhNhan)
        {
            return nt.tenBenh(maBenhNhan);
        }
        public string hoTen(string maBenhNhan)
        {
            return nt.hoTen(maBenhNhan);
        }
        public bool themNoiTru(QuanLyNoiTru qlnt)
        {
            return nt.themNoiTru(qlnt);

        }
        public bool suaNoiTru(QuanLyNoiTru qlnt, string maNoiTru)
        {
            return nt.suaNoiTru(qlnt, maNoiTru);
        }
        public bool xoaNoiTru(string maBenhNhan)
        {
            return nt.xoaNoiTru(maBenhNhan);
        }
        public DateTime ngayNhapVien(string maBenhNhan)
        {
            return nt.ngayNhapVien(maBenhNhan);
        }
        public bool suaThanhToan(string maNoiTru)
        {
            return nt.suaThanhToan(maNoiTru);
        }
        public bool thanhtoan(string maNoiTru)
        {

            return nt.thanhtoan(maNoiTru);
        }
    }
}
