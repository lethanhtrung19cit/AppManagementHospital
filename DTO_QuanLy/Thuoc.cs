using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class Thuoc
    {
        private string maThuoc, tenThuoc, donViTinh, ghiChu;
        private float gia;
        public Thuoc()
        {

        }
        public Thuoc(string maThuoc, string tenThuoc, string donViTinh, string ghiChu, float gia)
        {
            this.MaThuoc = maThuoc;
            this.TenThuoc = tenThuoc;
            this.DonViTinh = donViTinh;
            this.GhiChu = ghiChu;
            this.Gia = gia;
        }

        public string MaThuoc { get => maThuoc; set => maThuoc = value; }
        public string TenThuoc { get => tenThuoc; set => tenThuoc = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public float Gia { get => gia; set => gia = value; }
    }
}
