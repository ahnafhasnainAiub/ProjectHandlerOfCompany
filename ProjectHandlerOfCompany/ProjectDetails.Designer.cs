
namespace ProjectHandlerOfCompany
{
    partial class ProjectDetails
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
            this.txtSearchById = new System.Windows.Forms.TextBox();
            this.btnSearchProject = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteProject = new System.Windows.Forms.Button();
            this.dgvProjectDetails = new System.Windows.Forms.DataGridView();
            this.project_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.project_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.u_id_manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchById
            // 
            this.txtSearchById.Location = new System.Drawing.Point(772, 134);
            this.txtSearchById.Name = "txtSearchById";
            this.txtSearchById.Size = new System.Drawing.Size(100, 26);
            this.txtSearchById.TabIndex = 14;
            // 
            // btnSearchProject
            // 
            this.btnSearchProject.Location = new System.Drawing.Point(715, 192);
            this.btnSearchProject.Name = "btnSearchProject";
            this.btnSearchProject.Size = new System.Drawing.Size(148, 80);
            this.btnSearchProject.TabIndex = 13;
            this.btnSearchProject.Text = "Search Project";
            this.btnSearchProject.UseVisualStyleBackColor = true;
            this.btnSearchProject.Click += new System.EventHandler(this.btnSearchProject_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(691, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Project ID: ";
            // 
            // btnDeleteProject
            // 
            this.btnDeleteProject.Location = new System.Drawing.Point(715, 309);
            this.btnDeleteProject.Name = "btnDeleteProject";
            this.btnDeleteProject.Size = new System.Drawing.Size(148, 80);
            this.btnDeleteProject.TabIndex = 9;
            this.btnDeleteProject.Text = "Delete Project";
            this.btnDeleteProject.UseVisualStyleBackColor = true;
            this.btnDeleteProject.Click += new System.EventHandler(this.btnDeleteProject_Click);
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
            this.dgvProjectDetails.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvProjectDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvProjectDetails.Name = "dgvProjectDetails";
            this.dgvProjectDetails.ReadOnly = true;
            this.dgvProjectDetails.RowHeadersWidth = 62;
            this.dgvProjectDetails.RowTemplate.Height = 28;
            this.dgvProjectDetails.Size = new System.Drawing.Size(670, 533);
            this.dgvProjectDetails.TabIndex = 25;
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
            // ProjectDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvProjectDetails);
            this.Controls.Add(this.txtSearchById);
            this.Controls.Add(this.btnSearchProject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteProject);
            this.Name = "ProjectDetails";
            this.Size = new System.Drawing.Size(890, 533);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchById;
        private System.Windows.Forms.Button btnSearchProject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteProject;
        private System.Windows.Forms.DataGridView dgvProjectDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn project_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn project_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn deadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn u_id_manager;
    }
}
