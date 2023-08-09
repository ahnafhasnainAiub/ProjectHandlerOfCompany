
namespace ProjectHandlerOfCompany
{
    partial class ListOfProject
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchById = new System.Windows.Forms.MaskedTextBox();
            this.btnDeleteInfo = new System.Windows.Forms.Button();
            this.btnSaveInfo = new System.Windows.Forms.Button();
            this.txtPrjectId = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserManager = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtProjectTitle = new System.Windows.Forms.MaskedTextBox();
            this.txtProjectDes = new System.Windows.Forms.TextBox();
            this.dgvProjectDetails = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dtpDeadline = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.project_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.project_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.u_id_manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(726, 104);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(138, 110);
            this.btnSearch.TabIndex = 45;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchById
            // 
            this.txtSearchById.Location = new System.Drawing.Point(726, 62);
            this.txtSearchById.Name = "txtSearchById";
            this.txtSearchById.Size = new System.Drawing.Size(138, 26);
            this.txtSearchById.TabIndex = 44;
            this.txtSearchById.Text = "Search By Id";
            // 
            // btnDeleteInfo
            // 
            this.btnDeleteInfo.Location = new System.Drawing.Point(554, 230);
            this.btnDeleteInfo.Name = "btnDeleteInfo";
            this.btnDeleteInfo.Size = new System.Drawing.Size(138, 152);
            this.btnDeleteInfo.TabIndex = 43;
            this.btnDeleteInfo.Text = "Delete";
            this.btnDeleteInfo.UseVisualStyleBackColor = true;
            this.btnDeleteInfo.Click += new System.EventHandler(this.btnDeleteInfo_Click);
            // 
            // btnSaveInfo
            // 
            this.btnSaveInfo.Location = new System.Drawing.Point(554, 62);
            this.btnSaveInfo.Name = "btnSaveInfo";
            this.btnSaveInfo.Size = new System.Drawing.Size(138, 152);
            this.btnSaveInfo.TabIndex = 42;
            this.btnSaveInfo.Text = "Save";
            this.btnSaveInfo.UseVisualStyleBackColor = true;
            this.btnSaveInfo.Click += new System.EventHandler(this.btnSaveInfo_Click);
            // 
            // txtPrjectId
            // 
            this.txtPrjectId.Location = new System.Drawing.Point(50, 72);
            this.txtPrjectId.Name = "txtPrjectId";
            this.txtPrjectId.Size = new System.Drawing.Size(196, 26);
            this.txtPrjectId.TabIndex = 32;
            this.txtPrjectId.Text = "Project id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Table";
            // 
            // txtUserManager
            // 
            this.txtUserManager.Location = new System.Drawing.Point(50, 150);
            this.txtUserManager.Name = "txtUserManager";
            this.txtUserManager.Size = new System.Drawing.Size(196, 26);
            this.txtUserManager.TabIndex = 31;
            this.txtUserManager.Text = "Id of Manager";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 47);
            this.panel1.TabIndex = 27;
            // 
            // txtProjectTitle
            // 
            this.txtProjectTitle.Location = new System.Drawing.Point(50, 111);
            this.txtProjectTitle.Name = "txtProjectTitle";
            this.txtProjectTitle.Size = new System.Drawing.Size(196, 26);
            this.txtProjectTitle.TabIndex = 26;
            this.txtProjectTitle.Text = "Project Title";
            // 
            // txtProjectDes
            // 
            this.txtProjectDes.Location = new System.Drawing.Point(50, 228);
            this.txtProjectDes.Multiline = true;
            this.txtProjectDes.Name = "txtProjectDes";
            this.txtProjectDes.Size = new System.Drawing.Size(196, 150);
            this.txtProjectDes.TabIndex = 25;
            this.txtProjectDes.Text = "Project description";
            // 
            // dgvProjectDetails
            // 
            this.dgvProjectDetails.AllowUserToAddRows = false;
            this.dgvProjectDetails.AllowUserToDeleteRows = false;
            this.dgvProjectDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjectDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.project_id,
            this.project_name,
            this.description,
            this.deadline,
            this.u_id_manager});
            this.dgvProjectDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvProjectDetails.Location = new System.Drawing.Point(0, 397);
            this.dgvProjectDetails.Name = "dgvProjectDetails";
            this.dgvProjectDetails.ReadOnly = true;
            this.dgvProjectDetails.RowHeadersWidth = 62;
            this.dgvProjectDetails.RowTemplate.Height = 28;
            this.dgvProjectDetails.Size = new System.Drawing.Size(890, 136);
            this.dgvProjectDetails.TabIndex = 24;
            this.dgvProjectDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProjectDetails_CellContentClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(-22, -22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 47;
            // 
            // dtpDeadline
            // 
            this.dtpDeadline.CustomFormat = "yyyy-MM-dd";
            this.dtpDeadline.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeadline.Location = new System.Drawing.Point(50, 189);
            this.dtpDeadline.Name = "dtpDeadline";
            this.dtpDeadline.Size = new System.Drawing.Size(196, 26);
            this.dtpDeadline.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(265, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 22);
            this.label2.TabIndex = 49;
            this.label2.Text = "Deadline";
            // 
            // project_id
            // 
            this.project_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.project_id.DataPropertyName = "project_id";
            this.project_id.HeaderText = "Project ID";
            this.project_id.MinimumWidth = 8;
            this.project_id.Name = "project_id";
            this.project_id.ReadOnly = true;
            // 
            // project_name
            // 
            this.project_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.project_name.DataPropertyName = "project_name";
            this.project_name.HeaderText = "Project name";
            this.project_name.MinimumWidth = 8;
            this.project_name.Name = "project_name";
            this.project_name.ReadOnly = true;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "Description";
            this.description.MinimumWidth = 8;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // deadline
            // 
            this.deadline.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.deadline.DataPropertyName = "deadline";
            this.deadline.HeaderText = "Deadline";
            this.deadline.MinimumWidth = 8;
            this.deadline.Name = "deadline";
            this.deadline.ReadOnly = true;
            // 
            // u_id_manager
            // 
            this.u_id_manager.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.u_id_manager.DataPropertyName = "u_id_manager";
            this.u_id_manager.HeaderText = "Manager Id";
            this.u_id_manager.MinimumWidth = 8;
            this.u_id_manager.Name = "u_id_manager";
            this.u_id_manager.ReadOnly = true;
            // 
            // ListOfProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDeadline);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchById);
            this.Controls.Add(this.btnDeleteInfo);
            this.Controls.Add(this.btnSaveInfo);
            this.Controls.Add(this.txtPrjectId);
            this.Controls.Add(this.txtUserManager);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtProjectTitle);
            this.Controls.Add(this.txtProjectDes);
            this.Controls.Add(this.dgvProjectDetails);
            this.Name = "ListOfProject";
            this.Size = new System.Drawing.Size(890, 533);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.MaskedTextBox txtSearchById;
        private System.Windows.Forms.Button btnDeleteInfo;
        private System.Windows.Forms.Button btnSaveInfo;
        private System.Windows.Forms.MaskedTextBox txtPrjectId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtUserManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox txtProjectTitle;
        private System.Windows.Forms.TextBox txtProjectDes;
        private System.Windows.Forms.DataGridView dgvProjectDetails;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dtpDeadline;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn project_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn project_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn deadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn u_id_manager;
    }
}
