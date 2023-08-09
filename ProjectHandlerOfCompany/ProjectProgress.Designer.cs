
namespace ProjectHandlerOfCompany
{
    partial class ProjectProgress
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pgbProcess = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTarget = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbInitiated = new System.Windows.Forms.RadioButton();
            this.rdbAnalysis = new System.Windows.Forms.RadioButton();
            this.rdbDevelopment = new System.Windows.Forms.RadioButton();
            this.rdbTest = new System.Windows.Forms.RadioButton();
            this.rdbCompleted = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlTarget.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(890, 232);
            this.dataGridView1.TabIndex = 0;
            // 
            // pgbProcess
            // 
            this.pgbProcess.Location = new System.Drawing.Point(229, 288);
            this.pgbProcess.Name = "pgbProcess";
            this.pgbProcess.Size = new System.Drawing.Size(393, 97);
            this.pgbProcess.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Project Progress";
            // 
            // pnlTarget
            // 
            this.pnlTarget.Controls.Add(this.rdbCompleted);
            this.pnlTarget.Controls.Add(this.rdbTest);
            this.pnlTarget.Controls.Add(this.rdbDevelopment);
            this.pnlTarget.Controls.Add(this.rdbAnalysis);
            this.pnlTarget.Controls.Add(this.rdbInitiated);
            this.pnlTarget.Controls.Add(this.label2);
            this.pnlTarget.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTarget.Location = new System.Drawing.Point(681, 232);
            this.pnlTarget.Name = "pnlTarget";
            this.pnlTarget.Size = new System.Drawing.Size(209, 300);
            this.pnlTarget.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Targets";
            // 
            // rdbInitiated
            // 
            this.rdbInitiated.AutoSize = true;
            this.rdbInitiated.Location = new System.Drawing.Point(51, 73);
            this.rdbInitiated.Name = "rdbInitiated";
            this.rdbInitiated.Size = new System.Drawing.Size(91, 24);
            this.rdbInitiated.TabIndex = 6;
            this.rdbInitiated.TabStop = true;
            this.rdbInitiated.Text = "Initiated";
            this.rdbInitiated.UseVisualStyleBackColor = true;
            this.rdbInitiated.CheckedChanged += new System.EventHandler(this.rdbInitiated_CheckedChanged);
            // 
            // rdbAnalysis
            // 
            this.rdbAnalysis.AutoSize = true;
            this.rdbAnalysis.Location = new System.Drawing.Point(53, 120);
            this.rdbAnalysis.Name = "rdbAnalysis";
            this.rdbAnalysis.Size = new System.Drawing.Size(92, 24);
            this.rdbAnalysis.TabIndex = 7;
            this.rdbAnalysis.TabStop = true;
            this.rdbAnalysis.Text = "Analysis";
            this.rdbAnalysis.UseVisualStyleBackColor = true;
            // 
            // rdbDevelopment
            // 
            this.rdbDevelopment.AutoSize = true;
            this.rdbDevelopment.Location = new System.Drawing.Point(53, 167);
            this.rdbDevelopment.Name = "rdbDevelopment";
            this.rdbDevelopment.Size = new System.Drawing.Size(128, 24);
            this.rdbDevelopment.TabIndex = 8;
            this.rdbDevelopment.TabStop = true;
            this.rdbDevelopment.Text = "Development";
            this.rdbDevelopment.UseVisualStyleBackColor = true;
            // 
            // rdbTest
            // 
            this.rdbTest.AutoSize = true;
            this.rdbTest.Location = new System.Drawing.Point(53, 214);
            this.rdbTest.Name = "rdbTest";
            this.rdbTest.Size = new System.Drawing.Size(65, 24);
            this.rdbTest.TabIndex = 9;
            this.rdbTest.TabStop = true;
            this.rdbTest.Text = "Test";
            this.rdbTest.UseVisualStyleBackColor = true;
            // 
            // rdbCompleted
            // 
            this.rdbCompleted.AutoSize = true;
            this.rdbCompleted.Location = new System.Drawing.Point(53, 261);
            this.rdbCompleted.Name = "rdbCompleted";
            this.rdbCompleted.Size = new System.Drawing.Size(111, 24);
            this.rdbCompleted.TabIndex = 10;
            this.rdbCompleted.TabStop = true;
            this.rdbCompleted.Text = "Completed";
            this.rdbCompleted.UseVisualStyleBackColor = true;
            // 
            // ProjectProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlTarget);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pgbProcess);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ProjectProgress";
            this.Size = new System.Drawing.Size(890, 532);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlTarget.ResumeLayout(false);
            this.pnlTarget.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ProgressBar pgbProcess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTarget;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbCompleted;
        private System.Windows.Forms.RadioButton rdbTest;
        private System.Windows.Forms.RadioButton rdbDevelopment;
        private System.Windows.Forms.RadioButton rdbAnalysis;
        private System.Windows.Forms.RadioButton rdbInitiated;
    }
}
