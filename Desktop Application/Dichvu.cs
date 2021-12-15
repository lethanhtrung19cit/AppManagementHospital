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
    public partial class Dichvu : Form
    {
        busDichVu busDichVu = new busDichVu();
        public Dichvu()
        {
            InitializeComponent();
        }
        public Dichvu(string maBenhNhan1)
        {
            InitializeComponent();
            maBenhNhan.Text = maBenhNhan1;
            danhSachDichVu.DataSource = busDichVu.danhSachDichVu();
            load();
        }
        public void load()
        {
           
            tenBenhNhan.Text = busDichVu.hoTen(maBenhNhan.Text);
            byte[] image = busDichVu.image(maBenhNhan.Text);

            MemoryStream ms = new MemoryStream(image);

            Image img = Image.FromStream(ms);

            pictureBox10.Image = img;

        }
        private void Dichvu_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = busDichVu.getDichVu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            QuanLyDichVu qldv = new QuanLyDichVu(maBenhNhan.Text, maDichVu.Text, int.Parse(soLanThucHien.Text), double.Parse(tongTien.Text));
            if (int.Parse(soLanThucHien.Text)==1)
            {

                busDichVu.themDV(qldv, tenDichVu.Text);
                MessageBox.Show("Thêm thành công");
                this.Dispose();

            }    
            else
            {
                busDichVu.suaSoLanSuDungDV(int.Parse(soLanThucHien.Text), maBenhNhan.Text, maDichVu.Text, double.Parse(tongTien.Text));
                this.Dispose();
            }
               
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void maDichVu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                tenDichVu.Text = busDichVu.tenDichVu(maDichVu.Text);
                if (busDichVu.tonTaisoLanSuDungDV(maDichVu.Text, maBenhNhan.Text)<1)
                {
                    soLanThucHien.Text = "1";
                }
                else
                {
                    soLanThucHien.Text = Convert.ToString(busDichVu.soLanSuDungDV(maDichVu.Text, maBenhNhan.Text)+1);
                }
                donGia.Text = Convert.ToString(busDichVu.thanhGia(maDichVu.Text));

                tongTien.Text = Convert.ToString(double.Parse(donGia.Text) * double.Parse(soLanThucHien.Text));
                

            }
        }

        private void maBenhNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                load();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void soLanThucHien_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
