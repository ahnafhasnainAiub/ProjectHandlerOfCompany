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
    public partial class ListOfProject : UserControl
    {
        public ListOfProject()
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
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
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

        private void dgvProjectDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtPrjectId.Text = this.dgvProjectDetails.CurrentRow.Cells[0].Value.ToString();
            this.txtProjectTitle.Text = this.dgvProjectDetails.CurrentRow.Cells[1].Value.ToString();
            this.txtUserManager.Text = this.dgvProjectDetails.CurrentRow.Cells[4].Value.ToString();
            this.dtpDeadline.Text = this.dgvProjectDetails.CurrentRow.Cells[3].Value.ToString();
            this.txtProjectDes.Text = this.dgvProjectDetails.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                DataOperation dop = new DataOperation();
                dop.OpenDatabase();
                int rowCount = dop.RowCounter("select project_id, project_name, description, deadline, u_id_manager from ProjectDetails where project_id='" + this.txtPrjectId.Text + "';");
                
                dop.CloseDatabase();
                MessageBox.Show(rowCount.ToString());
                if (rowCount > 0)
                {
                    //update project info
                    this.UpdateProjectInfo();
                }
                else
                {
                    MessageBox.Show("update");
                    //insert project info
                    this.InsertProjectInfo();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void InsertProjectInfo()
        {
            DataOperation dop = new DataOperation();
            dop.OpenDatabase();
            int u = dop.RunNonQueryCommand("insert into  ProjectDetails (project_id, project_name, description, deadline, u_id_manager) values ('" + this.txtPrjectId.Text + "', '" + this.txtProjectTitle.Text + "', '" + this.txtProjectDes.Text + "', '" + this.dtpDeadline.Text + "', '" + this.txtUserManager.Text + "');");
            dop.CloseDatabase();
            if(u > 0)
            {
                MessageBox.Show("Insertion completed");
            }
            else
            {
                MessageBox.Show("Insertion Failed");
            }
        }

        public void UpdateProjectInfo()
        {
            DataOperation dop = new DataOperation();
            dop.OpenDatabase();
            int u = dop.RunNonQueryCommand("update ProjectDetails set project_name = '" + this.txtProjectTitle.Text + "', description = '" + this.txtProjectDes.Text + "', deadline='" + this.dtpDeadline.Text.ToString() + "', u_id_manager='" + this.txtUserManager.Text + "' where project_id = '" + this.txtPrjectId.Text + "';");
            dop.CloseDatabase();
            if (u > 0)
            {
                MessageBox.Show("Updation completed");
            }
            else
            {
                MessageBox.Show("Updation Failed");
            }
        }

        private void btnDeleteInfo_Click(object sender, EventArgs e)
        {
            DataOperation dop = new DataOperation();
            dop.OpenDatabase();
            int u = dop.RunNonQueryCommand("delete from ProjectDetails where project_id = '" + this.txtPrjectId.Text + "';");
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
