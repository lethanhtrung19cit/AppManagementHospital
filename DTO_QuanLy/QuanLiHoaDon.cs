using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class QuanLiHoaDon
    {
        private string maBenhNhan;
        private double tienThuoc, tienDichVu, tienKhamBenh, tienVienPhi;

        public QuanLiHoaDon(string maBenhNhan, double tienThuoc, double tienDichVu, double tienKhamBenh, double tienVienPhi)
        {
            this.MaBenhNhan = maBenhNhan;
            this.TienThuoc = tienThuoc;
            this.TienDichVu = tienDichVu;
            this.TienKhamBenh = tienKhamBenh;
            this.TienVienPhi = tienVienPhi;
        }
        public QuanLiHoaDon(string maBenhNhan, double tienThuoc, double tienDichVu, double tienKhamBenh)
        {
            this.MaBenhNhan = maBenhNhan;
            this.TienThuoc = tienThuoc;
            this.TienDichVu = tienDichVu;
            this.TienKhamBenh = tienKhamBenh;
           
        }

        public string MaBenhNhan { get => maBenhNhan; set => maBenhNhan = value; }
        public double TienThuoc { get => tienThuoc; set => tienThuoc = value; }
        public double TienDichVu { get => tienDichVu; set => tienDichVu = value; }
        public double TienKhamBenh { get => tienKhamBenh; set => tienKhamBenh = value; }
        public double TienVienPhi { get => tienVienPhi; set => tienVienPhi = value; }
    }
}
