namespace Blood
{
    partial class UserControl1
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lab = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.bloodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Blood.DataSet1();
            this.p = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Q = new System.Windows.Forms.TextBox();
            this.bloodTableAdapter = new Blood.DataSet1TableAdapters.BloodTableAdapter();
            this.bloodBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bloodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel2.Location = new System.Drawing.Point(251, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 267);
            this.panel2.TabIndex = 23;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel5.Location = new System.Drawing.Point(43, 325);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(218, 10);
            this.panel5.TabIndex = 24;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.panel6.Controls.Add(this.lab);
            this.panel6.Location = new System.Drawing.Point(33, 37);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(218, 66);
            this.panel6.TabIndex = 22;
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Font = new System.Drawing.Font("Century Gothic", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab.ForeColor = System.Drawing.Color.White;
            this.lab.Location = new System.Drawing.Point(75, 4);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(41, 57);
            this.lab.TabIndex = 0;
            this.lab.Text = "-";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(225)))), ((int)(((byte)(214)))));
            this.panel8.Controls.Add(this.p);
            this.panel8.Controls.Add(this.label11);
            this.panel8.Controls.Add(this.label12);
            this.panel8.Controls.Add(this.Q);
            this.panel8.Location = new System.Drawing.Point(33, 102);
            this.panel8.Margin = new System.Windows.Forms.Padding(6);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(218, 223);
            this.panel8.TabIndex = 21;
            // 
            // bloodBindingSource
            // 
            this.bloodBindingSource.DataMember = "Blood";
            this.bloodBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // p
            // 
            this.p.BackColor = System.Drawing.Color.White;
            this.p.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bloodBindingSource, "BloodGroup", true));
            this.p.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bloodBindingSource, "pu", true));
            this.p.Enabled = false;
            this.p.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.p.Location = new System.Drawing.Point(39, 148);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(136, 26);
            this.p.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label11.Location = new System.Drawing.Point(35, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 24);
            this.label11.TabIndex = 35;
            this.label11.Text = "Price";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label12.Location = new System.Drawing.Point(34, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 24);
            this.label12.TabIndex = 33;
            this.label12.Text = "Quantity";
            // 
            // Q
            // 
            this.Q.BackColor = System.Drawing.Color.White;
            this.Q.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Q.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bloodBindingSource, "BloodGroup", true));
            this.Q.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bloodBindingSource, "qstock", true));
            this.Q.Enabled = false;
            this.Q.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.Q.Location = new System.Drawing.Point(39, 66);
            this.Q.Name = "Q";
            this.Q.Size = new System.Drawing.Size(136, 26);
            this.Q.TabIndex = 32;
            // 
            // bloodTableAdapter
            // 
            this.bloodTableAdapter.ClearBeforeFill = true;
            // 
            // bloodBindingSource1
            // 
            this.bloodBindingSource1.DataMember = "Blood";
            this.bloodBindingSource1.DataSource = this.dataSet1;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel8);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(288, 369);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bloodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox p;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Q;
        private System.Windows.Forms.BindingSource bloodBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.BloodTableAdapter bloodTableAdapter;
        private System.Windows.Forms.BindingSource bloodBindingSource1;
    }
}
