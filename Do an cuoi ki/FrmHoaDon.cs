using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Do_an_cuoi_ki.DAO;
using Do_an_cuoi_ki.DTO;
namespace Do_an_cuoi_ki
{
    public partial class FrmHoaDon : Form
    {
        public FrmHoaDon()
        {
            InitializeComponent();
        }
        void LoadHoaDon()
        {
            dtgvHoaDon.DataSource = HoaDonDAO.Instance.LoadHoaDon();
        }
        void Binding()
        {
            txtMahd.Text = dtgvHoaDon.CurrentCell.OwningRow.Cells[0].Value.ToString();
            txtMaNV.Text = dtgvHoaDon.CurrentCell.OwningRow.Cells[1].Value.ToString();
            txtNgay.Text = dtgvHoaDon.CurrentCell.OwningRow.Cells[2].Value.ToString();             
        }
        void ShowBill(int mahd)
        {
            lsvListHang.Items.Clear();
            List<ThongTinHoaDon> listbillinfo = ThongTinHoaDonDAO.Instance.LayTTHoaDon(mahd);
            foreach (ThongTinHoaDon tthd in listbillinfo)
            {
                ListViewItem lsvItem = new ListViewItem(tthd.Mahang.ToString());
                lsvItem.SubItems.Add(tthd.Tenhang.ToString());
                lsvItem.SubItems.Add(tthd.Gia.ToString());
                lsvItem.SubItems.Add(tthd.Soluong.ToString());
                lsvItem.SubItems.Add(tthd.Thanhtien.ToString());
                lsvListHang.Items.Add(lsvItem);
            }
            HoaDonDTO hd = HoaDonDAO.Instance.LayHdTheoID(mahd);
            CultureInfo culture = new CultureInfo("vi-VN");
            txtTongBill.Text = hd.Tongtien.ToString("c", culture);
        }
        private void dtgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Binding();
            int mahd=0;
            try
            {
                 mahd = Convert.ToInt32(dtgvHoaDon.CurrentCell.OwningRow.Cells[0].Value.ToString());
            }
            catch 
            { 
            }
            ShowBill(mahd);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadHoaDon();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtgvHoaDon.DataSource = HoaDonDAO.Instance.TimKiemHDTheoNgay((DateTime) datimeNgay.Value);
        }
        ThongTinHoaDon ConvertBillInfo()
        {
            ThongTinHoaDon tthd = new ThongTinHoaDon();
            ListViewItem item = lsvListHang.FocusedItem;
            tthd.Mahang = Convert.ToInt32(item.SubItems[0].Text);
            tthd.Tenhang = item.SubItems[1].Text;
            tthd.Gia = (float)Convert.ToDouble(item.SubItems[2].Text);
            tthd.Soluong = (float)Convert.ToDouble(item.SubItems[3].Text);
            tthd.Thanhtien = (float)Convert.ToDouble(item.SubItems[4].Text);
            return tthd;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            ThongTinHoaDon tthd = new ThongTinHoaDon();
            ListViewItem item = lsvListHang.FocusedItem;
            if (item == null)
            {
                if (item == null)
                {
                    MessageBox.Show("Chưa chọn thông tin nào", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }
            tthd = ConvertBillInfo();
            int mahd =Convert.ToInt32( txtMahd.Text.Trim());
            if (BanHangDAO.Instance.deleteBillInfo(mahd, tthd))
            {
                MessageBox.Show("Xóa hàng khỏi hóa đơn thành công", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                lsvListHang.Items.Remove(item);
                HangHoaDAO.Instance.CapNhatLuongHang(tthd.Mahang, -tthd.Soluong);
                HoaDonDTO hd = HoaDonDAO.Instance.LayHdTheoID(mahd);
                HoaDonDAO.Instance.UpdateTongBill(mahd,-tthd.Thanhtien);
            }
            else
                MessageBox.Show("Xóa hàng khỏi hóa đơn thất bại", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            ShowBill(mahd);   
        }

        private void lsvListHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem item = lsvListHang.FocusedItem;
            if (item != null)
                txtSoluong.Text = lsvListHang.FocusedItem.SubItems[3].Text;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            ThongTinHoaDon tthd = new ThongTinHoaDon();
            ListViewItem item = lsvListHang.FocusedItem;
            if (item == null)
            {
                if (item == null)
                {
                    MessageBox.Show("Chưa chọn thông tin nào", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }
            tthd = ConvertBillInfo();
            int mahd = Convert.ToInt32(txtMahd.Text.Trim());
            float sluong =(float)Convert.ToDouble( txtSoluong.Text.Trim());
            if (sluong > tthd.Soluong)
            {
                MessageBox.Show("Số lượng trả không thể lớn hơn số hàng trong bill", "Thông báo",
                      MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            if (BanHangDAO.Instance.updateBillInfo(mahd, sluong, tthd))
            {
                MessageBox.Show("Trả hàng thành công", "Thông báo",
                      MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                HangHoaDAO.Instance.CapNhatLuongHang(tthd.Mahang, -sluong);
                HoaDonDAO.Instance.UpdateTongBill(mahd, -tthd.Gia * sluong);
            }
            else
                MessageBox.Show("Cập nhật số lượng thất bại", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            ShowBill(mahd);
        }
    }
}