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
    public partial class UserOperation : UserControl
    {
        private char UserType { set; get; }
        private string UserGender { set;get; }
        
        public UserOperation()
        {
            InitializeComponent();
            this.lblRequiredMessage.Visible = false;
        }
        public UserOperation(char userType) : this()
        {
            this.UserType = userType;
        }

        private void UserOperation_Load(object sender, EventArgs e)
        {
            switch (this.UserType)
            {
                case 'm':
                    this.lblTitle.Text = "Manager";
                    break;
                case 'e':
                    this.lblTitle.Text = "Employee";
                    break;
                case 'b':
                    this.lblTitle.Text = "Buyer";
                    break;
                default:
                    break;
            }
            try
            {
                DataOperation dop = new DataOperation();
                dop.OpenDatabase();
                //"select * from userinfo where u_id = '" + this.UserType.ToString() + "%';"
                DataSet ds = dop.RunQueryCommand("select * from userinfo where u_id like '" + this.UserType.ToString() + "%';");
                this.dgvUserDetails.AutoGenerateColumns = false;
                this.dgvUserDetails.DataSource = ds.Tables[0];
                dop.CloseDatabase();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            
        }

        public void SaveData()
        {
            int u=0;
            UserInfo ui = new UserInfo();
            try
            {
                ui.UserId = this.txtUserId.Text;
                ui.UserName = this.txtUserName.Text;
                ui.UserPass = this.txtUserPass.Text;
                ui.UserImage = this.txtImage.Text;
                ui.UserGender = this.UserGender;
                ui.UserPhone = this.txtUserPhone.Text;
                ui.UserAddressId = this.txtUserAddressId.Text;
                ui.UserDateOfBirth = this.dtpDateOfBirth.Text;
                ui.UserDesignation = this.txtUserDesignation.Text;
                ui.UserRank = this.txtUserRank.Text;
                ui.UserJoiningDate = this.dtpJoiningDate.Text;
                ui.ActiveStatus = Boolean.Parse(this.cmbActiveStatus.Text);
                ui.UserDepartment_no = this.txtDepartment.Text;
                if (!ui.AllPropertySet())
                {
                    this.lblRequiredMessage.Show();
                }
                else
                {
                    this.lblRequiredMessage.Hide();
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            

            try
            {
                DataOperation dop = new DataOperation();
                dop.OpenDatabase();
                DataSet ds = dop.RunQueryCommand("select * from userinfo where u_id = '" + this.txtUserId.Text + "';");
                int k = ds.Tables[0].Rows.Count;
                dop.CloseDatabase();
                if ( k > 0)
                {
                    //update operation
                    ui.UpdateUserInfo(ref u);
                }
                else
                {
                    //insert operation
                    ui.AddUserToDatabase(ref u);
                }
                
                if (u > 0)
                {
                    MessageBox.Show("User operation is executed");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            this.SaveData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //searching a table
                DataOperation dop = new DataOperation();
                dop.OpenDatabase();
                DataSet ds = dop.RunQueryCommand("select * from userinfo where u_id = '" + this.txtSearchById.Text + "';");
                this.dgvUserDetails.AutoGenerateColumns = false;
                this.dgvUserDetails.DataSource = ds.Tables[0];

                dop.CloseDatabase();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void dgvUserDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //showing table row in text box
            this.txtUserId.Text = this.dgvUserDetails.CurrentRow.Cells["u_id"].Value.ToString();
            this.txtUserName.Text = this.dgvUserDetails.CurrentRow.Cells["uname"].Value.ToString();
            this.txtUserPass.Text = this.dgvUserDetails.CurrentRow.Cells["pass"].Value.ToString();
            this.UserGender = this.dgvUserDetails.CurrentRow.Cells["gender"].Value.ToString();
            this.txtImage.Text = this.dgvUserDetails.CurrentRow.Cells["image"].Value.ToString();
            this.txtUserPhone.Text = this.dgvUserDetails.CurrentRow.Cells["phone"].Value.ToString();
            this.txtUserAddressId.Text = this.dgvUserDetails.CurrentRow.Cells["address_id"].Value.ToString();
            this.dtpDateOfBirth.Text = this.dgvUserDetails.CurrentRow.Cells["dob"].Value.ToString();
            this.txtUserDesignation.Text = this.dgvUserDetails.CurrentRow.Cells["designation"].Value.ToString();
            this.txtUserRank.Text = this.dgvUserDetails.CurrentRow.Cells["rank"].Value.ToString();
            this.dtpJoiningDate.Text = this.dgvUserDetails.CurrentRow.Cells["joiningdate"].Value.ToString();
            this.cmbActiveStatus.Text = this.dgvUserDetails.CurrentRow.Cells["activestatus"].Value.ToString();
            this.txtDepartment.Text = this.dgvUserDetails.CurrentRow.Cells["department_no"].Value.ToString();
            
        }

        //choosing gender
        private void rdbMale_CheckedChanged(object sender, EventArgs e)
        {
            this.UserGender = this.rdbMale.Text;
        }

        private void rdbFemale_CheckedChanged(object sender, EventArgs e)
        {
            this.UserGender = this.rdbFemale.Text;
        }

        private void btnDeleteInfo_Click(object sender, EventArgs e)
        {
            try
            {
                DataOperation dop = new DataOperation();
                dop.OpenDatabase();
                int u = dop.RunNonQueryCommand("delete from UserInfo where u_id='" + this.txtSearchById.Text + "';");
                dop.CloseDatabase();
                MessageBox.Show("Deletion completed");
            }catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            
        }
    }
}
