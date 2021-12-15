using Bus_QuanLy;
using DTO_QuanLy;
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
    public partial class fSystemMgn : Form
    {
        busTaiKhoan busTaiKhoan = new busTaiKhoan();
        busCapThuoc busCapThuoc = new busCapThuoc();
        busDichVu busDichVu = new busDichVu();
        public fSystemMgn()
        {
            InitializeComponent();
            load();
        }
         public void load()
        {
            danhSachTaiKhoan.DataSource = busTaiKhoan.dsTaiKhoan();
            danhSachThuoc.DataSource = busCapThuoc.danhSachThuoc();
            danhSachDichVu.DataSource = busDichVu.danhSachDichVu();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            
                Dangki a = new Dangki();
                a.ShowDialog();
                load();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            taikhoan tk = new taikhoan(tenTaiKhoan.Text, matKhau.Text, quyenTruyCap.SelectedItem.ToString());
            if (busTaiKhoan.suataikhoan(tk))
            {
                MessageBox.Show("Sửa thành công");
                load();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            taikhoan tk = new taikhoan(tenTaiKhoan.Text, matKhau.Text, quyenTruyCap.SelectedItem.ToString());
            if (busTaiKhoan.xoaTaiKhoan(tenTaiKhoan.Text))
            {
                MessageBox.Show("Xóa thành công");
                load();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Thuoc thuoc = new Thuoc(maThuoc.Text, tenThuoc.Text, donViTinhThuoc.Text, ghiChuThuoc.Text, float.Parse(giaThuoc.Text));
            if (busCapThuoc.themThuoc(thuoc))
            {
                MessageBox.Show("Thêm thành công");
                load();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void giaDV_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void donViTinhDV_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Thuoc thuoc = new Thuoc(maThuoc.Text, tenThuoc.Text, donViTinhThuoc.Text, ghiChuThuoc.Text, float.Parse(giaThuoc.Text));
            if (busCapThuoc.suaThuoc(thuoc))
            {
                MessageBox.Show("Sửa thành công");
                load();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Thuoc thuoc = new Thuoc(maThuoc.Text, tenThuoc.Text, donViTinhThuoc.Text, ghiChuThuoc.Text, float.Parse(giaThuoc.Text));
            if (busCapThuoc.xoaThuoc(maThuoc.Text))
            {
                MessageBox.Show("Xóa thành công");
                load();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            QuanLyDichVu qldv = new QuanLyDichVu(maDichVu.Text, tenDichVu.Text, double.Parse(giaDV.Text), donViTinhDV.Text, ghiChuDV.Text);
            if (busDichVu.themDichVu(qldv))
            {
                MessageBox.Show("Thêm thành công");
                load();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            QuanLyDichVu qldv = new QuanLyDichVu(maDichVu.Text, tenDichVu.Text, double.Parse(giaDV.Text), donViTinhDV.Text, ghiChuDV.Text);
            if (busDichVu.suaDichVu(qldv))
            {
                MessageBox.Show("Sửa thành công");
                load();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            QuanLyDichVu qldv = new QuanLyDichVu(maDichVu.Text, tenDichVu.Text, double.Parse(giaDV.Text), donViTinhDV.Text, ghiChuDV.Text);
            if (busDichVu.xoaDichVu(maDichVu.Text))
            {
                MessageBox.Show("Xóa thành công");
                load();
            }
        }

        private void danhSachDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int num;
            num = e.RowIndex;
            maDichVu.Text = danhSachDichVu.Rows[num].Cells[0].Value.ToString();
            tenDichVu.Text= danhSachDichVu.Rows[num].Cells[1].Value.ToString();
            giaDV.Text= danhSachDichVu.Rows[num].Cells[2].Value.ToString(); 
            donViTinhDV.Text= danhSachDichVu.Rows[num].Cells[3].Value.ToString();
            ghiChuDV.Text= danhSachDichVu.Rows[num].Cells[4].Value.ToString();
        }

        private void danhSachThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int num;
            num = e.RowIndex;
            maThuoc.Text = danhSachThuoc.Rows[num].Cells[0].Value.ToString();
            tenThuoc.Text = danhSachThuoc.Rows[num].Cells[1].Value.ToString();
            giaThuoc.Text = danhSachThuoc.Rows[num].Cells[2].Value.ToString();
            donViTinhThuoc.Text = danhSachThuoc.Rows[num].Cells[3].Value.ToString();
            ghiChuThuoc.Text = danhSachThuoc.Rows[num].Cells[4].Value.ToString();
        }

        private void danhSachTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int num;
            num = e.RowIndex;
            tenTaiKhoan.Text = danhSachTaiKhoan.Rows[num].Cells[0].Value.ToString();
            matKhau.Text = danhSachTaiKhoan.Rows[num].Cells[1].Value.ToString();
            quyenTruyCap.SelectedItem = danhSachTaiKhoan.Rows[num].Cells[2].Value.ToString();
        }
    }
}
