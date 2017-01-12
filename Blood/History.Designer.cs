namespace Blood
{
    partial class History
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
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.donorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Blood.DataSet1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.detaildonorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ltotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.donorTableAdapter = new Blood.DataSet1TableAdapters.donorTableAdapter();
            this.detaildonorTableAdapter = new Blood.DataSet1TableAdapters.DetaildonorTableAdapter();
            this.dated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ddidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detaildonorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel7.Location = new System.Drawing.Point(972, 15);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 730);
            this.panel7.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel3.Location = new System.Drawing.Point(350, 735);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(622, 10);
            this.panel3.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Location = new System.Drawing.Point(334, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(638, 56);
            this.panel4.TabIndex = 18;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.comboBox1.DataSource = this.donorBindingSource;
            this.comboBox1.DisplayMember = "firstname";
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(235, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 32);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "DonorId";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // donorBindingSource
            // 
            this.donorBindingSource.DataMember = "donor";
            this.donorBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(225)))), ((int)(((byte)(214)))));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.ltotal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(334, 55);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 680);
            this.panel1.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dated,
            this.ddidDataGridViewTextBoxColumn,
            this.datedDataGridViewTextBoxColumn,
            this.donoridDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.detaildonorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(140, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(344, 600);
            this.dataGridView1.TabIndex = 40;
            // 
            // detaildonorBindingSource
            // 
            this.detaildonorBindingSource.DataMember = "Detaildonor";
            this.detaildonorBindingSource.DataSource = this.dataSet1;
            // 
            // ltotal
            // 
            this.ltotal.AutoSize = true;
            this.ltotal.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotal.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ltotal.Location = new System.Drawing.Point(982, 209);
            this.ltotal.Name = "ltotal";
            this.ltotal.Size = new System.Drawing.Size(118, 40);
            this.ltotal.TabIndex = 39;
            this.ltotal.Text = "880Dh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label1.Location = new System.Drawing.Point(985, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "Total";
            // 
            // donorTableAdapter
            // 
            this.donorTableAdapter.ClearBeforeFill = true;
            // 
            // detaildonorTableAdapter
            // 
            this.detaildonorTableAdapter.ClearBeforeFill = true;
            // 
            // dated
            // 
            this.dated.DataPropertyName = "dated";
            this.dated.HeaderText = "Date of Donation";
            this.dated.Name = "dated";
            this.dated.ReadOnly = true;
            this.dated.Width = 300;
            // 
            // ddidDataGridViewTextBoxColumn
            // 
            this.ddidDataGridViewTextBoxColumn.DataPropertyName = "ddid";
            this.ddidDataGridViewTextBoxColumn.HeaderText = "ddid";
            this.ddidDataGridViewTextBoxColumn.Name = "ddidDataGridViewTextBoxColumn";
            this.ddidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datedDataGridViewTextBoxColumn
            // 
            this.datedDataGridViewTextBoxColumn.DataPropertyName = "dated";
            this.datedDataGridViewTextBoxColumn.HeaderText = "dated";
            this.datedDataGridViewTextBoxColumn.Name = "datedDataGridViewTextBoxColumn";
            this.datedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // donoridDataGridViewTextBoxColumn
            // 
            this.donoridDataGridViewTextBoxColumn.DataPropertyName = "Donorid";
            this.donoridDataGridViewTextBoxColumn.HeaderText = "Donorid";
            this.donoridDataGridViewTextBoxColumn.Name = "donoridDataGridViewTextBoxColumn";
            this.donoridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(1301, 750);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "History";
            this.Text = "History";
            this.Load += new System.EventHandler(this.History_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.donorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detaildonorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ltotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource donorBindingSource;
        private DataSet1TableAdapters.donorTableAdapter donorTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource detaildonorBindingSource;
        private DataSet1TableAdapters.DetaildonorTableAdapter detaildonorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dated;
        private System.Windows.Forms.DataGridViewTextBoxColumn ddidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donoridDataGridViewTextBoxColumn;
    }
}