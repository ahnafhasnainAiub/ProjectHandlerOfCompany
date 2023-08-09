using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace ProjectHandlerOfCompany
{
    public partial class DashboardOfEmployee : MetroForm
    {
        //Dashboard user
        private UserInfo Ui { set; get; }
        //login class
        private FormLogin Fl { set; get; }
        //project class
        private ProjectDetails PDetails { set; get; }
        private ProjectProgress PProgress { set; get; }
        //conversation class
        private Conversation Convo { set; get; }
        public DashboardOfEmployee()
        {
            InitializeComponent();
        }
        public DashboardOfEmployee(FormLogin fl, UserInfo ui) : this()
        {
            this.Fl = fl;
            this.Ui = ui;
        }
        //logout
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Fl.Show();
        }
        //exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProjectList_Click(object sender, EventArgs e)
        {
            this.PDetails = new ProjectDetails();
            if (this.pnlDashboard.Controls.Count > 0)
            {
                this.pnlDashboard.Controls.Clear();
            }
            this.pnlDashboard.Controls.Add(this.PDetails);

        }

        private void btnProjectProgress_Click(object sender, EventArgs e)
        {
            this.PProgress = new ProjectProgress();
            if (this.pnlDashboard.Controls.Count > 0)
            {
                this.pnlDashboard.Controls.Clear();
            }
            this.pnlDashboard.Controls.Add(this.PProgress);
        }

        private void btnConversation_Click(object sender, EventArgs e)
        {
            this.Convo = new Conversation(this.Ui);
            if (this.pnlDashboard.Controls.Count > 0)
            {
                this.pnlDashboard.Controls.Clear();
            }
            this.pnlDashboard.Controls.Add(this.Convo);
        }

        private void DashboardOfEmployee_Load(object sender, EventArgs e)
        {
            this.lblUserID.Text = this.Ui.UserId;
            this.lblUsername.Text = this.Ui.UserName;
            try { this.ptbUser.Image = Image.FromFile("C:\\Users\\SAKIF\\Desktop\\C#\\ProjectHandlerOfCompany-Updated\\ProjectHandlerOfCompany\\bin\\images\\" + this.Ui.UserImage + ".jpg"); }
            catch (Exception error)
            {
                MessageBox.Show("No image found");
            }
        }
    }
}
