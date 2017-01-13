namespace Blood
{
    partial class dashboard
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.BloodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new Blood.DataSet1();
            this.DetailComBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.BloodTableAdapter = new Blood.DataSet1TableAdapters.BloodTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel8 = new System.Windows.Forms.Panel();
            this.DetailComTableAdapter = new Blood.DataSet1TableAdapters.DetailComTableAdapter();
            this.dataSet11 = new Blood.DataSet1();
            this.detailComBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BloodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailComBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailComBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // BloodBindingSource
            // 
            this.BloodBindingSource.DataMember = "Blood";
            this.BloodBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DetailComBindingSource
            // 
            this.DetailComBindingSource.DataMember = "DetailCom";
            this.DetailComBindingSource.DataSource = this.DataSet1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel7.Location = new System.Drawing.Point(553, 16);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 277);
            this.panel7.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel3.Location = new System.Drawing.Point(13, 283);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(540, 10);
            this.panel3.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(1, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(552, 41);
            this.panel4.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(161, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Personal Bio Data";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(225)))), ((int)(((byte)(214)))));
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 281);
            this.panel1.TabIndex = 13;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.BloodBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Blood.ReportGroup.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-77, -9);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(697, 320);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel9.Location = new System.Drawing.Point(564, 420);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(10, 320);
            this.panel9.TabIndex = 23;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel10.Location = new System.Drawing.Point(12, 730);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(552, 10);
            this.panel10.TabIndex = 24;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.panel11.Controls.Add(this.label2);
            this.panel11.Location = new System.Drawing.Point(1, 403);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(563, 41);
            this.panel11.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(161, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Personal Bio Data";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(225)))), ((int)(((byte)(214)))));
            this.panel12.Location = new System.Drawing.Point(1, 440);
            this.panel12.Margin = new System.Windows.Forms.Padding(6);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(563, 290);
            this.panel12.TabIndex = 21;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel13.Location = new System.Drawing.Point(1291, 418);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(10, 320);
            this.panel13.TabIndex = 27;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel14.Location = new System.Drawing.Point(704, 728);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(587, 10);
            this.panel14.TabIndex = 28;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.panel15.Controls.Add(this.label3);
            this.panel15.Location = new System.Drawing.Point(688, 401);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(603, 41);
            this.panel15.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(190, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Personal Bio Data";
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(225)))), ((int)(((byte)(214)))));
            this.panel16.Location = new System.Drawing.Point(688, 438);
            this.panel16.Margin = new System.Windows.Forms.Padding(6);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(603, 290);
            this.panel16.TabIndex = 25;
            // 
            // BloodTableAdapter
            // 
            this.BloodTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel2.Location = new System.Drawing.Point(1291, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 281);
            this.panel2.TabIndex = 31;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(688, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(603, 41);
            this.panel5.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(161, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personal Bio Data";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(225)))), ((int)(((byte)(214)))));
            this.panel6.Controls.Add(this.reportViewer2);
            this.panel6.Location = new System.Drawing.Point(688, 3);
            this.panel6.Margin = new System.Windows.Forms.Padding(6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(603, 281);
            this.panel6.TabIndex = 29;
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.DetailComBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Blood.ReportDC.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, -2);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(687, 284);
            this.reportViewer2.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel8.Location = new System.Drawing.Point(704, 284);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(587, 10);
            this.panel8.TabIndex = 17;
            // 
            // DetailComTableAdapter
            // 
            this.DetailComTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detailComBindingSource1
            // 
            this.detailComBindingSource1.DataMember = "DetailCom";
            this.detailComBindingSource1.DataSource = this.dataSet11;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(1301, 750);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "dashboard";
            this.Text = "dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BloodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailComBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailComBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel16;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BloodBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.BloodTableAdapter BloodTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.BindingSource DetailComBindingSource;
        private System.Windows.Forms.Panel panel8;
        private DataSet1TableAdapters.DetailComTableAdapter DetailComTableAdapter;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource detailComBindingSource1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
    }
}