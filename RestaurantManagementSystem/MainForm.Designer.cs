
namespace RestaurantManagementSystem
{
    partial class MainForm
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
            this.loginControlForm1 = new RestaurantManagementSystem.LoginControlForm();
            this.tasksDashboardControlForm1 = new RestaurantManagementSystem.TasksDashboardControlForm();
            this.commandeControlForm1 = new RestaurantManagementSystem.CommandeControlForm();
            this.tableACommanderControlForm1 = new RestaurantManagementSystem.TableACommanderControlForm();
            this.SuspendLayout();
            // 
            // loginControlForm1
            // 
            this.loginControlForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginControlForm1.Location = new System.Drawing.Point(0, 0);
            this.loginControlForm1.Name = "loginControlForm1";
            this.loginControlForm1.Size = new System.Drawing.Size(825, 491);
            this.loginControlForm1.TabIndex = 0;
            this.loginControlForm1.Load += new System.EventHandler(this.loginControlForm1_Load_1);
            // 
            // tasksDashboardControlForm1
            // 
            this.tasksDashboardControlForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tasksDashboardControlForm1.Location = new System.Drawing.Point(0, 0);
            this.tasksDashboardControlForm1.Name = "tasksDashboardControlForm1";
            this.tasksDashboardControlForm1.Size = new System.Drawing.Size(825, 491);
            this.tasksDashboardControlForm1.TabIndex = 3;
            // 
            // commandeControlForm1
            // 
            this.commandeControlForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandeControlForm1.Location = new System.Drawing.Point(0, 0);
            this.commandeControlForm1.Name = "commandeControlForm1";
            this.commandeControlForm1.Size = new System.Drawing.Size(825, 491);
            this.commandeControlForm1.TabIndex = 4;
            // 
            // tableACommanderControlForm1
            // 
            this.tableACommanderControlForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableACommanderControlForm1.Location = new System.Drawing.Point(0, 0);
            this.tableACommanderControlForm1.Name = "tableACommanderControlForm1";
            this.tableACommanderControlForm1.Size = new System.Drawing.Size(825, 491);
            this.tableACommanderControlForm1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 491);
            this.Controls.Add(this.tableACommanderControlForm1);
            this.Controls.Add(this.loginControlForm1);
            this.Controls.Add(this.tasksDashboardControlForm1);
            this.Controls.Add(this.commandeControlForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private LoginControlForm loginControlForm1 = new LoginControlForm();
        private TableCrudControlForm tableCrudControlForm1 = new TableCrudControlForm();
        private TasksDashboardControlForm tasksDashboardControlForm1 = new TasksDashboardControlForm();
        private ServeurCrudControlForm serveurCrudControlForm1 = new ServeurCrudControlForm();
        private AffecterServeurTable affecterServeurTable1 = new AffecterServeurTable();
        private CommandeControlForm commandeControlForm1;
        private TableACommanderControlForm tableACommanderControlForm1;
    }
}