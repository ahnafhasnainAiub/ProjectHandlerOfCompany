
namespace ProjectHandlerOfCompany
{
    partial class Conversation
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
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.txtCommentDes = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSetProjectId = new System.Windows.Forms.Button();
            this.txtProjectId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flpComments = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSendMessage);
            this.panel1.Controls.Add(this.txtCommentDes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 432);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(731, 37);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(103, 37);
            this.btnSendMessage.TabIndex = 1;
            this.btnSendMessage.Text = "Send >>";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // txtCommentDes
            // 
            this.txtCommentDes.Location = new System.Drawing.Point(37, 43);
            this.txtCommentDes.Name = "txtCommentDes";
            this.txtCommentDes.Size = new System.Drawing.Size(653, 26);
            this.txtCommentDes.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSetProjectId);
            this.panel2.Controls.Add(this.txtProjectId);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(890, 100);
            this.panel2.TabIndex = 1;
            // 
            // btnSetProjectId
            // 
            this.btnSetProjectId.Location = new System.Drawing.Point(297, 32);
            this.btnSetProjectId.Name = "btnSetProjectId";
            this.btnSetProjectId.Size = new System.Drawing.Size(133, 38);
            this.btnSetProjectId.TabIndex = 3;
            this.btnSetProjectId.Text = "Set Project ID";
            this.btnSetProjectId.UseVisualStyleBackColor = true;
            this.btnSetProjectId.Click += new System.EventHandler(this.btnSetProjectId_Click);
            // 
            // txtProjectId
            // 
            this.txtProjectId.Location = new System.Drawing.Point(158, 38);
            this.txtProjectId.Name = "txtProjectId";
            this.txtProjectId.Size = new System.Drawing.Size(100, 26);
            this.txtProjectId.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project ID: ";
            // 
            // flpComments
            // 
            this.flpComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpComments.Location = new System.Drawing.Point(0, 100);
            this.flpComments.Name = "flpComments";
            this.flpComments.Size = new System.Drawing.Size(890, 332);
            this.flpComments.TabIndex = 2;
            // 
            // Conversation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpComments);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Conversation";
            this.Size = new System.Drawing.Size(890, 532);
            this.Load += new System.EventHandler(this.Conversation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.TextBox txtCommentDes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpComments;
        private System.Windows.Forms.Button btnSetProjectId;
        private System.Windows.Forms.TextBox txtProjectId;
    }
}
