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
    public partial class ProjectDetails : UserControl
    {
        public ProjectDetails()
        {
            InitializeComponent();
            //load current rows
            try
            {
                DataOperation dop = new DataOperation();
                dop.OpenDatabase();
                DataSet ds = dop.RunQueryCommand("select project_id, project_name, description, deadline, u_id_manager from ProjectDetails;");
                this.dgvProjectDetails.AutoGenerateColumns = false;
                this.dgvProjectDetails.DataSource = ds.Tables[0];
                dop.CloseDatabase();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnSearchProject_Click(object sender, EventArgs e)
        {
            try
            {
                DataOperation dop = new DataOperation();
                dop.OpenDatabase();
                DataSet ds = dop.RunQueryCommand("select project_id, project_name, description, deadline, u_id_manager from ProjectDetails where project_id='" + this.txtSearchById.Text + "';");
                this.dgvProjectDetails.AutoGenerateColumns = false;
                this.dgvProjectDetails.DataSource = ds.Tables[0];
                dop.CloseDatabase();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnDeleteProject_Click(object sender, EventArgs e)
        {
            DataOperation dop = new DataOperation();
            dop.OpenDatabase();
            int u = dop.RunNonQueryCommand("delete from ProjectDetails where project_id = '" + this.txtSearchById.Text + "';");
            dop.CloseDatabase();
            if (u > 0)
            {
                MessageBox.Show("Deletion completed");
            }
            else
            {
                MessageBox.Show("Deletion Failed");
            }
        }
    }
}
