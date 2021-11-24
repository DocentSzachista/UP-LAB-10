
namespace JoystickApp
{
    partial class Paint
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
            this.whiteBoard = new System.Windows.Forms.Panel();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.red = new System.Windows.Forms.PictureBox();
            this.green = new System.Windows.Forms.PictureBox();
            this.whiteBoard.SuspendLayout();
            this.colorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green)).BeginInit();
            this.SuspendLayout();
            // 
            // whiteBoard
            // 
            this.whiteBoard.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.whiteBoard.Controls.Add(this.colorPanel);
            this.whiteBoard.Location = new System.Drawing.Point(12, 12);
            this.whiteBoard.Name = "whiteBoard";
            this.whiteBoard.Size = new System.Drawing.Size(709, 393);
            this.whiteBoard.TabIndex = 0;
            this.whiteBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.whiteBoard_Paint);
            this.whiteBoard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.whiteBoard_MouseDown);
            this.whiteBoard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.whiteBoard_MouseMove);
            this.whiteBoard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.whiteBoard_MouseUp);
            // 
            // colorPanel
            // 
            this.colorPanel.Controls.Add(this.green);
            this.colorPanel.Controls.Add(this.red);
            this.colorPanel.Location = new System.Drawing.Point(526, 3);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(165, 42);
            this.colorPanel.TabIndex = 0;
            // 
            // Red
            // 
            this.red.BackColor = System.Drawing.Color.Red;
            this.red.Location = new System.Drawing.Point(4, 4);
            this.red.Name = "Red";
            this.red.Size = new System.Drawing.Size(34, 35);
            this.red.TabIndex = 0;
            this.red.TabStop = false;
            this.red.Click += new System.EventHandler(this.Red_Click);
            // 
            // green
            // 
            this.green.BackColor = System.Drawing.Color.LawnGreen;
            this.green.Location = new System.Drawing.Point(44, 4);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(34, 35);
            this.green.TabIndex = 1;
            this.green.TabStop = false;
            this.green.Click += new System.EventHandler(this.green_Click);
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 417);
            this.Controls.Add(this.whiteBoard);
            this.Name = "Paint";
            this.Text = "Paint";
            this.whiteBoard.ResumeLayout(false);
            this.colorPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.green)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel whiteBoard;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.PictureBox red;
        private System.Windows.Forms.PictureBox green;
    }
}