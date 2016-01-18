namespace BanVeTau.GUI
{
    partial class UCGhe
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imageListLoaiGhe = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbLoaiGhe = new System.Windows.Forms.ComboBox();
            this.numSoLuong = new DevExpress.XtraEditors.TrackBarControl();
            this.lbSoLuongGhe = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDoanTau = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvGhe = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageListLoaiGhe
            // 
            this.imageListLoaiGhe.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListLoaiGhe.ImageSize = new System.Drawing.Size(32, 32);
            this.imageListLoaiGhe.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbLoaiGhe);
            this.panel1.Controls.Add(this.numSoLuong);
            this.panel1.Controls.Add(this.lbSoLuongGhe);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbDoanTau);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 94);
            this.panel1.TabIndex = 8;
            // 
            // cbLoaiGhe
            // 
            this.cbLoaiGhe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiGhe.FormattingEnabled = true;
            this.cbLoaiGhe.Location = new System.Drawing.Point(319, 14);
            this.cbLoaiGhe.Name = "cbLoaiGhe";
            this.cbLoaiGhe.Size = new System.Drawing.Size(183, 21);
            this.cbLoaiGhe.TabIndex = 1;
            this.cbLoaiGhe.SelectionChangeCommitted += new System.EventHandler(this.cb_SelectionChangeCommitted);
            // 
            // numSoLuong
            // 
            this.numSoLuong.EditValue = null;
            this.numSoLuong.Location = new System.Drawing.Point(75, 41);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.numSoLuong.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.numSoLuong.Properties.Maximum = 200;
            this.numSoLuong.Size = new System.Drawing.Size(138, 45);
            this.numSoLuong.TabIndex = 2;
            this.numSoLuong.ValueChanged += new System.EventHandler(this.numSoLuong_ValueChanged);
            // 
            // lbSoLuongGhe
            // 
            this.lbSoLuongGhe.AutoSize = true;
            this.lbSoLuongGhe.Location = new System.Drawing.Point(224, 51);
            this.lbSoLuongGhe.Name = "lbSoLuongGhe";
            this.lbSoLuongGhe.Size = new System.Drawing.Size(25, 13);
            this.lbSoLuongGhe.TabIndex = 4;
            this.lbSoLuongGhe.Text = "ghế";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Loại ghế";
            // 
            // cbDoanTau
            // 
            this.cbDoanTau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDoanTau.FormattingEnabled = true;
            this.cbDoanTau.Location = new System.Drawing.Point(75, 14);
            this.cbDoanTau.Name = "cbDoanTau";
            this.cbDoanTau.Size = new System.Drawing.Size(174, 21);
            this.cbDoanTau.TabIndex = 0;
            this.cbDoanTau.SelectionChangeCommitted += new System.EventHandler(this.cb_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đoàn tàu";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(319, 46);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(104, 23);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Cập nhật";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lvGhe);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(931, 397);
            this.panel2.TabIndex = 10;
            // 
            // lvGhe
            // 
            this.lvGhe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvGhe.FullRowSelect = true;
            this.lvGhe.LargeImageList = this.imageListLoaiGhe;
            this.lvGhe.Location = new System.Drawing.Point(0, 94);
            this.lvGhe.MultiSelect = false;
            this.lvGhe.Name = "lvGhe";
            this.lvGhe.Size = new System.Drawing.Size(931, 303);
            this.lvGhe.SmallImageList = this.imageListLoaiGhe;
            this.lvGhe.TabIndex = 9;
            this.lvGhe.UseCompatibleStateImageBehavior = false;
            // 
            // UCGhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "UCGhe";
            this.Size = new System.Drawing.Size(931, 397);
            this.Load += new System.EventHandler(this.UCGhe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageListLoaiGhe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDoanTau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.TrackBarControl numSoLuong;
        private System.Windows.Forms.Label lbSoLuongGhe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvGhe;
        private System.Windows.Forms.ComboBox cbLoaiGhe;
    }
}
