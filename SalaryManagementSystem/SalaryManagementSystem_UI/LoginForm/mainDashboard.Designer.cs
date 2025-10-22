namespace SalaryManagementSystem_UI.LoginForm
{
    partial class mainDashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageEmployeeButton = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDepartmentButton = new System.Windows.Forms.ToolStripMenuItem();
            this.manageNewManageButton = new System.Windows.Forms.ToolStripMenuItem();
            this.managePaymentButton = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewAccountButton = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("B Nazanin", 18F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageEmployeeButton,
            this.manageDepartmentButton,
            this.manageNewManageButton,
            this.managePaymentButton,
            this.createNewAccountButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(192, 259);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageEmployeeButton
            // 
            this.manageEmployeeButton.Name = "manageEmployeeButton";
            this.manageEmployeeButton.Size = new System.Drawing.Size(179, 39);
            this.manageEmployeeButton.Text = "فرم مدیریت کارمندان";
            this.manageEmployeeButton.Click += new System.EventHandler(this.manageEmployeeButton_Click);
            // 
            // manageDepartmentButton
            // 
            this.manageDepartmentButton.Name = "manageDepartmentButton";
            this.manageDepartmentButton.Size = new System.Drawing.Size(179, 39);
            this.manageDepartmentButton.Text = "فرم مدیریت دپارتمان";
            this.manageDepartmentButton.Click += new System.EventHandler(this.manageDepartmentButton_Click);
            // 
            // manageNewManageButton
            // 
            this.manageNewManageButton.Name = "manageNewManageButton";
            this.manageNewManageButton.Size = new System.Drawing.Size(179, 39);
            this.manageNewManageButton.Text = "فرم استخدام نیرو";
            this.manageNewManageButton.Click += new System.EventHandler(this.manageNewManageButton_Click);
            // 
            // managePaymentButton
            // 
            this.managePaymentButton.Name = "managePaymentButton";
            this.managePaymentButton.Size = new System.Drawing.Size(179, 39);
            this.managePaymentButton.Text = "فرم پرداخت حقوق";
            // 
            // createNewAccountButton
            // 
            this.createNewAccountButton.Name = "createNewAccountButton";
            this.createNewAccountButton.Size = new System.Drawing.Size(179, 39);
            this.createNewAccountButton.Text = "ساخت حساب جدید";
            this.createNewAccountButton.Click += new System.EventHandler(this.createNewAccountButton_Click);
            // 
            // mainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(480, 259);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("B Nazanin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "mainDashboard";
            this.Text = "فرم اصلی";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainDashboard_FormClosing);
            this.Load += new System.EventHandler(this.mainDashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageEmployeeButton;
        private System.Windows.Forms.ToolStripMenuItem manageDepartmentButton;
        private System.Windows.Forms.ToolStripMenuItem manageNewManageButton;
        private System.Windows.Forms.ToolStripMenuItem managePaymentButton;
        private System.Windows.Forms.ToolStripMenuItem createNewAccountButton;
    }
}