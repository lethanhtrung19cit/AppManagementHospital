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
using DTO_QuanLy;
using Bus_QuanLy;

namespace Desktop_Application
{
    public partial class ThemBenhNhan : Form
    {
        BUS bus = new BUS();
        
        public ThemBenhNhan()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e) 
        {

        }
        string path = null;
        private void button5_Click(object sender, EventArgs e)
        {
         
            string gioitinh;
            if (nam.Checked == true) gioitinh = "Nam";
            else gioitinh = "Nữ";
            DTO_QuanLyBenhNhan bn = new DTO_QuanLyBenhNhan(hoTen.Text, gioitinh, ngaySinh.Text, diaChi.Text, ngheNghiep.Text, SDT.Text, doiTuong.Text, CMND.Text, maBHYT.Text);
            Danhsachchokham dsck = new Danhsachchokham(maKhamBenh.Text, maBenhNhan.Text, yeuCauKham.Text);

            if (bus.themBenhNhanCho(bn, dsck, maBenhNhan.Text, maBenhAn.Text, maKhamBenh.Text, path))
            {
                MessageBox.Show("Thêm thành công");
                               
                this.Dispose();

            }

            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void diaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //openFileDialog1.ShowDialog();
            //string file = openFileDialog1.FileName;
            //if (string.IsNullOrEmpty(file)) return;
            //Image myImage = Image.FromFile(file);
            //pictureBox1.Image = myImage;
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Title = "Chon mot hinh anh";
            openDlg.RestoreDirectory = true;
            openDlg.Filter = "All images (*.bmp;*.jpg;*.gif;*.png)|*.bmp;*.jpg;*.gif;*.png";
            openDlg.Multiselect = false;
            if (openDlg.ShowDialog() == DialogResult.OK)
            {

                pictureBox1.Image = Image.FromFile(openDlg.FileName);
                path = openDlg.FileName;
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void ThemBenhNhan_Load(object sender, EventArgs e)
        {
            maBenhNhan.Text = bus.mabenhnhan();
            maKhamBenh.Text = bus.makhambenh();
            maBenhAn.Text = bus.mabenhan();

        }

        private void ThemBenhNhan_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            diaChi.Text = "";
            ngheNghiep.Text = "";
            
            SDT.Text = "";
            CMND.Text = "";
            
            doiTuong.Text = "";
            maBHYT.Text = "";
            
            yeuCauKham.Text = "";
            diaChi.Text = "";
            pictureBox1.Image = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Visible = false;


        }
    }
}
