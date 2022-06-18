
namespace RestaurantManagementSystem
{
    partial class TestForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginControlForm1 = new RestaurantManagementSystem.LoginControlForm();
            this.tasksDashboardControlForm1 = new RestaurantManagementSystem.TasksDashboardControlForm();
            this.loginControlForm2 = new RestaurantManagementSystem.LoginControlForm();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.loginControlForm2);
            this.panel1.Controls.Add(this.tasksDashboardControlForm1);
            this.panel1.Controls.Add(this.loginControlForm1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 508);
            this.panel1.TabIndex = 0;
            // 
            // loginControlForm1
            // 
            this.loginControlForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginControlForm1.Location = new System.Drawing.Point(0, 0);
            this.loginControlForm1.Name = "loginControlForm1";
            this.loginControlForm1.Size = new System.Drawing.Size(825, 508);
            this.loginControlForm1.TabIndex = 0;
            // 
            // tasksDashboardControlForm1
            // 
            this.tasksDashboardControlForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tasksDashboardControlForm1.Location = new System.Drawing.Point(0, 0);
            this.tasksDashboardControlForm1.Name = "tasksDashboardControlForm1";
            this.tasksDashboardControlForm1.Size = new System.Drawing.Size(825, 508);
            this.tasksDashboardControlForm1.TabIndex = 1;
            // 
            // loginControlForm2
            // 
            this.loginControlForm2.Location = new System.Drawing.Point(0, 0);
            this.loginControlForm2.Name = "loginControlForm2";
            this.loginControlForm2.Size = new System.Drawing.Size(824, 441);
            this.loginControlForm2.TabIndex = 2;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 508);
            this.Controls.Add(this.panel1);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private LoginControlForm loginControlForm2;
        private TasksDashboardControlForm tasksDashboardControlForm1;
        private LoginControlForm loginControlForm1;
    }
}