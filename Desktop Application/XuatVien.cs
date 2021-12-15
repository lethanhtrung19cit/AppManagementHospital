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
    public partial class XuatVien : Form
    {
        busXuatVien busXuatVien = new busXuatVien();
        busNoiTru busNoiTru = new busNoiTru();
        string manoitru = null;
        public XuatVien(string maNoiTru, string maBenhNhan1)
        {
            InitializeComponent();
            manoitru = maNoiTru;
            ngayNhapVien.Text = busNoiTru.ngayNhapVien(maBenhNhan1).ToShortDateString();                        
            ngayXuatVien.Text = DateTime.Today.ToShortDateString();
            soNgay.Text = Convert.ToString((Convert.ToDateTime(ngayXuatVien.Text)-Convert.ToDateTime(ngayNhapVien.Text)).TotalDays);
            tenBenhNhan.Text = busNoiTru.hoTen(maBenhNhan1);
            tongTien.Text = Convert.ToString(int.Parse(soNgay.Text) * 200000);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xuất viện thành công");
            busNoiTru busNoiTru = new busNoiTru();
            busNoiTru.xoaNoiTru(manoitru);
            
        }
    }
}
