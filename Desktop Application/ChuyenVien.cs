using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QuanLy;
using Bus_QuanLy;
namespace Desktop_Application
{
    public partial class ChuyenVien : Form
    {
        busChuyenVien chuyenVien = new busChuyenVien();
        string maNoiTru1 = null;
        public ChuyenVien(string maNoiTru, string mabenhnhan, string hoten, string mabenhan)
        {
            InitializeComponent();
            maBenhNhan.Text = mabenhnhan;
            tenBenhNhan.Text = hoten;
            maBenhAn.Text = mabenhan;
            maNoiTru1 = maNoiTru;
        }

        private void ChuyenVien_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            quanLiChuyenVien qlcv = new quanLiChuyenVien(maBenhNhan.Text, tenBenhNhan.Text, maBenhAn.Text, ngayChuyen.Text, noiDen.Text);
            if (chuyenVien.themChuyenVien(qlcv, maBenhNhan.Text))
            {
                MessageBox.Show("Chuyển viện thành công");
                busNoiTru busNoiTru = new busNoiTru();
                busNoiTru.xoaNoiTru(maNoiTru1);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        
    }
}
