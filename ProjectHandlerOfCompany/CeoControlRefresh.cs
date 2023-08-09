using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectHandlerOfCompany
{
    public partial class CeoControlRefresh : UserControl
    {
        public CeoControlRefresh()
        {
            InitializeComponent();
        }

        private void CeoControlRefresh_Load(object sender, EventArgs e)
        {
            //managers summery
            try
            {
                DataOperation dop = new DataOperation();
                dop.OpenDatabase();
                DataSet ds = dop.RunQueryCommand("select u_id, activeStatus from UserInfo where u_id like 'm%';");
                this.dgvManagerDetails.AutoGenerateColumns = false;
                this.dgvManagerDetails.DataSource = ds.Tables[0];
                dop.CloseDatabase();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            //pie chart
            this.crtRatio.Series["Series1"].Points.AddXY("R", 70);
            this.crtRatio.Series["Series1"].Points.AddXY("E", 30);

            //client count
            try
            {
                DataOperation dop = new DataOperation();
                dop.OpenDatabase();
                DataSet ds = dop.RunQueryCommand("select * from userinfo where u_id like 'b-%';");
                this.lblClientCount.Text = ds.Tables[0].Rows.Count.ToString();
                dop.CloseDatabase();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            //project count
            try
            {
                DataOperation dop = new DataOperation();
                dop.OpenDatabase();
                DataSet ds = dop.RunQueryCommand("select * from projectdetails;");
                this.lblProjectCount.Text = ds.Tables[0].Rows.Count.ToString();
                dop.CloseDatabase();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
