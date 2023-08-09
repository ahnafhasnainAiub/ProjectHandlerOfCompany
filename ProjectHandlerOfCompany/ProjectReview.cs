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
    public partial class ProjectReview : UserControl
    {
        public string ProjectId { set; get; }
        public ProjectReview()
        {
            InitializeComponent();
        }
        public ProjectReview(string projectId):this()
        {
            this.ProjectId = projectId;
            this.lblProjectRev.Text = projectId;
        }
        private void metroTrackBar4_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void tkbRating_Scroll(object sender, ScrollEventArgs e)
        {
            this.lblRating.Text = this.tkbRating.Value.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //update project rating
            try
            {
                DataOperation dop = new DataOperation();
                dop.OpenDatabase();
                int u = dop.RunNonQueryCommand("update ProjectDetails set rating = " + float.Parse(this.lblRating.Text) + " where project_id = '" + this.ProjectId + "';");
                dop.CloseDatabase();
                MessageBox.Show("Submitted");
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnSetProjectId_Click(object sender, EventArgs e)
        {
            this.ProjectId = this.txtProjectId.Text;
            this.lblProjectRev.Text = this.ProjectId;
        }
    }
}
