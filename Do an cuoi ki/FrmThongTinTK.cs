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
    public partial class FrmThongTinTK : Form
    {
        public FrmThongTinTK()
        {
            InitializeComponent();
            LoadThongTinTK();
        }
        void LoadThongTinTK()
        {
            txtTenDangNhap.Text= ShareVar.tk.Tendangnhap;
            txtTenHienThi.Text = ShareVar.tk.Tenhienthi;
            txtMatKhau.Text = ShareVar.tk.Matkhau;
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtMatKhauMoi.Text == txtXacNhanMK.Text)
            {
                if (TaiKhoanDAO.Instance.DoiMatKhau(ShareVar.tk.Matk, txtMatKhauMoi.Text))
                    MessageBox.Show("Đổi mật khẩu thành công");
                else
                {
                    MessageBox.Show("Đổi mật khẩu thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Xác nhận mật khẩu không chính xác!");
            }
        }
    }
}
