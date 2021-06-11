
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
            this.searchResultLabel = new System.Windows.Forms.Label();
            this.userMgmtListBox = new System.Windows.Forms.ListBox();
            this.filterStdntLabel = new System.Windows.Forms.Label();
            this.searchUserMgmTextBox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.addNewUserMgmButton = new System.Windows.Forms.Button();
            this.userRepViewButton = new System.Windows.Forms.Button();
            this.noResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // filUserMgmTextBox
            // 
            this.filUserMgmTextBox.Location = new System.Drawing.Point(213, 16);
            this.filUserMgmTextBox.Name = "filUserMgmTextBox";
            this.filUserMgmTextBox.Size = new System.Drawing.Size(100, 23);
            this.filUserMgmTextBox.TabIndex = 41;
            // 
            // searchResultLabel
            // 
            this.searchResultLabel.AutoSize = true;
            this.searchResultLabel.Location = new System.Drawing.Point(13, 53);
            this.searchResultLabel.Name = "searchResultLabel";
            this.searchResultLabel.Size = new System.Drawing.Size(90, 15);
            this.searchResultLabel.TabIndex = 40;
            this.searchResultLabel.Text = "Search Result(s)";
            // 
            // userMgmtListBox
            // 
            this.userMgmtListBox.FormattingEnabled = true;
            this.userMgmtListBox.ItemHeight = 15;
            this.userMgmtListBox.Location = new System.Drawing.Point(12, 71);
            this.userMgmtListBox.Name = "userMgmtListBox";
            this.userMgmtListBox.Size = new System.Drawing.Size(301, 319);
            this.userMgmtListBox.TabIndex = 38;
            this.userMgmtListBox.SelectedIndexChanged += new System.EventHandler(this.userMgmtListBox_SelectedIndexChanged);
            // 
            // filterStdntLabel
            // 
            this.filterStdntLabel.AutoSize = true;
            this.filterStdntLabel.Location = new System.Drawing.Point(174, 16);
            this.filterStdntLabel.Name = "filterStdntLabel";
            this.filterStdntLabel.Size = new System.Drawing.Size(33, 15);
            this.filterStdntLabel.TabIndex = 37;
            this.filterStdntLabel.Text = "Filter";
            // 
            // searchUserMgmTextBox
            // 
            this.searchUserMgmTextBox.Location = new System.Drawing.Point(58, 16);
            this.searchUserMgmTextBox.Name = "searchUserMgmTextBox";
            this.searchUserMgmTextBox.Size = new System.Drawing.Size(100, 23);
            this.searchUserMgmTextBox.TabIndex = 36;
            this.searchUserMgmTextBox.TextChanged += new System.EventHandler(this.searchUserMgmTextBox_TextChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(10, 16);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(42, 15);
            this.SearchLabel.TabIndex = 35;
            this.SearchLabel.Text = "Search";
            // 
            // addNewUserMgmButton
            // 
            this.addNewUserMgmButton.Location = new System.Drawing.Point(109, 406);
            this.addNewUserMgmButton.Name = "addNewUserMgmButton";
            this.addNewUserMgmButton.Size = new System.Drawing.Size(73, 37);
            this.addNewUserMgmButton.TabIndex = 53;
            this.addNewUserMgmButton.Text = "Add New ";
            this.addNewUserMgmButton.UseVisualStyleBackColor = true;
            this.addNewUserMgmButton.Click += new System.EventHandler(this.addNewUserMgmButton_Click);
            // 
            // userRepViewButton
            // 
            this.userRepViewButton.Location = new System.Drawing.Point(238, 406);
            this.userRepViewButton.Name = "userRepViewButton";
            this.userRepViewButton.Size = new System.Drawing.Size(75, 37);
            this.userRepViewButton.TabIndex = 69;
            this.userRepViewButton.Text = "View";
            this.userRepViewButton.UseVisualStyleBackColor = true;
            this.userRepViewButton.Click += new System.EventHandler(this.userRepViewButton_Click);
            // 
            // noResultLabel
            // 
            this.noResultLabel.AutoSize = true;
            this.noResultLabel.Location = new System.Drawing.Point(13, 53);
            this.noResultLabel.Name = "noResultLabel";
            this.noResultLabel.Size = new System.Drawing.Size(81, 15);
            this.noResultLabel.TabIndex = 70;
            this.noResultLabel.Text = "noResultLabel";
            // 
            // UserReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 472);
            this.Controls.Add(this.userRepViewButton);
            this.Controls.Add(this.addNewUserMgmButton);
            this.Controls.Add(this.filUserMgmTextBox);
            this.Controls.Add(this.searchResultLabel);
            this.Controls.Add(this.userMgmtListBox);
            this.Controls.Add(this.filterStdntLabel);
            this.Controls.Add(this.searchUserMgmTextBox);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.noResultLabel);
            this.Name = "UserReport";
            this.Text = "User Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filUserMgmTextBox;
        private System.Windows.Forms.Label searchResultLabel;
        private System.Windows.Forms.ListBox userMgmtListBox;
        private System.Windows.Forms.Label filterStdntLabel;
        private System.Windows.Forms.TextBox searchUserMgmTextBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Button addNewUserMgmButton;
        private System.Windows.Forms.Button userRepViewButton;
        private System.Windows.Forms.Label noResultLabel;
    }
}