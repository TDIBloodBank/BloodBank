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
    public partial class Login : Form
    {
        Form1 F;

        public Login(Form1 F)
        {
            InitializeComponent();
            this.F = F;
        }



        private void BCon_Click_1(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.blood_2;
            F.clear();
        }
    }
}
