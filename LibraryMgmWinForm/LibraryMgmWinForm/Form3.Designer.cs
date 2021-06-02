
namespace LibraryMgmWinForm
{
    partial class UserReport
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
            this.filUserMgmTextBox = new System.Windows.Forms.TextBox();
            this.rentResultLabel = new System.Windows.Forms.Label();
            this.viewUserMgmButton = new System.Windows.Forms.Button();
            this.userMgmtListBox = new System.Windows.Forms.ListBox();
            this.filterStdntLabel = new System.Windows.Forms.Label();
            this.searchUserMgmTextBox = new System.Windows.Forms.TextBox();
            this.searchStdntLabel = new System.Windows.Forms.Label();
            this.addNewUserMgmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // filUserMgmTextBox
            // 
            this.filUserMgmTextBox.Location = new System.Drawing.Point(215, 10);
            this.filUserMgmTextBox.Name = "filUserMgmTextBox";
            this.filUserMgmTextBox.Size = new System.Drawing.Size(100, 23);
            this.filUserMgmTextBox.TabIndex = 41;
            // 
            // rentResultLabel
            // 
            this.rentResultLabel.AutoSize = true;
            this.rentResultLabel.Location = new System.Drawing.Point(13, 43);
            this.rentResultLabel.Name = "rentResultLabel";
            this.rentResultLabel.Size = new System.Drawing.Size(90, 15);
            this.rentResultLabel.TabIndex = 40;
            this.rentResultLabel.Text = "Search Result(s)";
            // 
            // viewUserMgmButton
            // 
            this.viewUserMgmButton.Location = new System.Drawing.Point(69, 326);
            this.viewUserMgmButton.Name = "viewUserMgmButton";
            this.viewUserMgmButton.Size = new System.Drawing.Size(92, 23);
            this.viewUserMgmButton.TabIndex = 39;
            this.viewUserMgmButton.Text = "View";
            this.viewUserMgmButton.UseVisualStyleBackColor = true;
            // 
            // userMgmtListBox
            // 
            this.userMgmtListBox.FormattingEnabled = true;
            this.userMgmtListBox.ItemHeight = 15;
            this.userMgmtListBox.Location = new System.Drawing.Point(12, 61);
            this.userMgmtListBox.Name = "userMgmtListBox";
            this.userMgmtListBox.Size = new System.Drawing.Size(301, 259);
            this.userMgmtListBox.TabIndex = 38;
            this.userMgmtListBox.SelectedIndexChanged += new System.EventHandler(this.userMgmtListBox_SelectedIndexChanged);
            // 
            // filterStdntLabel
            // 
            this.filterStdntLabel.AutoSize = true;
            this.filterStdntLabel.Location = new System.Drawing.Point(176, 10);
            this.filterStdntLabel.Name = "filterStdntLabel";
            this.filterStdntLabel.Size = new System.Drawing.Size(33, 15);
            this.filterStdntLabel.TabIndex = 37;
            this.filterStdntLabel.Text = "Filter";
            // 
            // searchUserMgmTextBox
            // 
            this.searchUserMgmTextBox.Location = new System.Drawing.Point(61, 10);
            this.searchUserMgmTextBox.Name = "searchUserMgmTextBox";
            this.searchUserMgmTextBox.Size = new System.Drawing.Size(100, 23);
            this.searchUserMgmTextBox.TabIndex = 36;
            // 
            // searchStdntLabel
            // 
            this.searchStdntLabel.AutoSize = true;
            this.searchStdntLabel.Location = new System.Drawing.Point(12, 10);
            this.searchStdntLabel.Name = "searchStdntLabel";
            this.searchStdntLabel.Size = new System.Drawing.Size(42, 15);
            this.searchStdntLabel.TabIndex = 35;
            this.searchStdntLabel.Text = "Search";
            // 
            // addNewUserMgmButton
            // 
            this.addNewUserMgmButton.Location = new System.Drawing.Point(176, 326);
            this.addNewUserMgmButton.Name = "addNewUserMgmButton";
            this.addNewUserMgmButton.Size = new System.Drawing.Size(75, 23);
            this.addNewUserMgmButton.TabIndex = 53;
            this.addNewUserMgmButton.Text = "Add New ";
            this.addNewUserMgmButton.UseVisualStyleBackColor = true;
            this.addNewUserMgmButton.Click += new System.EventHandler(this.addNewUserMgmButton_Click);
            // 
            // UserReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 362);
            this.Controls.Add(this.addNewUserMgmButton);
            this.Controls.Add(this.filUserMgmTextBox);
            this.Controls.Add(this.rentResultLabel);
            this.Controls.Add(this.viewUserMgmButton);
            this.Controls.Add(this.userMgmtListBox);
            this.Controls.Add(this.filterStdntLabel);
            this.Controls.Add(this.searchUserMgmTextBox);
            this.Controls.Add(this.searchStdntLabel);
            this.Name = "UserReport";
            this.Text = "User Report";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filUserMgmTextBox;
        private System.Windows.Forms.Label rentResultLabel;
        private System.Windows.Forms.Button viewUserMgmButton;
        private System.Windows.Forms.ListBox userMgmtListBox;
        private System.Windows.Forms.Label filterStdntLabel;
        private System.Windows.Forms.TextBox searchUserMgmTextBox;
        private System.Windows.Forms.Label searchStdntLabel;
        private System.Windows.Forms.Button addNewUserMgmButton;
    }
}