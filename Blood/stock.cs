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
    public partial class stock : Form
    {

        public stock()
        {
            InitializeComponent();
        }



        private void stock_Load(object sender, EventArgs e)
        {

            
            List<DataSet1.BloodRow> LB = new BloodTableAdapter().GetData().ToList<DataSet1.BloodRow>();
            foreach (var B1 in LB)
            {
                UserControl1 uc = new UserControl1();

                uc.BloodGroupe = B1.BloodGroup;
                uc.quin = B1.qstock;
                uc.pu = B1.pu;
                flp.Controls.Add(uc);
            }
           
                

            
        }
    }
}
