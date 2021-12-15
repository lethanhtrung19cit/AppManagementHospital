using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class quanLiChuyenVien
    {
        private string maBenhNhan, hoTen, maBenhAn, ngayChuyen, noiDen;

        public quanLiChuyenVien(string maBenhNhan, string hoTen, string maBenhAn, string ngayChuyen, string noiDen)
        {
            this.maBenhNhan = maBenhNhan;
            this.hoTen = hoTen;
            this.maBenhAn = maBenhAn;
            this.ngayChuyen = ngayChuyen;
            this.noiDen = noiDen;
        }

        public string MaBenhNhan { get => maBenhNhan; set => maBenhNhan = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string MaBenhAn { get => maBenhAn; set => maBenhAn = value; }
        public string NgayChuyen { get => ngayChuyen; set => ngayChuyen = value; }
        public string NoiDen { get => noiDen; set => noiDen = value; }
    }
}
