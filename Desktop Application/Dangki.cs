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
    public partial class Dangki : Form
    {
        busTaiKhoan busTaiKhoan = new busTaiKhoan();
        public Dangki()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            textBox3.PasswordChar = '*';
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e1)
        {
            taikhoan a = new taikhoan(textBox1.Text, textBox2.Text, "Y tá");
            busTaiKhoan bus = new busTaiKhoan();
          
            if (textBox3.Text != textBox2.Text)
            {
                MessageBox.Show("Nhập lại mật khẩu không khớp");
            }
            else if (textBox3.Text.Equals(textBox2.Text) && bus.themtaikhoan(a))
            {
                MessageBox.Show("Thêm thành công");
                Dangnhap a1 = new Dangnhap();
                this.Visible = false;
                a1.Show();
            }
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                if (busTaiKhoan.kiemtratontai(textBox1.Text))
                textBox2.Focus();
                else
                {
                    textBox1.Focus();
                    MessageBox.Show("Tên đăng nhập đã tồn tại");
                }
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                textBox3.Focus();
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            taikhoan a = new taikhoan(textBox1.Text, textBox2.Text, "Y tá");
            busTaiKhoan bus = new busTaiKhoan();
            if (e.KeyCode==Keys.Enter)
            {
                if (textBox3.Text!=textBox2.Text)
                {
                    MessageBox.Show("Nhập lại mật khẩu không khớp");
                }
                else if (textBox3.Text.Equals(textBox2.Text) && (bus.themtaikhoan(a)))
                {
                    MessageBox.Show("Thêm thành công");
                    Dangnhap a1 = new Dangnhap();
                    this.Visible = false;
                    a1.Show();
                }    
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
