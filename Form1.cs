using LapTrinhTrucQuanKiemTra.Models;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Windows.Forms;

namespace LapTrinhTrucQuanKiemTra
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            TaiLaiDanhSachNhanVien();
        }
        private void TaiLaiDanhSachNhanVien()
        {
            using (var db = new DuLieu_NhanSuContext())
            {
                var nhanViens = db.NhanViens.ToList();
                dtgDanhSachNhanVien.DataSource = nhanViens;
            }
        }
        private bool _dangKhoiTao;

        private int _idhientai = 0;
        private void txtLuongCoBan_TextChanged(object sender, EventArgs e)
        {
            int Soluong = 0;
            if (!int.TryParse(txtLuongCoBan.Text, out Soluong) || !float.TryParse(txtLuongCoBan.Text, out float HeSoLuong))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hoặt số thực cho Lương cơ bản! ");
             
                txtLuongCoBan.Clear();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text) || string.IsNullOrWhiteSpace(txtTenNV.Text) || string.IsNullOrWhiteSpace(txtLuongCoBan.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            using var db = new DuLieu_NhanSuContext();
            var query = db.NhanViens.FirstOrDefault(nv => nv.MaNhanVien == txtMaNV.Text);

            if (query != null)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNV.Clear();
                txtMaNV.Focus();
                return;
            }

            var moi = new NhanVien
            {
                MaNhanVien = txtMaNV.Text.Trim(),
                TenNhanVien = txtTenNV.Text,
                LuongCoBan = txtLuongCoBan.Text.Trim()



            };
            db.NhanViens.Add(moi);
            db.SaveChanges();

            MessageBox.Show("Thêm mới mặt hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TaiLaiDanhSachNhanVien();
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtLuongCoBan.Clear();
            txtMaNV.Focus();
            btnThem.Enabled = false;

        }

        private void dtgDanhSachNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (_idhientai < 0) return;
            var row = dtgDanhSachNhanVien.Rows[e.RowIndex];
            if (row.DataBoundItem is NhanVien item)
            {
                txtMaNV.Text = item.MaNhanVien;
                txtTenNV.Text = item.TenNhanVien;
                txtLuongCoBan.Text = item.LuongCoBan;
                _idhientai = e.RowIndex;
            }
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
          
            DialogResult result = MessageBox.Show("Bạn có muốn xóa nhân viên này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using var db = new DuLieu_NhanSuContext();
                var item = db.NhanViens.FirstOrDefault(nv => nv.MaNhanVien == txtMaNV.Text);
                if (item != null)
                {
                    db.NhanViens.Remove(item);
                    db.SaveChanges();
                    MessageBox.Show("Đã xóa nhân viên thành công");
                    TaiLaiDanhSachNhanVien();
                    txtMaNV.Clear();
                    txtTenNV.Clear();
                    txtLuongCoBan.Clear();
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    txtMaNV.Focus();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            using var db = new DuLieu_NhanSuContext();
            var item = db.NhanViens.FirstOrDefault(nv => nv.MaNhanVien == txtMaNV.Text);
            if (item != null)
            {
                item.MaNhanVien = txtMaNV.Text.Trim();
                item.TenNhanVien = txtTenNV.Text;
                item.LuongCoBan = txtLuongCoBan.Text.Trim();
                db.SaveChanges();
                MessageBox.Show("Đã cập nhân viên thành công");
                TaiLaiDanhSachNhanVien();
                txtMaNV.Clear();
                txtTenNV.Clear();
                txtLuongCoBan.Clear();
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                txtMaNV.Focus();
            }
        }
    }
}
