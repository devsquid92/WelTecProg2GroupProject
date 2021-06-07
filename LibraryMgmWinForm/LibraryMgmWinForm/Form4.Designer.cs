
namespace LibraryMgmWinForm
{
    partial class Form4
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
            this.userInfoSaveButton = new System.Windows.Forms.Button();
            this.userInfoIDTextBox = new System.Windows.Forms.TextBox();
            this.userInfoLNameTextBox = new System.Windows.Forms.TextBox();
            this.userInfoFNameTextBox = new System.Windows.Forms.TextBox();
            this.stdntInfoFirstNameLabel = new System.Windows.Forms.Label();
            this.stdntInfoIDLabel = new System.Windows.Forms.Label();
            this.stdntInfoLastNameLabel = new System.Windows.Forms.Label();
            this.issuedListBox = new System.Windows.Forms.ListBox();
            this.stdntInfoPenaltyAmountLabel = new System.Windows.Forms.Label();
            this.stdntInfoPayButton = new System.Windows.Forms.Button();
            this.stdntInfoRecieveItemButton = new System.Windows.Forms.Button();
            this.stndtInfoBorrowedLabel = new System.Windows.Forms.Label();
            this.stdntInfoDueByLabel = new System.Windows.Forms.Label();
            this.userInfoDeparmentTextBox = new System.Windows.Forms.TextBox();
            this.stdntDepartmentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userInfoSaveButton
            // 
            this.userInfoSaveButton.Location = new System.Drawing.Point(268, 17);
            this.userInfoSaveButton.Name = "userInfoSaveButton";
            this.userInfoSaveButton.Size = new System.Drawing.Size(75, 23);
            this.userInfoSaveButton.TabIndex = 34;
            this.userInfoSaveButton.Text = "Save";
            this.userInfoSaveButton.UseVisualStyleBackColor = true;
            this.userInfoSaveButton.Click += new System.EventHandler(this.userInfoSaveButton_Click);
            // 
            // userInfoIDTextBox
            // 
            this.userInfoIDTextBox.Location = new System.Drawing.Point(107, 18);
            this.userInfoIDTextBox.Name = "userInfoIDTextBox";
            this.userInfoIDTextBox.Size = new System.Drawing.Size(135, 23);
            this.userInfoIDTextBox.TabIndex = 30;
            // 
            // userInfoLNameTextBox
            // 
            this.userInfoLNameTextBox.Location = new System.Drawing.Point(107, 76);
            this.userInfoLNameTextBox.Name = "userInfoLNameTextBox";
            this.userInfoLNameTextBox.Size = new System.Drawing.Size(236, 23);
            this.userInfoLNameTextBox.TabIndex = 28;
            // 
            // userInfoFNameTextBox
            // 
            this.userInfoFNameTextBox.Location = new System.Drawing.Point(107, 47);
            this.userInfoFNameTextBox.Name = "userInfoFNameTextBox";
            this.userInfoFNameTextBox.Size = new System.Drawing.Size(236, 23);
            this.userInfoFNameTextBox.TabIndex = 27;
            this.userInfoFNameTextBox.TextChanged += new System.EventHandler(this.userInfoFNameTextBox_TextChanged);
            // 
            // stdntInfoFirstNameLabel
            // 
            this.stdntInfoFirstNameLabel.AutoSize = true;
            this.stdntInfoFirstNameLabel.Location = new System.Drawing.Point(14, 50);
            this.stdntInfoFirstNameLabel.Name = "stdntInfoFirstNameLabel";
            this.stdntInfoFirstNameLabel.Size = new System.Drawing.Size(64, 15);
            this.stdntInfoFirstNameLabel.TabIndex = 26;
            this.stdntInfoFirstNameLabel.Text = "First Name";
            // 
            // stdntInfoIDLabel
            // 
            this.stdntInfoIDLabel.AutoSize = true;
            this.stdntInfoIDLabel.Location = new System.Drawing.Point(14, 21);
            this.stdntInfoIDLabel.Name = "stdntInfoIDLabel";
            this.stdntInfoIDLabel.Size = new System.Drawing.Size(18, 15);
            this.stdntInfoIDLabel.TabIndex = 24;
            this.stdntInfoIDLabel.Text = "ID";
            // 
            // stdntInfoLastNameLabel
            // 
            this.stdntInfoLastNameLabel.AutoSize = true;
            this.stdntInfoLastNameLabel.Location = new System.Drawing.Point(14, 79);
            this.stdntInfoLastNameLabel.Name = "stdntInfoLastNameLabel";
            this.stdntInfoLastNameLabel.Size = new System.Drawing.Size(63, 15);
            this.stdntInfoLastNameLabel.TabIndex = 23;
            this.stdntInfoLastNameLabel.Text = "Last Name";
            // 
            // issuedListBox
            // 
            this.issuedListBox.FormattingEnabled = true;
            this.issuedListBox.ItemHeight = 15;
            this.issuedListBox.Location = new System.Drawing.Point(14, 146);
            this.issuedListBox.Name = "issuedListBox";
            this.issuedListBox.Size = new System.Drawing.Size(329, 259);
            this.issuedListBox.TabIndex = 35;
            this.issuedListBox.SelectedIndexChanged += new System.EventHandler(this.BorrowedItems_SelectedIndexChanged);
            // 
            // stdntInfoPenaltyAmountLabel
            // 
            this.stdntInfoPenaltyAmountLabel.AutoSize = true;
            this.stdntInfoPenaltyAmountLabel.Location = new System.Drawing.Point(361, 350);
            this.stdntInfoPenaltyAmountLabel.Name = "stdntInfoPenaltyAmountLabel";
            this.stdntInfoPenaltyAmountLabel.Size = new System.Drawing.Size(46, 15);
            this.stdntInfoPenaltyAmountLabel.TabIndex = 36;
            this.stdntInfoPenaltyAmountLabel.Text = "Penalty";
            // 
            // stdntInfoPayButton
            // 
            this.stdntInfoPayButton.Location = new System.Drawing.Point(361, 382);
            this.stdntInfoPayButton.Name = "stdntInfoPayButton";
            this.stdntInfoPayButton.Size = new System.Drawing.Size(109, 23);
            this.stdntInfoPayButton.TabIndex = 38;
            this.stdntInfoPayButton.Text = "Pay an amount";
            this.stdntInfoPayButton.UseVisualStyleBackColor = true;
            // 
            // stdntInfoRecieveItemButton
            // 
            this.stdntInfoRecieveItemButton.Location = new System.Drawing.Point(107, 411);
            this.stdntInfoRecieveItemButton.Name = "stdntInfoRecieveItemButton";
            this.stdntInfoRecieveItemButton.Size = new System.Drawing.Size(91, 37);
            this.stdntInfoRecieveItemButton.TabIndex = 39;
            this.stdntInfoRecieveItemButton.Text = "Receive Item";
            this.stdntInfoRecieveItemButton.UseVisualStyleBackColor = true;
            // 
            // stndtInfoBorrowedLabel
            // 
            this.stndtInfoBorrowedLabel.AutoSize = true;
            this.stndtInfoBorrowedLabel.Location = new System.Drawing.Point(361, 116);
            this.stndtInfoBorrowedLabel.Name = "stndtInfoBorrowedLabel";
            this.stndtInfoBorrowedLabel.Size = new System.Drawing.Size(75, 15);
            this.stndtInfoBorrowedLabel.TabIndex = 40;
            this.stndtInfoBorrowedLabel.Text = "Borrowed on";
            // 
            // stdntInfoDueByLabel
            // 
            this.stdntInfoDueByLabel.AutoSize = true;
            this.stdntInfoDueByLabel.Location = new System.Drawing.Point(361, 160);
            this.stdntInfoDueByLabel.Name = "stdntInfoDueByLabel";
            this.stdntInfoDueByLabel.Size = new System.Drawing.Size(44, 15);
            this.stdntInfoDueByLabel.TabIndex = 41;
            this.stdntInfoDueByLabel.Text = "Due by";
            // 
            // userInfoDeparmentTextBox
            // 
            this.userInfoDeparmentTextBox.Location = new System.Drawing.Point(107, 105);
            this.userInfoDeparmentTextBox.Name = "userInfoDeparmentTextBox";
            this.userInfoDeparmentTextBox.Size = new System.Drawing.Size(236, 23);
            this.userInfoDeparmentTextBox.TabIndex = 43;
            // 
            // stdntDepartmentLabel
            // 
            this.stdntDepartmentLabel.AutoSize = true;
            this.stdntDepartmentLabel.Location = new System.Drawing.Point(14, 108);
            this.stdntDepartmentLabel.Name = "stdntDepartmentLabel";
            this.stdntDepartmentLabel.Size = new System.Drawing.Size(70, 15);
            this.stdntDepartmentLabel.TabIndex = 42;
            this.stdntDepartmentLabel.Text = "Department";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 473);
            this.Controls.Add(this.userInfoDeparmentTextBox);
            this.Controls.Add(this.stdntDepartmentLabel);
            this.Controls.Add(this.stdntInfoDueByLabel);
            this.Controls.Add(this.stndtInfoBorrowedLabel);
            this.Controls.Add(this.stdntInfoRecieveItemButton);
            this.Controls.Add(this.stdntInfoPayButton);
            this.Controls.Add(this.stdntInfoPenaltyAmountLabel);
            this.Controls.Add(this.issuedListBox);
            this.Controls.Add(this.userInfoSaveButton);
            this.Controls.Add(this.userInfoIDTextBox);
            this.Controls.Add(this.userInfoLNameTextBox);
            this.Controls.Add(this.userInfoFNameTextBox);
            this.Controls.Add(this.stdntInfoFirstNameLabel);
            this.Controls.Add(this.stdntInfoIDLabel);
            this.Controls.Add(this.stdntInfoLastNameLabel);
            this.Name = "Form4";
            this.Text = "User Info";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button userInfoSaveButton;
        private System.Windows.Forms.TextBox userInfoIDTextBox;
        private System.Windows.Forms.TextBox userInfoLNameTextBox;
        private System.Windows.Forms.TextBox userInfoFNameTextBox;
        private System.Windows.Forms.Label stdntInfoFirstNameLabel;
        private System.Windows.Forms.Label stdntInfoIDLabel;
        private System.Windows.Forms.Label stdntInfoLastNameLabel;
        private System.Windows.Forms.ListBox issuedListBox;
        private System.Windows.Forms.Label stdntInfoPenaltyAmountLabel;
        private System.Windows.Forms.Button stdntInfoPayButton;
        private System.Windows.Forms.Button stdntInfoRecieveItemButton;
        private System.Windows.Forms.Label stndtInfoBorrowedLabel;
        private System.Windows.Forms.Label stdntInfoDueByLabel;
        private System.Windows.Forms.TextBox userInfoDeparmentTextBox;
        private System.Windows.Forms.Label stdntDepartmentLabel;
    }
}