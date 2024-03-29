﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class ChiTietKhamBenh 
    {
        private string maKhambenh, maBenhNhan, nhomMau, tinhTrang, chuanDoanSoBo,  huongDieuTri, maBacSi, bacSiPhuTrach, chuanDoanSauCung, ngayKham, phongKham, ghiChu;
        private float canNang, nhietDo, mach, huyetAp, nhipTho;
        public ChiTietKhamBenh()
        {

        }

        public ChiTietKhamBenh(string chuanDoanSauCung, string ngayKham, string phongKham)
        {
            this.chuanDoanSauCung = chuanDoanSauCung;
            this.ngayKham = ngayKham;
            this.phongKham = phongKham;
        }

        public ChiTietKhamBenh(string maKhambenh, string nhomMau, string tinhTrang, string chuanDoanSoBo, string chuanDoanSauCung, string huongDieuTri, float canNang, float nhietDo, float mach, float huyetAp, float nhipTho, string bacSiPhuTrach, string maBenhNhan, string ngayKham, string phongKham)
        {
            this.maKhambenh = maKhambenh;
            this.nhomMau = nhomMau;
            this.tinhTrang = tinhTrang;
            this.chuanDoanSoBo = chuanDoanSoBo;
            this.chuanDoanSauCung = chuanDoanSauCung;
            this.huongDieuTri = huongDieuTri;
           
            this.bacSiPhuTrach = bacSiPhuTrach;
            this.canNang = canNang;
            this.nhietDo = nhietDo;
            this.mach = mach;
            this.huyetAp = huyetAp;
            this.nhipTho = nhipTho;
            NgayKham = ngayKham;
            PhongKham = phongKham;
            this.maBenhNhan = maBenhNhan;
        }

        public string MaKhambenh { get => maKhambenh; set => maKhambenh = value; }
        public string NhomMau { get => nhomMau; set => nhomMau = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public string ChuanDoanSoBo { get => chuanDoanSoBo; set => chuanDoanSoBo = value; }
        public string ChuanDoanSauCung { get => chuanDoanSauCung; set => chuanDoanSauCung = value; }
        public string HuongDieuTri { get => huongDieuTri; set => huongDieuTri = value; }
        public float CanNang { get => canNang; set => canNang = value; }
        public float NhietDo { get => nhietDo; set => nhietDo = value; }
        public float Mach { get => mach; set => mach = value; }
        public float HuyetAp { get => huyetAp; set => huyetAp = value; }
        public float NhipTho { get => nhipTho; set => nhipTho = value; }
        public string MaBacSi { get => maBacSi; set => maBacSi = value; }
        public string BacSiPhuTrach { get => bacSiPhuTrach; set => bacSiPhuTrach = value; }
        public string NgayKham { get => ngayKham; set => ngayKham = value; }
        public string PhongKham { get => phongKham; set => phongKham = value; }
        public string MaBenhNhan { get => maBenhNhan; set => maBenhNhan = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
    }
}
