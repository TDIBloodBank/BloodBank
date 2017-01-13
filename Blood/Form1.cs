using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood
{
    public partial class Form1 : Form
    {
        public static string Nurename { set { lname.Text = value.ToString(); } }

        public Form1()
        {
            InitializeComponent();

            Login L = new Login(this);
            login(L);

            //fullscrean
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new Point(0, 0);
            this.Size = SystemInformation.PrimaryMonitorSize;
        }

        public void clear()
        {
            panel3.Controls.Clear();
            panel3.Dock = DockStyle.None;
            panel1.Visible = true;
            panel2.Visible = true;
            panel4.Visible = true;
        }
        public void login (Form myForm)
        {
            
            panel3.Controls.Clear();
            myForm.TopLevel = false;
            myForm.AutoScroll = false;
            myForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            panel3.Controls.Add(myForm);
            myForm.Show();
            myForm.Location = new Point(600,175);
            panel1.Visible = false;
            panel2.Visible = false;
            panel4.Visible = false;
            panel3.Dock = DockStyle.Fill;
            WindowState = FormWindowState.Normal;
        }
   
        public void call(Form myForm)
        {
            panel3.Controls.Clear();
            myForm.TopLevel = false;
            myForm.AutoScroll = false;
            myForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            panel3.Controls.Add(myForm);
            myForm.Show();
            myForm.Location = new Point(50,50);
        }

        private void bajout_Click(object sender, EventArgs e)
        {
            Add a = new Add();
            call(a); 
        }

        private void blabo_Click(object sender, EventArgs e)
        {
            Labo l = new Labo();
            call(l);
        }

        private void Comm_Click(object sender, EventArgs e)
        {
            command c = new command();
            call(c);
        }

        private void bhos_Click(object sender, EventArgs e)
        {
            Hospital h = new Hospital();
            call(h);
        }

        private void Stock_Click(object sender, EventArgs e)
        {
            stock s = new stock();
            call(s);
        }

        private void donorh_Click(object sender, EventArgs e)
        {
            History h = new History();
            call(h);
        }

        private void dinfo_Click(object sender, EventArgs e)
        {
            info i = new info();
            call(i);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dashdoard_Click(object sender, EventArgs e)
        {
            dashboard d = new dashboard();
            call(d);

        }

        private void Mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Labo l = new Labo();
            call(l);
        }
    }
}
