using Bus_QuanLy;
using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Application
{
    public partial class ThanhToan : Form
    {
        busDichVu busDichVu = new busDichVu();
        busCapThuoc busCapThuoc = new busCapThuoc();
        busHoaDon busHoaDon = new busHoaDon();
        public ThanhToan(string maBenhNhan1)
        {
            InitializeComponent();
            maBenhNhan.Text = maBenhNhan1;
            tenBenhNhan.Text = busDichVu.hoTen(maBenhNhan.Text);
            if (busDichVu.tonTaiDichVu(maBenhNhan.Text) > 0)
                tienDichVu.Text = Convert.ToString(busDichVu.tienDichVu(maBenhNhan.Text));
            else tienDichVu.Text = "0";
            tienThuoc.Text = Convert.ToString(busCapThuoc.tongTienThuoc(maBenhNhan.Text));
            tienKhamBenh.Text = "100000";
            tongTien.Text = Convert.ToString(double.Parse(tienThuoc.Text)+ double.Parse(tienDichVu.Text)+ double.Parse(tienKhamBenh.Text));
            byte[] image = busDichVu.image(maBenhNhan.Text);

            MemoryStream ms = new MemoryStream(image);

            Image img = Image.FromStream(ms);

            pictureBox1.Image = img;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maBenhNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //QuanLiHoaDon qlhd = new QuanLiHoaDon(maBenhNhan.Text, double.Parse(tienThuoc.Text), double.Parse(tienDichVu.Text), double.Parse(tienKhamBenh.Text));
            //if (busHoaDon.themHoaDon(qlhd))
            //{
            //    HoaDonThanhToan hdtt = new HoaDonThanhToan(maBenhNhan.Text, double.Parse(tongTien.Text));
            //    hdtt.ShowDialog();
            //}
            

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
