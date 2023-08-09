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
    public partial class LoginInfoProvider : UserControl
    {
        //user class
        private UserInfo U;
        //login class
        private FormLogin Fl { set; get; }
        //property of user's dashboards
        private DashboardOfCeo DCeo { get; set; }
        private DashboardOfAdministrator DAdministrator { set; get; }
        private DashboardOfManager DManager { set; get; }
        private DashboardOfEmployee DEmployee { set; get; }
        private DashboardOfBuyer DBuyer { set; get; }
        public LoginInfoProvider()
        {
            InitializeComponent();
        }
        public LoginInfoProvider(FormLogin fl) : this()
        {
            this.Fl = fl;
        }

        // extra
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            //authentication
            try
            {
                DataOperation dop = new DataOperation();
                dop.OpenDatabase();
                DataSet ds = dop.RunQueryCommand("select * from UserInfo where u_id ='" + this.txtUserId.Text + "' and pass = '" + this.txtPassword.Text + "';");
                int rowCount = ds.Tables[0].Rows.Count;
                dop.CloseDatabase();
                if (rowCount > 0)
                {
                    this.U = new UserInfo(
                    ds.Tables[0].Rows[0][0].ToString(),
                    ds.Tables[0].Rows[0][1].ToString(),
                    ds.Tables[0].Rows[0][4].ToString(),
                    ds.Tables[0].Rows[0][0].ToString().Substring(0, 1)
                    );
                }
                else
                {
                    MessageBox.Show("Credential didn't match");
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }

            try
            {
                //move to dashboard
                if (this.U.IsSet())
                {
                    this.Fl.Hide();
                    switch (this.U.UserType)
                    {
                        case "c":
                            this.DCeo = new DashboardOfCeo(this.Fl, this.U);
                            this.DCeo.Show();
                            break;
                        case "a":
                            this.DAdministrator = new DashboardOfAdministrator(this.Fl, this.U);
                            this.DAdministrator.Show();
                            break;
                        case "m":
                            this.DManager = new DashboardOfManager(this.Fl, this.U);
                            this.DManager.Show();
                            break;
                        case "e":
                            this.DEmployee = new DashboardOfEmployee(this.Fl, this.U);
                            this.DEmployee.Show();
                            break;
                        case "b":
                            this.DBuyer = new DashboardOfBuyer(this.Fl, this.U);
                            this.DBuyer.Show();
                            break;
                        default:
                            MessageBox.Show("Failed to Move!!!");
                            this.Fl.Show();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("User Validation failed!!!");
                }
            }
            catch (NullReferenceException error)
            {
                MessageBox.Show(error.Message);
            }
            
        }
    }
}
