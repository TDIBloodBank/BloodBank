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
    public partial class info : Form
    {
        public info()
        {
            InitializeComponent();
        }

        private void info_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.donor' table. You can move, or remove it, as needed.
            this.donorTableAdapter.Fill(this.dataSet1.donor);
            //
            DataTable LD = new DetaildonorTableAdapter().GetDataByDonorId(int.Parse(comboBox1.SelectedValue.ToString()));
            lcount.Text = LD.Rows.Count.ToString();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(comboBox1.SelectedValue.ToString());
                var LastDate = new DetaildonorTableAdapter().MaxDate(id);

                if ((((DateTime)LastDate - DateTime.Now).Days > 90 && lsex.Text == "Male") || (((DateTime)LastDate - DateTime.Now).Days > 120 && lsex.Text == "Female"))
                {
                    lcheck.Text = "Possible";
                    lcheck.ForeColor = Color.Green;
                }
                else
                {
                    lcheck.Text = "Imposssible";
                    lcheck.ForeColor = Color.Red;
                }

                DataTable LD = new DetaildonorTableAdapter().GetDataByDonorId(id);
                lcount.Text = LD.Rows.Count.ToString();
            }
            catch (Exception)
            {

            }

        }
    }
}
