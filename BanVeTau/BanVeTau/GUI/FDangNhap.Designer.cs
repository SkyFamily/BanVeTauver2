namespace BanVeTau
{
    partial class FLogin
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
            this.tsLoaiTaiKhoan = new DevExpress.XtraEditors.ToggleSwitch();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbTenDangNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMatKhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbDangKy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tsLoaiTaiKhoan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tsLoaiTaiKhoan
            // 
            this.tsLoaiTaiKhoan.Location = new System.Drawing.Point(12, 78);
            this.tsLoaiTaiKhoan.Name = "tsLoaiTaiKhoan";
            this.tsLoaiTaiKhoan.Properties.OffText = "Nhân viên";
            this.tsLoaiTaiKhoan.Properties.OnText = "Khách hàng";
            this.tsLoaiTaiKhoan.Size = new System.Drawing.Size(132, 24);
            this.tsLoaiTaiKhoan.TabIndex = 2;
            this.tsLoaiTaiKhoan.Toggled += new System.EventHandler(this.tsLoaiTaiKhoan_Toggled);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(257, 79);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbTenDangNhap
            // 
            this.tbTenDangNhap.Location = new System.Drawing.Point(148, 12);
            this.tbTenDangNhap.Name = "tbTenDangNhap";
            this.tbTenDangNhap.Size = new System.Drawing.Size(184, 20);
            this.tbTenDangNhap.TabIndex = 0;
            this.tbTenDangNhap.TextChanged += new System.EventHandler(this.tbTenDangNhap_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên đăng nhập";
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.Location = new System.Drawing.Point(148, 38);
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.Size = new System.Drawing.Size(184, 20);
            this.tbMatKhau.TabIndex = 1;
            this.tbMatKhau.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bạn chưa có tài khoản ? Vui lòng";
            // 
            // lbDangKy
            // 
            this.lbDangKy.AutoSize = true;
            this.lbDangKy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDangKy.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbDangKy.Location = new System.Drawing.Point(178, 109);
            this.lbDangKy.Name = "lbDangKy";
            this.lbDangKy.Size = new System.Drawing.Size(46, 13);
            this.lbDangKy.TabIndex = 4;
            this.lbDangKy.Text = "đăng ký";
            this.lbDangKy.Click += new System.EventHandler(this.lbDangKy_Click);
            // 
            // FLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 132);
            this.Controls.Add(this.lbDangKy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMatKhau);
            this.Controls.Add(this.tbTenDangNhap);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tsLoaiTaiKhoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.tsLoaiTaiKhoan.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ToggleSwitch tsLoaiTaiKhoan;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbTenDangNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbDangKy;
    }
}

