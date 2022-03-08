namespace Planet_Personal_Investigation
{
    partial class Main
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
            this.canvas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.Black;
            this.canvas.Location = new System.Drawing.Point(0, 0);
            this.canvas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(2194, 1329);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.CanvasPaint);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 554);
            this.Controls.Add(this.canvas);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
    }
}

