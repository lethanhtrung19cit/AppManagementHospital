using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class QuanLyDichVu
    {
        private string  maBenhNhan, maDichVu, tenDichVu, donViTinh, GhiChu;
        private double tongTien, thanhGia;
        private int soLanSuDung;
        public QuanLyDichVu()
        {

        }

       

        public QuanLyDichVu(string maBenhNhan, string maDichVu, int soLanSuDung, double tongTien)
        {

            MaBenhNhan = maBenhNhan;
            this.maDichVu = maDichVu;
            this.TongTien = tongTien;
            this.SoLanSuDung = soLanSuDung;
        }

        public QuanLyDichVu(string maDichVu, string tenDichVu, double thanhGia, string donViTinh, string ghiChu)
        {
            this.maDichVu = maDichVu;
            this.tenDichVu = tenDichVu;
            this.donViTinh = donViTinh;
            GhiChu = ghiChu;
            this.thanhGia = thanhGia;
        }

        public string MaBenhNhan { get => maBenhNhan; set => maBenhNhan = value; }
        public string MaDichVu { get => maDichVu; set => maDichVu = value; }
        public double TongTien { get => tongTien; set => tongTien = value; }
        public int SoLanSuDung { get => soLanSuDung; set => soLanSuDung = value; }
        public string TenDichVu { get => tenDichVu; set => tenDichVu = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public string GhiChu1 { get => GhiChu; set => GhiChu = value; }
        public double ThanhGia { get => thanhGia; set => thanhGia = value; }
    }
}
