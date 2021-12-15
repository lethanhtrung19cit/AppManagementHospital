using DAL_QuanLy;
using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_QuanLy
{
    public class busXuatVien
    {
        XuatVien xv = new XuatVien();
        public DataTable thongKeXuatVien(string maBenhnhan)
        {
            return xv.thongKeXuatVien(maBenhnhan);
        }
        public bool themXuatVien(quanLiXuatVien qlxv)
        {
            return xv.themXuatVien(qlxv);
        }
    }
}
