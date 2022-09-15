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
using Do_an_cuoi_ki.DTO;

namespace Do_an_cuoi_ki
{
    public partial class FrmHangHoa : Form
    {
        public FrmHangHoa()
        {
            InitializeComponent();
            LoadHangHoa();
            LoadLoaiHangCBB();
            LoadNCCCBB();
        }
        void LoadHangHoa()
        {
            dtgvHangHoa.DataSource = HangHoaDAO.Instance.LoadHangHoa();
        }
        void binding()
        {
            txtMaHang.Text = dtgvHangHoa.CurrentCell.OwningRow.Cells[0].Value.ToString();
            txtTenHang.Text = dtgvHangHoa.CurrentCell.OwningRow.Cells[1].Value.ToString();
            txtGia.Text = dtgvHangHoa.CurrentCell.OwningRow.Cells[3].Value.ToString();
        }
        
        private void dtgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            binding();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            LoaiHangDTO lh = cbLoaiHang.SelectedItem as LoaiHangDTO ;
            int maloaihang = lh.Maloaihang;
            NhaCungCapDTO ncc = cbNhaCungCap.SelectedItem as NhaCungCapDTO;
            int mancc = ncc.Mancc;
            string tenhang = txtTenHang.Text;
            float giaban =(float)Convert.ToDouble( txtGia.Text.Trim());
            if (HangHoaDAO.Instance.ThemHangHoa(maloaihang, tenhang, giaban, mancc))
            {
                MessageBox.Show("thêm thành công", "thông báo",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                int mahang = HangHoaDAO.Instance.LayidMax();
                HangHoaDAO.Instance.UpdateGia2(mahang);
            }
            else
            {
                MessageBox.Show("thêm thất bại", "thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadHangHoa();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            NhaCungCapDTO ncc = cbNhaCungCap.SelectedItem as NhaCungCapDTO;
            string tenhang = txtTenHang.Text;
            int mahang =Convert.ToInt32( txtMaHang.Text);
            float gia = (float)Convert.ToDouble(txtGia.Text);
            if (HangHoaDAO.Instance.SuaHangHoa(mahang,tenhang, gia, ncc.Mancc))
                MessageBox.Show("sửa thành công", "thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("sửa thất bại", "thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadHangHoa();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int mahang = Convert.ToInt32(txtMaHang.Text.Trim());
            if(HangHoaDAO.Instance.XoaHangHoa(mahang))
                MessageBox.Show("xóa thành công", "thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("xóa thất bại", "thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadHangHoa();
        }
        void LoadLoaiHangCBB()
        {
            cbLoaiHang.DataSource = LoaiHangDAO.Instance.LayDsLoaiHang();
            cbLoaiHang.DisplayMember = "TenLoaiHang";
        }
        void LoadNCCCBB()
        {
            cbNhaCungCap.DataSource = NhaCungCapDAO.Instance.ListNCC();
            cbNhaCungCap.DisplayMember = "TenNCC";
        }
        private void txtTimTenHang_TextChanged(object sender, EventArgs e)
        {
            dtgvHangHoa.DataSource = HangHoaDAO.Instance.TimKiemTenGanDung(txtTimTenHang.Text);
        }
    }
}
