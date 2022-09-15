using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Do_an_cuoi_ki.DAO;

namespace Do_an_cuoi_ki
{
    public partial class FrmTaiKhoan : Form
    {
        public FrmTaiKhoan()
        {
            InitializeComponent();
            LoadTaiKhoan();
        }
        int flag = 0;
        void Binding()
        {
            txtTenDangNhap.Text = dtgvTaiKhoan.CurrentCell.OwningRow.Cells[0].Value.ToString();
            txtTenHienThi.Text= dtgvTaiKhoan.CurrentCell.OwningRow.Cells[1].Value.ToString();
            txtMatKhau.Text= dtgvTaiKhoan.CurrentCell.OwningRow.Cells[2].Value.ToString();
            txtLoaiTaiKhoan.Text = dtgvTaiKhoan.CurrentCell.OwningRow.Cells[3].Value.ToString();
            txtMaNhanVien.Text= dtgvTaiKhoan.CurrentCell.OwningRow.Cells[4].Value.ToString();
        }
        void LoadTaiKhoan()
        {
            dtgvTaiKhoan.DataSource = TaiKhoanDAO.Instance.LoadTaiKhoan();
        }

        private void dtgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Binding();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            flag = 1;
            txtLoaiTaiKhoan.Text = "";
            txtMaNhanVien.Text = "";
            txtMatKhau.Text = "";
            txtTenDangNhap.Text = "";
            txtTenHienThi.Text = "";
            btnThem.Enabled = false;
            
            btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            flag = 2;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                string tendn = txtTenDangNhap.Text;
                string tenhienthi = txtTenHienThi.Text;
                string matkhau = txtMatKhau.Text;
                int loaitk = Convert.ToInt32(txtLoaiTaiKhoan.Text.Trim());
                int manv = Convert.ToInt32( txtMaNhanVien.Text);
                if (TaiKhoanDAO.Instance.ThemTaiKhoan(tendn, tenhienthi, matkhau, loaitk, manv))
                    MessageBox.Show("Thêm thành công", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm thất bại", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadTaiKhoan();
                btnThem.Enabled = true;

                btnXoa.Enabled = true;
            }
            if (flag == 2)
            {
                string tendn = txtTenDangNhap.Text;
                string matkhau = txtMatKhau.Text;
               
                if (TaiKhoanDAO.Instance.XoaTaiKhoan(tendn,matkhau))
                    MessageBox.Show("Xóa thành công", "Thông báo!",
                        MessageBoxButtons.OK, MessageBoxIcon.Question);
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo!", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadTaiKhoan();
                btnThem.Enabled = true;

                btnXoa.Enabled = true;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
         
            btnXoa.Enabled = true;
      
        }

       
    }
}
