using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO_QuanLy;
using System.Drawing;
using System.IO;

namespace DAL_QuanLy
{
    public class DBConnect : connection
    {


        
        public DataTable getBenhNhan()
        {
            conn = new SqlConnection("Data Source=DESKTOP-76IH46T\\SQLEXPRESS;Initial Catalog=quanlibenhvien;Persist Security Info=True;User ID=sa;Password=lethanhtrung");      
            SqlDataAdapter da = new SqlDataAdapter("select bn.MaBenhNhan 'Mã bệnh nhân', TenBenhNhan 'Tên bệnh nhân', GioiTinh 'Giới tính', NgaySinh 'Ngày sinh', DiaChi 'Địa chỉ', NgheNghiep 'Nghề nghiệp', SDT 'Số điện thoại', MaBenhAn 'Mã bệnh án', MaBHYT 'Mã bảo hiểm y tế', DoiTuong 'Đối tượng', picture 'Ảnh', CMND 'Số CMND', NgayKham 'Ngày Khám', PhongKham 'Phòng khám', ChuanDoanSauCung 'Tên bệnh' from BenhNhan bn inner join ChiTietKhamBenh ctkb on bn.MaBenhNhan=ctkb.MaBenhNhan", conn);
            DataTable dtBenhNhan = new DataTable();
            da.Fill(dtBenhNhan);
           
            return dtBenhNhan;
            
        }
        public DataTable getBenhNhanChoKham()
        {
            conn = new SqlConnection("Data Source=DESKTOP-76IH46T\\SQLEXPRESS;Initial Catalog=quanlibenhvien;Persist Security Info=True;User ID=sa;Password=lethanhtrung");
            SqlDataAdapter da = new SqlDataAdapter("select dsck.MaBenhNhan 'Mã bệnh nhân', TenBenhNhan 'Tên bệnh nhân', GioiTinh 'Giới tính', NgaySinh 'Ngày sinh', DiaChi 'Địa chỉ', NgheNghiep 'Nghề nghiệp', SDT 'Số điện thoại', MaBenhAn 'Mã bệnh án', MaBHYT 'Mã bảo hiểm y tế', DoiTuong 'Đối tượng', picture 'Ảnh', CMND 'Số CMND', dsck.YeuCauKham 'Yêu cầu khám', dsck.MaKhamBenh'Mã khám bệnh' from BenhNhan bn inner join dsck on bn.MaBenhNhan=dsck.MaBenhNhan", conn);
            DataTable dtBenhNhan = new DataTable();
            da.Fill(dtBenhNhan);

            return dtBenhNhan;

        }

        public bool themBenhNhan(DTO_QuanLyBenhNhan bn, Danhsachchokham kb, string maBenhNhan, string maBenhAn, string maKhamBenh, string path)
        {

           
            byte[] imageData = null;
            // Read the file into a byte array
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                imageData = new Byte[fs.Length];
                fs.Read(imageData, 0, (int)fs.Length);
            }
            using (conn)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("InsertImageBN", conn);
                string sql = string.Format("insert into dsck(MaKhamBenh, MaBenhNhan, YeuCauKham) values('{0}', '{1}', N'{2}') insert into BenhAn(MaBenhAn) values('{3}')", maKhamBenh, kb.MaBenhNhan, kb.YeuCauKham, maBenhAn);

                SqlCommand cmd1 = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaBenhNhan", maBenhNhan);
                cmd.Parameters["@MaBenhNhan"].Direction = ParameterDirection.Input;
                cmd.Parameters.Add("@picture", SqlDbType.Image);
                cmd.Parameters["@picture"].Direction = ParameterDirection.Input;
                // Store the byte array within the image field
                cmd.Parameters["@picture"].Value = imageData;
                cmd.Parameters.AddWithValue("@TenBenhNhan", bn.TenBenhNhan1);
                cmd.Parameters.AddWithValue("@GioiTinh", bn.GioiTinh);
                cmd.Parameters.AddWithValue("@NgaySinh", bn.NgaySinh1);
                cmd.Parameters.AddWithValue("@DiaChi", bn.Diachi);
                cmd.Parameters.AddWithValue("@NgheNghiep", bn.NgheNghiep);
                cmd.Parameters.AddWithValue("@SDT", bn.SDT1);
                cmd.Parameters.AddWithValue("@MaBenhAn", maBenhAn);
                cmd.Parameters.AddWithValue("@MaBHYT1", bn.MaBHYT1);
                cmd.Parameters.AddWithValue("@DoiTuong", bn.DoiTuong);
                cmd.Parameters.AddWithValue("@CMND", bn.CMND1);
                if (cmd.ExecuteNonQuery() > 0 && cmd1.ExecuteNonQuery() > 0)
                    return true;
                conn.Close();
            }
            
          
            return false;
                     
        }
        public bool suaBenhNhan(DTO_QuanLyBenhNhan bn, ChiTietKhamBenh ctkb, string maBenhNhan, string path)
        {
            
            conn.Open();
            if (path != null)
            {
                byte[] imageData = null;

                {
                    // Read the file into a byte array
                    using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                    {
                        imageData = new Byte[fs.Length];
                        fs.Read(imageData, 0, (int)fs.Length);
                    }
                }
                using (conn)
                {
                    
                    SqlCommand cmd = new SqlCommand("UpdateImageBN", conn);
                    string sql = string.Format("set dateformat dmy update ChiTietKhamBenh set NgayKham='{0}', PhongKham='{1}', ChuanDoanSauCung=N'{2}' where MaBenhNhan='{3}'", ctkb.NgayKham, ctkb.PhongKham, ctkb.ChuanDoanSauCung, maBenhNhan);

                    SqlCommand cmd1 = new SqlCommand(sql, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaBenhNhan", maBenhNhan);
                    cmd.Parameters["@MaBenhNhan"].Direction = ParameterDirection.Input;
                    //if (path!=null)
                    //{     
                    cmd.Parameters.Add("@picture", SqlDbType.Image);
                    cmd.Parameters["@picture"].Direction = ParameterDirection.Input;
                    // Store the byte array within the image field
                    cmd.Parameters["@picture"].Value = imageData;
                    //}
                    cmd.Parameters.AddWithValue("@TenBenhNhan", bn.TenBenhNhan1);
                    cmd.Parameters.AddWithValue("@GioiTinh", bn.GioiTinh);
                    cmd.Parameters.AddWithValue("@NgaySinh", bn.NgaySinh1);
                    cmd.Parameters.AddWithValue("@DiaChi", bn.Diachi);
                    cmd.Parameters.AddWithValue("@NgheNghiep", bn.NgheNghiep);
                    cmd.Parameters.AddWithValue("@SDT", bn.SDT1);

                    cmd.Parameters.AddWithValue("@DoiTuong", bn.DoiTuong);
                    cmd.Parameters.AddWithValue("@CMND", bn.CMND1);
                    
                    if (cmd.ExecuteNonQuery()>0 && cmd1.ExecuteNonQuery() > 0)
                        return true;
                   
                }
            }
            else 
            {
              
                using (conn)
                {
                    
                    SqlCommand cmd = new SqlCommand("NoUpdateImageBN", conn);
                    string sql = string.Format("set dateformat dmy update ChiTietKhamBenh set NgayKham='{0}', PhongKham='{1}', ChuanDoanSauCung=N'{2}' where MaBenhNhan='{3}'", ctkb.NgayKham, ctkb.PhongKham, ctkb.ChuanDoanSauCung, maBenhNhan);

                    SqlCommand cmd1 = new SqlCommand(sql, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaBenhNhan", maBenhNhan);
                    cmd.Parameters["@MaBenhNhan"].Direction = ParameterDirection.Input;
                   
                    cmd.Parameters.AddWithValue("@TenBenhNhan", bn.TenBenhNhan1);
                    cmd.Parameters.AddWithValue("@GioiTinh", bn.GioiTinh);
                    cmd.Parameters.AddWithValue("@NgaySinh", bn.NgaySinh1);
                    cmd.Parameters.AddWithValue("@DiaChi", bn.Diachi);
                    cmd.Parameters.AddWithValue("@NgheNghiep", bn.NgheNghiep);
                    cmd.Parameters.AddWithValue("@SDT", bn.SDT1);
                    cmd.Parameters.AddWithValue("@DoiTuong", bn.DoiTuong);
                    cmd.Parameters.AddWithValue("@CMND", bn.CMND1);
                    
                    if (cmd.ExecuteNonQuery() > 0 && cmd1.ExecuteNonQuery() > 0)
                        return true;
                    
                }
            }

            conn.Close();
            return false;
            
        }
        public bool xoabenhnhan(string mabenhnhan)
        {
            conn.Open();
            string sql = string.Format("delete from NoiTru where MaBenhNhan='{0}'", mabenhnhan);
            SqlCommand cmd = new SqlCommand(sql, conn);
            if (cmd.ExecuteNonQuery() > 0) return true;
            conn.Close();
            return false;
        }
        public DataTable timKiemBenhNhan(string tenBenhNhan)
        {
            string sql = string.Format("select kb.MaBenhNhan 'Mã bệnh nhân', TenBenhNhan 'Tên bệnh nhân', GioiTinh 'Giới tính', NgaySinh 'Ngày sinh', DiaChi 'Địa chỉ', NgheNghiep 'Nghề nghiệp', SDT 'Số điện thoại', MaBenhAn 'Mã bệnh án', MaBHYT 'Mã bảo hiểm y tế', DoiTuong 'Đối tượng', picture 'Ảnh', CMND 'Số CMND', kb.NgayKham 'Ngày Khám',  ctkb.ChuanDoanSauCung 'Tên bệnh' from BenhNhan bn inner join  ChiTietKhamBenh ctkb on ctkb.MaBenhNhan=bn.MaBenhNhan where bn.TenBenhNhan like N'%{0}%'", tenBenhNhan);
            conn = new SqlConnection("Data Source=DESKTOP-76IH46T\\SQLEXPRESS;Initial Catalog=quanlibenhvien;Persist Security Info=True;User ID=sa;Password=lethanhtrung");
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dtBenhNhan = new DataTable();
            da.Fill(dtBenhNhan);

            return dtBenhNhan;

        }
        public DataTable timKiemBenhNhanChoKham(string tenBenhNhan)
        {
            string sql = string.Format("select kb.MaBenhNhan 'Mã bệnh nhân', TenBenhNhan 'Tên bệnh nhân', GioiTinh 'Giới tính', NgaySinh 'Ngày sinh', DiaChi 'Địa chỉ', NgheNghiep 'Nghề nghiệp', SDT 'Số điện thoại', kb.MaBenhAn 'Mã bệnh án', MaBHYT 'Mã bảo hiểm y tế', DoiTuong 'Đối tượng', picture 'Ảnh', CMND 'Số CMND', kb.NgayKham 'Ngày Khám', kb.PhongKham 'Phòng khám', kb.YeuCauKham 'Yêu cầu khám' from BenhNhan bn inner join KhamBenh kb on bn.MaBenhNhan=kb.MaBenhNhan where bn.TenBenhNhan like N'%{0}%'", tenBenhNhan);
            conn = new SqlConnection("Data Source=DESKTOP-76IH46T\\SQLEXPRESS;Initial Catalog=quanlibenhvien;Persist Security Info=True;User ID=sa;Password=lethanhtrung");
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dtBenhNhan = new DataTable();
            da.Fill(dtBenhNhan);

            return dtBenhNhan;

        }
        public DataTable thongKeBenhNhan(string ngayKham)
        {
            string sql = string.Format("set dateformat dmy select bn.MaBenhNhan 'Mã bệnh nhân', TenBenhNhan 'Tên bệnh nhân', GioiTinh 'Giới tính', NgaySinh 'Ngày sinh', DiaChi 'Địa chỉ', NgheNghiep 'Nghề nghiệp', SDT 'Số điện thoại', MaBenhAn 'Mã bệnh án', MaBHYT 'Mã bảo hiểm y tế', DoiTuong 'Đối tượng', picture 'Ảnh', CMND 'Số CMND', NgayKham 'Ngày Khám', PhongKham 'Phòng khám' from BenhNhan bn inner join ChiTietKhamBenh ctkb on bn.MaBenhNhan=ctkb.MaBenhNhan where NgayKham='"+ngayKham+"'");
            conn = new SqlConnection("Data Source=DESKTOP-76IH46T\\SQLEXPRESS;Initial Catalog=quanlibenhvien;Persist Security Info=True;User ID=sa;Password=lethanhtrung");
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dtBenhNhan = new DataTable();
            da.Fill(dtBenhNhan);

            return dtBenhNhan;

        }
        public string mabenhnhan()
        {
           
            conn.Open();
            string sql = string.Format("declare cur_MaBN cursor for select count(MaBenhAn) from BenhAn open cur_MaBN declare @count int fetch next from cur_MaBN into @count while @@FETCH_STATUS=0 begin select MaBenhNhan='BN0'+CAST(@count+1 as char(10)) from BenhNhan fetch next from cur_MaBN into @count end close cur_MaBN deallocate cur_MaBN");
            SqlCommand a = new SqlCommand(sql, conn);
            String a1 = (String)a.ExecuteScalar();
            conn.Close();
            return a1;
        }
        public string mabenhan()
        {
            conn.Open();
            string sql = string.Format("declare cur_MaBA cursor for select count(MaBenhAn) from BenhAn open cur_MaBA declare @count1 int fetch next from cur_MaBA into @count1 while @@FETCH_STATUS=0 begin  select MaBenhAn='BA0'+CAST(@count1+1 as char(10)) from BenhAn fetch next from cur_MaBA into @count1 end close cur_MaBA deallocate cur_MaBA");
            SqlCommand a = new SqlCommand(sql, conn);
            String a1 = (String)a.ExecuteScalar();

            conn.Close();
            return a1;
        }

        public string makhambenh()
        {
            conn.Open();  
            string sql = string.Format("declare cur_MaKB cursor for select count(MaBenhAn) from BenhAn open cur_MaKB declare @count2 int fetch next from cur_MaKB into @count2 while @@FETCH_STATUS = 0 begin select MaKhamBenh='KB0'+CAST(@count2+1 as char(10)) from ChiTietKhamBenh  fetch next from cur_MaKB into @count2 end close cur_MaKB deallocate cur_MaKB");
            SqlCommand a = new SqlCommand(sql, conn);
            String a1 = (String)a.ExecuteScalar();
            conn.Close();
           
            return a1;
        }
       
    }
}

