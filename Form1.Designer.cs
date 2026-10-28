namespace LapTrinhTrucQuanKiemTra
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            txtLuongCoBan = new TextBox();
            txtTenNV = new TextBox();
            txtMaNV = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            btnXoa = new Button();
            btnSua = new Button();
            btnThoat = new Button();
            btnThem = new Button();
            dtgDanhSachNhanVien = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachNhanVien).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtLuongCoBan);
            groupBox1.Controls.Add(txtTenNV);
            groupBox1.Controls.Add(txtMaNV);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(32, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(407, 144);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // txtLuongCoBan
            // 
            txtLuongCoBan.Location = new Point(123, 99);
            txtLuongCoBan.Name = "txtLuongCoBan";
            txtLuongCoBan.Size = new Size(262, 27);
            txtLuongCoBan.TabIndex = 5;
            txtLuongCoBan.TextChanged += txtLuongCoBan_TextChanged;
            // 
            // txtTenNV
            // 
            txtTenNV.Location = new Point(123, 58);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(262, 27);
            txtTenNV.TabIndex = 4;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(123, 25);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(262, 27);
            txtMaNV.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 102);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 2;
            label3.Text = "Lương cơ bản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 65);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên nhân viên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 28);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã nhân viên:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Location = new Point(487, 25);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(270, 147);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thao tác";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnXoa);
            groupBox3.Controls.Add(btnSua);
            groupBox3.Controls.Add(btnThoat);
            groupBox3.Controls.Add(btnThem);
            groupBox3.Location = new Point(20, 28);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(244, 113);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Các chức năng";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(126, 74);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(17, 72);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(126, 26);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(17, 26);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // dtgDanhSachNhanVien
            // 
            dtgDanhSachNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDanhSachNhanVien.Location = new Point(32, 194);
            dtgDanhSachNhanVien.Name = "dtgDanhSachNhanVien";
            dtgDanhSachNhanVien.RowHeadersWidth = 51;
            dtgDanhSachNhanVien.Size = new Size(725, 226);
            dtgDanhSachNhanVien.TabIndex = 3;
            dtgDanhSachNhanVien.CellContentClick += dtgDanhSachNhanVien_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtgDanhSachNhanVien);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Quản lý Nhân viên/Nhân sự - VP104";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachNhanVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtLuongCoBan;
        private TextBox txtTenNV;
        private TextBox txtMaNV;
        private ContextMenuStrip contextMenuStrip1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThoat;
        private Button btnThem;
        private DataGridView dtgDanhSachNhanVien;
    }
}
