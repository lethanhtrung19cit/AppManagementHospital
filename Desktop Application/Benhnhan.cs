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
using System.Drawing.Imaging;
namespace Desktop_Application
{
    public partial class Benhnhan : Form
    {
        
        public Benhnhan()
        {
            InitializeComponent();
        }

        BUS busQuanLy = new BUS();
        string path = null;
        private void button1_Click(object sender, EventArgs e)
        {

            //OpenFileDialog openDlg = new OpenFileDialog();
            //openDlg.Title = "Chon mot hinh anh";
            //openDlg.RestoreDirectory = true;
            //openDlg.Filter = "All images (*.bmp;*.jpg;*.gif;*.png)|*.bmp;*.jpg;*.gif;*.png";
            //openDlg.Multiselect = false;
            //if (openDlg.ShowDialog() == DialogResult.OK)
            //{

            //    pictureBox1.Image = Image.FromFile(openDlg.FileName);

            //}
            //using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            //{
            //    imageData = new Byte[fs.Length];
            //    fs.Read(imageData, 0, (int)fs.Length);
            //}

            //MemoryStream stream = new MemoryStream();
            //pictureBox1.Image.Save(stream, ImageFormat.Jpeg);
            //MyDBContextDataContext myDB = new MyDBContextDataContext();
            //picture1 benhnhan = new picture1();
            //benhnhan.img = stream.ToArray();
            //myDB.picture1s.InsertOnSubmit(benhnhan);

            //myDB.SubmitChanges();
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

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
           
        }

        private void Benhnhan_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busQuanLy.getBenhNhan();
            //dataGridView1.Rows[0].Cells[0].Value = Properties.Resources.Image;
            //dataGridView1.Rows[1].Cells[0].Value = Properties.Resources.Image;
            //dataGridView1.Rows[2].Cells[0].Value = Properties.Resources.Image;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            pictureBox1.Image = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             int num;
            num = e.RowIndex;
            byte[] a = (byte[])dataGridView1.Rows[num].Cells[1].Value;
            MemoryStream ms = new MemoryStream(a);

            Image img = Image.FromStream(ms);
            pictureBox1.Image = img;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //pictureBox1.Image.Save(Application.StartupPath + "/image/" + tenhinh + ".jpg");

            //info.HinhAnh = "image/" + tenhinh + ".jpg";

            //busQuanLy.id(textBox1.Text, path, textBox7.Text);
        }

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    byte[] img = busQuanLy.picture();
        //    MemoryStream str = new MemoryStream(img);
        //}
    }
}
