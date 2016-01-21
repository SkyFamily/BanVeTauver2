namespace BanVeTau.GUI
{
    partial class UcBaoCaoDoanhThu
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXem = new System.Windows.Forms.Button();
            this.tbNam = new System.Windows.Forms.TextBox();
            this.cbDoanTau = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.View_DoanhThuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veTauDataSet = new BanVeTau.Report.VeTauDataSet();
            this.view_DoanhThuTableAdapter = new BanVeTau.Report.VeTauDataSetTableAdapters.View_DoanhThuTableAdapter();
            this.tbThang = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.View_DoanhThuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veTauDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSetDoanhThu";
            reportDataSource3.Value = this.View_DoanhThuBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BanVeTau.Report.ReportDoanhThu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(986, 399);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXem);
            this.panel1.Controls.Add(this.tbNam);
            this.panel1.Controls.Add(this.tbThang);
            this.panel1.Controls.Add(this.cbDoanTau);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 49);
            this.panel1.TabIndex = 1;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(477, 10);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(100, 23);
            this.btnXem.TabIndex = 3;
            this.btnXem.Text = "Xem báo cáo";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // tbNam
            // 
            this.tbNam.Location = new System.Drawing.Point(399, 13);
            this.tbNam.Name = "tbNam";
            this.tbNam.Size = new System.Drawing.Size(61, 20);
            this.tbNam.TabIndex = 2;
            // 
            // cbDoanTau
            // 
            this.cbDoanTau.FormattingEnabled = true;
            this.cbDoanTau.Location = new System.Drawing.Point(66, 12);
            this.cbDoanTau.Name = "cbDoanTau";
            this.cbDoanTau.Size = new System.Drawing.Size(174, 21);
            this.cbDoanTau.TabIndex = 0;
            this.cbDoanTau.SelectionChangeCommitted += new System.EventHandler(this.cbDoanTau_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tháng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Năm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đoàn tàu";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(986, 399);
            this.panel2.TabIndex = 2;
            // 
            // View_DoanhThuBindingSource
            // 
            this.View_DoanhThuBindingSource.DataMember = "View_DoanhThu";
            this.View_DoanhThuBindingSource.DataSource = this.veTauDataSet;
            // 
            // veTauDataSet
            // 
            this.veTauDataSet.DataSetName = "VeTauDataSet";
            this.veTauDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_DoanhThuTableAdapter
            // 
            this.view_DoanhThuTableAdapter.ClearBeforeFill = true;
            // 
            // tbThang
            // 
            this.tbThang.Location = new System.Drawing.Point(296, 13);
            this.tbThang.Name = "tbThang";
            this.tbThang.Size = new System.Drawing.Size(61, 20);
            this.tbThang.TabIndex = 1;
            this.tbThang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbThang_KeyPress);
            // 
            // UcBaoCaoDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UcBaoCaoDoanhThu";
            this.Size = new System.Drawing.Size(986, 448);
            this.Load += new System.EventHandler(this.UcBaoCaoDoanhThuTC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.View_DoanhThuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veTauDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.TextBox tbNam;
        private System.Windows.Forms.ComboBox cbDoanTau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource View_DoanhThuBindingSource;
        private Report.VeTauDataSet veTauDataSet;
        private Report.VeTauDataSetTableAdapters.View_DoanhThuTableAdapter view_DoanhThuTableAdapter;
        private System.Windows.Forms.TextBox tbThang;
    }
}
