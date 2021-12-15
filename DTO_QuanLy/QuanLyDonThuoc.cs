using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class QuanLyDonThuoc
    {
        private string maBenhNhan, maThuoc, lieuDung, ghiChu;
        public QuanLyDonThuoc()
        {

        }
        public QuanLyDonThuoc(string maBenhNhan, string maThuoc, string lieuDung, string ghiChu)
        {
            this.maBenhNhan = maBenhNhan;
            this.maThuoc = maThuoc;
            this.lieuDung = lieuDung;
            this.ghiChu = ghiChu;
        }

        public string MaBenhNhan { get => maBenhNhan; set => maBenhNhan = value; }
        public string MaThuoc { get => maThuoc; set => maThuoc = value; }
        public string LieuDung { get => lieuDung; set => lieuDung = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
    }
}
