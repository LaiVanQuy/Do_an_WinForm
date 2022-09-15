
namespace Do_an_cuoi_ki
{
    partial class FrmPhieuNhapHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QuanLySieuThiDataSet = new Do_an_cuoi_ki.QuanLySieuThiDataSet();
            this.HangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HangHoaTableAdapter = new Do_an_cuoi_ki.QuanLySieuThiDataSetTableAdapters.HangHoaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLySieuThiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HangHoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "NhapHang";
            reportDataSource1.Value = this.HangHoaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Do_an_cuoi_ki.SieuThiReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 75);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1141, 524);
            this.reportViewer1.TabIndex = 0;
            // 
            // QuanLySieuThiDataSet
            // 
            this.QuanLySieuThiDataSet.DataSetName = "QuanLySieuThiDataSet";
            this.QuanLySieuThiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HangHoaBindingSource
            // 
            this.HangHoaBindingSource.DataMember = "HangHoa";
            this.HangHoaBindingSource.DataSource = this.QuanLySieuThiDataSet;
            // 
            // HangHoaTableAdapter
            // 
            this.HangHoaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPhieuNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 633);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmPhieuNhapHang";
            this.Text = "FrmPhieuNhapHang";
            this.Load += new System.EventHandler(this.FrmPhieuNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuanLySieuThiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HangHoaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HangHoaBindingSource;
        private QuanLySieuThiDataSet QuanLySieuThiDataSet;
        private QuanLySieuThiDataSetTableAdapters.HangHoaTableAdapter HangHoaTableAdapter;
    }
}