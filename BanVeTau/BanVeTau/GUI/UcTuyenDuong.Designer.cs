namespace BanVeTau.GUI
{
    partial class UcTuyenDuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcTuyenDuong));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.label1 = new System.Windows.Forms.Label();
            this.gvExtra = new DevExpress.XtraGrid.GridControl();
            this.gvObject = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbgidGaTauDau = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbgidGaTauCuoi = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.numGridKhoangCach = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gridColumnLuu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btGridSave = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumnXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnGridDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numKhoangCach = new System.Windows.Forms.NumericUpDown();
            this.cbGaCuoi = new System.Windows.Forms.ComboBox();
            this.cbGaDau = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvExtra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbgidGaTauDau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbgidGaTauCuoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGridKhoangCach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btGridSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGridDelete)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKhoangCach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ga đầu";
            // 
            // gvExtra
            // 
            this.gvExtra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvExtra.Location = new System.Drawing.Point(0, 0);
            this.gvExtra.MainView = this.gvObject;
            this.gvExtra.Name = "gvExtra";
            this.gvExtra.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cbgidGaTauDau,
            this.cbgidGaTauCuoi,
            this.numGridKhoangCach,
            this.btGridSave,
            this.btnGridDelete});
            this.gvExtra.Size = new System.Drawing.Size(1123, 353);
            this.gvExtra.TabIndex = 5;
            this.gvExtra.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvObject});
            // 
            // gvObject
            // 
            this.gvObject.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gridColumn5,
            this.gridColumn1,
            this.gridColumnLuu,
            this.gridColumnXoa,
            this.gridColumn3});
            this.gvObject.GridControl = this.gvExtra;
            this.gvObject.Name = "gvObject";
            this.gvObject.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Ga đầu";
            this.gridColumn6.ColumnEdit = this.cbgidGaTauDau;
            this.gridColumn6.FieldName = "GaTauDauId";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            this.gridColumn6.Width = 249;
            // 
            // cbgidGaTauDau
            // 
            this.cbgidGaTauDau.AutoHeight = false;
            this.cbgidGaTauDau.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbgidGaTauDau.Name = "cbgidGaTauDau";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Ga cuối";
            this.gridColumn5.ColumnEdit = this.cbgidGaTauCuoi;
            this.gridColumn5.FieldName = "GaTauCuoiId";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            this.gridColumn5.Width = 380;
            // 
            // cbgidGaTauCuoi
            // 
            this.cbgidGaTauCuoi.AutoHeight = false;
            this.cbgidGaTauCuoi.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbgidGaTauCuoi.Name = "cbgidGaTauCuoi";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Khoảng cách (km)";
            this.gridColumn1.ColumnEdit = this.numGridKhoangCach;
            this.gridColumn1.FieldName = "KhoangCach";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 314;
            // 
            // numGridKhoangCach
            // 
            this.numGridKhoangCach.AutoHeight = false;
            this.numGridKhoangCach.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.numGridKhoangCach.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numGridKhoangCach.MaxValue = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numGridKhoangCach.MinValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numGridKhoangCach.Name = "numGridKhoangCach";
            // 
            // gridColumnLuu
            // 
            this.gridColumnLuu.ColumnEdit = this.btGridSave;
            this.gridColumnLuu.Name = "gridColumnLuu";
            this.gridColumnLuu.Visible = true;
            this.gridColumnLuu.VisibleIndex = 3;
            this.gridColumnLuu.Width = 76;
            // 
            // btGridSave
            // 
            this.btGridSave.AutoHeight = false;
            this.btGridSave.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btGridSave.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btGridSave.Name = "btGridSave";
            this.btGridSave.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btGridSave.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btGridSave_ButtonClick);
            // 
            // gridColumnXoa
            // 
            this.gridColumnXoa.ColumnEdit = this.btnGridDelete;
            this.gridColumnXoa.Name = "gridColumnXoa";
            this.gridColumnXoa.Visible = true;
            this.gridColumnXoa.VisibleIndex = 4;
            this.gridColumnXoa.Width = 86;
            // 
            // btnGridDelete
            // 
            this.btnGridDelete.AutoHeight = false;
            this.btnGridDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnGridDelete.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.btnGridDelete.Name = "btnGridDelete";
            this.btnGridDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnGridDelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnGridDelete_ButtonClick);
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "gridColumn3";
            this.gridColumn3.FieldName = "Id";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gvExtra);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1123, 353);
            this.panel2.TabIndex = 7;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(113, 51);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(32, 51);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ga cuối";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numKhoangCach);
            this.panel1.Controls.Add(this.cbGaCuoi);
            this.panel1.Controls.Add(this.cbGaDau);
            this.panel1.Controls.Add(this.btnLamMoi);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1123, 89);
            this.panel1.TabIndex = 6;
            // 
            // numKhoangCach
            // 
            this.numKhoangCach.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numKhoangCach.Location = new System.Drawing.Point(525, 17);
            this.numKhoangCach.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numKhoangCach.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numKhoangCach.Name = "numKhoangCach";
            this.numKhoangCach.Size = new System.Drawing.Size(74, 20);
            this.numKhoangCach.TabIndex = 2;
            this.numKhoangCach.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // cbGaCuoi
            // 
            this.cbGaCuoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGaCuoi.FormattingEnabled = true;
            this.cbGaCuoi.Location = new System.Drawing.Point(297, 16);
            this.cbGaCuoi.Name = "cbGaCuoi";
            this.cbGaCuoi.Size = new System.Drawing.Size(168, 21);
            this.cbGaCuoi.TabIndex = 1;
            // 
            // cbGaDau
            // 
            this.cbGaDau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGaDau.FormattingEnabled = true;
            this.cbGaDau.Location = new System.Drawing.Point(73, 16);
            this.cbGaDau.Name = "cbGaDau";
            this.cbGaDau.Size = new System.Drawing.Size(168, 21);
            this.cbGaDau.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(605, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "km";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(475, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ga cuối";
            // 
            // UcTuyenDuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UcTuyenDuong";
            this.Size = new System.Drawing.Size(1123, 442);
            this.Load += new System.EventHandler(this.UcTuyenDuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvExtra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvObject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbgidGaTauDau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbgidGaTauCuoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGridKhoangCach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btGridSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGridDelete)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKhoangCach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gvExtra;
        private DevExpress.XtraGrid.Views.Grid.GridView gvObject;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnXoa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbGaCuoi;
        private System.Windows.Forms.ComboBox cbGaDau;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cbgidGaTauDau;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cbgidGaTauCuoi;
        private System.Windows.Forms.NumericUpDown numKhoangCach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit numGridKhoangCach;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnLuu;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btGridSave;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnGridDelete;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}
