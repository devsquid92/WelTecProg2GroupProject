
namespace LibraryMgmWinForm
{
    partial class addNewItem
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
            this.addNewItemLabel = new System.Windows.Forms.Label();
            this.addNewItemTextBox = new System.Windows.Forms.TextBox();
            this.addNewItemCancelBtn = new System.Windows.Forms.Button();
            this.addNewItemOkBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addNewItemLabel
            // 
            this.addNewItemLabel.AutoSize = true;
            this.addNewItemLabel.Location = new System.Drawing.Point(13, 43);
            this.addNewItemLabel.Name = "addNewItemLabel";
            this.addNewItemLabel.Size = new System.Drawing.Size(220, 20);
            this.addNewItemLabel.TabIndex = 0;
            this.addNewItemLabel.Text = "Enter the name of the new item:";
            // 
            // addNewItemTextBox
            // 
            this.addNewItemTextBox.Location = new System.Drawing.Point(239, 36);
            this.addNewItemTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addNewItemTextBox.Name = "addNewItemTextBox";
            this.addNewItemTextBox.Size = new System.Drawing.Size(258, 27);
            this.addNewItemTextBox.TabIndex = 1;
            // 
            // addNewItemCancelBtn
            // 
            this.addNewItemCancelBtn.Location = new System.Drawing.Point(128, 104);
            this.addNewItemCancelBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addNewItemCancelBtn.Name = "addNewItemCancelBtn";
            this.addNewItemCancelBtn.Size = new System.Drawing.Size(86, 31);
            this.addNewItemCancelBtn.TabIndex = 2;
            this.addNewItemCancelBtn.Text = "Cancel";
            this.addNewItemCancelBtn.UseVisualStyleBackColor = true;
            this.addNewItemCancelBtn.Click += new System.EventHandler(this.addNewItemCancelBtn_Click);
            // 
            // addNewItemOkBtn
            // 
            this.addNewItemOkBtn.Location = new System.Drawing.Point(305, 104);
            this.addNewItemOkBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addNewItemOkBtn.Name = "addNewItemOkBtn";
            this.addNewItemOkBtn.Size = new System.Drawing.Size(86, 31);
            this.addNewItemOkBtn.TabIndex = 3;
            this.addNewItemOkBtn.Text = "OK";
            this.addNewItemOkBtn.UseVisualStyleBackColor = true;
            this.addNewItemOkBtn.Click += new System.EventHandler(this.addNewItemOkBtn_Click);
            // 
            // addNewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 175);
            this.Controls.Add(this.addNewItemOkBtn);
            this.Controls.Add(this.addNewItemCancelBtn);
            this.Controls.Add(this.addNewItemTextBox);
            this.Controls.Add(this.addNewItemLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "addNewItem";
            this.Text = "addNewItem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addNewItemLabel;
        private System.Windows.Forms.TextBox addNewItemTextBox;
        private System.Windows.Forms.Button addNewItemCancelBtn;
        private System.Windows.Forms.Button addNewItemOkBtn;
    }
}