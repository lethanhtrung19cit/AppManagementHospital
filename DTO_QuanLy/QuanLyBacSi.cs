using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class QuanLyBacSi
    {
        private string  hoTen, gioiTinh, ngaySinh, diaChi, SDT, CMND, maKhoa, tenKhoa, chucVu;
       

      
        
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChi1 { get => diaChi; set => diaChi = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
        public string CMND1 { get => CMND; set => CMND = value; }
        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
        public string TenKhoa { get => tenKhoa; set => tenKhoa = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public QuanLyBacSi()
        {

        }
        public QuanLyBacSi(string hoTen, string gioiTinh, string ngaySinh, string diaChi, string sDT, string cMND, string maKhoa, string tenKhoa, string chucVu)
        {

            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
            SDT = sDT;
            CMND = cMND;
            this.maKhoa = maKhoa;
            this.tenKhoa = tenKhoa;
            this.chucVu = chucVu;
        }
    }
}
