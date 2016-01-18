using BanVeTau.Report;

namespace BanVeTau.GUI
{
    sealed partial class UcBaoCaoGiaVe
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.View_GiaVeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veTauDataSet = new BanVeTau.Report.VeTauDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbLichTrinh = new System.Windows.Forms.ComboBox();
            this.cbDoanTau = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportGiaVe = new Microsoft.Reporting.WinForms.ReportViewer();
            this.view_GiaVeTableAdapter = new BanVeTau.Report.VeTauDataSetTableAdapters.View_GiaVeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.View_GiaVeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veTauDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // View_GiaVeBindingSource
            // 
            this.View_GiaVeBindingSource.DataMember = "View_GiaVe";
            this.View_GiaVeBindingSource.DataSource = this.veTauDataSet;
            // 
            // veTauDataSet
            // 
            this.veTauDataSet.DataSetName = "VeTauDataSet";
            this.veTauDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbLichTrinh);
            this.panel1.Controls.Add(this.cbDoanTau);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 60);
            this.panel1.TabIndex = 3;
            // 
            // cbLichTrinh
            // 
            this.cbLichTrinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLichTrinh.FormattingEnabled = true;
            this.cbLichTrinh.Location = new System.Drawing.Point(317, 18);
            this.cbLichTrinh.Name = "cbLichTrinh";
            this.cbLichTrinh.Size = new System.Drawing.Size(174, 21);
            this.cbLichTrinh.TabIndex = 1;
            this.cbLichTrinh.SelectionChangeCommitted += new System.EventHandler(this.cbLichTrinh_SelectionChangeCommitted);
            // 
            // cbDoanTau
            // 
            this.cbDoanTau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDoanTau.FormattingEnabled = true;
            this.cbDoanTau.Location = new System.Drawing.Point(67, 18);
            this.cbDoanTau.Name = "cbDoanTau";
            this.cbDoanTau.Size = new System.Drawing.Size(174, 21);
            this.cbDoanTau.TabIndex = 0;
            this.cbDoanTau.SelectionChangeCommitted += new System.EventHandler(this.cbDoanTau_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lịch trình";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Đoàn tàu";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportGiaVe);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(831, 375);
            this.panel2.TabIndex = 4;
            // 
            // reportGiaVe
            // 
            this.reportGiaVe.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.View_GiaVeBindingSource;
            this.reportGiaVe.LocalReport.DataSources.Add(reportDataSource1);
            this.reportGiaVe.LocalReport.ReportEmbeddedResource = "BanVeTau.Report.ReportGiaVe.rdlc";
            this.reportGiaVe.Location = new System.Drawing.Point(0, 0);
            this.reportGiaVe.Name = "reportGiaVe";
            this.reportGiaVe.Size = new System.Drawing.Size(831, 375);
            this.reportGiaVe.TabIndex = 0;
            this.reportGiaVe.Load += new System.EventHandler(this.UcBaoCaoGiaVe_Load);
            // 
            // view_GiaVeTableAdapter
            // 
            this.view_GiaVeTableAdapter.ClearBeforeFill = true;
            // 
            // UcBaoCaoGiaVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UcBaoCaoGiaVe";
            this.Size = new System.Drawing.Size(831, 435);
            ((System.ComponentModel.ISupportInitialize)(this.View_GiaVeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veTauDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportGiaVe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource View_GiaVeBindingSource;
        private VeTauDataSet veTauDataSet;
        private Report.VeTauDataSetTableAdapters.View_GiaVeTableAdapter view_GiaVeTableAdapter;
        private System.Windows.Forms.ComboBox cbLichTrinh;
        private System.Windows.Forms.ComboBox cbDoanTau;
    }
}
