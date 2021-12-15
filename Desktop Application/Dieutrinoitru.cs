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
using System.IO;

namespace Desktop_Application
{
    public partial class Dieutrinoitru : Form
    {
        busNoiTru busNoiTru = new busNoiTru();
        public Dieutrinoitru()
        {
            InitializeComponent();
        }    
        
        public Dieutrinoitru(string maBenhNhan)
        {
            InitializeComponent();
            maBN.Text = maBenhNhan;
            thongTin();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            QuanLyNoiTru qlnt = new QuanLyNoiTru(maBN.Text, MaGiuong.Text, ngayvaoVien.Text, Phong.Text);
            if (busNoiTru.themNoiTru(qlnt))
            {
                MessageBox.Show("Thêm thành công");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Dieutrinoitru_Load(object sender, EventArgs e)
        {

        }

        private void maBN_MouseEnter(object sender, EventArgs e)
        {

        }
        public void thongTin()
        {
            tenBenh.Text = busNoiTru.tenBenh(maBN.Text);
            tenBenhNhan.Text = busNoiTru.hoTen(maBN.Text);
            byte[] image = busNoiTru.image(maBN.Text);

            MemoryStream ms = new MemoryStream(image);

            Image img = Image.FromStream(ms);

            pictureBox1.Image = img;
        }
        private void maBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                thongTin();
            }
        }
    }
}
