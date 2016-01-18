namespace BanVeTau.GUI
{
    partial class UCLoaiGhe
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.listViewLoaiGhe = new System.Windows.Forms.ListView();
            this.imageListLoaiGhe = new System.Windows.Forms.ImageList(this.components);
            this.tbTenLoaiGhe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numSoLuong = new DevExpress.XtraEditors.TrackBarControl();
            this.lbSoLuongGhe = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.pbAnh = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listViewLoaiGhe);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1155, 381);
            this.panel2.TabIndex = 9;
            // 
            // listViewLoaiGhe
            // 
            this.listViewLoaiGhe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewLoaiGhe.HideSelection = false;
            this.listViewLoaiGhe.LargeImageList = this.imageListLoaiGhe;
            this.listViewLoaiGhe.Location = new System.Drawing.Point(0, 0);
            this.listViewLoaiGhe.Name = "listViewLoaiGhe";
            this.listViewLoaiGhe.Size = new System.Drawing.Size(1155, 381);
            this.listViewLoaiGhe.SmallImageList = this.imageListLoaiGhe;
            this.listViewLoaiGhe.TabIndex = 0;
            this.listViewLoaiGhe.UseCompatibleStateImageBehavior = false;
            this.listViewLoaiGhe.View = System.Windows.Forms.View.Tile;
            this.listViewLoaiGhe.SelectedIndexChanged += new System.EventHandler(this.listViewLoaiGhe_SelectedIndexChanged);
            // 
            // imageListLoaiGhe
            // 
            this.imageListLoaiGhe.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imageListLoaiGhe.ImageSize = new System.Drawing.Size(32, 32);
            this.imageListLoaiGhe.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tbTenLoaiGhe
            // 
            this.tbTenLoaiGhe.Location = new System.Drawing.Point(92, 19);
            this.tbTenLoaiGhe.Name = "tbTenLoaiGhe";
            this.tbTenLoaiGhe.Size = new System.Drawing.Size(175, 20);
            this.tbTenLoaiGhe.TabIndex = 0;
            this.tbTenLoaiGhe.Enter += new System.EventHandler(this.tbTenLoaiGhe_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên loại ghế";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(615, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numSoLuong);
            this.panel1.Controls.Add(this.lbSoLuongGhe);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.pbAnh);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.tbTenLoaiGhe);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 55);
            this.panel1.TabIndex = 8;
            // 
            // numSoLuong
            // 
            this.numSoLuong.EditValue = null;
            this.numSoLuong.Location = new System.Drawing.Point(426, 7);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.numSoLuong.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.numSoLuong.Properties.Maximum = 50;
            this.numSoLuong.Size = new System.Drawing.Size(138, 45);
            this.numSoLuong.TabIndex = 1;
            this.numSoLuong.EditValueChanged += new System.EventHandler(this.numSoLuong_EditValueChanged);
            // 
            // lbSoLuongGhe
            // 
            this.lbSoLuongGhe.AutoSize = true;
            this.lbSoLuongGhe.Location = new System.Drawing.Point(575, 17);
            this.lbSoLuongGhe.Name = "lbSoLuongGhe";
            this.lbSoLuongGhe.Size = new System.Drawing.Size(22, 13);
            this.lbSoLuongGhe.TabIndex = 13;
            this.lbSoLuongGhe.Text = "0.0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Hệ số";
            // 
            // btnXoa
            // 
            this.btnXoa.Enabled = false;
            this.btnXoa.Location = new System.Drawing.Point(696, 12);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // pbAnh
            // 
            this.pbAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAnh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAnh.Image = global::BanVeTau.Properties.Resources.chair0;
            this.pbAnh.InitialImage = global::BanVeTau.Properties.Resources.chair0;
            this.pbAnh.Location = new System.Drawing.Point(319, 8);
            this.pbAnh.Name = "pbAnh";
            this.pbAnh.Size = new System.Drawing.Size(34, 34);
            this.pbAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnh.TabIndex = 3;
            this.pbAnh.TabStop = false;
            this.pbAnh.Click += new System.EventHandler(this.pbAnh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ảnh";
            // 
            // UCLoaiGhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCLoaiGhe";
            this.Size = new System.Drawing.Size(1155, 436);
            this.Load += new System.EventHandler(this.UCLoaiGhe_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbTenLoaiGhe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listViewLoaiGhe;
        private System.Windows.Forms.ImageList imageListLoaiGhe;
        private System.Windows.Forms.PictureBox pbAnh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXoa;
        private DevExpress.XtraEditors.TrackBarControl numSoLuong;
        private System.Windows.Forms.Label lbSoLuongGhe;
        private System.Windows.Forms.Label label4;
    }
}
