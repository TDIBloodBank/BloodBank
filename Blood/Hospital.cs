using Blood.DataSet1TableAdapters;
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
    public partial class Hospital : Form
    {
        HospitalTableAdapter h = new HospitalTableAdapter();
        public Hospital()
        {
            InitializeComponent();
        }

        private void savedata_Click(object sender, EventArgs e)
        {
            h.Insert(int.Parse(thid.Text) ,thname.Text,tcity.Text,phone.Text,tadress.Text);
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            thid.Text="" ;
            thname.Text="";
            tcity.Text="";
            phone.Text="";
            tadress.Text="";
        }
    }
}
