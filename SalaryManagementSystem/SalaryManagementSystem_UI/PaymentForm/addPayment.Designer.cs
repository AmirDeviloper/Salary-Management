namespace SalaryManagementSystem_UI.PaymentForm
{
    partial class addPayment
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
            this.label1 = new System.Windows.Forms.Label();
            this.manageSearchValue = new System.Windows.Forms.TextBox();
            this.salaryAmountValue = new System.Windows.Forms.NumericUpDown();
            this.manageIDValue = new System.Windows.Forms.ComboBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.descriptionValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryAmountValue)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.descriptionValue);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.manageSearchValue);
            this.groupBox.Controls.Add(this.salaryAmountValue);
            this.groupBox.Controls.Add(this.manageIDValue);
            this.groupBox.Controls.Add(this.confirmButton);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox.Size = new System.Drawing.Size(295, 446);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "اطلاعات استخدام";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 35);
            this.label4.TabIndex = 16;
            this.label4.Text = "میزان پرداختی :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 35);
            this.label1.TabIndex = 16;
            this.label1.Text = "استخدامی ها :";
            // 
            // manageSearchValue
            // 
            this.manageSearchValue.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.manageSearchValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.manageSearchValue.Location = new System.Drawing.Point(15, 48);
            this.manageSearchValue.MaxLength = 12;
            this.manageSearchValue.Name = "manageSearchValue";
            this.manageSearchValue.Size = new System.Drawing.Size(146, 36);
            this.manageSearchValue.TabIndex = 15;
            this.manageSearchValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // salaryAmountValue
            // 
            this.salaryAmountValue.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.salaryAmountValue.Increment = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.salaryAmountValue.Location = new System.Drawing.Point(10, 186);
            this.salaryAmountValue.Maximum = new decimal(new int[] {
            20000000,
            0,
            0,
            0});
            this.salaryAmountValue.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.salaryAmountValue.Name = "salaryAmountValue";
            this.salaryAmountValue.Size = new System.Drawing.Size(262, 43);
            this.salaryAmountValue.TabIndex = 14;
            this.salaryAmountValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.salaryAmountValue.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // manageIDValue
            // 
            this.manageIDValue.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.manageIDValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.manageIDValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageIDValue.FormattingEnabled = true;
            this.manageIDValue.Location = new System.Drawing.Point(15, 90);
            this.manageIDValue.Name = "manageIDValue";
            this.manageIDValue.Size = new System.Drawing.Size(262, 43);
            this.manageIDValue.TabIndex = 13;
            // 
            // confirmButton
            // 
            this.confirmButton.FlatAppearance.BorderSize = 0;
            this.confirmButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.confirmButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.Location = new System.Drawing.Point(88, 393);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(132, 44);
            this.confirmButton.TabIndex = 10;
            this.confirmButton.Text = "ثبت";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // descriptionValue
            // 
            this.descriptionValue.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.descriptionValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionValue.Location = new System.Drawing.Point(15, 282);
            this.descriptionValue.MaxLength = 50;
            this.descriptionValue.Multiline = true;
            this.descriptionValue.Name = "descriptionValue";
            this.descriptionValue.Size = new System.Drawing.Size(262, 105);
            this.descriptionValue.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 35);
            this.label2.TabIndex = 16;
            this.label2.Text = "توضیحات :";
            // 
            // addPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(323, 466);
            this.Controls.Add(this.groupBox);
            this.Font = new System.Drawing.Font("B Nazanin", 18F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Name = "addPayment";
            this.Text = "پرداخت حقوق";
            this.Load += new System.EventHandler(this.addPayment_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryAmountValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox manageSearchValue;
        private System.Windows.Forms.NumericUpDown salaryAmountValue;
        private System.Windows.Forms.ComboBox manageIDValue;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.TextBox descriptionValue;
        private System.Windows.Forms.Label label2;
    }
}