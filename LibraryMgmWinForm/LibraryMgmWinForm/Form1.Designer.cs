
namespace LibraryMgmWinForm
{
    partial class Form1
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
            this.itemStockLabel = new System.Windows.Forms.Label();
            this.IsbnTextBox = new System.Windows.Forms.TextBox();
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
            this.itemListBox.TabIndex = 4;
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
            // itemStockLabel
            // 
            this.itemStockLabel.AutoSize = true;
            this.itemStockLabel.Location = new System.Drawing.Point(617, 46);
            this.itemStockLabel.Name = "itemStockLabel";
            this.itemStockLabel.Size = new System.Drawing.Size(36, 15);
            this.itemStockLabel.TabIndex = 9;
            this.itemStockLabel.Text = "Stock";
            // 
            // IsbnTextBox
            // 
            this.IsbnTextBox.Location = new System.Drawing.Point(437, 100);
            this.IsbnTextBox.Name = "IsbnTextBox";
            this.IsbnTextBox.Size = new System.Drawing.Size(100, 23);
            this.IsbnTextBox.TabIndex = 10;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(437, 129);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(236, 23);
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
            // 
            // deleteItemButton
            // 
            this.deleteItemButton.Location = new System.Drawing.Point(425, 20);
            this.deleteItemButton.Name = "deleteItemButton";
            this.deleteItemButton.Size = new System.Drawing.Size(87, 23);
            this.deleteItemButton.TabIndex = 17;
            this.deleteItemButton.Text = "Delete Item";
            this.deleteItemButton.UseVisualStyleBackColor = true;
            // 
            // rentItemButton
            // 
            this.rentItemButton.Location = new System.Drawing.Point(176, 326);
            this.rentItemButton.Name = "rentItemButton";
            this.rentItemButton.Size = new System.Drawing.Size(92, 23);
            this.rentItemButton.TabIndex = 18;
            this.rentItemButton.Text = "Rent Item";
            this.rentItemButton.UseVisualStyleBackColor = true;
            // 
            // memberReportButton
            // 
            this.memberReportButton.Location = new System.Drawing.Point(70, 368);
            this.memberReportButton.Name = "memberReportButton";
            this.memberReportButton.Size = new System.Drawing.Size(109, 23);
            this.memberReportButton.TabIndex = 19;
            this.memberReportButton.Text = "User Report";
            this.memberReportButton.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 402);
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
            this.Controls.Add(this.IsbnTextBox);
            this.Controls.Add(this.itemStockLabel);
            this.Controls.Add(this.isbnLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.itemListBox);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.searchLabel);
            this.Name = "Form1";
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
        private System.Windows.Forms.Label itemStockLabel;
        private System.Windows.Forms.TextBox IsbnTextBox;
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
    }
}

