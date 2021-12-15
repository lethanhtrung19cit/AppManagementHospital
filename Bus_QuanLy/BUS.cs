using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL_QuanLy;
using DTO_QuanLy;
using System.Data;
namespace Bus_QuanLy
{
    public class BUS
    {

        DBConnect dbconnect = new DBConnect();
        public DataTable getBenhNhan()
        {
            return dbconnect.getBenhNhan();
        }
        public DataTable getChoKham()
        {
            return dbconnect.getBenhNhanChoKham() ;
        }
        public bool themBenhNhanCho(DTO_QuanLyBenhNhan bn, Danhsachchokham dsck, string maBenhNhan, string maBenhAn, string maKhamBenh, string path)
        {
            return dbconnect.themBenhNhan(bn, dsck, maBenhNhan,maBenhAn, maKhamBenh, path);

        }
        public bool suaBenhNhan(DTO_QuanLyBenhNhan bn, ChiTietKhamBenh kb, string maBenhNhan, string path)
        {
            return dbconnect.suaBenhNhan(bn, kb, maBenhNhan, path);
        }
        public bool xoabenhnhan(string mabenhnhan)
        {
            return dbconnect.xoabenhnhan(mabenhnhan);
        }
        public DataTable searchBenhNhan(string maBenhNhan)
        {
            return dbconnect.timKiemBenhNhan(maBenhNhan);
        }
        public DataTable searchChoKham(string tenBenhNhan)
        {
            return dbconnect.timKiemBenhNhanChoKham(tenBenhNhan);
        }
        public DataTable thongKeBenhNhan(string ngayKham)
        {
            return dbconnect.thongKeBenhNhan(ngayKham);
        }
        public string mabenhnhan()
        {
            return dbconnect.mabenhnhan();
        }
        public string mabenhan()
        {
            return dbconnect.mabenhan();
        }
        public string makhambenh()
        {
            return dbconnect.makhambenh();
        }
        
    }
}
