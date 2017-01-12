namespace Blood
{
    partial class info
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.donorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Blood.DataSet1();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lcheck = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lajhfikqsd = new System.Windows.Forms.Label();
            this.savedata = new System.Windows.Forms.Button();
            this.lcount = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lsex = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.donorTableAdapter = new Blood.DataSet1TableAdapters.donorTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.donorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DataSource = this.donorBindingSource;
            this.comboBox1.DisplayMember = "firstname";
            this.comboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(571, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 32);
            this.comboBox1.TabIndex = 2;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel3.Location = new System.Drawing.Point(122, 735);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1105, 11);
            this.panel3.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(108, 55);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1109, 41);
            this.panel4.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(459, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Donor information";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(225)))), ((int)(((byte)(214)))));
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.lcheck);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.lajhfikqsd);
            this.panel1.Controls.Add(this.savedata);
            this.panel1.Controls.Add(this.lcount);
            this.panel1.Controls.Add(this.label32);
            this.panel1.Controls.Add(this.label31);
            this.panel1.Controls.Add(this.label30);
            this.panel1.Controls.Add(this.label29);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.lsex);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(108, 92);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1109, 643);
            this.panel1.TabIndex = 13;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel6.Location = new System.Drawing.Point(802, 585);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(190, 6);
            this.panel6.TabIndex = 24;
            // 
            // lcheck
            // 
            this.lcheck.AutoSize = true;
            this.lcheck.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lcheck.Location = new System.Drawing.Point(429, 569);
            this.lcheck.Name = "lcheck";
            this.lcheck.Size = new System.Drawing.Size(84, 25);
            this.lcheck.TabIndex = 66;
            this.lcheck.Text = "--------";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel5.Location = new System.Drawing.Point(992, 551);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(6, 40);
            this.panel5.TabIndex = 23;
            // 
            // lajhfikqsd
            // 
            this.lajhfikqsd.AutoSize = true;
            this.lajhfikqsd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lajhfikqsd.Location = new System.Drawing.Point(430, 545);
            this.lajhfikqsd.Name = "lajhfikqsd";
            this.lajhfikqsd.Size = new System.Drawing.Size(176, 24);
            this.lajhfikqsd.TabIndex = 65;
            this.lajhfikqsd.Text = "Donation check";
            // 
            // savedata
            // 
            this.savedata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.savedata.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.savedata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savedata.ForeColor = System.Drawing.Color.White;
            this.savedata.Location = new System.Drawing.Point(792, 545);
            this.savedata.Name = "savedata";
            this.savedata.Size = new System.Drawing.Size(200, 40);
            this.savedata.TabIndex = 25;
            this.savedata.Text = "Give Blood";
            this.savedata.UseVisualStyleBackColor = false;
            // 
            // lcount
            // 
            this.lcount.AutoSize = true;
            this.lcount.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lcount.Location = new System.Drawing.Point(37, 569);
            this.lcount.Name = "lcount";
            this.lcount.Size = new System.Drawing.Size(84, 25);
            this.lcount.TabIndex = 64;
            this.lcount.Text = "--------";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label32.Location = new System.Drawing.Point(38, 545);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(171, 24);
            this.label32.TabIndex = 63;
            this.label32.Text = "Donation count";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.donorBindingSource, "DonorId", true));
            this.label31.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donorBindingSource, "diseases", true));
            this.label31.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label31.Location = new System.Drawing.Point(35, 378);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(84, 25);
            this.label31.TabIndex = 62;
            this.label31.Text = "--------";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.donorBindingSource, "DonorId", true));
            this.label30.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donorBindingSource, "donotedBefor", true));
            this.label30.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label30.Location = new System.Drawing.Point(789, 469);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(84, 25);
            this.label30.TabIndex = 61;
            this.label30.Text = "--------";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.donorBindingSource, "DonorId", true));
            this.label29.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donorBindingSource, "Dweight", true));
            this.label29.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label29.Location = new System.Drawing.Point(427, 469);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(84, 25);
            this.label29.TabIndex = 60;
            this.label29.Text = "--------";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.donorBindingSource, "DonorId", true));
            this.label28.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donorBindingSource, "BloodGroup", true));
            this.label28.Font = new System.Drawing.Font("Century Gothic", 120F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.label28.Location = new System.Drawing.Point(15, 36);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(360, 193);
            this.label28.TabIndex = 59;
            this.label28.Text = "AB-";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.donorBindingSource, "DonorId", true));
            this.label27.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donorBindingSource, "Height", true));
            this.label27.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label27.Location = new System.Drawing.Point(37, 469);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(84, 25);
            this.label27.TabIndex = 58;
            this.label27.Text = "--------";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.donorBindingSource, "DonorId", true));
            this.label26.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donorBindingSource, "Adress", true));
            this.label26.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label26.Location = new System.Drawing.Point(427, 378);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(84, 25);
            this.label26.TabIndex = 57;
            this.label26.Text = "--------";
            // 
            // lsex
            // 
            this.lsex.AutoSize = true;
            this.lsex.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donorBindingSource, "sex", true));
            this.lsex.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.donorBindingSource, "DonorId", true));
            this.lsex.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lsex.Location = new System.Drawing.Point(789, 209);
            this.lsex.Name = "lsex";
            this.lsex.Size = new System.Drawing.Size(84, 25);
            this.lsex.TabIndex = 56;
            this.lsex.Text = "--------";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.donorBindingSource, "DonorId", true));
            this.label24.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donorBindingSource, "city", true));
            this.label24.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label24.Location = new System.Drawing.Point(789, 290);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(84, 25);
            this.label24.TabIndex = 55;
            this.label24.Text = "--------";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.donorBindingSource, "DonorId", true));
            this.label23.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donorBindingSource, "phone", true));
            this.label23.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label23.Location = new System.Drawing.Point(37, 290);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(84, 25);
            this.label23.TabIndex = 54;
            this.label23.Text = "--------";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.donorBindingSource, "DonorId", true));
            this.label22.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donorBindingSource, "age", true));
            this.label22.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label22.Location = new System.Drawing.Point(789, 138);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(84, 25);
            this.label22.TabIndex = 53;
            this.label22.Text = "--------";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.donorBindingSource, "DonorId", true));
            this.label21.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donorBindingSource, "lastname", true));
            this.label21.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label21.Location = new System.Drawing.Point(789, 57);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(84, 25);
            this.label21.TabIndex = 52;
            this.label21.Text = "--------";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.donorBindingSource, "DonorId", true));
            this.label20.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donorBindingSource, "firstname", true));
            this.label20.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label20.Location = new System.Drawing.Point(429, 57);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(84, 25);
            this.label20.TabIndex = 51;
            this.label20.Text = "--------";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.donorBindingSource, "DonorId", true));
            this.label19.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donorBindingSource, "datebirth", true));
            this.label19.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label19.Location = new System.Drawing.Point(429, 290);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 25);
            this.label19.TabIndex = 50;
            this.label19.Text = "--------";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.donorBindingSource, "DonorId", true));
            this.label15.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donorBindingSource, "cin", true));
            this.label15.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label15.Location = new System.Drawing.Point(429, 138);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 25);
            this.label15.TabIndex = 49;
            this.label15.Text = "--------";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.donorBindingSource, "DonorId", true));
            this.label13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donorBindingSource, "DonorId", true));
            this.label13.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label13.Location = new System.Drawing.Point(429, 209);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 25);
            this.label13.TabIndex = 48;
            this.label13.Text = "--------";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label18.Location = new System.Drawing.Point(790, 445);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(230, 24);
            this.label18.TabIndex = 47;
            this.label18.Text = "Donoted blood befor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label10.Location = new System.Drawing.Point(428, 445);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 24);
            this.label10.TabIndex = 39;
            this.label10.Text = "Weight (kg)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label11.Location = new System.Drawing.Point(38, 445);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 24);
            this.label11.TabIndex = 38;
            this.label11.Text = "Height (cm)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label12.Location = new System.Drawing.Point(36, 357);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(170, 24);
            this.label12.TabIndex = 37;
            this.label12.Text = "Diseases (if any)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label17.Location = new System.Drawing.Point(790, 185);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 24);
            this.label17.TabIndex = 35;
            this.label17.Text = "Sex";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label16.Location = new System.Drawing.Point(430, 185);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 24);
            this.label16.TabIndex = 33;
            this.label16.Text = "ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label9.Location = new System.Drawing.Point(36, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 24);
            this.label9.TabIndex = 19;
            this.label9.Text = "Phone number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label7.Location = new System.Drawing.Point(428, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Adress";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label6.Location = new System.Drawing.Point(788, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label5.Location = new System.Drawing.Point(790, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label4.Location = new System.Drawing.Point(430, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "CIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label3.Location = new System.Drawing.Point(428, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date of birth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label2.Location = new System.Drawing.Point(790, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Age";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label1.Location = new System.Drawing.Point(428, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // donorTableAdapter
            // 
            this.donorTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel2.Location = new System.Drawing.Point(1217, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 664);
            this.panel2.TabIndex = 16;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label25.Location = new System.Drawing.Point(44, 36);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(140, 24);
            this.label25.TabIndex = 67;
            this.label25.Text = "Blood Group";
            // 
            // info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(1301, 750);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "info";
            this.Text = "info";
            this.Load += new System.EventHandler(this.info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.donorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lsex;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource donorBindingSource;
        private DataSet1TableAdapters.donorTableAdapter donorTableAdapter;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lcount;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label lcheck;
        private System.Windows.Forms.Label lajhfikqsd;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button savedata;
        private System.Windows.Forms.Label label25;
    }
}