using Bus_QuanLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Application
{
    public partial class HoaDonThanhToan : Form
    {
        busHoaDon busHoaDon = new busHoaDon();
        busNoiTru busNoiTru = new busNoiTru();
        busCapThuoc busCapThuoc = new busCapThuoc();
        string ma1=null;
        string ten2 = null;
       
        //string maBenhNhan, string tienThuoc,string tienDichVu, string tienKhamBenh, string tienVienPhi
        public HoaDonThanhToan(string tentaikhoan, string ma, string maBenhNhan, double tongTien1, string hoaDon1, string ten1)
        {
            InitializeComponent();
            ma1 = ma;
            
            tenHoaDon.Text = hoaDon1;
            ten2 = ten1;
            if (ten1.Equals("thuoc"))
                danhSach.DataSource = busCapThuoc.tenThuocBN(maBenhNhan);
            else if (ten1.Equals("noitru"))
                danhSach.Visible = false;
            ngay.Text = DateTime.Today.ToShortDateString();
            tenBenhNhan.Text = busNoiTru.hoTen(maBenhNhan);

            string maBaoHiem =busHoaDon.BHYT(maBenhNhan);
            tenYTa.Text = tentaikhoan;
            double tienBaoHiem=tongTien1;
            tienGiam.Text = "0 VND";
            if (maBaoHiem.Equals("Hộ nghèo"))
            {
                tienGiam.Text = Convert.ToString(tienBaoHiem * 0.2) + "VND";
                tienBaoHiem = tongTien1 - double.Parse(Convert.ToString(tienBaoHiem * 0.2));
            }
            else if (maBaoHiem.Equals("Sinh Viên") || maBaoHiem.Equals("Học sinh"))
            {
                tienGiam.Text = Convert.ToString(tienBaoHiem * 0.1) + "VND";
                tienBaoHiem = tongTien1 - double.Parse(Convert.ToString(tienBaoHiem * 0.1));
            }

            tongTien.Text = Convert.ToString(tienBaoHiem) +" VND";

        }
       
        private void HoaDonThanhToan_Load(object sender, EventArgs e)
        {



            this.reportViewer1.RefreshReport();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ten2.Equals("noitru"))
            { 
                busNoiTru busNoiTru = new busNoiTru();
                busNoiTru.suaThanhToan(ma1);
            }
            else if (ten2.Equals("thuoc"))
            {
                busCapThuoc busCapThuoc = new busCapThuoc();
                busCapThuoc.suaThanhToan(ma1);
            }
            MessageBox.Show("In thành công");
        }
    }
}
