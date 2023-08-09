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
    public partial class UserDetails : UserControl
    {
        //extra property
        private string DeletedData { set; get; }
        private char UserType { set; get; }
        public UserDetails()
        {
            InitializeComponent();
        }
        public UserDetails(char userType):this()
        {
            this.UserType = userType;
        }

        private void UserDetails_Load(object sender, EventArgs e)
        {
            switch (this.UserType)
            {
                case 'm':
                    this.lblUserRole.Text = "Manager";
                    break;
                case 'e':
                    this.lblUserRole.Text = "Employee";
                    break;
                case 'b':
                    this.lblUserRole.Text = "Buyer";
                    break;
                default:
                    break;
            }
            try
            {
                DataOperation dop = new DataOperation();
                dop.OpenDatabase();
                DataSet ds = dop.RunQueryCommand("select u_id, uname, joiningDate, activeStatus from UserInfo where u_id like '" + this.UserType.ToString() + "%';");
                this.dgvUserDetails.AutoGenerateColumns = false;
                this.dgvUserDetails.DataSource = ds.Tables[0];
                dop.CloseDatabase();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            try
            {
                DataOperation dop = new DataOperation();
                dop.OpenDatabase();
                DataSet ds = dop.RunQueryCommand("select u_id, uname, joiningDate, activeStatus from userinfo where u_id = '" + this.txtSearchUser.Text + "';");
                this.dgvUserDetails.AutoGenerateColumns = false;
                this.dgvUserDetails.DataSource = ds.Tables[0];
                this.DeletedData = ds.Tables[0].Rows[0][0].ToString();
                dop.CloseDatabase();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Do u wanna del: " + this.DeletedData);
                DataOperation dop = new DataOperation();
                dop.OpenDatabase();
                int u = dop.RunNonQueryCommand("delete from UserInfo where u_id='" + this.DeletedData + "';");
                dop.CloseDatabase();
                if (u > 0)
                {
                    MessageBox.Show("Data has been deleted!!!");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        //make an event for selecting a data in datagridview
    }
}
