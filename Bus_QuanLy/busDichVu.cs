﻿using DAL_QuanLy;
using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_QuanLy
{
    public class busDichVu
    {
        DichVu busDV = new DichVu();
        public DataTable getDichVu()
        {
            return busDV.getDichVu();
        }
        public bool themDV(QuanLyDichVu qldv, string tenDichVu)
        {
            return busDV.themSDDV(qldv, tenDichVu);
        }
        public int soLanSuDungDV(string maDichVu, string maBenhNhan)
        {
            return busDV.soLanSuDung(maDichVu, maBenhNhan);
        }
        public int tonTaisoLanSuDungDV(string maDichVu, string maBenhNhan)
        {
            return busDV.tonTaisoLanSuDung(maDichVu, maBenhNhan);
        }
        public bool suaSoLanSuDungDV(int count, string maBenhNhan, string maDichVu, double tongTien)
        {
            return busDV.suaSoLanSuDung(count, maBenhNhan, maDichVu, tongTien);
        }
        public byte[] image(string maBenhNhan)
        {
            return busDV.image(maBenhNhan);
        }
        
        public string hoTen(string maBenhNhan)
        {
            return busDV.hoTen(maBenhNhan);
        }
        public string tenDichVu(string maDichVu)
        {
            return busDV.tenDichVu(maDichVu);
        }
        public double thanhGia(string maDichVu)
        {
            return busDV.dongia(maDichVu);
        }
        public double tienDichVu(string maBenhNhan)
        {
            return busDV.tienDichVu(maBenhNhan);
        }
        public int tonTaiDichVu(string maBenhNhan)
        {
            return busDV.tonTaiDichVu(maBenhNhan);
        }
        public bool busThanhToan(string maChiTietDV)
        {
            return busDV.suaThanhToan(maChiTietDV);
        }
        public DataTable danhSachDichVu()
        {
            return busDV.danhSachDivhVu();
        }
        public bool xoaDichVu(string tenTaiKhoan)
        {
            return busDV.xoataikhoan(tenTaiKhoan);
        }
        public DataTable dsTaiKhoan()
        {
            return busDV.getDichVu();
        }
        public bool suaDichVu(QuanLyDichVu dichvu)
        {
            return busDV.suadichvu(dichvu);
        }
        public bool themDichVu(QuanLyDichVu dichvu)
        {
            return busDV.themDichVu(dichvu);
        }
    }
}