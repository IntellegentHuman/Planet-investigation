namespace Planet_Personal_Investigation
{
    partial class Menu
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
            this.StartButton = new System.Windows.Forms.Button();
            this.ReadPathTextBox = new System.Windows.Forms.TextBox();
            this.ReadPathLabel = new System.Windows.Forms.Label();
            this.WriteDirectoryLabel = new System.Windows.Forms.Label();
            this.WriteDirectoyTextBox = new System.Windows.Forms.TextBox();
            this.ExcelFileLabel = new System.Windows.Forms.Label();
            this.ExcelFileTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(585, 108);
            this.StartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(204, 71);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ReadPathTextBox
            // 
            this.ReadPathTextBox.Location = new System.Drawing.Point(89, 12);
            this.ReadPathTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReadPathTextBox.Name = "ReadPathTextBox";
            this.ReadPathTextBox.Size = new System.Drawing.Size(699, 22);
            this.ReadPathTextBox.TabIndex = 1;
            // 
            // ReadPathLabel
            // 
            this.ReadPathLabel.AutoSize = true;
            this.ReadPathLabel.Location = new System.Drawing.Point(12, 15);
            this.ReadPathLabel.Name = "ReadPathLabel";
            this.ReadPathLabel.Size = new System.Drawing.Size(71, 16);
            this.ReadPathLabel.TabIndex = 2;
            this.ReadPathLabel.Text = "Read Path";
            // 
            // WriteDirectoryLabel
            // 
            this.WriteDirectoryLabel.AutoSize = true;
            this.WriteDirectoryLabel.Location = new System.Drawing.Point(12, 46);
            this.WriteDirectoryLabel.Name = "WriteDirectoryLabel";
            this.WriteDirectoryLabel.Size = new System.Drawing.Size(95, 16);
            this.WriteDirectoryLabel.TabIndex = 3;
            this.WriteDirectoryLabel.Text = "Write Directory";
            // 
            // WriteDirectoyTextBox
            // 
            this.WriteDirectoyTextBox.Location = new System.Drawing.Point(113, 43);
            this.WriteDirectoyTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WriteDirectoyTextBox.Name = "WriteDirectoyTextBox";
            this.WriteDirectoyTextBox.Size = new System.Drawing.Size(675, 22);
            this.WriteDirectoyTextBox.TabIndex = 4;
            // 
            // ExcelFileLabel
            // 
            this.ExcelFileLabel.AutoSize = true;
            this.ExcelFileLabel.Location = new System.Drawing.Point(12, 76);
            this.ExcelFileLabel.Name = "ExcelFileLabel";
            this.ExcelFileLabel.Size = new System.Drawing.Size(65, 16);
            this.ExcelFileLabel.TabIndex = 5;
            this.ExcelFileLabel.Text = "Excel File";
            // 
            // ExcelFileTextBox
            // 
            this.ExcelFileTextBox.Location = new System.Drawing.Point(83, 73);
            this.ExcelFileTextBox.Name = "ExcelFileTextBox";
            this.ExcelFileTextBox.Size = new System.Drawing.Size(706, 22);
            this.ExcelFileTextBox.TabIndex = 6;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 193);
            this.Controls.Add(this.ExcelFileTextBox);
            this.Controls.Add(this.ExcelFileLabel);
            this.Controls.Add(this.WriteDirectoyTextBox);
            this.Controls.Add(this.WriteDirectoryLabel);
            this.Controls.Add(this.ReadPathLabel);
            this.Controls.Add(this.ReadPathTextBox);
            this.Controls.Add(this.StartButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox ReadPathTextBox;
        private System.Windows.Forms.Label ReadPathLabel;
        private System.Windows.Forms.Label WriteDirectoryLabel;
        private System.Windows.Forms.TextBox WriteDirectoyTextBox;
        private System.Windows.Forms.Label ExcelFileLabel;
        private System.Windows.Forms.TextBox ExcelFileTextBox;
    }
}