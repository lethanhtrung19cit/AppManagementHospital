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
    public partial class CapThuoc : Form
    {
        busCapThuoc busCapThuoc = new busCapThuoc();
        QuanLyDonThuoc qldt = new QuanLyDonThuoc();
        public CapThuoc()
        {
            InitializeComponent();
        }
        public CapThuoc(string maBenhNhan1)
        {
            
            InitializeComponent();
            maBenhNhan.Text = maBenhNhan1;
            danhsachThuoc.DataSource = busCapThuoc.danhSachThuoc();
            load();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void load()
        {
            tenBenhNhan.Text = busCapThuoc.hoTen(maBenhNhan.Text);
            byte[] image = busCapThuoc.image(maBenhNhan.Text);

            MemoryStream ms = new MemoryStream(image);

            Image img = Image.FromStream(ms);

            pictureBox9.Image = img;
        }
        private void maBenhNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                load();
            }    
        }

        private void maThuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                tenThuoc.Text = busCapThuoc.tenThuoc(maThuoc.Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            QuanLyDonThuoc qldt = new QuanLyDonThuoc(maBenhNhan.Text, maThuoc.Text, lieuDung.Text, ghiChu.Text);
            if (busCapThuoc.themDonThuoc(qldt, tenThuoc.Text))
            {
                MessageBox.Show("Thêm thành công");
                this.Dispose();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
