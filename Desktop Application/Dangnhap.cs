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
    public partial class Dangnhap : Form
    {
        busTaiKhoan busTaiKhoan = new busTaiKhoan();
        //sqltaikkhoan tk = new sqltaikhoan();
        public Dangnhap()
        {
            InitializeComponent();
            txtmatkhau.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //taikhoan tk1 = new taikhoan(txttaikhoan.Text, txtmatkhau.Text);
            //if (tk.tentaikhoan(tk1))
            //{
            //    MessageBox.Show("Đăng nhập thành công");
            //}
            //else
            //{
            //    MessageBox.Show("Đăng nhập thất bại");
            //}


        }

        private void btdangnhap_Click(object sender, EventArgs e)
        {
            taikhoan tk = new taikhoan(txttaikhoan.Text, txtmatkhau.Text, quyenTruyCap.SelectedItem.ToString());
            if (busTaiKhoan.matKhau(tk).ToString().Equals("null"))
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            else if (busTaiKhoan.matKhau(tk).ToString().Equals(txtmatkhau.Text))
            {
               
                Visible = false;
                Form2 a = new Form2(txttaikhoan.Text, quyenTruyCap.SelectedItem.ToString());
                a.Show();
                
            }
            else MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
        }
    }
}
