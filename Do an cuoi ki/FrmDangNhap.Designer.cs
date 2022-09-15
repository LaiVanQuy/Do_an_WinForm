
namespace Do_an_cuoi_ki
{
    partial class FrmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDangNhap));
            this.grbDangNhap = new System.Windows.Forms.GroupBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pcticon = new System.Windows.Forms.PictureBox();
            this.btnHienMk = new System.Windows.Forms.Button();
            this.grbDangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcticon)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDangNhap
            // 
            this.grbDangNhap.Controls.Add(this.btnHienMk);
            this.grbDangNhap.Controls.Add(this.txtMatKhau);
            this.grbDangNhap.Controls.Add(this.txtTaiKhoan);
            this.grbDangNhap.Controls.Add(this.label2);
            this.grbDangNhap.Controls.Add(this.label3);
            this.grbDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDangNhap.Location = new System.Drawing.Point(57, 35);
            this.grbDangNhap.Name = "grbDangNhap";
            this.grbDangNhap.Size = new System.Drawing.Size(520, 286);
            this.grbDangNhap.TabIndex = 0;
            this.grbDangNhap.TabStop = false;
            this.grbDangNhap.Text = "Thông tin đăng nhập";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(222, 139);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(213, 35);
            this.txtMatKhau.TabIndex = 5;
            this.txtMatKhau.Text = "12345";
            this.txtMatKhau.UseSystemPasswordChar = true;
            this.txtMatKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatKhau_KeyPress);
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(222, 84);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(213, 35);
            this.txtTaiKhoan.TabIndex = 4;
            this.txtTaiKhoan.Text = "Admin";
            this.txtTaiKhoan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaiKhoan_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên đăng nhập";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnDangNhap.Location = new System.Drawing.Point(57, 343);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(167, 47);
            this.btnDangNhap.TabIndex = 1;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            this.btnDangNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnDangNhap_KeyPress);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Red;
            this.btnThoat.Location = new System.Drawing.Point(440, 343);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(137, 47);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // pcticon
            // 
            this.pcticon.BackgroundImage = global::Do_an_cuoi_ki.Properties.Resources._3514407;
            this.pcticon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcticon.Location = new System.Drawing.Point(604, 35);
            this.pcticon.Name = "pcticon";
            this.pcticon.Size = new System.Drawing.Size(179, 273);
            this.pcticon.TabIndex = 4;
            this.pcticon.TabStop = false;
            // 
            // btnHienMk
            // 
            this.btnHienMk.BackgroundImage = global::Do_an_cuoi_ki.Properties.Resources.view;
            this.btnHienMk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHienMk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienMk.ForeColor = System.Drawing.Color.Black;
            this.btnHienMk.Location = new System.Drawing.Point(430, 143);
            this.btnHienMk.Name = "btnHienMk";
            this.btnHienMk.Size = new System.Drawing.Size(31, 32);
            this.btnHienMk.TabIndex = 5;
            this.btnHienMk.UseVisualStyleBackColor = true;
            this.btnHienMk.Click += new System.EventHandler(this.btnHienMk_Click);
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(795, 450);
            this.Controls.Add(this.pcticon);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.grbDangNhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập hệ thống ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDangNhap_FormClosing);
            this.grbDangNhap.ResumeLayout(false);
            this.grbDangNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcticon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.PictureBox pcticon;
        private System.Windows.Forms.Button btnHienMk;
    }
}

