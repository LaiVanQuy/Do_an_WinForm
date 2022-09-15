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
using Microsoft.Reporting.WinForms;

namespace Do_an_cuoi_ki
{
    public partial class FrmThongKe : Form
    {
        public FrmThongKe()
        {
            InitializeComponent();
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QuanLySieuThiDataSet4.ThongKe' table. You can move, or remove it, as needed.
            this.ThongKeTableAdapter.Fill(this.QuanLySieuThiDataSet4.ThongKe);
            this.reportViewer1.RefreshReport();
            LoadData();
        }
        void LoadData()
        {
            DataTable ds = GetData();
            ReportDataSource dbs = new ReportDataSource("DataSet2", ds);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(dbs);
            this.reportViewer1.RefreshReport();
        }
        DataTable GetData()
        {
            return ThongKeDAO.Instance.ThongKe();
        }
    }
}
