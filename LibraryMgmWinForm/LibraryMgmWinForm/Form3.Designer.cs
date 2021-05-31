
namespace LibraryMgmWinForm
{
    partial class Form3
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
            this.stdntReportFilterTextBox = new System.Windows.Forms.TextBox();
            this.rentResultLabel = new System.Windows.Forms.Label();
            this.viewStdntButton = new System.Windows.Forms.Button();
            this.studntReportListBox = new System.Windows.Forms.ListBox();
            this.filterStdntLabel = new System.Windows.Forms.Label();
            this.searchStdntReport = new System.Windows.Forms.TextBox();
            this.searchStdntLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stdntReportFilterTextBox
            // 
            this.stdntReportFilterTextBox.Location = new System.Drawing.Point(215, 10);
            this.stdntReportFilterTextBox.Name = "stdntReportFilterTextBox";
            this.stdntReportFilterTextBox.Size = new System.Drawing.Size(100, 23);
            this.stdntReportFilterTextBox.TabIndex = 41;
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
            // viewStdntButton
            // 
            this.viewStdntButton.Location = new System.Drawing.Point(96, 326);
            this.viewStdntButton.Name = "viewStdntButton";
            this.viewStdntButton.Size = new System.Drawing.Size(92, 23);
            this.viewStdntButton.TabIndex = 39;
            this.viewStdntButton.Text = "View";
            this.viewStdntButton.UseVisualStyleBackColor = true;
            // 
            // studntReportListBox
            // 
            this.studntReportListBox.FormattingEnabled = true;
            this.studntReportListBox.ItemHeight = 15;
            this.studntReportListBox.Location = new System.Drawing.Point(12, 61);
            this.studntReportListBox.Name = "studntReportListBox";
            this.studntReportListBox.Size = new System.Drawing.Size(301, 259);
            this.studntReportListBox.TabIndex = 38;
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
            // searchStdntReport
            // 
            this.searchStdntReport.Location = new System.Drawing.Point(61, 10);
            this.searchStdntReport.Name = "searchStdntReport";
            this.searchStdntReport.Size = new System.Drawing.Size(100, 23);
            this.searchStdntReport.TabIndex = 36;
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
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 358);
            this.Controls.Add(this.stdntReportFilterTextBox);
            this.Controls.Add(this.rentResultLabel);
            this.Controls.Add(this.viewStdntButton);
            this.Controls.Add(this.studntReportListBox);
            this.Controls.Add(this.filterStdntLabel);
            this.Controls.Add(this.searchStdntReport);
            this.Controls.Add(this.searchStdntLabel);
            this.Name = "Form3";
            this.Text = "Student Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox stdntReportFilterTextBox;
        private System.Windows.Forms.Label rentResultLabel;
        private System.Windows.Forms.Button viewStdntButton;
        private System.Windows.Forms.ListBox studntReportListBox;
        private System.Windows.Forms.Label filterStdntLabel;
        private System.Windows.Forms.TextBox searchStdntReport;
        private System.Windows.Forms.Label searchStdntLabel;
    }
}