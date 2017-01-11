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
    public partial class Add : Form
    {
        BindingSource b = new BindingSource();
        donorTableAdapter d = new donorTableAdapter();

        public void actu()
        {
            tdid.DataBindings.Add("Text", b, "DonorId");
            tfname.DataBindings.Add("Text", b, "firstname");
            tlname.DataBindings.Add("Text", b, "lastname");
            tcin.DataBindings.Add("Text", b, "cin");
            dob.DataBindings.Add("Value", b, "datebirth");
            age.DataBindings.Add("Text", b, "age");
            phone.DataBindings.Add("Text", b, "phone");
            tcity.DataBindings.Add("Text", b, "city");
            sex.DataBindings.Add("Text", b, "sex");
            tadress.DataBindings.Add("Text", b, "Adress");
            cm.DataBindings.Add("Text", b, "Height");
            kg.DataBindings.Add("Text", b, "Dweight");
            tdis.DataBindings.Add("Text", b, "diseases");
            cbbg.DataBindings.Add("Text", b, "bloodGroup");
            dod.DataBindings.Add("Value", b, "datedonation");
            cbdb.DataBindings.Add("Text", b, "donotedBefor");
        }

        public Add()
        {
            InitializeComponent();
            b.DataSource = d.GetData();
            actu();

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void savedata_Click(object sender, EventArgs e)
        {
            d.Insert(int.Parse(tdid.Text), tfname.Text, tlname.Text, tcin.Text, dob.Value, int.Parse(age.Text), phone.Text, tcity.Text, sex.Text, tadress.Text, int.Parse(cm.Text), int.Parse(kg.Text), tdis.Text, cbbg.Text, dod.Value, cbdb.Text);
            actu();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            tdid.Text = "";
            tfname.Text = "";
            tlname.Text = "";
            tcin.Text = "";
            dob.Text = "";
            age.Value = 0;
            phone.Text = "";
            tcity.Text = "";
            sex.Text = "";
            tadress.Text = "";
            cm.Value = 0;
            kg.Value = 0;
            tdis.Text = "";
            cbbg.Text = "";
            dod.Text = "";
            cbdb.Text = "";
        }

        private void bfirst_Click(object sender, EventArgs e)
        {
            b.MoveFirst();
        }

        private void bpre_Click(object sender, EventArgs e)
        {
            b.MovePrevious();
        }

        private void bnext_Click(object sender, EventArgs e)
        {
            b.MoveNext();
        }

        private void blast_Click(object sender, EventArgs e)
        {
            b.MoveNext();
        }
    }
}
