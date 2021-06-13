
namespace LibraryMgmWinForm
{
    partial class LibraryManagement
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.itemListBox = new System.Windows.Forms.ListBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.isbnLabel = new System.Windows.Forms.Label();
            this.isbnTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.categryLabel = new System.Windows.Forms.Label();
            this.addItemButton = new System.Windows.Forms.Button();
            this.deleteItemButton = new System.Windows.Forms.Button();
            this.rentItemButton = new System.Windows.Forms.Button();
            this.memberReportButton = new System.Windows.Forms.Button();
            this.cancelEditButton = new System.Windows.Forms.Button();
            this.saveEditButton = new System.Windows.Forms.Button();
            this.searchResultLabel = new System.Windows.Forms.Label();
            this.ctgryTextBox = new System.Windows.Forms.TextBox();
            this.noSearchResultLabel = new System.Windows.Forms.Label();
            this.avaLabel = new System.Windows.Forms.Label();
            this.isbnOKLabel = new System.Windows.Forms.Label();
            this.isbnInvalidLabel = new System.Windows.Forms.Label();
            this.titleOKLabel = new System.Windows.Forms.Label();
            this.yearOKLabel = new System.Windows.Forms.Label();
            this.categoryOKLabel = new System.Windows.Forms.Label();
            this.authorOKLabel = new System.Windows.Forms.Label();
            this.titleInvalidLabel = new System.Windows.Forms.Label();
            this.authorInvalidLabel = new System.Windows.Forms.Label();
            this.yearInvalidLabel = new System.Windows.Forms.Label();
            this.categoryInvalidLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(12, 9);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(42, 15);
            this.searchLabel.TabIndex = 0;
            this.searchLabel.Text = "Search";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(61, 9);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(100, 23);
            this.searchBox.TabIndex = 1;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(176, 9);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(55, 15);
            this.categoryLabel.TabIndex = 2;
            this.categoryLabel.Text = "Category";
            // 
            // itemListBox
            // 
            this.itemListBox.FormattingEnabled = true;
            this.itemListBox.ItemHeight = 15;
            this.itemListBox.Location = new System.Drawing.Point(12, 60);
            this.itemListBox.Name = "itemListBox";
            this.itemListBox.Size = new System.Drawing.Size(301, 259);
            this.itemListBox.TabIndex = 27;
            this.itemListBox.SelectedIndexChanged += new System.EventHandler(this.itemListBox_SelectedIndexChanged_1);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(344, 132);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(29, 15);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Title";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(344, 161);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(44, 15);
            this.authorLabel.TabIndex = 6;
            this.authorLabel.Text = "Author";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(344, 189);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(84, 15);
            this.yearLabel.TabIndex = 7;
            this.yearLabel.Text = "Year Published";
            // 
            // isbnLabel
            // 
            this.isbnLabel.AutoSize = true;
            this.isbnLabel.Location = new System.Drawing.Point(344, 103);
            this.isbnLabel.Name = "isbnLabel";
            this.isbnLabel.Size = new System.Drawing.Size(32, 15);
            this.isbnLabel.TabIndex = 8;
            this.isbnLabel.Text = "ISBN";
            // 
            // isbnTextBox
            // 
            this.isbnTextBox.Location = new System.Drawing.Point(437, 100);
            this.isbnTextBox.Name = "isbnTextBox";
            this.isbnTextBox.Size = new System.Drawing.Size(100, 23);
            this.isbnTextBox.TabIndex = 10;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(437, 129);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(197, 23);
            this.titleTextBox.TabIndex = 11;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(437, 186);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(80, 23);
            this.yearTextBox.TabIndex = 12;
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(437, 158);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(165, 23);
            this.authorTextBox.TabIndex = 13;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Location = new System.Drawing.Point(437, 215);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(80, 23);
            this.categoryTextBox.TabIndex = 15;
            // 
            // categryLabel
            // 
            this.categryLabel.AutoSize = true;
            this.categryLabel.Location = new System.Drawing.Point(344, 218);
            this.categryLabel.Name = "categryLabel";
            this.categryLabel.Size = new System.Drawing.Size(55, 15);
            this.categryLabel.TabIndex = 14;
            this.categryLabel.Text = "Category";
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(13, 326);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(87, 23);
            this.addItemButton.TabIndex = 16;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // deleteItemButton
            // 
            this.deleteItemButton.Location = new System.Drawing.Point(289, 367);
            this.deleteItemButton.Name = "deleteItemButton";
            this.deleteItemButton.Size = new System.Drawing.Size(87, 23);
            this.deleteItemButton.TabIndex = 17;
            this.deleteItemButton.Text = "Delete Item";
            this.deleteItemButton.UseVisualStyleBackColor = true;
            this.deleteItemButton.Click += new System.EventHandler(this.deleteItemButton_Click);
            // 
            // rentItemButton
            // 
            this.rentItemButton.Location = new System.Drawing.Point(176, 326);
            this.rentItemButton.Name = "rentItemButton";
            this.rentItemButton.Size = new System.Drawing.Size(92, 23);
            this.rentItemButton.TabIndex = 18;
            this.rentItemButton.Text = "Rent Item";
            this.rentItemButton.UseVisualStyleBackColor = true;
            this.rentItemButton.Click += new System.EventHandler(this.rentItemButton_Click);
            // 
            // memberReportButton
            // 
            this.memberReportButton.Location = new System.Drawing.Point(89, 367);
            this.memberReportButton.Name = "memberReportButton";
            this.memberReportButton.Size = new System.Drawing.Size(123, 23);
            this.memberReportButton.TabIndex = 19;
            this.memberReportButton.Text = "User management";
            this.memberReportButton.UseVisualStyleBackColor = true;
            this.memberReportButton.Click += new System.EventHandler(this.memberReportButton_Click);
            // 
            // cancelEditButton
            // 
            this.cancelEditButton.Location = new System.Drawing.Point(437, 271);
            this.cancelEditButton.Name = "cancelEditButton";
            this.cancelEditButton.Size = new System.Drawing.Size(75, 23);
            this.cancelEditButton.TabIndex = 21;
            this.cancelEditButton.Text = "Cancel";
            this.cancelEditButton.UseVisualStyleBackColor = true;
            // 
            // saveEditButton
            // 
            this.saveEditButton.Location = new System.Drawing.Point(546, 271);
            this.saveEditButton.Name = "saveEditButton";
            this.saveEditButton.Size = new System.Drawing.Size(75, 23);
            this.saveEditButton.TabIndex = 22;
            this.saveEditButton.Text = "Save";
            this.saveEditButton.UseVisualStyleBackColor = true;
            this.saveEditButton.Click += new System.EventHandler(this.saveEditButton_Click);
            // 
            // searchResultLabel
            // 
            this.searchResultLabel.AutoSize = true;
            this.searchResultLabel.Location = new System.Drawing.Point(13, 42);
            this.searchResultLabel.Name = "searchResultLabel";
            this.searchResultLabel.Size = new System.Drawing.Size(90, 15);
            this.searchResultLabel.TabIndex = 23;
            this.searchResultLabel.Text = "Search Result(s)";
            // 
            // ctgryTextBox
            // 
            this.ctgryTextBox.Location = new System.Drawing.Point(237, 9);
            this.ctgryTextBox.Name = "ctgryTextBox";
            this.ctgryTextBox.Size = new System.Drawing.Size(100, 23);
            this.ctgryTextBox.TabIndex = 24;
            // 
            // noSearchResultLabel
            // 
            this.noSearchResultLabel.AutoSize = true;
            this.noSearchResultLabel.Location = new System.Drawing.Point(13, 42);
            this.noSearchResultLabel.Name = "noSearchResultLabel";
            this.noSearchResultLabel.Size = new System.Drawing.Size(58, 15);
            this.noSearchResultLabel.TabIndex = 25;
            this.noSearchResultLabel.Text = "No Result";
            // 
            // avaLabel
            // 
            this.avaLabel.AutoSize = true;
            this.avaLabel.Location = new System.Drawing.Point(237, 42);
            this.avaLabel.Name = "avaLabel";
            this.avaLabel.Size = new System.Drawing.Size(55, 15);
            this.avaLabel.TabIndex = 26;
            this.avaLabel.Text = "Available";
            // 
            // isbnOKLabel
            // 
            this.isbnOKLabel.AutoSize = true;
            this.isbnOKLabel.ForeColor = System.Drawing.Color.Green;
            this.isbnOKLabel.Location = new System.Drawing.Point(546, 103);
            this.isbnOKLabel.Name = "isbnOKLabel";
            this.isbnOKLabel.Size = new System.Drawing.Size(23, 15);
            this.isbnOKLabel.TabIndex = 28;
            this.isbnOKLabel.Text = "OK";
            // 
            // isbnInvalidLabel
            // 
            this.isbnInvalidLabel.AutoSize = true;
            this.isbnInvalidLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.isbnInvalidLabel.Location = new System.Drawing.Point(543, 103);
            this.isbnInvalidLabel.Name = "isbnInvalidLabel";
            this.isbnInvalidLabel.Size = new System.Drawing.Size(42, 15);
            this.isbnInvalidLabel.TabIndex = 29;
            this.isbnInvalidLabel.Text = "Invalid";
            // 
            // titleOKLabel
            // 
            this.titleOKLabel.AutoSize = true;
            this.titleOKLabel.ForeColor = System.Drawing.Color.Green;
            this.titleOKLabel.Location = new System.Drawing.Point(640, 132);
            this.titleOKLabel.Name = "titleOKLabel";
            this.titleOKLabel.Size = new System.Drawing.Size(23, 15);
            this.titleOKLabel.TabIndex = 30;
            this.titleOKLabel.Text = "OK";
            // 
            // yearOKLabel
            // 
            this.yearOKLabel.AutoSize = true;
            this.yearOKLabel.ForeColor = System.Drawing.Color.Green;
            this.yearOKLabel.Location = new System.Drawing.Point(523, 189);
            this.yearOKLabel.Name = "yearOKLabel";
            this.yearOKLabel.Size = new System.Drawing.Size(23, 15);
            this.yearOKLabel.TabIndex = 31;
            this.yearOKLabel.Text = "OK";
            // 
            // categoryOKLabel
            // 
            this.categoryOKLabel.AutoSize = true;
            this.categoryOKLabel.ForeColor = System.Drawing.Color.Green;
            this.categoryOKLabel.Location = new System.Drawing.Point(523, 218);
            this.categoryOKLabel.Name = "categoryOKLabel";
            this.categoryOKLabel.Size = new System.Drawing.Size(23, 15);
            this.categoryOKLabel.TabIndex = 32;
            this.categoryOKLabel.Text = "OK";
            // 
            // authorOKLabel
            // 
            this.authorOKLabel.AutoSize = true;
            this.authorOKLabel.ForeColor = System.Drawing.Color.Green;
            this.authorOKLabel.Location = new System.Drawing.Point(608, 161);
            this.authorOKLabel.Name = "authorOKLabel";
            this.authorOKLabel.Size = new System.Drawing.Size(23, 15);
            this.authorOKLabel.TabIndex = 33;
            this.authorOKLabel.Text = "OK";
            // 
            // titleInvalidLabel
            // 
            this.titleInvalidLabel.AutoSize = true;
            this.titleInvalidLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.titleInvalidLabel.Location = new System.Drawing.Point(640, 132);
            this.titleInvalidLabel.Name = "titleInvalidLabel";
            this.titleInvalidLabel.Size = new System.Drawing.Size(42, 15);
            this.titleInvalidLabel.TabIndex = 34;
            this.titleInvalidLabel.Text = "Invalid";
            // 
            // authorInvalidLabel
            // 
            this.authorInvalidLabel.AutoSize = true;
            this.authorInvalidLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.authorInvalidLabel.Location = new System.Drawing.Point(608, 161);
            this.authorInvalidLabel.Name = "authorInvalidLabel";
            this.authorInvalidLabel.Size = new System.Drawing.Size(42, 15);
            this.authorInvalidLabel.TabIndex = 35;
            this.authorInvalidLabel.Text = "Invalid";

            // 
            // yearInvalidLabel
            // 
            this.yearInvalidLabel.AutoSize = true;
            this.yearInvalidLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.yearInvalidLabel.Location = new System.Drawing.Point(527, 189);
            this.yearInvalidLabel.Name = "yearInvalidLabel";
            this.yearInvalidLabel.Size = new System.Drawing.Size(42, 15);
            this.yearInvalidLabel.TabIndex = 36;
            this.yearInvalidLabel.Text = "Invalid";
            // 
            // categoryInvalidLabel
            // 
            this.categoryInvalidLabel.AutoSize = true;
            this.categoryInvalidLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.categoryInvalidLabel.Location = new System.Drawing.Point(527, 218);
            this.categoryInvalidLabel.Name = "categoryInvalidLabel";
            this.categoryInvalidLabel.Size = new System.Drawing.Size(42, 15);
            this.categoryInvalidLabel.TabIndex = 37;
            this.categoryInvalidLabel.Text = "Invalid";
            // 
            // LibraryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 402);
            this.Controls.Add(this.authorOKLabel);
            this.Controls.Add(this.categoryOKLabel);
            this.Controls.Add(this.yearOKLabel);
            this.Controls.Add(this.titleOKLabel);
            this.Controls.Add(this.isbnOKLabel);
            this.Controls.Add(this.avaLabel);
            this.Controls.Add(this.ctgryTextBox);
            this.Controls.Add(this.searchResultLabel);
            this.Controls.Add(this.saveEditButton);
            this.Controls.Add(this.cancelEditButton);
            this.Controls.Add(this.memberReportButton);
            this.Controls.Add(this.rentItemButton);
            this.Controls.Add(this.deleteItemButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(this.categryLabel);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.isbnTextBox);
            this.Controls.Add(this.isbnLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.itemListBox);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.noSearchResultLabel);
            this.Controls.Add(this.isbnInvalidLabel);
            this.Controls.Add(this.titleInvalidLabel);
            this.Controls.Add(this.authorInvalidLabel);
            this.Controls.Add(this.yearInvalidLabel);
            this.Controls.Add(this.categoryInvalidLabel);
            this.Name = "LibraryManagement";
            this.Text = "LibraryManagement - Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.ListBox itemListBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label isbnLabel;
        private System.Windows.Forms.TextBox isbnTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.Label categryLabel;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button deleteItemButton;
        private System.Windows.Forms.Button rentItemButton;
        private System.Windows.Forms.Button memberReportButton;
        private System.Windows.Forms.Button cancelEditButton;
        private System.Windows.Forms.Button saveEditButton;
        private System.Windows.Forms.Label searchResultLabel;
        private System.Windows.Forms.TextBox ctgryTextBox;
        private System.Windows.Forms.Label noSearchResultLabel;
        private System.Windows.Forms.Label avaLabel;
        private System.Windows.Forms.Label isbnOKLabel;
        private System.Windows.Forms.Label isbnInvalidLabel;
        private System.Windows.Forms.Label titleOKLabel;
        private System.Windows.Forms.Label yearOKLabel;
        private System.Windows.Forms.Label categoryOKLabel;
        private System.Windows.Forms.Label authorOKLabel;
        private System.Windows.Forms.Label titleInvalidLabel;
        private System.Windows.Forms.Label authorInvalidLabel;
        private System.Windows.Forms.Label yearInvalidLabel;
        private System.Windows.Forms.Label categoryInvalidLabel;
    }
}

