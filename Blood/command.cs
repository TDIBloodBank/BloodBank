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
    public partial class command : Form
    {
        
        public command()
        {
            InitializeComponent();
            panel12.Enabled = false;
            FillIdsection();
        }

        CommandeTableAdapter c = new CommandeTableAdapter();
        private void command_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Commande' table. You can move, or remove it, as needed.
            this.commandeTableAdapter.Fill(this.dataSet1.Commande);
            // TODO: This line of code loads data into the 'dataSet1.Commande' table. You can move, or remove it, as needed.
            //this.commandeTableAdapter.Fill(this.dataSet1.Commande);
            // TODO: This line of code loads data into the 'dataSet1.Blood' table. You can move, or remove it, as needed.
            this.bloodTableAdapter.Fill(this.dataSet1.Blood);
            // TODO: This line of code loads data into the 'dataSet1.Hospital' table. You can move, or remove it, as needed.
            this.hospitalTableAdapter.Fill(this.dataSet1.Hospital);

        }

        private void FillIdsection()
        {
            try
            {
                DataTable dt = c.GetDataBy();
                int i = int.Parse(dt.Rows[0]["MAXID"].ToString()) + 1;
                lid.Text = i.ToString();
            }
            catch (Exception)
            {

                lid.Text = "1";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (tcnum.Text != "")
            //{
                  panel12.Enabled = true;
            //}
        }

        private void savedata_Click(object sender, EventArgs e)
        {
            double d = 0,t=0;
            if (nudq.Value > 0)
            {
                double montant = double.Parse(tprice.Text) * int.Parse(nudq.Value.ToString());

                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    if (r.Cells[0].Value.ToString() == cbbg.Text)
                    {
                        d = double.Parse(r.Cells[2].Value.ToString()) + double.Parse(nudq.Value.ToString());
                        r.Cells[2].Value = d;
                        r.Cells[3].Value = d * double.Parse(tprice.Text);
                        break;
                    }
                }
                if(d==0)
                    dataGridView1.Rows.Add(cbbg.Text, tprice.Text, nudq.Text, montant);

                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    t += double.Parse(r.Cells[3].Value.ToString());
                }
                ltotal.Text = t.ToString();
            }
        }

        private void cbbg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nudq_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tprice_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            i = int.Parse(textBox4.Text);

            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                if (r.Cells[0].Value.ToString() == cbbg.Text)
                {
                    nudq.Maximum = i - int.Parse(r.Cells[2].Value.ToString());
                    nudq.Value = 0;
                    break;
                }
                else
                {
                    nudq.Maximum = i;
                    nudq.Value = 0;
                }
            }

        }

        private void ValidateCmd_Click(object sender, EventArgs e)
        {
            DataSet1.BloodRow BR;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                BR = new BloodTableAdapter().GetData().FindByBloodGroup(row.Cells[0].Value.ToString());
                BR.qstock -= int.Parse(row.Cells[2].Value.ToString());
                new BloodTableAdapter().Update(BR);
                new DetailComTableAdapter().Insert(lid.Text, cbbj.Text, nudq.Value);
            }
            
        }
    }
}
