
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
            this.SuspendLayout();
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(14, 12);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(53, 20);
            this.searchLabel.TabIndex = 0;
            this.searchLabel.Text = "Search";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(70, 12);
            this.searchBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(114, 27);
            this.searchBox.TabIndex = 1;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(201, 12);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(69, 20);
            this.categoryLabel.TabIndex = 2;
            this.categoryLabel.Text = "Category";
            // 
            // itemListBox
            // 
            this.itemListBox.FormattingEnabled = true;
            this.itemListBox.ItemHeight = 20;
            this.itemListBox.Location = new System.Drawing.Point(14, 80);
            this.itemListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.itemListBox.Name = "itemListBox";
            this.itemListBox.Size = new System.Drawing.Size(343, 344);
            this.itemListBox.TabIndex = 27;
            this.itemListBox.SelectedIndexChanged += new System.EventHandler(this.itemListBox_SelectedIndexChanged_1);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(393, 176);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(38, 20);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Title";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(393, 215);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(54, 20);
            this.authorLabel.TabIndex = 6;
            this.authorLabel.Text = "Author";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(393, 252);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(105, 20);
            this.yearLabel.TabIndex = 7;
            this.yearLabel.Text = "Year Published";
            // 
            // isbnLabel
            // 
            this.isbnLabel.AutoSize = true;
            this.isbnLabel.Location = new System.Drawing.Point(393, 137);
            this.isbnLabel.Name = "isbnLabel";
            this.isbnLabel.Size = new System.Drawing.Size(41, 20);
            this.isbnLabel.TabIndex = 8;
            this.isbnLabel.Text = "ISBN";
            // 
            // isbnTextBox
            // 
            this.isbnTextBox.Location = new System.Drawing.Point(499, 133);
            this.isbnTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.isbnTextBox.Name = "isbnTextBox";
            this.isbnTextBox.Size = new System.Drawing.Size(114, 27);
            this.isbnTextBox.TabIndex = 10;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(499, 172);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(269, 27);
            this.titleTextBox.TabIndex = 11;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(499, 248);
            this.yearTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(91, 27);
            this.yearTextBox.TabIndex = 12;
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(499, 211);
            this.authorTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(188, 27);
            this.authorTextBox.TabIndex = 13;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Location = new System.Drawing.Point(499, 287);
            this.categoryTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(91, 27);
            this.categoryTextBox.TabIndex = 15;
            // 
            // categryLabel
            // 
            this.categryLabel.AutoSize = true;
            this.categryLabel.Location = new System.Drawing.Point(393, 291);
            this.categryLabel.Name = "categryLabel";
            this.categryLabel.Size = new System.Drawing.Size(69, 20);
            this.categryLabel.TabIndex = 14;
            this.categryLabel.Text = "Category";
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(15, 435);
            this.addItemButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(99, 31);
            this.addItemButton.TabIndex = 16;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // deleteItemButton
            // 
            this.deleteItemButton.Location = new System.Drawing.Point(330, 489);
            this.deleteItemButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteItemButton.Name = "deleteItemButton";
            this.deleteItemButton.Size = new System.Drawing.Size(99, 31);
            this.deleteItemButton.TabIndex = 17;
            this.deleteItemButton.Text = "Delete Item";
            this.deleteItemButton.UseVisualStyleBackColor = true;
            // 
            // rentItemButton
            // 
            this.rentItemButton.Location = new System.Drawing.Point(201, 435);
            this.rentItemButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rentItemButton.Name = "rentItemButton";
            this.rentItemButton.Size = new System.Drawing.Size(105, 31);
            this.rentItemButton.TabIndex = 18;
            this.rentItemButton.Text = "Rent Item";
            this.rentItemButton.UseVisualStyleBackColor = true;
            // 
            // memberReportButton
            // 
            this.memberReportButton.Location = new System.Drawing.Point(102, 489);
            this.memberReportButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.memberReportButton.Name = "memberReportButton";
            this.memberReportButton.Size = new System.Drawing.Size(141, 31);
            this.memberReportButton.TabIndex = 19;
            this.memberReportButton.Text = "User management";
            this.memberReportButton.UseVisualStyleBackColor = true;
            this.memberReportButton.Click += new System.EventHandler(this.memberReportButton_Click);
            // 
            // cancelEditButton
            // 
            this.cancelEditButton.Location = new System.Drawing.Point(499, 361);
            this.cancelEditButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelEditButton.Name = "cancelEditButton";
            this.cancelEditButton.Size = new System.Drawing.Size(86, 31);
            this.cancelEditButton.TabIndex = 21;
            this.cancelEditButton.Text = "Cancel";
            this.cancelEditButton.UseVisualStyleBackColor = true;
            // 
            // saveEditButton
            // 
            this.saveEditButton.Location = new System.Drawing.Point(624, 361);
            this.saveEditButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveEditButton.Name = "saveEditButton";
            this.saveEditButton.Size = new System.Drawing.Size(86, 31);
            this.saveEditButton.TabIndex = 22;
            this.saveEditButton.Text = "Save";
            this.saveEditButton.UseVisualStyleBackColor = true;
            this.saveEditButton.Click += new System.EventHandler(this.saveEditButton_Click);
            // 
            // searchResultLabel
            // 
            this.searchResultLabel.AutoSize = true;
            this.searchResultLabel.Location = new System.Drawing.Point(15, 56);
            this.searchResultLabel.Name = "searchResultLabel";
            this.searchResultLabel.Size = new System.Drawing.Size(113, 20);
            this.searchResultLabel.TabIndex = 23;
            this.searchResultLabel.Text = "Search Result(s)";
            // 
            // ctgryTextBox
            // 
            this.ctgryTextBox.Location = new System.Drawing.Point(271, 12);
            this.ctgryTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ctgryTextBox.Name = "ctgryTextBox";
            this.ctgryTextBox.Size = new System.Drawing.Size(114, 27);
            this.ctgryTextBox.TabIndex = 24;
            // 
            // noSearchResultLabel
            // 
            this.noSearchResultLabel.AutoSize = true;
            this.noSearchResultLabel.Location = new System.Drawing.Point(15, 56);
            this.noSearchResultLabel.Name = "noSearchResultLabel";
            this.noSearchResultLabel.Size = new System.Drawing.Size(73, 20);
            this.noSearchResultLabel.TabIndex = 25;
            this.noSearchResultLabel.Text = "No Result";
            // 
            // avaLabel
            // 
            this.avaLabel.AutoSize = true;
            this.avaLabel.Location = new System.Drawing.Point(271, 56);
            this.avaLabel.Name = "avaLabel";
            this.avaLabel.Size = new System.Drawing.Size(71, 20);
            this.avaLabel.TabIndex = 26;
            this.avaLabel.Text = "Available";
            // 
            // LibraryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 536);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
    }
}

