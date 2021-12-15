using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLy;
namespace DAL_QuanLy
{
    public class BacSi : connection
    {
        public DataTable getBacSi()
        {
            conn = new SqlConnection("Data Source=DESKTOP-76IH46T\\SQLEXPRESS;Initial Catalog=quanlibenhvien;Persist Security Info=True;User ID=sa;Password=lethanhtrung");
            SqlDataAdapter da = new SqlDataAdapter("select MaBacSi 'Mã bác sĩ', Hoten'Họ tên', GioiTinh'Giới tính', NgaySinh'Ngày sinh', DiaChi'Địa chỉ', SDT'SĐT', CMND, MaKhoa'Mã khoa', TenKhoa 'Tên khoa', ChucVu'Chức vụ', picture 'Ảnh' from BacSi", conn);
            DataTable dtDichVu = new DataTable();
            da.Fill(dtDichVu);

            return dtDichVu;

        }
        public string maBacSi()
        {

            conn.Open();
            string sql = string.Format("declare cur_MaBS cursor for select count(MaBacSi) from dsbs open cur_MaBS declare @countbs int fetch next from cur_MaBS into @countbs while @@FETCH_STATUS=0 begin select MaBacSi='BS0'+CAST(@countbs+1 as varchar(10)) from dsbs fetch next from cur_MaBS into @countbs end close cur_MaBS deallocate cur_MaBS");
            SqlCommand a = new SqlCommand(sql, conn);
            String a1 = (String)a.ExecuteScalar();
            conn.Close();
            return a1;
        }
        public bool themBacSi(QuanLyBacSi bs, string maBacSi, string path)
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
                SqlCommand cmd = new SqlCommand("InsertImageBS", conn);
                string sql = string.Format("insert into dsbs(MaBacSi) values('{0}')", maBacSi);

                SqlCommand cmd1 = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaBacSi", maBacSi);
                cmd.Parameters["@MaBacSi"].Direction = ParameterDirection.Input;
                cmd.Parameters.Add("@picture", SqlDbType.Image);
                cmd.Parameters["@picture"].Direction = ParameterDirection.Input;
                // Store the byte array within the image field
                cmd.Parameters["@picture"].Value = imageData;
                cmd.Parameters.AddWithValue("@HoTen", bs.HoTen);
                cmd.Parameters.AddWithValue("@GioiTinh", bs.GioiTinh);
                cmd.Parameters.AddWithValue("@NgaySinh", bs.NgaySinh);
                cmd.Parameters.AddWithValue("@DiaChi", bs.DiaChi1);                
                cmd.Parameters.AddWithValue("@SDT", bs.SDT1);               
                cmd.Parameters.AddWithValue("@CMND", bs.CMND1);
                cmd.Parameters.AddWithValue("@MaKhoa", bs.MaKhoa);
                cmd.Parameters.AddWithValue("@TenKhoa", bs.TenKhoa);
                cmd.Parameters.AddWithValue("@ChucVu", bs.ChucVu);
                if (cmd.ExecuteNonQuery()>0 && cmd1.ExecuteNonQuery() > 0)
                    return true;
                conn.Close();
            }


            return false;

        }
        public bool suaBacSi(QuanLyBacSi bs, string maBacSi, string path)
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
                SqlCommand cmd = new SqlCommand("UpdateImageBS", conn);
                //string sql = string.Format("update BacSi v('{0}')", maBacSi);

                //SqlCommand cmd1 = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaBacSi", maBacSi);
                cmd.Parameters["@MaBacSi"].Direction = ParameterDirection.Input;
                cmd.Parameters.Add("@picture", SqlDbType.Image);
                cmd.Parameters["@picture"].Direction = ParameterDirection.Input;
                // Store the byte array within the image field
                cmd.Parameters["@picture"].Value = imageData;
                cmd.Parameters.AddWithValue("@HoTen", bs.HoTen);
                cmd.Parameters.AddWithValue("@GioiTinh", bs.GioiTinh);
                cmd.Parameters.AddWithValue("@NgaySinh", bs.NgaySinh);
                cmd.Parameters.AddWithValue("@DiaChi", bs.DiaChi1);
                cmd.Parameters.AddWithValue("@SDT", bs.SDT1);
                cmd.Parameters.AddWithValue("@CMND", bs.CMND1);
                cmd.Parameters.AddWithValue("@MaKhoa", bs.MaKhoa);
                cmd.Parameters.AddWithValue("@TenKhoa", bs.TenKhoa);
                cmd.Parameters.AddWithValue("@ChucVu", bs.ChucVu);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                conn.Close();
            }


            return false;

        }
    }
}
