using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DTO_QuanLy
{

    public class DTO_QuanLyBenhNhan 
    {

        private string gioiTinh, diachi, SDT, doiTuong, ngheNghiep, CMND, maBHYT, mabenhAn;
        //private DTO_QuanLy
        public string CMND1
        {
            get { return CMND; }
            set { CMND = value; }
        }

        public string NgheNghiep
        {
            get { return ngheNghiep; }
            set { ngheNghiep = value; }
        }
   
        public string DoiTuong
        {
            get { return doiTuong; }
            set { doiTuong = value; }
        }

        public string SDT1
        {
            get { return SDT; }
            set { SDT = value; }
        }

        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }

        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        
        private string TenBenhNhan;

        public string TenBenhNhan1
        {
            get { return TenBenhNhan; }
            set { TenBenhNhan = value; }
        }
        private string NgaySinh;

        public string NgaySinh1
        {
            get { return NgaySinh; }
            set { NgaySinh = value; }
        }
        private string MaBenhAn;

        public string MaBenhAn1
        {
            get { return MaBenhAn; }
            set { MaBenhAn = value; }
        }
       
        public string MaBHYT1
        {
            get { return maBHYT; }
            set { maBHYT = value; }
        }

        
        public string MabenhAn { get => mabenhAn; set => mabenhAn = value; }

        public DTO_QuanLyBenhNhan()
        {

        }
        public DTO_QuanLyBenhNhan(string TenBenhNhan, string gioiTinh, string NgaySinh, string diaChi, string ngheNghiep, string SDT, string doiTuong, string CMND)
        {

            this.TenBenhNhan = TenBenhNhan;
            this.gioiTinh = gioiTinh;
            this.NgaySinh = NgaySinh;
            this.diachi = diaChi;
            this.ngheNghiep = ngheNghiep;
            this.SDT = SDT;
            this.doiTuong = doiTuong;
            this.CMND = CMND;


        }
        public DTO_QuanLyBenhNhan(string TenBenhNhan, string gioiTinh, string NgaySinh, string diaChi, string ngheNghiep, string SDT, string doiTuong, string CMND, string maBHYT)
        {

            this.TenBenhNhan = TenBenhNhan;
            this.gioiTinh = gioiTinh;
            this.NgaySinh = NgaySinh;
            this.diachi = diaChi;
            this.ngheNghiep = ngheNghiep;
            this.SDT = SDT;
            this.doiTuong = doiTuong;
            this.CMND = CMND;
            this.maBHYT = maBHYT;
           
        }
    }
    
}
