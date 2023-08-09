using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHandlerOfCompany
{
    public class UserInfo
    {
        //attributes to check
        private string userId;
        private string userName;
        private string userPass;
        private string userPhone;

        public string UserId 
        {
            set
            {
                if(value.Length <= 5)
                {
                    this.userId = value;
                }
                else
                {
                    this.userId = "u-000";
                }
            }
            get { return this.userId; }
        }
        public string UserName 
        {
            set
            {
                if (value.Length <= 15)
                {
                    this.userName = value;
                }
                else
                {
                    this.userName = " ";
                }
            }
            get { return this.userName; }
        }
        public string UserPass 
        {
            set
            {
                if (value.Length <= 5 )
                {
                    this.userPass = value;
                }
                else
                {
                    this.userPass = " ";
                }
            }
            get { return this.userPass; }
        }
        public string UserGender { set; get; }
        public string UserPhone 
        {
            set
            {
                if (value.Length == 11)
                {
                    this.userPhone = value;
                }
                else
                {
                    this.userPhone = "invalid";
                }
            }
            get { return this.userPhone; }
        }
        public string UserAddressId { set; get; }
        public string UserDateOfBirth { set; get; }
        public string UserDesignation { set; get; }
        public string UserJoiningDate { set; get; }
        public bool ActiveStatus { set; get; }
        public string UserDepartment_no { set; get; }
        public string UserImage { set; get; }
        public string UserType { set; get; }
        public string UserRank { set; get; }

        public UserInfo()
        {

        }
        public UserInfo(string userid, string username, string userimage, string usertype)
        {
            this.UserId = userid;
            this.UserName = username;
            this.UserImage = userimage;
            this.UserType = usertype;
        }
        public UserInfo(string userid, string username, string userpass, string usergender, string userimage, string userphone, string useraddressid, string userdateofbirth, string designation, string userrank, string joiningdate,  bool activestatus, string department_no)
        {
            this.UserId = userid;
            this.UserName = username;
            this.UserPass = userpass;
            this.UserGender = usergender;
            this.UserPhone = userphone;
            this.UserAddressId = useraddressid;
            this.UserImage = userimage;
            this.UserDesignation = designation;
            this.UserDateOfBirth = userdateofbirth;
            this.UserJoiningDate = joiningdate;
            this.ActiveStatus = activestatus;
            this.UserDepartment_no = department_no;
            this.UserRank = userrank;
        }

        public bool IsSet()
        {
            if(this.UserImage != "" && this.UserId != "" && this.UserName != "" && this.UserType != "")
            {
                return true;
            }
            return false;
        }
        public void AddUserToDatabase(ref int u)
        {
            DataOperation dop = new DataOperation();
            dop.OpenDatabase();
            u = dop.RunNonQueryCommand("insert into UserInfo values ('" + this.UserId + "', '" + this.UserName + "', '" + this.UserPass + "', '" + this.UserGender + "', '" + this.UserImage + "', '" + this.UserPhone + "', '" + this.UserAddressId + "', '" + this.UserDateOfBirth + "', '" + this.UserDesignation + "', '" + this.UserRank + "', '" + this.UserJoiningDate + "', '" + this.ActiveStatus + "', '" + this.UserDepartment_no + "');");
            dop.CloseDatabase();
        }
        public void UpdateUserInfo(ref int u)
        {
            DataOperation dop = new DataOperation();
            dop.OpenDatabase();
            u = dop.RunNonQueryCommand("update UserInfo set uname='" + this.UserName + "', pass='" + this.UserPass + "', gender='" + this.UserGender + "', image='" + this.UserImage + "', phone='" + this.UserPhone + "', address_id='" + this.UserAddressId + "', dob='" + this.UserDateOfBirth + "', designation='" + this.UserDesignation + "', rank='" + this.UserRank + "', joiningDate='" + this.UserJoiningDate + "', activeStatus='" + this.ActiveStatus + "', department_no='" + this.UserDepartment_no + "' where u_id='" + this.UserId + "';");
            dop.CloseDatabase();
        }
        public bool AllPropertySet()
        {
            bool check = true;
            if(this.userId.Equals("") 
                && this.userName.Equals("") 
                && this.userPass.Equals("") 
                && this.UserGender.Equals("") 
                && this.UserPhone.Equals("") 
                && this.UserAddressId.Equals("")
                && this.UserImage.Equals("")
                && this.Equals("")
                && this.UserDateOfBirth.Equals("")
                && this.UserJoiningDate.Equals("")
                && this.ActiveStatus.Equals("")
                && this.UserDepartment_no.Equals("")
                && this.UserRank.Equals(""))
            {
                check = false;
            }
            return check;
        }
    }
}
