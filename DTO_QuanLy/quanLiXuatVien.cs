using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class quanLiXuatVien
    {
        private string maBenhNhan, ngayXuatVien;

        public quanLiXuatVien(string maBenhNhan, string ngayXuatVien)
        {
            this.MaBenhNhan = maBenhNhan;
            this.NgayXuatVien = ngayXuatVien;
        }

        public string MaBenhNhan { get => maBenhNhan; set => maBenhNhan = value; }
        public string NgayXuatVien { get => ngayXuatVien; set => ngayXuatVien = value; }
    }
}
