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
    public partial class FrmNhaCungCap : Form
    {
        public FrmNhaCungCap()
        {
            InitializeComponent();
            LoadNCC();
        }
        void LoadNCC()
        {
            dtgvNhaCungCap.DataSource = NhaCungCapDAO.Instance.LoadNhaCungCap();
        }
        void Binding()
        {
            txtTenNCC.Text = dtgvNhaCungCap.CurrentCell.OwningRow.Cells[1].Value.ToString();
            txtDiaChi.Text = dtgvNhaCungCap.CurrentCell.OwningRow.Cells[2].Value.ToString();
            txtSDT.Text = dtgvNhaCungCap.CurrentCell.OwningRow.Cells[3].Value.ToString();
        }
        private int flag = 0;
        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 1;
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtTenNCC.Text = "";
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
            int MaNCC = Convert.ToInt32(dtgvNhaCungCap.CurrentCell.OwningRow.Cells[0].Value.ToString());
            if (NhaCungCapDAO.Instance.XoaNCC(MaNCC))
                MessageBox.Show("Xóa thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Xóa thất bại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            LoadNCC();
        }

        private void dtgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Binding();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tenncc = txtTenNCC.Text;
            string diachi = txtDiaChi.Text;
            string sdt = txtSDT.Text;
            int MaNCC = Convert.ToInt32(dtgvNhaCungCap.CurrentCell.OwningRow.Cells[0].Value.ToString());
            if (flag == 1)
            {
                if (NhaCungCapDAO.Instance.ThemNCC(tenncc, diachi, sdt))
                    MessageBox.Show("Thêm thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm thất bại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadNCC();
                btnHuy_Click(sender, e);
            }
            if (flag == 2)
            {
                if(NhaCungCapDAO.Instance.SuaNCC(MaNCC,tenncc,diachi,sdt))
                    MessageBox.Show("Sửa thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sửa thất bại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadNCC();
                btnHuy_Click(sender, e);
            }
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
        }
    }
}
