
namespace LibraryMgmWinForm
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ctgryTextBox = new System.Windows.Forms.TextBox();
            this.rentResultLabel = new System.Windows.Forms.Label();
            this.confirmRentButton = new System.Windows.Forms.Button();
            this.userListBox = new System.Windows.Forms.ListBox();
            this.filterRentLabel = new System.Windows.Forms.Label();
            this.searchRentBox = new System.Windows.Forms.TextBox();
            this.searchRentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctgryTextBox
            // 
            this.ctgryTextBox.Location = new System.Drawing.Point(215, 5);
            this.ctgryTextBox.Name = "ctgryTextBox";
            this.ctgryTextBox.Size = new System.Drawing.Size(100, 23);
            this.ctgryTextBox.TabIndex = 34;
            // 
            // rentResultLabel
            // 
            this.rentResultLabel.AutoSize = true;
            this.rentResultLabel.Location = new System.Drawing.Point(13, 38);
            this.rentResultLabel.Name = "rentResultLabel";
            this.rentResultLabel.Size = new System.Drawing.Size(90, 15);
            this.rentResultLabel.TabIndex = 33;
            this.rentResultLabel.Text = "Search Result(s)";
            // 
            // confirmRentButton
            // 
            this.confirmRentButton.Location = new System.Drawing.Point(96, 321);
            this.confirmRentButton.Name = "confirmRentButton";
            this.confirmRentButton.Size = new System.Drawing.Size(92, 23);
            this.confirmRentButton.TabIndex = 31;
            this.confirmRentButton.Text = "Confirm";
            this.confirmRentButton.UseVisualStyleBackColor = true;
            this.confirmRentButton.Click += new System.EventHandler(this.confirmRentButton_Click);
            // 
            // userListBox
            // 
            this.userListBox.FormattingEnabled = true;
            this.userListBox.ItemHeight = 15;
            this.userListBox.Location = new System.Drawing.Point(12, 56);
            this.userListBox.Name = "userListBox";
            this.userListBox.Size = new System.Drawing.Size(301, 259);
            this.userListBox.TabIndex = 28;
            this.userListBox.SelectedIndexChanged += new System.EventHandler(this.userListBox_SelectedIndexChanged);
            // 
            // filterRentLabel
            // 
            this.filterRentLabel.AutoSize = true;
            this.filterRentLabel.Location = new System.Drawing.Point(176, 5);
            this.filterRentLabel.Name = "filterRentLabel";
            this.filterRentLabel.Size = new System.Drawing.Size(33, 15);
            this.filterRentLabel.TabIndex = 27;
            this.filterRentLabel.Text = "Filter";
            // 
            // searchRentBox
            // 
            this.searchRentBox.Location = new System.Drawing.Point(61, 5);
            this.searchRentBox.Name = "searchRentBox";
            this.searchRentBox.Size = new System.Drawing.Size(100, 23);
            this.searchRentBox.TabIndex = 26;
            // 
            // searchRentLabel
            // 
            this.searchRentLabel.AutoSize = true;
            this.searchRentLabel.Location = new System.Drawing.Point(12, 5);
            this.searchRentLabel.Name = "searchRentLabel";
            this.searchRentLabel.Size = new System.Drawing.Size(42, 15);
            this.searchRentLabel.TabIndex = 25;
            this.searchRentLabel.Text = "Search";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 353);
            this.Controls.Add(this.ctgryTextBox);
            this.Controls.Add(this.rentResultLabel);
            this.Controls.Add(this.confirmRentButton);
            this.Controls.Add(this.userListBox);
            this.Controls.Add(this.filterRentLabel);
            this.Controls.Add(this.searchRentBox);
            this.Controls.Add(this.searchRentLabel);
            this.Name = "Form2";
            this.Text = "Issue Item";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox ctgryTextBox;
        private System.Windows.Forms.Label rentResultLabel;
        private System.Windows.Forms.Button confirmRentButton;
        private System.Windows.Forms.ListBox userListBox;
        private System.Windows.Forms.Label filterRentLabel;
        private System.Windows.Forms.TextBox searchRentBox;
        private System.Windows.Forms.Label searchRentLabel;
    }
}