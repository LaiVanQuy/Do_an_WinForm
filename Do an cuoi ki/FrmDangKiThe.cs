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
    public partial class FrmDangKiThe : Form
    {
        public FrmDangKiThe()
        {
            InitializeComponent();
        }
        private void btnDangKi_Click(object sender, EventArgs e)
        {
            if(TheDAO.Instance.ThemThe(txtSDT.Text, txtTenKH.Text))
                MessageBox.Show("Đăng kí thành công","Thông báo",
                    MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            else 
                MessageBox.Show("Đăng kí thất bại", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

        }
    }
}
