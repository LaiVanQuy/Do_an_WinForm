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
    public partial class FrmKhuyenMai : Form
    {
        public FrmKhuyenMai()
        {
            InitializeComponent();
        }
        
        void LoadKhuyenMai()
        {
            dtgvKhuyenMai.DataSource = KhuyenMaiDAO.Instance.LoadKhuyenMai();
        }
        void Binding()
        {
            txtMaHang.Text = dtgvKhuyenMai.CurrentCell.OwningRow.Cells[1].Value.ToString();
            txtMucGiam.Text = dtgvKhuyenMai.CurrentCell.OwningRow.Cells[3].Value.ToString();
            dateTimePickerNHH.Value =Convert.ToDateTime( dtgvKhuyenMai.CurrentCell.OwningRow.Cells[4].Value.ToString());
        }
        private int flag = 0;
        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 1;
            txtMaHang.Text = "";
            txtMucGiam.Text = "";
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
            int makm=Convert.ToInt32( dtgvKhuyenMai.CurrentCell.OwningRow.Cells[0].Value.ToString());
            if(KhuyenMaiDAO.Instance.XoaKM(makm))
                MessageBox.Show("Xóa thành công!", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Xóa thất bại!", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            LoadKhuyenMai();
        }

        private void dtgvKhuyenMai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Binding();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtgvKhuyenMai.DataSource= KhuyenMaiDAO.Instance.LoadKMSapHetHan();
        }
     
        private void btnLuu_Click(object sender, EventArgs e)
        {
            int mahang = Convert.ToInt32(txtMaHang.Text.Trim());
            int mucgiam = Convert.ToInt32(txtMucGiam.Text.Trim());
            DateTime nhh = Convert.ToDateTime(dateTimePickerNHH.Value.ToString());
            if (flag == 1)
            {
                if (KhuyenMaiDAO.Instance.ThemKM(mahang, mucgiam, nhh))
                    MessageBox.Show("Thêm thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm thất bại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadKhuyenMai();
                btnHuy_Click(sender, e);
            }
            if (flag == 2)
            {
                int makm = Convert.ToInt32(dtgvKhuyenMai.CurrentCell.OwningRow.Cells[0].Value.ToString());
                if (KhuyenMaiDAO.Instance.SuaKM(makm, mucgiam, nhh))
                    MessageBox.Show("Sửa thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sửa thất bại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadKhuyenMai();
                btnHuy_Click(sender, e);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadKhuyenMai();
        }
    }
}
