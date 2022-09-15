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
    public partial class FrmNhanVien : Form
    {
        public FrmNhanVien()
        {
            InitializeComponent();
            LoadNhanVien();
        }
        void LoadNhanVien()
        {
            dtgvNhanVien.DataSource = NhanVienDAO.Instance.LoadNhanVien();
        }
        void Binding()
        {
            txtTenNV.Text = dtgvNhanVien.CurrentCell.OwningRow.Cells[1].Value.ToString();
            txtSDT.Text= dtgvNhanVien.CurrentCell.OwningRow.Cells[2].Value.ToString();
            txtDiaChi.Text= dtgvNhanVien.CurrentCell.OwningRow.Cells[3].Value.ToString();
            txtLuong.Text= dtgvNhanVien.CurrentCell.OwningRow.Cells[4].Value.ToString();
        }
        private int flag = 0;
        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 1;
            txtTenNV.Text = "";
            txtDiaChi.Text = "";
            txtLuong.Text = "";
            txtSDT.Text = "";
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 2;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int manv = Convert.ToInt32(dtgvNhanVien.CurrentCell.OwningRow.Cells[0].Value.ToString());
            if (NhanVienDAO.Instance.XoaNV(manv))
                MessageBox.Show("Xóa thành công!", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Xóa thất bại!", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            LoadNhanVien();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            float luong = (float)Convert.ToDouble(txtLuong.Text.Trim());
            string tennv = txtTenNV.Text;
            string diachi = txtDiaChi.Text;
            string sdt = txtSDT.Text;
            int manv = Convert.ToInt32(dtgvNhanVien.CurrentCell.OwningRow.Cells[0].Value.ToString());
            if (flag == 1)
            {
                if (NhanVienDAO.Instance.ThemNV(tennv,sdt,diachi,luong))
                    MessageBox.Show("Thêm thành công!", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm thất bại!", "Thông báo",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadNhanVien();
                
            }
            if (flag == 2)
            {
                if(NhanVienDAO.Instance.SuaNV(manv,tennv,sdt,diachi,luong))
                    MessageBox.Show("Sửa thành công!", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sửa thất bại!", "Thông báo",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadNhanVien();  
            }
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
        }

        private void dtgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Binding();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
        }
    }
}
