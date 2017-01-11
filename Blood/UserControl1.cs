
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public string BloodGroupe { set { lab.Text = value.ToString(); } }
        public int quin { set { Q.Text = value.ToString(); } }
        public double pu { set { p.Text = value.ToString(); } }


        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
