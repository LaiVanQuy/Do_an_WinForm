using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_an_cuoi_ki
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void thongtinTKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmThongTinTK f = new FrmThongTinTK();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            FrmHoaDon f = new FrmHoaDon();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            FrmHangHoa f = new FrmHangHoa();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            FrmThongKe f = new FrmThongKe();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            FrmNhanVien f = new FrmNhanVien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnKhuyenMai_Click(object sender, EventArgs e)
        {
            FrmKhuyenMai f = new FrmKhuyenMai();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void btnNhaCC_Click(object sender, EventArgs e)
        {
            FrmNhaCungCap f = new FrmNhaCungCap();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            FrmTaiKhoan f = new FrmTaiKhoan();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            FrmNhapHang f = new FrmNhapHang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
