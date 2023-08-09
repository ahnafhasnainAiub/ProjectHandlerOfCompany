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
    public partial class DashboardOfManager : MetroForm
    {
        //Dashboard user
        private UserInfo Ui { set; get; }
        //user
        private UserOperation Buyer { set; get; }
        private UserDetails Employee { set; get; }
        //project
        private ListOfProject Project { set; get; }
        //login class
        private FormLogin Fl { set; get; }
        public DashboardOfManager()
        {
            InitializeComponent();
        }
        public DashboardOfManager(FormLogin fl, UserInfo ui) : this()
        {
            this.Fl = fl;
            this.Ui = ui;
        }
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

        private void btnBuyerDetails_Click(object sender, EventArgs e)
        {
            this.Buyer = new UserOperation('b');
            if (this.pnlDashboard.Controls.Count > 0)
            {
                this.pnlDashboard.Controls.Clear();
            }
            this.pnlDashboard.Controls.Add(this.Buyer);
        }

        
        private void btnEmployeeDetails_Click(object sender, EventArgs e)
        {
            this.Employee = new UserDetails('e');
            if (this.pnlDashboard.Controls.Count > 0)
            {
                this.pnlDashboard.Controls.Clear();
            }
            this.pnlDashboard.Controls.Add(this.Employee);
        }

        //creating a project
        private void btnProject_Click(object sender, EventArgs e)
        {
            this.Project = new ListOfProject();
            if (this.pnlDashboard.Controls.Count > 0)
            {
                this.pnlDashboard.Controls.Clear();
            }
            this.pnlDashboard.Controls.Add(this.Project);
        }

        private void DashboardOfManager_Load(object sender, EventArgs e)
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
