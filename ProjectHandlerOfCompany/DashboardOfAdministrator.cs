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
    public partial class DashboardOfAdministrator : MetroForm
    {
        //Dashboard user
        private UserInfo Ui { set; get; }
        //user
        private UserOperation Manager { set; get; }
        private UserOperation Employee { set; get; }
        //login class
        private FormLogin Fl { set; get; }
        public DashboardOfAdministrator()
        {
            InitializeComponent();
        }
        public DashboardOfAdministrator(FormLogin fl, UserInfo ui):this()
        {
            this.Fl = fl;
            this.Ui = ui;
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            this.Manager = new UserOperation('m');
            if (this.pnlDashboard.Controls.Count > 0)
            {
                this.pnlDashboard.Controls.Clear();
            }
            this.pnlDashboard.Controls.Add(this.Manager);
        }

        private void btnProject_Click(object sender, EventArgs e)
        {
            this.Employee = new UserOperation('e');
            if (this.pnlDashboard.Controls.Count > 0)
            {
                this.pnlDashboard.Controls.Clear();
            }
            this.pnlDashboard.Controls.Add(this.Employee);
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

        private void DashboardOfAdministrator_Load(object sender, EventArgs e)
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
