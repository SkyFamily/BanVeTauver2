﻿namespace BanVeTau.GUI
{
    partial class UcNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcNhanVien));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.cbPhongBan = new System.Windows.Forms.ComboBox();
            this.cbPhongBan1 = new System.Windows.Forms.ComboBox();
            this.tbMatKhau1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMatKhau = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gvExtra = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reNgaySinh = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reNgayVaoLam = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reGridPhongBan = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemToggleSwitch1 = new DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_Delete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.dtNgayVaoLam = new System.Windows.Forms.DateTimePicker();
            this.twGioTinh = new DevExpress.XtraEditors.ToggleSwitch();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvExtra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reNgaySinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reNgaySinh.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reNgayVaoLam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reNgayVaoLam.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reGridPhongBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemToggleSwitch1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Delete)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.twGioTinh.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbPhongBan
            // 
            this.cbPhongBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhongBan.FormattingEnabled = true;
            this.cbPhongBan.Location = new System.Drawing.Point(439, 19);
            this.cbPhongBan.Name = "cbPhongBan";
            this.cbPhongBan.Size = new System.Drawing.Size(172, 21);
            this.cbPhongBan.TabIndex = 4;
            this.cbPhongBan.SelectionChangeCommitted += new System.EventHandler(this.cbPhongBan_SelectionChangeCommitted);
            // 
            // cbPhongBan1
            // 
            this.cbPhongBan1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhongBan1.FormattingEnabled = true;
            this.cbPhongBan1.Location = new System.Drawing.Point(122, 19);
            this.cbPhongBan1.Name = "cbPhongBan1";
            this.cbPhongBan1.Size = new System.Drawing.Size(172, 21);
            this.cbPhongBan1.TabIndex = 12;
            // 
            // tbMatKhau1
            // 
            this.tbMatKhau1.Location = new System.Drawing.Point(439, 72);
            this.tbMatKhau1.Name = "tbMatKhau1";
            this.tbMatKhau1.Size = new System.Drawing.Size(172, 20);
            this.tbMatKhau1.TabIndex = 6;
            this.tbMatKhau1.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(310, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Nhập lại mật khẩu (*)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Phòng ban (*)";
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.Location = new System.Drawing.Point(439, 46);
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.Size = new System.Drawing.Size(172, 20);
            this.tbMatKhau.TabIndex = 5;
            this.tbMatKhau.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(310, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Mật khẩu (*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Giới tính";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Phòng ban";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Ngày vào làm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Ngày sinh ";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(136, 20);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(160, 20);
            this.tbId.TabIndex = 0;
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(136, 46);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(160, 20);
            this.tbTen.TabIndex = 1;
            this.tbTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTen_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Tên nhân viên (*)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Mã nhân viên (*)";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(631, 49);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 9;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(631, 20);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(122, 46);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 13;
            this.btnXem.Text = "Xem ";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gvExtra);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1155, 348);
            this.panel2.TabIndex = 15;
            // 
            // gvExtra
            // 
            this.gvExtra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvExtra.Location = new System.Drawing.Point(0, 0);
            this.gvExtra.MainView = this.gridView;
            this.gvExtra.Name = "gvExtra";
            this.gvExtra.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btn_Delete,
            this.repositoryItemToggleSwitch1,
            this.reGridPhongBan,
            this.reNgaySinh,
            this.reNgayVaoLam});
            this.gvExtra.Size = new System.Drawing.Size(1155, 348);
            this.gvExtra.TabIndex = 11;
            this.gvExtra.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn6,
            this.gridColumn5,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn7,
            this.gridColumn4});
            this.gridView.GridControl = this.gvExtra;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã nhân viên";
            this.gridColumn1.FieldName = "Id";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 94;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Tên";
            this.gridColumn6.FieldName = "TenNhanVien";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            this.gridColumn6.Width = 291;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Ngày sinh";
            this.gridColumn5.ColumnEdit = this.reNgaySinh;
            this.gridColumn5.FieldName = "NgaySinh";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 208;
            // 
            // reNgaySinh
            // 
            this.reNgaySinh.AutoHeight = false;
            this.reNgaySinh.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.reNgaySinh.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.reNgaySinh.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.reNgaySinh.Name = "reNgaySinh";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Ngày vào làm";
            this.gridColumn2.ColumnEdit = this.reNgayVaoLam;
            this.gridColumn2.FieldName = "NgayVaoLam";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
            this.gridColumn2.Width = 198;
            // 
            // reNgayVaoLam
            // 
            this.reNgayVaoLam.AutoHeight = false;
            this.reNgayVaoLam.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.reNgayVaoLam.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.reNgayVaoLam.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.reNgayVaoLam.Name = "reNgayVaoLam";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Phòng ban";
            this.gridColumn3.ColumnEdit = this.reGridPhongBan;
            this.gridColumn3.FieldName = "PhongBanID";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 5;
            this.gridColumn3.Width = 140;
            // 
            // reGridPhongBan
            // 
            this.reGridPhongBan.AutoHeight = false;
            this.reGridPhongBan.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.reGridPhongBan.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Mã phòng ban"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenPhongBan", "Tên phòng ban")});
            this.reGridPhongBan.DisplayMember = "Ten";
            this.reGridPhongBan.Name = "reGridPhongBan";
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Giới tính";
            this.gridColumn7.ColumnEdit = this.repositoryItemToggleSwitch1;
            this.gridColumn7.FieldName = "GioiTinh";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 2;
            this.gridColumn7.Width = 149;
            // 
            // repositoryItemToggleSwitch1
            // 
            this.repositoryItemToggleSwitch1.AutoHeight = false;
            this.repositoryItemToggleSwitch1.Name = "repositoryItemToggleSwitch1";
            this.repositoryItemToggleSwitch1.OffText = "Nữ";
            this.repositoryItemToggleSwitch1.OnText = "Nam";
            // 
            // gridColumn4
            // 
            this.gridColumn4.ColumnEdit = this.btn_Delete;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 6;
            this.gridColumn4.Width = 57;
            // 
            // btn_Delete
            // 
            this.btn_Delete.AutoHeight = false;
            this.btn_Delete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btn_Delete.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btn_Delete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btn_Delete_ButtonClick);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(631, 78);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 10;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtNgaySinh);
            this.panel1.Controls.Add(this.dtNgayVaoLam);
            this.panel1.Controls.Add(this.twGioTinh);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.cbPhongBan);
            this.panel1.Controls.Add(this.tbMatKhau1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbMatKhau);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbId);
            this.panel1.Controls.Add(this.tbTen);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnLamMoi);
            this.panel1.Controls.Add(this.btnCapNhat);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 138);
            this.panel1.TabIndex = 14;
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.CustomFormat = "dd/MM/yyyy ";
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgaySinh.Location = new System.Drawing.Point(136, 72);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(160, 20);
            this.dtNgaySinh.TabIndex = 2;
            // 
            // dtNgayVaoLam
            // 
            this.dtNgayVaoLam.CustomFormat = "dd/MM/yyyy ";
            this.dtNgayVaoLam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayVaoLam.Location = new System.Drawing.Point(136, 98);
            this.dtNgayVaoLam.Name = "dtNgayVaoLam";
            this.dtNgayVaoLam.Size = new System.Drawing.Size(160, 20);
            this.dtNgayVaoLam.TabIndex = 3;
            // 
            // twGioTinh
            // 
            this.twGioTinh.EditValue = true;
            this.twGioTinh.Location = new System.Drawing.Point(439, 98);
            this.twGioTinh.Name = "twGioTinh";
            this.twGioTinh.Properties.OffText = "Nữ";
            this.twGioTinh.Properties.OnText = "Nam";
            this.twGioTinh.Size = new System.Drawing.Size(172, 24);
            this.twGioTinh.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbPhongBan1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnXem);
            this.groupBox1.Location = new System.Drawing.Point(733, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 124);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Xem nhân viên";
            // 
            // UcNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UcNhanVien";
            this.Size = new System.Drawing.Size(1155, 486);
            this.Load += new System.EventHandler(this.UcNhanVien_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvExtra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reNgaySinh.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reNgaySinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reNgayVaoLam.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reNgayVaoLam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reGridPhongBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemToggleSwitch1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Delete)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.twGioTinh.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPhongBan;
        private System.Windows.Forms.ComboBox cbPhongBan1;
        private System.Windows.Forms.TextBox tbMatKhau1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMatKhau;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gvExtra;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit reGridPhongBan;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch repositoryItemToggleSwitch1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btn_Delete;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.ToggleSwitch twGioTinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtNgayVaoLam;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit reNgaySinh;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit reNgayVaoLam;
        private const int ChieuDaiId = 4;
    }
}
