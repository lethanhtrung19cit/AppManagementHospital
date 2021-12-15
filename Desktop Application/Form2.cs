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
    public partial class Form2 : Form
    {
        BUS busBenhNhan = new BUS();
        busBacSi busBacSi = new busBacSi();
        busKhamBenh busKhamBenh = new busKhamBenh();
        busNoiTru busNoiTru = new busNoiTru();
        busCapThuoc busCapThuoc = new busCapThuoc();
        busDichVu busDichVu = new busDichVu();
        busXuatVien busXuatVien = new busXuatVien();
        string quyentruycap=null;
        string tentaikhoan = null;
        public Form2(string tenTaiKhoan, string quyenTruyCap)
        {
                
            InitializeComponent();
            tentaikhoan = tenTaiKhoan;
            quyentruycap = quyenTruyCap;
            if (quyenTruyCap.Equals("Y tá"))
            {
                adminToolStripMenuItem.Visible = false;
            }
            button20.Enabled = false;
            button23.Enabled = false;
            button41.Enabled = false;
            button30.Enabled = false;
            load();
            danhsachThuoc.DataSource = busCapThuoc.danhSachThuoc();
            danhSachDichVu.DataSource = busDichVu.danhSachDichVu();
            khoa.DataSource = busKhamBenh.khoaKham();
            khoa.DisplayMember = "Khoa";
            khoa.ValueMember = "Khoa";
            bacSi.DataSource = busKhamBenh.tenBacSi(khoa.SelectedValue.ToString());
            bacSi.DisplayMember = "BacSi";
            bacSi.ValueMember = "BacSi";
        }
        public void load()
        {
            danhSachBenhNhan.DataSource = busBenhNhan.getBenhNhan();
            dataGridView2.DataSource = busBenhNhan.getChoKham();
            dataGridView3.DataSource = busNoiTru.getNoiTru();
            dataGridView5.DataSource = busBacSi.getBacSi();
            danhSachDonThuoc.DataSource = busCapThuoc.getCapThuoc();
            danhSachSuDungDV.DataSource = busDichVu.getDichVu();
            maBacSiBS.Text = busBacSi.maBacSi();
            //maBenhAn.Enabled = false;
            //maBenhNhan.Enabled = false;
        }
        private void tabPage2_Click(object sender, EventArgs e)
        {
            load();
        }
        string path = null;
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Title = "Chon mot hinh anh";
            openDlg.RestoreDirectory = true;
            openDlg.Filter = "All images (*.bmp;*.jpg;*.gif;*.png)|*.bmp;*.jpg;*.gif;*.png";
            openDlg.Multiselect = false;
            if (openDlg.ShowDialog() == DialogResult.OK)
            {

                pictureBox5.Image = Image.FromFile(openDlg.FileName);
                path = openDlg.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            danhSachBenhNhan.DataSource = busBenhNhan.searchBenhNhan(timKiem.Text);
        }

        private void huytimkiem_Click(object sender, EventArgs e)
        {
            load();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            string gioitinh;
            if (nam.Checked == true) gioitinh = "Nam";
            else gioitinh = "Nữ";
            DTO_QuanLyBenhNhan bn = new DTO_QuanLyBenhNhan(hoTen.Text, gioitinh, ngaySinh.Text, diaChi.Text, ngheNghiep.Text, SDT.Text, doiTuong.Text, CMND.Text);
            ChiTietKhamBenh kb = new ChiTietKhamBenh(ChuanDoanSauCung.Text, ngayKham.Text, phongKham.Text);

            if (busBenhNhan.suaBenhNhan(bn, kb, maBenhNhan.Text, path))
            {

                danhSachBenhNhan.DataSource = busBenhNhan.getBenhNhan();
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (busBenhNhan.xoabenhnhan(maBenhNhan.Text))
                danhSachBenhNhan.DataSource = busBenhNhan.getBenhNhan();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            ThemBenhNhan a = new ThemBenhNhan();
            a.ShowDialog();
            load();
        }
        public void vidu()
        {
            SDT.Text = "thành công";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int num;
            num = e.RowIndex;
            maBenhNhan.Text = danhSachBenhNhan.Rows[num].Cells[0].Value.ToString();
            hoTen.Text = danhSachBenhNhan.Rows[num].Cells[1].Value.ToString();
            string gioitinh = danhSachBenhNhan.Rows[num].Cells[2].Value.ToString();
            if (gioitinh.Equals("Nam")) nam.Checked = true;
            else nu.Checked = true;
            
            
            ngaySinh.Text = danhSachBenhNhan.Rows[num].Cells[3].Value.ToString();
            diaChi.Text = danhSachBenhNhan.Rows[num].Cells[4].Value.ToString();
            ngheNghiep.Text = danhSachBenhNhan.Rows[num].Cells[5].Value.ToString();
            SDT.Text = danhSachBenhNhan.Rows[num].Cells[6].Value.ToString();
            maBenhAn.Text = danhSachBenhNhan.Rows[num].Cells[7].Value.ToString();

            doiTuong.Text = danhSachBenhNhan.Rows[num].Cells[9].Value.ToString();
            string a1 = danhSachBenhNhan.Rows[num].Cells[10].Value.ToString();
            if (a1 != "")
            {
                byte[] a = (byte[])danhSachBenhNhan.Rows[num].Cells[10].Value;
                MemoryStream ms = new MemoryStream(a);

                Image img = Image.FromStream(ms);

                pictureBox5.Image = img;
            }
            else pictureBox5.Image = null;
            CMND.Text = danhSachBenhNhan.Rows[num].Cells[11].Value.ToString();
            ngayKham.Text = danhSachBenhNhan.Rows[num].Cells[12].Value.ToString();
            phongKham.Text = danhSachBenhNhan.Rows[num].Cells[13].Value.ToString();
            ChuanDoanSauCung.Text = danhSachBenhNhan.Rows[num].Cells[14].Value.ToString();
          
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView2.ForeColor = Color.Black;
            
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            load();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = busBenhNhan.searchChoKham(textBox7.Text);
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int num;
            num = e.RowIndex;
            maBNCK.Text = dataGridView2.Rows[num].Cells[0].Value.ToString();
            hotenCK.Text = dataGridView2.Rows[num].Cells[1].Value.ToString();
            gioiTinh.Text = dataGridView2.Rows[num].Cells[2].Value.ToString();
            string[] ngaysinh = (dataGridView2.Rows[num].Cells[3].Value.ToString()).Split(' ');
            NSCK.Text = ngaysinh[0];
            diaChiCK.Text = dataGridView2.Rows[num].Cells[4].Value.ToString();
            
            SDTCK.Text = dataGridView2.Rows[num].Cells[6].Value.ToString();
            

            
            string a1 = dataGridView2.Rows[num].Cells[10].Value.ToString();
            if (a1 != "")
            {
                byte[] a = (byte[])dataGridView2.Rows[num].Cells[10].Value;
                MemoryStream ms = new MemoryStream(a);

                Image img = Image.FromStream(ms);

                pictureBox6.Image = img;
            }
            else pictureBox5.Image = null;
            
            yeuCauKhamCK.Text= dataGridView2.Rows[num].Cells[12].Value.ToString();
            maPhieuKham.Text = dataGridView2.Rows[num].Cells[13].Value.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            load();
        }

        private void button32_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            string gioitinh;
            if (namBS.Checked == true) gioitinh = "Nam";
            else gioitinh = "Nữ";
            QuanLyBacSi bs = new QuanLyBacSi(hoTenBS.Text, gioitinh, ngaySinhBS.Text, diaChiBS.Text, SDTBS.Text, CMNDBS.Text, maKhoaBS.Text, tenKhoaBS.Text, chucVuBS.Text);
           

            if (busBacSi.themBacSi(bs, maBacSiBS.Text, path))
            {
                MessageBox.Show("Thêm thành công");
                load();
            }
            
        }

        private void button44_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Title = "Chon mot hinh anh";
            openDlg.RestoreDirectory = true;
            openDlg.Filter = "All images (*.bmp;*.jpg;*.gif;*.png)|*.bmp;*.jpg;*.gif;*.png";
            openDlg.Multiselect = false;
            if (openDlg.ShowDialog() == DialogResult.OK)
            {

                pictureBox8.Image = Image.FromFile(openDlg.FileName);
                path = openDlg.FileName;
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            string gioitinh;
            if (namBS.Checked == true) gioitinh = "Nam";
            else gioitinh = "Nữ";

            QuanLyBacSi bs = new QuanLyBacSi(hoTenBS.Text, gioitinh, ngaySinhBS.Text, diaChiBS.Text, SDTBS.Text, CMNDBS.Text, maKhoaBS.Text, tenKhoaBS.Text, chucVuBS.Text);

            if (busBacSi.suaBacSi(bs, maBacSiBS.Text, path))
            {

                dataGridView5.DataSource = busBacSi.getBacSi();
            }
        }

        private void maBacSi_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ChiTietKhamBenh ctkb = new ChiTietKhamBenh(maPhieuKham.Text, nhomMau.Text, tinhTrangKhamBenh.Text, chanDoanSoBo.Text, chanDoanSauCung.Text, huongDieuTri.Text, float.Parse(canNang.Text), float.Parse(nhietDo.Text), float.Parse(mach.Text), float.Parse(huyetAp.Text), float.Parse(nhipTho.Text),  bacSi.Text, maBNCK.Text, ngayKhamCK.Text, phongKhamCK.Text);
            Danhsachchokham dsck = new Danhsachchokham(maPhieuKham.Text, maBNCK.Text, yeuCauKhamCK.Text);
            if (busKhamBenh.themBenhNhan(ctkb, dsck))
            {
                MessageBox.Show("Thêm thành công");
                load();
                button41.Enabled = true;
                button20.Enabled = true;
                button23.Enabled = true;
                button30.Enabled = true;
            }
        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void tenBenh_TextChanged(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {
            ChuyenVien cv = new ChuyenVien(maNoiTru1, maBenhNhan.Text, hoTen.Text, maBenhAn.Text);
            cv.ShowDialog();
            load();
        }

        private void button39_Click(object sender, EventArgs e)
        {

        }

        private void button42_Click(object sender, EventArgs e)
        {
            bangThongKe.DataSource = busBenhNhan.thongKeBenhNhan(ngay.Text);
        }

        private void ngay_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void ngay_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                
        }

        private void button41_Click(object sender, EventArgs e)
        {
            Dieutrinoitru dtnt = new Dieutrinoitru(maBNCK.Text);
            dtnt.ShowDialog();
            load();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Dieutrinoitru dtnt = new Dieutrinoitru();
            dtnt.ShowDialog();
            load();
        }
        string maNoiTru1 = null;
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int num;
            num = e.RowIndex;
            maBN.Text = dataGridView3.Rows[num].Cells[1].Value.ToString();
            tenBenhNhan.Text= dataGridView3.Rows[num].Cells[2].Value.ToString();
            MaGiuong.Text = dataGridView3.Rows[num].Cells[6].Value.ToString();
            
            Phong.Text= dataGridView3.Rows[num].Cells[9].Value.ToString(); 
            ngayvaoVien.Text= dataGridView3.Rows[num].Cells[10].Value.ToString();
            maNoiTru1= dataGridView3.Rows[num].Cells[0].Value.ToString();
            tenBenh.Text = busNoiTru.tenBenh(maBN.Text);
            byte[] a = (byte[])busNoiTru.image(maBN.Text);
            MemoryStream ms = new MemoryStream(a);

            Image img = Image.FromStream(ms);

            pictureBox7.Image = img;
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            QuanLyNoiTru qlnt = new QuanLyNoiTru(maBN.Text, MaGiuong.Text, ngayvaoVien.Text, Phong.Text);
            if (busNoiTru.suaNoiTru(qlnt, maNoiTru1))
            {
                load();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (busNoiTru.xoaNoiTru(maNoiTru1))
            {
                load();
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            bangThongKe.DataSource= busNoiTru.getThongKeNhapVien(ngay.Text);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button46_Click(object sender, EventArgs e)
        {
            QuanLyDonThuoc qlct = new QuanLyDonThuoc(maBenhNhanCT.Text, maThuocCT.Text, lieuDungCT.Text, ghiChuCT.Text);
            if (busCapThuoc.suaDonThuoc(qlct, maDonThuoc))
            {
                load();
            }
        }
        string maDonThuoc = null;
        private void danhSachDonThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int num;
            num = e.RowIndex;
            maDonThuoc= danhSachDonThuoc.Rows[num].Cells[0].Value.ToString();
            maBenhNhanCT.Text = danhSachDonThuoc.Rows[num].Cells[1].Value.ToString();
            tenBenhNhanCT.Text = danhSachDonThuoc.Rows[num].Cells[2].Value.ToString();
            maThuocCT.Text= danhSachDonThuoc.Rows[num].Cells[6].Value.ToString();
            tenThuocCT.Text= danhSachDonThuoc.Rows[num].Cells[7].Value.ToString();
            lieuDungCT.Text = danhSachDonThuoc.Rows[num].Cells[8].Value.ToString();
            ghiChuCT.Text = danhSachDonThuoc.Rows[num].Cells[9].Value.ToString();
            byte[] a = busCapThuoc.image(maBenhNhanCT.Text);
            MemoryStream ms = new MemoryStream(a);

            Image img = Image.FromStream(ms);

            pictureBox9.Image = img;
        }

        private void button47_Click(object sender, EventArgs e)
        {
            if (busCapThuoc.xoaDonThuoc(maDonThuoc))
            {
                load();
            }    
        }

        private void button48_Click(object sender, EventArgs e)
        {
            CapThuoc ct = new CapThuoc();
            ct.ShowDialog();
            danhSachDonThuoc.DataSource = busCapThuoc.getCapThuoc();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CapThuoc ct = new CapThuoc(maBN.Text);
            ct.ShowDialog();
            danhSachDonThuoc.DataSource = busCapThuoc.getCapThuoc();
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Dichvu dv = new Dichvu(maBN.Text);
            dv.ShowDialog();
            load();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Dichvu dv = new Dichvu();
            dv.ShowDialog();
            load();
        }
        string maChiTietDichVu = null;
        private void danhSachSuDungDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int num;
            num = e.RowIndex;
            maBenhNhanDV.Text= danhSachSuDungDV.Rows[num].Cells[0].Value.ToString();
            tenBenhNhanDV.Text= danhSachSuDungDV.Rows[num].Cells[1].Value.ToString();
            tenDichVuDV.Text= danhSachSuDungDV.Rows[num].Cells[2].Value.ToString(); 

            soLanThucHienDV.Text= danhSachSuDungDV.Rows[num].Cells[5].Value.ToString();
            
            ghiChuDV.Text= danhSachSuDungDV.Rows[num].Cells[7].Value.ToString();
            byte[] a = (byte[])danhSachSuDungDV.Rows[num].Cells[8].Value;
            MemoryStream ms = new MemoryStream(a);

            Image img = Image.FromStream(ms);

            pictureBox10.Image = img;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ThanhToan tt = new ThanhToan(maBenhNhan.Text);
            tt.ShowDialog();
            load();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            quanLiXuatVien qlxv = new quanLiXuatVien(maBN.Text, DateTime.Now.ToString());
            QuanLyNoiTru qlnt = new QuanLyNoiTru(maBN.Text, MaGiuong.Text, ngayvaoVien.Text, Phong.Text);
            //if (busNoiTru.xoaNoiTru(maBenhNhan.Text) && busXuatVien.themXuatVien(qlxv))
                //{
                XuatVien xv = new XuatVien(maNoiTru1, maBenhNhan.Text);
                xv.ShowDialog();
                load();
            //}
        }

        private void khoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            bacSi.DataSource = busKhamBenh.tenBacSi(khoa.SelectedValue.ToString());
            bacSi.DisplayMember = "BacSi";
            bacSi.ValueMember = "BacSi";
            //bacSi.Text = khoa.SelectedValue.ToString();
        }

        private void khoa_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }

        private void khoa_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void khoa_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Dichvu dv = new Dichvu(maBNCK.Text);
            dv.ShowDialog();
            load();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            CapThuoc ct = new CapThuoc(maBN.Text);
            ct.ShowDialog();
            danhSachDonThuoc.DataSource = busCapThuoc.getCapThuoc();
        }

        private void button30_Click_1(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void maDichVuDV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                tenDichVuDV.Text = busDichVu.tenDichVu(maDichVuDV.Text);
            }
        }

        private void maThuocCT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                tenThuocCT.Text = busCapThuoc.tenThuoc(maThuocCT.Text);
            }
        }

        private void button48_Click_1(object sender, EventArgs e)
        {
            busCapThuoc busCapThuoc = new busCapThuoc();
            if (busCapThuoc.thanhtoan(maDonThuoc)) MessageBox.Show("Đã thanh toán");
            else
            {
                double tongTien = busCapThuoc.tongTienThuoc(maBenhNhanCT.Text);
                string hoaDon = "HÓA ĐƠN THANH TOÁN TIỀN THUỐC";
                string tenThuoc = "thuoc";
                HoaDonThanhToan a = new HoaDonThanhToan(tentaikhoan, maDonThuoc, maBenhNhanCT.Text, tongTien, hoaDon, tenThuoc);
                a.ShowDialog();
                load();
            }
        }

        private void button51_Click(object sender, EventArgs e)
        {
            busNoiTru busNoiTru = new busNoiTru();
            if (busNoiTru.thanhtoan(maNoiTru1)) MessageBox.Show("Đã thanh toán");
            else
            {
                string ngayNhapVien = busNoiTru.ngayNhapVien(maBN.Text).ToShortDateString();
                string ngayXuatVien = DateTime.Today.ToShortDateString();
                string soNgay = Convert.ToString((Convert.ToDateTime(ngayXuatVien) - Convert.ToDateTime(ngayNhapVien)).TotalDays);
                double tongTien = int.Parse(soNgay) * 200000;
                string hoaDon = "HÓA ĐƠN THANH TOÁN VIỆN PHÍ";
                string ten = "noitru";
                HoaDonThanhToan a = new HoaDonThanhToan(tentaikhoan, maNoiTru1, maBN.Text, tongTien, hoaDon, ten);
                a.ShowDialog();
                load();
            }
        }

        private void changePassWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doiMatKhau doi = new doiMatKhau(tentaikhoan, quyentruycap);
            doi.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dangnhap a1 = new Dangnhap();
            this.Visible = false;
            a1.Show();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            /*if(dataGridView1.Rows.Count>0)
            {
                Microsoft.Office.Interop.Excel.Application Export = new Microsoft.Office.Interop.Excel.Application();
                Export.Application.Workbooks.Add(Type.Missing);
                for(int i= 1;i<dataGridView1.Columns.Count+1;i++)
                {
                    Export.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }
                foreach()
                Export.Columns.AutoFit();
                Export.Visible = true;
            }*/
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < bangThongKe.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = bangThongKe.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < bangThongKe.Rows.Count - 1; i++)
            {
                for (int j = 0; j < bangThongKe.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = bangThongKe.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            //workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            //app.Quit();
            app.Visible = true;
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fSystemMgn a = new fSystemMgn();
            a.ShowDialog();
        }

        private void button52_Click(object sender, EventArgs e)
        {

        }

        private void button54_Click(object sender, EventArgs e)
        {
            ChuyenVien cv = new ChuyenVien(maNoiTru1, maBN.Text, hoTen.Text, maBenhAn.Text);
            cv.ShowDialog();
            load();
        }

        private void button53_Click(object sender, EventArgs e)
        {
            quanLiXuatVien qlxv = new quanLiXuatVien(maBN.Text, DateTime.Now.ToString());
            QuanLyNoiTru qlnt = new QuanLyNoiTru(maBN.Text, MaGiuong.Text, ngayvaoVien.Text, Phong.Text);
            //if (busNoiTru.xoaNoiTru(maBenhNhan.Text) && busXuatVien.themXuatVien(qlxv))
            //{
            XuatVien xv = new XuatVien(maNoiTru1, maBN.Text);
            xv.ShowDialog();
            load();
            //}
        }
    }
}
