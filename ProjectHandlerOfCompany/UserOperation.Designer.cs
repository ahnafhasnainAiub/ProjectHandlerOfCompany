
namespace ProjectHandlerOfCompany
{
    partial class UserOperation
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvUserDetails = new System.Windows.Forms.DataGridView();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtUserPass = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtUserAddressId = new System.Windows.Forms.MaskedTextBox();
            this.txtUserPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtUserName = new System.Windows.Forms.MaskedTextBox();
            this.txtUserDesignation = new System.Windows.Forms.MaskedTextBox();
            this.txtDepartment = new System.Windows.Forms.MaskedTextBox();
            this.txtUserRank = new System.Windows.Forms.MaskedTextBox();
            this.btnSaveInfo = new System.Windows.Forms.Button();
            this.btnDeleteInfo = new System.Windows.Forms.Button();
            this.txtSearchById = new System.Windows.Forms.MaskedTextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbActiveStatus = new System.Windows.Forms.ComboBox();
            this.pnlGender = new System.Windows.Forms.Panel();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtImage = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpJoiningDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblRequiredMessage = new System.Windows.Forms.Label();
            this.u_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joiningdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activestatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserDetails)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUserDetails
            // 
            this.dgvUserDetails.AllowUserToAddRows = false;
            this.dgvUserDetails.AllowUserToDeleteRows = false;
            this.dgvUserDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.u_id,
            this.uname,
            this.pass,
            this.gender,
            this.image,
            this.phone,
            this.address_id,
            this.dob,
            this.designation,
            this.rank,
            this.joiningdate,
            this.activestatus,
            this.department_no});
            this.dgvUserDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvUserDetails.Location = new System.Drawing.Point(0, 397);
            this.dgvUserDetails.Name = "dgvUserDetails";
            this.dgvUserDetails.ReadOnly = true;
            this.dgvUserDetails.RowHeadersWidth = 62;
            this.dgvUserDetails.RowTemplate.Height = 28;
            this.dgvUserDetails.Size = new System.Drawing.Size(890, 136);
            this.dgvUserDetails.TabIndex = 0;
            this.dgvUserDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserDetails_CellClick);
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(44, 62);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(200, 26);
            this.txtUserId.TabIndex = 1;
            this.txtUserId.Text = "user id";
            // 
            // txtUserPass
            // 
            this.txtUserPass.Location = new System.Drawing.Point(44, 107);
            this.txtUserPass.Name = "txtUserPass";
            this.txtUserPass.Size = new System.Drawing.Size(200, 26);
            this.txtUserPass.TabIndex = 2;
            this.txtUserPass.Text = "password";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 47);
            this.panel1.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(55, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(96, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "... ... ... Table";
            // 
            // txtUserAddressId
            // 
            this.txtUserAddressId.Location = new System.Drawing.Point(44, 230);
            this.txtUserAddressId.Name = "txtUserAddressId";
            this.txtUserAddressId.Size = new System.Drawing.Size(200, 26);
            this.txtUserAddressId.TabIndex = 5;
            this.txtUserAddressId.Text = "Address Id";
            // 
            // txtUserPhone
            // 
            this.txtUserPhone.Location = new System.Drawing.Point(44, 190);
            this.txtUserPhone.Name = "txtUserPhone";
            this.txtUserPhone.Size = new System.Drawing.Size(200, 26);
            this.txtUserPhone.TabIndex = 4;
            this.txtUserPhone.Text = "phone";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(44, 152);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(200, 26);
            this.txtUserName.TabIndex = 3;
            this.txtUserName.Text = "username";
            // 
            // txtUserDesignation
            // 
            this.txtUserDesignation.Location = new System.Drawing.Point(271, 257);
            this.txtUserDesignation.Name = "txtUserDesignation";
            this.txtUserDesignation.Size = new System.Drawing.Size(196, 26);
            this.txtUserDesignation.TabIndex = 10;
            this.txtUserDesignation.Text = "Designation";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(271, 293);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(196, 26);
            this.txtDepartment.TabIndex = 11;
            this.txtDepartment.Text = "department no";
            // 
            // txtUserRank
            // 
            this.txtUserRank.Location = new System.Drawing.Point(271, 62);
            this.txtUserRank.Name = "txtUserRank";
            this.txtUserRank.Size = new System.Drawing.Size(196, 26);
            this.txtUserRank.TabIndex = 6;
            this.txtUserRank.Text = "rank";
            // 
            // btnSaveInfo
            // 
            this.btnSaveInfo.Location = new System.Drawing.Point(554, 62);
            this.btnSaveInfo.Name = "btnSaveInfo";
            this.btnSaveInfo.Size = new System.Drawing.Size(138, 152);
            this.btnSaveInfo.TabIndex = 18;
            this.btnSaveInfo.Text = "Save";
            this.btnSaveInfo.UseVisualStyleBackColor = true;
            this.btnSaveInfo.Click += new System.EventHandler(this.btnSaveInfo_Click);
            // 
            // btnDeleteInfo
            // 
            this.btnDeleteInfo.Location = new System.Drawing.Point(554, 230);
            this.btnDeleteInfo.Name = "btnDeleteInfo";
            this.btnDeleteInfo.Size = new System.Drawing.Size(138, 152);
            this.btnDeleteInfo.TabIndex = 19;
            this.btnDeleteInfo.Text = "Delete";
            this.btnDeleteInfo.UseVisualStyleBackColor = true;
            this.btnDeleteInfo.Click += new System.EventHandler(this.btnDeleteInfo_Click);
            // 
            // txtSearchById
            // 
            this.txtSearchById.Location = new System.Drawing.Point(726, 62);
            this.txtSearchById.Name = "txtSearchById";
            this.txtSearchById.Size = new System.Drawing.Size(138, 26);
            this.txtSearchById.TabIndex = 20;
            this.txtSearchById.Text = "Search By Id";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(726, 104);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(138, 110);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbActiveStatus
            // 
            this.cmbActiveStatus.FormattingEnabled = true;
            this.cmbActiveStatus.Items.AddRange(new object[] {
            "true",
            "false"});
            this.cmbActiveStatus.Location = new System.Drawing.Point(271, 161);
            this.cmbActiveStatus.Name = "cmbActiveStatus";
            this.cmbActiveStatus.Size = new System.Drawing.Size(196, 28);
            this.cmbActiveStatus.TabIndex = 8;
            this.cmbActiveStatus.Text = "Active Status";
            // 
            // pnlGender
            // 
            this.pnlGender.Controls.Add(this.rdbFemale);
            this.pnlGender.Controls.Add(this.rdbMale);
            this.pnlGender.Controls.Add(this.lblGender);
            this.pnlGender.Location = new System.Drawing.Point(44, 287);
            this.pnlGender.Name = "pnlGender";
            this.pnlGender.Size = new System.Drawing.Size(200, 69);
            this.pnlGender.TabIndex = 27;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Location = new System.Drawing.Point(90, 33);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(87, 24);
            this.rdbFemale.TabIndex = 2;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = true;
            this.rdbFemale.CheckedChanged += new System.EventHandler(this.rdbFemale_CheckedChanged);
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(16, 33);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(68, 24);
            this.rdbMale.TabIndex = 1;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = true;
            this.rdbMale.CheckedChanged += new System.EventHandler(this.rdbMale_CheckedChanged);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(12, 5);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(63, 20);
            this.lblGender.TabIndex = 0;
            this.lblGender.Text = "Gender";
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(271, 330);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(196, 26);
            this.txtImage.TabIndex = 12;
            this.txtImage.Text = "Image name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Joining Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Date of Birth";
            // 
            // dtpJoiningDate
            // 
            this.dtpJoiningDate.CustomFormat = "yyyy-MM-dd";
            this.dtpJoiningDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpJoiningDate.Location = new System.Drawing.Point(272, 123);
            this.dtpJoiningDate.Name = "dtpJoiningDate";
            this.dtpJoiningDate.Size = new System.Drawing.Size(196, 26);
            this.dtpJoiningDate.TabIndex = 7;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.CustomFormat = "yyyy-MM-dd";
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(271, 223);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(196, 26);
            this.dtpDateOfBirth.TabIndex = 9;
            // 
            // lblRequiredMessage
            // 
            this.lblRequiredMessage.AutoSize = true;
            this.lblRequiredMessage.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredMessage.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredMessage.Location = new System.Drawing.Point(719, 293);
            this.lblRequiredMessage.Name = "lblRequiredMessage";
            this.lblRequiredMessage.Size = new System.Drawing.Size(159, 37);
            this.lblRequiredMessage.TabIndex = 31;
            this.lblRequiredMessage.Text = "Required*";
            // 
            // u_id
            // 
            this.u_id.DataPropertyName = "u_id";
            this.u_id.HeaderText = "ID";
            this.u_id.MinimumWidth = 8;
            this.u_id.Name = "u_id";
            this.u_id.ReadOnly = true;
            this.u_id.Width = 56;
            // 
            // uname
            // 
            this.uname.DataPropertyName = "uname";
            this.uname.HeaderText = "Username";
            this.uname.MinimumWidth = 8;
            this.uname.Name = "uname";
            this.uname.ReadOnly = true;
            this.uname.Width = 57;
            // 
            // pass
            // 
            this.pass.DataPropertyName = "pass";
            this.pass.HeaderText = "Password";
            this.pass.MinimumWidth = 8;
            this.pass.Name = "pass";
            this.pass.ReadOnly = true;
            this.pass.Width = 56;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "Gender";
            this.gender.MinimumWidth = 8;
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Width = 56;
            // 
            // image
            // 
            this.image.DataPropertyName = "image";
            this.image.HeaderText = "Image";
            this.image.MinimumWidth = 8;
            this.image.Name = "image";
            this.image.ReadOnly = true;
            this.image.Width = 57;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "Phone";
            this.phone.MinimumWidth = 8;
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.Width = 56;
            // 
            // address_id
            // 
            this.address_id.DataPropertyName = "address_id";
            this.address_id.HeaderText = "Address ID";
            this.address_id.MinimumWidth = 8;
            this.address_id.Name = "address_id";
            this.address_id.ReadOnly = true;
            this.address_id.Width = 56;
            // 
            // dob
            // 
            this.dob.DataPropertyName = "dob";
            this.dob.HeaderText = "Dob";
            this.dob.MinimumWidth = 8;
            this.dob.Name = "dob";
            this.dob.ReadOnly = true;
            this.dob.Width = 150;
            // 
            // designation
            // 
            this.designation.DataPropertyName = "designation";
            this.designation.HeaderText = "De";
            this.designation.MinimumWidth = 8;
            this.designation.Name = "designation";
            this.designation.ReadOnly = true;
            this.designation.Width = 57;
            // 
            // rank
            // 
            this.rank.DataPropertyName = "rank";
            this.rank.HeaderText = "Rank";
            this.rank.MinimumWidth = 8;
            this.rank.Name = "rank";
            this.rank.ReadOnly = true;
            this.rank.Width = 56;
            // 
            // joiningdate
            // 
            this.joiningdate.DataPropertyName = "joiningDate";
            this.joiningdate.HeaderText = "JD";
            this.joiningdate.MinimumWidth = 8;
            this.joiningdate.Name = "joiningdate";
            this.joiningdate.ReadOnly = true;
            this.joiningdate.Width = 56;
            // 
            // activestatus
            // 
            this.activestatus.DataPropertyName = "activeStatus";
            this.activestatus.HeaderText = "AS";
            this.activestatus.MinimumWidth = 8;
            this.activestatus.Name = "activestatus";
            this.activestatus.ReadOnly = true;
            this.activestatus.Width = 57;
            // 
            // department_no
            // 
            this.department_no.DataPropertyName = "department_no";
            this.department_no.HeaderText = "Dpt_no";
            this.department_no.MinimumWidth = 8;
            this.department_no.Name = "department_no";
            this.department_no.ReadOnly = true;
            this.department_no.Width = 56;
            // 
            // UserOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblRequiredMessage);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.dtpJoiningDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.pnlGender);
            this.Controls.Add(this.cmbActiveStatus);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchById);
            this.Controls.Add(this.btnDeleteInfo);
            this.Controls.Add(this.btnSaveInfo);
            this.Controls.Add(this.txtUserDesignation);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.txtUserRank);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtUserPhone);
            this.Controls.Add(this.txtUserAddressId);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtUserPass);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.dgvUserDetails);
            this.Name = "UserOperation";
            this.Size = new System.Drawing.Size(890, 533);
            this.Load += new System.EventHandler(this.UserOperation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserDetails)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlGender.ResumeLayout(false);
            this.pnlGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUserDetails;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.MaskedTextBox txtUserPass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.MaskedTextBox txtUserAddressId;
        private System.Windows.Forms.MaskedTextBox txtUserPhone;
        private System.Windows.Forms.MaskedTextBox txtUserName;
        private System.Windows.Forms.MaskedTextBox txtUserDesignation;
        private System.Windows.Forms.MaskedTextBox txtDepartment;
        private System.Windows.Forms.MaskedTextBox txtUserRank;
        private System.Windows.Forms.Button btnSaveInfo;
        private System.Windows.Forms.Button btnDeleteInfo;
        private System.Windows.Forms.MaskedTextBox txtSearchById;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbActiveStatus;
        private System.Windows.Forms.Panel pnlGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.MaskedTextBox txtImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpJoiningDate;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label lblRequiredMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn u_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn uname;
        private System.Windows.Forms.DataGridViewTextBoxColumn pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn image;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn address_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn rank;
        private System.Windows.Forms.DataGridViewTextBoxColumn joiningdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn activestatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn department_no;
    }
}
