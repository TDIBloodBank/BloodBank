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
            FillIdsection();
        }
        private void FillIdsection()
        {
            DataTable dt = h.GetDataBy();
            int i = int.Parse(dt.Rows[0]["MAXID"].ToString()) + 1;
            lid.Text = i.ToString();
        }

        private void savedata_Click(object sender, EventArgs e)
        {
            h.Insert(thname.Text.ToString(),tcity.Text.ToString(), phone.Text.ToString(), tadress.Text.ToString());
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            FillIdsection();
            thname.Text="";
            tcity.Text="";
            phone.Text="";
            tadress.Text="";
        }
    }
}
