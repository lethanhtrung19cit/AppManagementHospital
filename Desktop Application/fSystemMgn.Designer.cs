
namespace Desktop_Application
{
    partial class fSystemMgn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.quyenTruyCap = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.matKhau = new System.Windows.Forms.TextBox();
            this.tenTaiKhoan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.danhSachTaiKhoan = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.ghiChuThuoc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.donViTinhThuoc = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.giaThuoc = new System.Windows.Forms.TextBox();
            this.tenThuoc = new System.Windows.Forms.TextBox();
            this.maThuoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.danhSachThuoc = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.ghiChuDV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.donViTinhDV = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.giaDV = new System.Windows.Forms.TextBox();
            this.tenDichVu = new System.Windows.Forms.TextBox();
            this.maDichVu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.danhSachDichVu = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachTaiKhoan)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachThuoc)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(795, 345);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.quyenTruyCap);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.matKhau);
            this.tabPage1.Controls.Add(this.tenTaiKhoan);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.danhSachTaiKhoan);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(787, 319);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tài khoản";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // quyenTruyCap
            // 
            this.quyenTruyCap.FormattingEnabled = true;
            this.quyenTruyCap.Items.AddRange(new object[] {
            "Quản trị hệ thống",
            "Y tá"});
            this.quyenTruyCap.Location = new System.Drawing.Point(622, 86);
            this.quyenTruyCap.Name = "quyenTruyCap";
            this.quyenTruyCap.Size = new System.Drawing.Size(159, 21);
            this.quyenTruyCap.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(652, 290);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(585, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(520, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(516, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mật Khẩu";
            // 
            // matKhau
            // 
            this.matKhau.Location = new System.Drawing.Point(622, 149);
            this.matKhau.Name = "matKhau";
            this.matKhau.Size = new System.Drawing.Size(159, 20);
            this.matKhau.TabIndex = 5;
            // 
            // tenTaiKhoan
            // 
            this.tenTaiKhoan.Location = new System.Drawing.Point(622, 21);
            this.tenTaiKhoan.Name = "tenTaiKhoan";
            this.tenTaiKhoan.Size = new System.Drawing.Size(159, 20);
            this.tenTaiKhoan.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(516, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quyền truy cập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(516, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Tài khoản";
            // 
            // danhSachTaiKhoan
            // 
            this.danhSachTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.danhSachTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhSachTaiKhoan.Location = new System.Drawing.Point(6, 6);
            this.danhSachTaiKhoan.Name = "danhSachTaiKhoan";
            this.danhSachTaiKhoan.Size = new System.Drawing.Size(504, 307);
            this.danhSachTaiKhoan.TabIndex = 0;
            this.danhSachTaiKhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.danhSachTaiKhoan_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.ghiChuThuoc);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.donViTinhThuoc);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.giaThuoc);
            this.tabPage2.Controls.Add(this.tenThuoc);
            this.tabPage2.Controls.Add(this.maThuoc);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.danhSachThuoc);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(787, 319);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kho Thuốc";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(516, 253);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Ghi chú";
            // 
            // ghiChuThuoc
            // 
            this.ghiChuThuoc.Location = new System.Drawing.Point(622, 253);
            this.ghiChuThuoc.Name = "ghiChuThuoc";
            this.ghiChuThuoc.Size = new System.Drawing.Size(159, 20);
            this.ghiChuThuoc.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(513, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Đơn vị tính";
            // 
            // donViTinhThuoc
            // 
            this.donViTinhThuoc.Location = new System.Drawing.Point(622, 194);
            this.donViTinhThuoc.Name = "donViTinhThuoc";
            this.donViTinhThuoc.Size = new System.Drawing.Size(159, 20);
            this.donViTinhThuoc.TabIndex = 20;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(712, 290);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(49, 23);
            this.button5.TabIndex = 19;
            this.button5.Text = "Xóa";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(622, 290);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(47, 23);
            this.button6.TabIndex = 18;
            this.button6.Text = "Sửa";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(527, 290);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(49, 23);
            this.button7.TabIndex = 17;
            this.button7.Text = "Thêm";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(516, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Đơn giá";
            // 
            // giaThuoc
            // 
            this.giaThuoc.Location = new System.Drawing.Point(622, 137);
            this.giaThuoc.Name = "giaThuoc";
            this.giaThuoc.Size = new System.Drawing.Size(159, 20);
            this.giaThuoc.TabIndex = 15;
            // 
            // tenThuoc
            // 
            this.tenThuoc.Location = new System.Drawing.Point(622, 83);
            this.tenThuoc.Name = "tenThuoc";
            this.tenThuoc.Size = new System.Drawing.Size(159, 20);
            this.tenThuoc.TabIndex = 14;
            // 
            // maThuoc
            // 
            this.maThuoc.Location = new System.Drawing.Point(622, 21);
            this.maThuoc.Name = "maThuoc";
            this.maThuoc.Size = new System.Drawing.Size(159, 20);
            this.maThuoc.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(516, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tên Thuốc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(516, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mã Thuốc";
            // 
            // danhSachThuoc
            // 
            this.danhSachThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.danhSachThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhSachThuoc.Location = new System.Drawing.Point(3, 6);
            this.danhSachThuoc.Name = "danhSachThuoc";
            this.danhSachThuoc.Size = new System.Drawing.Size(504, 307);
            this.danhSachThuoc.TabIndex = 10;
            this.danhSachThuoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.danhSachThuoc_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.ghiChuDV);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.donViTinhDV);
            this.tabPage3.Controls.Add(this.button8);
            this.tabPage3.Controls.Add(this.button9);
            this.tabPage3.Controls.Add(this.button10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.giaDV);
            this.tabPage3.Controls.Add(this.tenDichVu);
            this.tabPage3.Controls.Add(this.maDichVu);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.danhSachDichVu);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(787, 319);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Dịch Vụ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(517, 252);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Ghi chú";
            // 
            // ghiChuDV
            // 
            this.ghiChuDV.Location = new System.Drawing.Point(623, 252);
            this.ghiChuDV.Name = "ghiChuDV";
            this.ghiChuDV.Size = new System.Drawing.Size(159, 20);
            this.ghiChuDV.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(516, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Đơn vị tính";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // donViTinhDV
            // 
            this.donViTinhDV.Location = new System.Drawing.Point(622, 197);
            this.donViTinhDV.Name = "donViTinhDV";
            this.donViTinhDV.Size = new System.Drawing.Size(159, 20);
            this.donViTinhDV.TabIndex = 32;
            this.donViTinhDV.TextChanged += new System.EventHandler(this.donViTinhDV_TextChanged);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(713, 290);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(49, 23);
            this.button8.TabIndex = 31;
            this.button8.Text = "Xóa";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(623, 290);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(47, 23);
            this.button9.TabIndex = 30;
            this.button9.Text = "Sửa";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(528, 290);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(49, 23);
            this.button10.TabIndex = 29;
            this.button10.Text = "Thêm";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(516, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Đơn giá";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // giaDV
            // 
            this.giaDV.Location = new System.Drawing.Point(622, 139);
            this.giaDV.Name = "giaDV";
            this.giaDV.Size = new System.Drawing.Size(159, 20);
            this.giaDV.TabIndex = 27;
            this.giaDV.TextChanged += new System.EventHandler(this.giaDV_TextChanged);
            // 
            // tenDichVu
            // 
            this.tenDichVu.Location = new System.Drawing.Point(623, 83);
            this.tenDichVu.Name = "tenDichVu";
            this.tenDichVu.Size = new System.Drawing.Size(159, 20);
            this.tenDichVu.TabIndex = 26;
            // 
            // maDichVu
            // 
            this.maDichVu.Location = new System.Drawing.Point(623, 21);
            this.maDichVu.Name = "maDichVu";
            this.maDichVu.Size = new System.Drawing.Size(159, 20);
            this.maDichVu.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(517, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Tên dịch vụ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(517, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Mã dịch vụ";
            // 
            // danhSachDichVu
            // 
            this.danhSachDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.danhSachDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhSachDichVu.Location = new System.Drawing.Point(4, 6);
            this.danhSachDichVu.Name = "danhSachDichVu";
            this.danhSachDichVu.Size = new System.Drawing.Size(504, 307);
            this.danhSachDichVu.TabIndex = 22;
            this.danhSachDichVu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.danhSachDichVu_CellContentClick);
            // 
            // fSystemMgn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 352);
            this.Controls.Add(this.tabControl1);
            this.Name = "fSystemMgn";
            this.Text = "System Management";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachTaiKhoan)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachThuoc)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachDichVu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView danhSachTaiKhoan;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox matKhau;
        private System.Windows.Forms.TextBox tenTaiKhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox donViTinhThuoc;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox giaThuoc;
        private System.Windows.Forms.TextBox tenThuoc;
        private System.Windows.Forms.TextBox maThuoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView danhSachThuoc;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox donViTinhDV;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox giaDV;
        private System.Windows.Forms.TextBox tenDichVu;
        private System.Windows.Forms.TextBox maDichVu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView danhSachDichVu;
        private System.Windows.Forms.ComboBox quyenTruyCap;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ghiChuThuoc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ghiChuDV;
    }
}