using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Blood.DataSet1TableAdapters;

namespace Blood
{
    public partial class Labo : Form
    {

        LaboTableAdapter l = new LaboTableAdapter();
        donorTableAdapter d = new donorTableAdapter();
        public static int ID { set { cbdid.SelectedValue =value; } }
        public static string BloodG { set { cbbg.Text = value.ToString(); } }


        public Labo()
        {
            InitializeComponent();
        }


        private void Labo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.donor' table. You can move, or remove it, as needed.
            this.donorTableAdapter.Fill(this.dataSet1.donor);
            foreach (DataRow r in d.GetData())
            {
                cbdid.Items.Add( r[0].ToString());
            }

        }

        private void savedata_Click(object sender, EventArgs e)
        {
            l.Insert(int.Parse(cbdid.Text) , cbver.Text ,cbbg.Text , tstatus.Text);
        }
    }
}
