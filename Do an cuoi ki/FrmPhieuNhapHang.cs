using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using Do_an_cuoi_ki.DAO;

namespace Do_an_cuoi_ki
{
    public partial class FrmPhieuNhapHang : Form
    {
        public FrmPhieuNhapHang()
        {
            InitializeComponent();
        }
        private void FrmPhieuNhapHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QuanLySieuThiDataSet.HangHoa' table. You can move, or remove it, as needed.
            this.HangHoaTableAdapter.Fill(this.QuanLySieuThiDataSet.HangHoa);
            this.reportViewer1.RefreshReport();
            LoadData();
        }
        void LoadData()
        {
            DataTable ds = GetData();
            ReportDataSource dbs = new ReportDataSource("NhapHang", ds);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(dbs);
            this.reportViewer1.RefreshReport();
        }
        DataTable GetData()
        {
            return NhapHangDAO.Instance.LayThongTinNhapHang();
        }
    }
}
