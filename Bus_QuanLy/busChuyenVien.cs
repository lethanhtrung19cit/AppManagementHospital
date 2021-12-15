using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLy;
using DAL_QuanLy;
namespace Bus_QuanLy
{
    public class busChuyenVien
    {
        ChuyenVien cv = new ChuyenVien();
        public bool themChuyenVien(quanLiChuyenVien qlcv, string maBenhNhan)
        {
            return cv.themChuyenVien(qlcv, maBenhNhan);

        }
    }
}
