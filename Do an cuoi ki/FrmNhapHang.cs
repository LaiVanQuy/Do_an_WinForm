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
    public partial class FrmNhapHang : Form
    {
        public FrmNhapHang()
        {
            InitializeComponent();
            LoadHang();
            txtMaNV.Text = ShareVar.tk.Manv.ToString();
        }
        int flag = 0;
        void LoadHang()
        {
            dtgvHang.DataSource = HangHoaDAO.Instance.LoadHangHoa();
        }
        void Binding()
        {
            txtMaHang.Text = dtgvHang.CurrentCell.OwningRow.Cells[0].Value.ToString();
            txtTenHang.Text = dtgvHang.CurrentCell.OwningRow.Cells[1].Value.ToString();
        }
        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            int manv = ShareVar.tk.Manv;
            int mahang = Convert.ToInt32(txtMaHang.Text);
            float gianhap = (float)Convert.ToDouble(txtGiaNhapKho.Text.Trim());
            float sln= (float)Convert.ToDouble(txtSLN.Text.Trim());
            DateTime? ngayhh = (DateTime?)dtpkNgayhh.Value;
            if (NhapHangDAO.Instance.NhapHang(manv, mahang, gianhap, sln,ngayhh))
            {
                HangHoaDAO.Instance.CapNhatLuongHang(mahang, -sln);
                MessageBox.Show("Nhập hàng thành công", "Thông báo", MessageBoxButtons.OK);
                flag = 1;
            }
            else
                MessageBox.Show("Nhập hàng thất bại", "Thông báo", MessageBoxButtons.OK);
            LoadHang();
        }
        private void dtgvHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Binding();
        }

        private void txtTimTenHang_TextChanged(object sender, EventArgs e)
        {
            dtgvHang.DataSource = HangHoaDAO.Instance.TimKiemTenGanDung(txtTimTenHang.Text);
        }

        private void btnInPhieuNhap_Click(object sender, EventArgs e)
        {
            if (flag != 1)
            {
                MessageBox.Show("Chưa có thông tin nhập hàng!");
                return;
            }
            FrmPhieuNhapHang f = new FrmPhieuNhapHang();
            this.Hide();
            f.ShowDialog();
            this.Show();
            flag = 0;
        }
    }
}
