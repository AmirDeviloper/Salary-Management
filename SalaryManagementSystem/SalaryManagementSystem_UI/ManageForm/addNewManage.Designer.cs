namespace SalaryManagementSystem_UI.ManageForm
{
    partial class addNewManage
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.departmentSearchValue = new System.Windows.Forms.TextBox();
            this.employeeSearchValue = new System.Windows.Forms.TextBox();
            this.salaryAmountValue = new System.Windows.Forms.NumericUpDown();
            this.skillIDValue = new System.Windows.Forms.ComboBox();
            this.departmentIDValue = new System.Windows.Forms.ComboBox();
            this.employeeIDValue = new System.Windows.Forms.ComboBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryAmountValue)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.departmentSearchValue);
            this.groupBox.Controls.Add(this.employeeSearchValue);
            this.groupBox.Controls.Add(this.salaryAmountValue);
            this.groupBox.Controls.Add(this.skillIDValue);
            this.groupBox.Controls.Add(this.departmentIDValue);
            this.groupBox.Controls.Add(this.employeeIDValue);
            this.groupBox.Controls.Add(this.confirmButton);
            this.groupBox.Location = new System.Drawing.Point(9, 7);
            this.groupBox.Name = "groupBox";
            this.groupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox.Size = new System.Drawing.Size(298, 501);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "اطلاعات استخدام";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 35);
            this.label4.TabIndex = 16;
            this.label4.Text = "حقوق ماهیانه :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 35);
            this.label3.TabIndex = 16;
            this.label3.Text = "سطح مهارت :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 35);
            this.label2.TabIndex = 16;
            this.label2.Text = "دپارتمان :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 35);
            this.label1.TabIndex = 16;
            this.label1.Text = "کارمند :";
            // 
            // departmentSearchValue
            // 
            this.departmentSearchValue.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.departmentSearchValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.departmentSearchValue.Location = new System.Drawing.Point(15, 160);
            this.departmentSearchValue.MaxLength = 12;
            this.departmentSearchValue.Name = "departmentSearchValue";
            this.departmentSearchValue.Size = new System.Drawing.Size(174, 36);
            this.departmentSearchValue.TabIndex = 15;
            this.departmentSearchValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.departmentSearchValue.TextChanged += new System.EventHandler(this.departmentSearchValue_TextChanged);
            // 
            // employeeSearchValue
            // 
            this.employeeSearchValue.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.employeeSearchValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employeeSearchValue.Location = new System.Drawing.Point(15, 48);
            this.employeeSearchValue.MaxLength = 12;
            this.employeeSearchValue.Name = "employeeSearchValue";
            this.employeeSearchValue.Size = new System.Drawing.Size(188, 36);
            this.employeeSearchValue.TabIndex = 15;
            this.employeeSearchValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.employeeSearchValue.TextChanged += new System.EventHandler(this.employeeSearchValue_TextChanged);
            // 
            // salaryAmountValue
            // 
            this.salaryAmountValue.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.salaryAmountValue.Increment = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.salaryAmountValue.Location = new System.Drawing.Point(15, 397);
            this.salaryAmountValue.Maximum = new decimal(new int[] {
            20000000,
            0,
            0,
            0});
            this.salaryAmountValue.Minimum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.salaryAmountValue.Name = "salaryAmountValue";
            this.salaryAmountValue.Size = new System.Drawing.Size(262, 43);
            this.salaryAmountValue.TabIndex = 14;
            this.salaryAmountValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.salaryAmountValue.Value = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            // 
            // skillIDValue
            // 
            this.skillIDValue.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.skillIDValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skillIDValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skillIDValue.FormattingEnabled = true;
            this.skillIDValue.Location = new System.Drawing.Point(15, 299);
            this.skillIDValue.Name = "skillIDValue";
            this.skillIDValue.Size = new System.Drawing.Size(262, 43);
            this.skillIDValue.TabIndex = 13;
            // 
            // departmentIDValue
            // 
            this.departmentIDValue.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.departmentIDValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentIDValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.departmentIDValue.FormattingEnabled = true;
            this.departmentIDValue.Location = new System.Drawing.Point(15, 202);
            this.departmentIDValue.Name = "departmentIDValue";
            this.departmentIDValue.Size = new System.Drawing.Size(262, 43);
            this.departmentIDValue.TabIndex = 13;
            // 
            // employeeIDValue
            // 
            this.employeeIDValue.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.employeeIDValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeIDValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeIDValue.FormattingEnabled = true;
            this.employeeIDValue.Location = new System.Drawing.Point(15, 90);
            this.employeeIDValue.Name = "employeeIDValue";
            this.employeeIDValue.Size = new System.Drawing.Size(262, 43);
            this.employeeIDValue.TabIndex = 13;
            // 
            // confirmButton
            // 
            this.confirmButton.FlatAppearance.BorderSize = 0;
            this.confirmButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.confirmButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.Location = new System.Drawing.Point(91, 446);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(132, 44);
            this.confirmButton.TabIndex = 10;
            this.confirmButton.Text = "ثبت";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // addNewManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(316, 520);
            this.Controls.Add(this.groupBox);
            this.Font = new System.Drawing.Font("B Nazanin", 18F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.MaximizeBox = false;
            this.Name = "addNewManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "استخدام جدید";
            this.Load += new System.EventHandler(this.addNewManage_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryAmountValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.ComboBox employeeIDValue;
        private System.Windows.Forms.NumericUpDown salaryAmountValue;
        private System.Windows.Forms.ComboBox skillIDValue;
        private System.Windows.Forms.ComboBox departmentIDValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox employeeSearchValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox departmentSearchValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}