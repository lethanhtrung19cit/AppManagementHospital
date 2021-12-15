using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class Danhsachchokham
    {
        private string  maBenhNhan, maKhamBenh, yeuCauKham;
        

        public string MaBenhNhan { get => maBenhNhan; set => maBenhNhan = value; }
       
        public string YeuCauKham { get => yeuCauKham; set => yeuCauKham = value; }
        public string MaKhamBenh { get => maKhamBenh; set => maKhamBenh = value; }

        public Danhsachchokham()
        {


        }
        public Danhsachchokham(string maKhamBenh, string maBenhNhan, string yeuCauKham)
        {
            this.MaBenhNhan = maBenhNhan;
            this.MaKhamBenh = maKhamBenh;
            this.YeuCauKham = yeuCauKham;
        }
    }
}
