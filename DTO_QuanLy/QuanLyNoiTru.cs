using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class QuanLyNoiTru
    {
        private string  MaBenhNhan, MaGiuong, NgayVaoVien, Phong, ThuocSuDung, DichVuSuDung;

        public QuanLyNoiTru(string maBenhNhan, string maGiuong, string ngayVaoVien, string phong)
        {
            MaBenhNhan = maBenhNhan;
            MaGiuong = maGiuong;
            NgayVaoVien = ngayVaoVien;
            Phong = phong;
        }

        public QuanLyNoiTru(string maGiuong, string ngayVaoVien, string phong, string thuocSuDung, string dichVuSuDung)
        {
            MaGiuong = maGiuong;
            NgayVaoVien = ngayVaoVien;
            Phong = phong;
            ThuocSuDung = thuocSuDung;
            DichVuSuDung = dichVuSuDung;
        }

        public string MaBenhNhan1 { get => MaBenhNhan; set => MaBenhNhan = value; }
        public string MaGiuong1 { get => MaGiuong; set => MaGiuong = value; }
        public string NgayVaoVien1 { get => NgayVaoVien; set => NgayVaoVien = value; }
        public string Phong1 { get => Phong; set => Phong = value; }
        public string ThuocSuDung1 { get => ThuocSuDung; set => ThuocSuDung = value; }
        public string DichVuSuDung1 { get => DichVuSuDung; set => DichVuSuDung = value; }
    }
}
