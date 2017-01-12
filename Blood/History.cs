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
    public partial class History : Form
    {
        DetaildonorTableAdapter ddd = new DetaildonorTableAdapter();
        public History()
        {
            InitializeComponent();
        }


        private void History_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Detaildonor' table. You can move, or remove it, as needed.
            this.detaildonorTableAdapter.Fill(this.dataSet1.Detaildonor);
            // TODO: This line of code loads data into the 'dataSet1.Detaildonor' table. You can move, or remove it, as needed.
            this.detaildonorTableAdapter.Fill(this.dataSet1.Detaildonor);
            // TODO: This line of code loads data into the 'dataSet1.donor' table. You can move, or remove it, as needed.
            this.donorTableAdapter.Fill(this.dataSet1.donor);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = new DetaildonorTableAdapter().GetDataByDonorId(int.Parse(comboBox1.SelectedValue.ToString()));
        }
    }
}
