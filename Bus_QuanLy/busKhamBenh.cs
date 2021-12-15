using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLy;
using DTO_QuanLy;
namespace Bus_QuanLy
{
    public class busKhamBenh
    {
        KhamBenh ctkb = new KhamBenh();
        public DataTable tenBacSi(string maBacSi)
        {
            return ctkb.tenBacSi(maBacSi);
        }
        public bool themBenhNhan(ChiTietKhamBenh ctkb1, Danhsachchokham dsck)
        {
            return ctkb.themCTKB(ctkb1, dsck);

        }
        public bool suaThanhToan(string maKhamBenh)
        {
            return ctkb.suaThanhToan(maKhamBenh);
        }
        public DataTable khoaKham()
        {
            return ctkb.getKhoaKham();
                
        }
    }
}
