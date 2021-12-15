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
    public partial class doiMatKhau : Form
    {
        busTaiKhoan busTaiKhoan = new busTaiKhoan();
        string ten=null;
        string quyen = null;
        public doiMatKhau(string tenTaiKhoan, string quyenTruyCap)
        {
            InitializeComponent();
            ten = tenTaiKhoan;
            quyen = quyenTruyCap;


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            taikhoan taikhoan = new taikhoan(ten, textBox1.Text, quyen);
            
            if (textBox1.Text.Equals(busTaiKhoan.matKhau(taikhoan)) && textBox2.Text.Equals(textBox3.Text))
            {
                if (busTaiKhoan.suamatkhau(taikhoan))
                MessageBox.Show("Thay đổi mật khẩu thành công");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void textBox1_CursorChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                taikhoan taikhoan = new taikhoan(ten, textBox1.Text, quyen);
                if (textBox1.Text != busTaiKhoan.matKhau(taikhoan))
                {
                    MessageBox.Show("Sai mật khẩu");
                    textBox1.Focus();
                }
                textBox2.Focus();
            }    
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                taikhoan taikhoan = new taikhoan(ten, textBox1.Text, quyen);

                if (textBox1.Text.Equals(busTaiKhoan.matKhau(taikhoan)) && textBox2.Text.Equals(textBox3.Text))
                {
                    if (busTaiKhoan.suamatkhau(taikhoan))
                        MessageBox.Show("Thay đổi mật khẩu thành công");
                }
                else if (textBox2.Text!=textBox3.Text)
                {
                    MessageBox.Show("Mật khẩu không khớp");
                    textBox2.Focus();
                }
            }    
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            textBox3.Focus();
        }
    }
}
