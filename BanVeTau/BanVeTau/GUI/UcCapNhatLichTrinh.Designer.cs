namespace BanVeTau.GUI
{
    partial class UcCapNhatLichTrinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcCapNhatLichTrinh));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reRadioGroupTrangThai = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reRadioGroupViTri = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reBtnSave = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gvExtra = new DevExpress.XtraGrid.GridControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkLichTrinhChuaChay = new System.Windows.Forms.CheckBox();
            this.cbDoanTau = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reRadioGroupTrangThai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reRadioGroupViTri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reBtnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvExtra)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn1});
            this.gridView.GridControl = this.gvExtra;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gridView_CustomRowCellEdit);
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "gridColumn4";
            this.gridColumn4.FieldName = "Id";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Lịch trình";
            this.gridColumn2.FieldName = "TenLichTrinh";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 177;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Trạng thái hiện tại";
            this.gridColumn3.ColumnEdit = this.reRadioGroupTrangThai;
            this.gridColumn3.FieldName = "TrangThai";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 159;
            // 
            // reRadioGroupTrangThai
            // 
            this.reRadioGroupTrangThai.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(-1, "Đã chạy"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Đang"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Sắp")});
            this.reRadioGroupTrangThai.Name = "reRadioGroupTrangThai";
            this.reRadioGroupTrangThai.ReadOnly = true;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Ga khởi hành";
            this.gridColumn5.FieldName = "TenGaDau";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            this.gridColumn5.Width = 90;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Ga cuối";
            this.gridColumn6.ColumnEdit = this.reRadioGroupViTri;
            this.gridColumn6.FieldName = "LichTrinhTuyenDuongHienTaiId";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            this.gridColumn6.Width = 456;
            // 
            // reRadioGroupViTri
            // 
            this.reRadioGroupViTri.Name = "reRadioGroupViTri";
            // 
            // gridColumn1
            // 
            this.gridColumn1.ColumnEdit = this.reBtnSave;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            this.gridColumn1.Width = 52;
            // 
            // reBtnSave
            // 
            this.reBtnSave.AutoHeight = false;
            this.reBtnSave.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("reBtnSave.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.reBtnSave.Name = "reBtnSave";
            this.reBtnSave.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.reBtnSave.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.reBtnSave_ButtonClick);
            // 
            // gvExtra
            // 
            this.gvExtra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvExtra.Location = new System.Drawing.Point(0, 51);
            this.gvExtra.MainView = this.gridView;
            this.gvExtra.Name = "gvExtra";
            this.gvExtra.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.reRadioGroupTrangThai,
            this.reRadioGroupViTri,
            this.reBtnSave});
            this.gvExtra.Size = new System.Drawing.Size(952, 411);
            this.gvExtra.TabIndex = 9;
            this.gvExtra.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkLichTrinhChuaChay);
            this.panel1.Controls.Add(this.cbDoanTau);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 51);
            this.panel1.TabIndex = 8;
            // 
            // chkLichTrinhChuaChay
            // 
            this.chkLichTrinhChuaChay.AutoSize = true;
            this.chkLichTrinhChuaChay.Checked = true;
            this.chkLichTrinhChuaChay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLichTrinhChuaChay.Location = new System.Drawing.Point(273, 16);
            this.chkLichTrinhChuaChay.Name = "chkLichTrinhChuaChay";
            this.chkLichTrinhChuaChay.Size = new System.Drawing.Size(163, 17);
            this.chkLichTrinhChuaChay.TabIndex = 1;
            this.chkLichTrinhChuaChay.Text = "Xem các lịch trình chưa chạy";
            this.chkLichTrinhChuaChay.UseVisualStyleBackColor = true;
            this.chkLichTrinhChuaChay.CheckedChanged += new System.EventHandler(this.chkLichTrinhChuaChay_CheckedChanged);
            // 
            // cbDoanTau
            // 
            this.cbDoanTau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDoanTau.FormattingEnabled = true;
            this.cbDoanTau.Location = new System.Drawing.Point(75, 14);
            this.cbDoanTau.Name = "cbDoanTau";
            this.cbDoanTau.Size = new System.Drawing.Size(174, 21);
            this.cbDoanTau.TabIndex = 0;
            this.cbDoanTau.SelectedIndexChanged += new System.EventHandler(this.cbDoanTau_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đoàn tàu";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gvExtra);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(952, 462);
            this.panel2.TabIndex = 10;
            // 
            // UcCapNhatLichTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "UcCapNhatLichTrinh";
            this.Size = new System.Drawing.Size(952, 462);
            this.Load += new System.EventHandler(this.UcCapNhatLichTrinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reRadioGroupTrangThai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reRadioGroupViTri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reBtnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvExtra)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup reRadioGroupTrangThai;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup reRadioGroupViTri;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.GridControl gvExtra;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkLichTrinhChuaChay;
        private System.Windows.Forms.ComboBox cbDoanTau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit reBtnSave;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}
