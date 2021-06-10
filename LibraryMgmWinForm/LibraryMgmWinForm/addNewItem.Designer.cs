
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
            this.addNewItemLabel.Location = new System.Drawing.Point(11, 32);
            this.addNewItemLabel.Name = "addNewItemLabel";
            this.addNewItemLabel.Size = new System.Drawing.Size(176, 15);
            this.addNewItemLabel.TabIndex = 0;
            this.addNewItemLabel.Text = "Enter the name of the new item:";
            // 
            // addNewItemTextBox
            // 
            this.addNewItemTextBox.Location = new System.Drawing.Point(209, 27);
            this.addNewItemTextBox.Name = "addNewItemTextBox";
            this.addNewItemTextBox.Size = new System.Drawing.Size(226, 23);
            this.addNewItemTextBox.TabIndex = 1;
            this.addNewItemTextBox.TextChanged += new System.EventHandler(this.addNewItemTextBox_TextChanged);
            // 
            // addNewItemCancelBtn
            // 
            this.addNewItemCancelBtn.Location = new System.Drawing.Point(112, 78);
            this.addNewItemCancelBtn.Name = "addNewItemCancelBtn";
            this.addNewItemCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.addNewItemCancelBtn.TabIndex = 2;
            this.addNewItemCancelBtn.Text = "Cancel";
            this.addNewItemCancelBtn.UseVisualStyleBackColor = true;
            this.addNewItemCancelBtn.Click += new System.EventHandler(this.addNewItemCancelBtn_Click);
            // 
            // addNewItemOkBtn
            // 
            this.addNewItemOkBtn.Location = new System.Drawing.Point(267, 78);
            this.addNewItemOkBtn.Name = "addNewItemOkBtn";
            this.addNewItemOkBtn.Size = new System.Drawing.Size(75, 23);
            this.addNewItemOkBtn.TabIndex = 3;
            this.addNewItemOkBtn.Text = "OK";
            this.addNewItemOkBtn.UseVisualStyleBackColor = true;
            this.addNewItemOkBtn.Click += new System.EventHandler(this.addNewItemOkBtn_Click);
            // 
            // addNewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 131);
            this.Controls.Add(this.addNewItemOkBtn);
            this.Controls.Add(this.addNewItemCancelBtn);
            this.Controls.Add(this.addNewItemTextBox);
            this.Controls.Add(this.addNewItemLabel);
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