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
    public partial class DashboardOfCeo : MetroForm
    {
        //Dashboard user
        private UserInfo Ui { set; get; }
        //user
        private UserDetails Manager { set; get; }
        //project
        private ProjectDetails Project { set; get; }
        //login class
        private FormLogin Fl { set; get; }
        //Dashboard view
        private CeoControlRefresh Ccr { set; get; }
        public DashboardOfCeo()
        {
            InitializeComponent();
        }
        public DashboardOfCeo(FormLogin fl, UserInfo ui) : this()
        {
            this.Fl = fl;
            this.Ui = ui;
        }

        //exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //extra
        private void DashboardOfCeo_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        public void GenerateCeoDashboard()
        {
            this.Ccr = new CeoControlRefresh();
            if (this.pnlDashboard.Controls.Count > 0)
            {
                this.pnlDashboard.Controls.Clear();
            }
            this.pnlDashboard.Controls.Add(this.Ccr);
        }

        private void DashboardOfCeo_Load(object sender, EventArgs e)
        {
            this.lblUserID.Text = this.Ui.UserId;
            this.lblUsername.Text = this.Ui.UserName;
            try { this.ptbUser.Image = Image.FromFile("C:\\Users\\SAKIF\\Desktop\\C#\\ProjectHandlerOfCompany-Updated\\ProjectHandlerOfCompany\\bin\\images\\" + this.Ui.UserImage + ".jpg"); }catch(Exception error)
            {
                MessageBox.Show("No image found");
            }
            
            GenerateCeoDashboard();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GenerateCeoDashboard();
        }
        //logout
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Fl.Show();
        }

        //buttons hover effect
        private void btnRefresh_MouseHover(object sender, EventArgs e)
        {
            /*this.btnRefresh.BackColor = Color.FromArgb(6, 167, 125);
            this.btnRefresh.ForeColor = Color.White;*/
        }

        private void btnRefresh_MouseLeave(object sender, EventArgs e)
        {
            /*this.btnRefresh.BackColor = Color.White;
            this.btnRefresh.ForeColor = Color.FromArgb(5, 140, 66);*/
        }

        private void btnManager_MouseHover(object sender, EventArgs e)
        {
            /*this.btnManager.BackColor = Color.FromArgb(6, 167, 125);
            this.btnManager.ForeColor = Color.White;*/
        }

        private void btnManager_MouseLeave(object sender, EventArgs e)
        {
           /* this.btnManager.BackColor = Color.White;
            this.btnManager.ForeColor = Color.FromArgb(5, 140, 66);*/
        }

        private void btnProject_MouseHover(object sender, EventArgs e)
        {
           /* this.btnProject.BackColor = Color.FromArgb(6, 167, 125);
            this.btnProject.ForeColor = Color.White;*/
        }

        private void btnProject_MouseLeave(object sender, EventArgs e)
        {
            /*this.btnProject.BackColor = Color.White;
            this.btnProject.ForeColor = Color.FromArgb(5, 140, 66);*/
        }

        private void btnFinancialReport_MouseHover(object sender, EventArgs e)
        {
            /*this.btnFinancialReport.BackColor = Color.FromArgb(6, 167, 125);
            this.btnFinancialReport.ForeColor = Color.White;*/
        }

        private void btnFinancialReport_MouseLeave(object sender, EventArgs e)
        {/*
            this.btnFinancialReport.BackColor = Color.White;
            this.btnFinancialReport.ForeColor = Color.FromArgb(5, 140, 66);*/
        }

        private void btnLogout_MouseHover(object sender, EventArgs e)
        {
            /*this.btnLogout.BackColor = Color.FromArgb(255, 159, 28);
            this.btnLogout.ForeColor = Color.White;*/
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            /*this.btnLogout.BackColor = Color.White;
            this.btnLogout.ForeColor = Color.FromArgb(255, 147, 79);*/
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            /*this.btnExit.BackColor = Color.FromArgb(188, 57, 8);
            this.btnExit.ForeColor = Color.White;*/
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            /*this.btnExit.BackColor = Color.White;
            this.btnExit.ForeColor = Color.FromArgb(239, 48, 84);*/
        }

        //showing manager details
        private void btnManager_Click(object sender, EventArgs e)
        {
            this.Manager = new UserDetails('m');
            if (this.pnlDashboard.Controls.Count > 0)
            {
                this.pnlDashboard.Controls.Clear();
            }
            this.pnlDashboard.Controls.Add(this.Manager);
        }

        //showing project list
        private void btnProject_Click(object sender, EventArgs e)
        {
            this.Project = new ProjectDetails();
            if (this.pnlDashboard.Controls.Count > 0)
            {
                this.pnlDashboard.Controls.Clear();
            }
            this.pnlDashboard.Controls.Add(this.Project);
        }

        private void btnFinancialReport_Click(object sender, EventArgs e)
        {
            //use pdf

        }
    }
}
