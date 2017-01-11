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
        }
        int i;
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (tcnum.Text != "")
            {

                panel12.Enabled = true;

            }
        }

        private void savedata_Click(object sender, EventArgs e)
        {
            if (nudq.Value > 0)
            {
                double montant = double.Parse(tprice.Text) * int.Parse(nudq.Value.ToString());
                dataGridView1.Rows.Add(cbbg.Text, tprice.Text, nudq.Text, montant);

                //total += montant;
                //ttotal.Text = total.ToString();
            }

        }

        private void cbbg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                i = int.Parse(textBox4.Text);
                nudq.Maximum = i;
                nudq.Value = 0;

            }

            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                if (r.Cells[0].Value.ToString() == cbbg.Text)
                {
                    nudq.Maximum = int.Parse(textBox4.Text)  - int.Parse(r.Cells[2].Value.ToString());
                }
            }
        }

        private void nudq_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
