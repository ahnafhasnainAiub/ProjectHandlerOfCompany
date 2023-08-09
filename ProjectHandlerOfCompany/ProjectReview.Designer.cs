
namespace ProjectHandlerOfCompany
{
    partial class ProjectReview
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProjectRev = new System.Windows.Forms.Label();
            this.tkbRating = new MetroFramework.Controls.MetroTrackBar();
            this.lblRating = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProjectId = new System.Windows.Forms.TextBox();
            this.btnSetProjectId = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSetProjectId);
            this.panel1.Controls.Add(this.txtProjectId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblProjectRev);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 100);
            this.panel1.TabIndex = 0;
            // 
            // lblProjectRev
            // 
            this.lblProjectRev.AutoSize = true;
            this.lblProjectRev.Location = new System.Drawing.Point(47, 36);
            this.lblProjectRev.Name = "lblProjectRev";
            this.lblProjectRev.Size = new System.Drawing.Size(113, 20);
            this.lblProjectRev.TabIndex = 1;
            this.lblProjectRev.Text = "Project Review";
            // 
            // tkbRating
            // 
            this.tkbRating.BackColor = System.Drawing.Color.Transparent;
            this.tkbRating.Location = new System.Drawing.Point(280, 271);
            this.tkbRating.Maximum = 10;
            this.tkbRating.Name = "tkbRating";
            this.tkbRating.Size = new System.Drawing.Size(350, 118);
            this.tkbRating.TabIndex = 1;
            this.tkbRating.Text = "metroTrackBar1";
            this.tkbRating.Value = 3;
            this.tkbRating.Scroll += new System.Windows.Forms.ScrollEventHandler(this.tkbRating_Scroll);
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(427, 183);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(29, 20);
            this.lblRating.TabIndex = 5;
            this.lblRating.Text = ".....";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(405, 432);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(104, 49);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Project Id";
            // 
            // txtProjectId
            // 
            this.txtProjectId.Location = new System.Drawing.Point(378, 36);
            this.txtProjectId.Name = "txtProjectId";
            this.txtProjectId.Size = new System.Drawing.Size(100, 26);
            this.txtProjectId.TabIndex = 3;
            // 
            // btnSetProjectId
            // 
            this.btnSetProjectId.Location = new System.Drawing.Point(513, 34);
            this.btnSetProjectId.Name = "btnSetProjectId";
            this.btnSetProjectId.Size = new System.Drawing.Size(159, 31);
            this.btnSetProjectId.TabIndex = 4;
            this.btnSetProjectId.Text = "Set Project Id";
            this.btnSetProjectId.UseVisualStyleBackColor = true;
            this.btnSetProjectId.Click += new System.EventHandler(this.btnSetProjectId_Click);
            // 
            // ProjectReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.tkbRating);
            this.Controls.Add(this.panel1);
            this.Name = "ProjectReview";
            this.Size = new System.Drawing.Size(890, 532);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblProjectRev;
        private MetroFramework.Controls.MetroTrackBar tkbRating;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnSetProjectId;
        private System.Windows.Forms.TextBox txtProjectId;
        private System.Windows.Forms.Label label1;
    }
}
