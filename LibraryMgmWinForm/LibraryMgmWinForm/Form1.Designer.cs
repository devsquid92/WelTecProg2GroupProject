
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.itemStockLabel = new System.Windows.Forms.Label();
            this.IsbnTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addItemButton = new System.Windows.Forms.Button();
            this.deleteItemButton = new System.Windows.Forms.Button();
            this.rentItemButton = new System.Windows.Forms.Button();
            this.stdnReportButton = new System.Windows.Forms.Button();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(437, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Year Published";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "ISBN";
            // 
            // itemStockLabel
            // 
            this.itemStockLabel.AutoSize = true;
            this.itemStockLabel.Location = new System.Drawing.Point(710, 38);
            this.itemStockLabel.Name = "itemStockLabel";
            this.itemStockLabel.Size = new System.Drawing.Size(36, 15);
            this.itemStockLabel.TabIndex = 9;
            this.itemStockLabel.Text = "Stock";
            // 
            // IsbnTextBox
            // 
            this.IsbnTextBox.Location = new System.Drawing.Point(530, 92);
            this.IsbnTextBox.Name = "IsbnTextBox";
            this.IsbnTextBox.Size = new System.Drawing.Size(100, 23);
            this.IsbnTextBox.TabIndex = 10;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(530, 121);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(236, 23);
            this.titleTextBox.TabIndex = 11;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(530, 178);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(80, 23);
            this.yearTextBox.TabIndex = 12;
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(530, 150);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(165, 23);
            this.authorTextBox.TabIndex = 13;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Location = new System.Drawing.Point(530, 207);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(80, 23);
            this.categoryTextBox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(437, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Category";
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
            this.deleteItemButton.Location = new System.Drawing.Point(518, 12);
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
            // stdnReportButton
            // 
            this.stdnReportButton.Location = new System.Drawing.Point(70, 368);
            this.stdnReportButton.Name = "stdnReportButton";
            this.stdnReportButton.Size = new System.Drawing.Size(123, 23);
            this.stdnReportButton.TabIndex = 19;
            this.stdnReportButton.Text = "Student Report";
            this.stdnReportButton.UseVisualStyleBackColor = true;
            // 
            // cancelEditButton
            // 
            this.cancelEditButton.Location = new System.Drawing.Point(530, 263);
            this.cancelEditButton.Name = "cancelEditButton";
            this.cancelEditButton.Size = new System.Drawing.Size(75, 23);
            this.cancelEditButton.TabIndex = 21;
            this.cancelEditButton.Text = "Cancel";
            this.cancelEditButton.UseVisualStyleBackColor = true;
            // 
            // saveEditButton
            // 
            this.saveEditButton.Location = new System.Drawing.Point(639, 263);
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
            this.ClientSize = new System.Drawing.Size(790, 404);
            this.Controls.Add(this.ctgryTextBox);
            this.Controls.Add(this.searchResultLabel);
            this.Controls.Add(this.saveEditButton);
            this.Controls.Add(this.cancelEditButton);
            this.Controls.Add(this.stdnReportButton);
            this.Controls.Add(this.rentItemButton);
            this.Controls.Add(this.deleteItemButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.IsbnTextBox);
            this.Controls.Add(this.itemStockLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemListBox);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.searchLabel);
            this.Name = "Form1";
            this.Text = "LibraryManagement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.ListBox itemListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label itemStockLabel;
        private System.Windows.Forms.TextBox IsbnTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button deleteItemButton;
        private System.Windows.Forms.Button rentItemButton;
        private System.Windows.Forms.Button stdnReportButton;
        private System.Windows.Forms.Button cancelEditButton;
        private System.Windows.Forms.Button saveEditButton;
        private System.Windows.Forms.Label searchResultLabel;
        private System.Windows.Forms.TextBox ctgryTextBox;
    }
}

