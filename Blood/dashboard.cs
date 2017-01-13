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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet11.DetailCom' table. You can move, or remove it, as needed.
            this.DetailComTableAdapter.Fill(this.dataSet11.DetailCom);
            // TODO: This line of code loads data into the 'DataSet1.DetailCom' table. You can move, or remove it, as needed.
            this.DetailComTableAdapter.Fill(this.DataSet1.DetailCom);
            // TODO: This line of code loads data into the 'DataSet1.Blood' table. You can move, or remove it, as needed.
            this.BloodTableAdapter.Fill(this.DataSet1.Blood);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
        }
    }
}
