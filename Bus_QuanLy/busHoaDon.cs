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
    public class busHoaDon
    {
        HoaDon hoaDon = new HoaDon();
        public DataTable getHoaDon(string maBenhNhan)
        {
            return hoaDon.getHoaDon(maBenhNhan);                    
        }
        public string BHYT(string maBenhNhan)
        {
            return hoaDon.MaBHYT(maBenhNhan);
        }
        public bool themHoaDon(QuanLiHoaDon qlhd)
        {
            return hoaDon.themHoaDon(qlhd);
        }
    }
}
