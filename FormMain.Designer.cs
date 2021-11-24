
namespace JoystickApp
{
    partial class FormMain
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
            this.detectedItemsListBox = new System.Windows.Forms.ListBox();
            this.testControllerButton = new System.Windows.Forms.Button();
            this.emulateMouseButton = new System.Windows.Forms.Button();
            this.turnOnGraphicalInterfaceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // detectedItemsListBox
            // 
            this.detectedItemsListBox.FormattingEnabled = true;
            this.detectedItemsListBox.ItemHeight = 15;
            this.detectedItemsListBox.Location = new System.Drawing.Point(10, 76);
            this.detectedItemsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.detectedItemsListBox.Name = "detectedItemsListBox";
            this.detectedItemsListBox.Size = new System.Drawing.Size(321, 169);
            this.detectedItemsListBox.TabIndex = 0;
            this.detectedItemsListBox.SelectedIndexChanged += new System.EventHandler(this.detectedItemsListBox_SelectedIndexChanged);
            // 
            // testControllerButton
            // 
            this.testControllerButton.Location = new System.Drawing.Point(336, 76);
            this.testControllerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.testControllerButton.Name = "testControllerButton";
            this.testControllerButton.Size = new System.Drawing.Size(285, 46);
            this.testControllerButton.TabIndex = 1;
            this.testControllerButton.Text = "Testuj komponent";
            this.testControllerButton.UseVisualStyleBackColor = true;
            this.testControllerButton.Click += new System.EventHandler(this.testControllerButton_Click);
            // 
            // emulateMouseButton
            // 
            this.emulateMouseButton.Location = new System.Drawing.Point(336, 136);
            this.emulateMouseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emulateMouseButton.Name = "emulateMouseButton";
            this.emulateMouseButton.Size = new System.Drawing.Size(285, 46);
            this.emulateMouseButton.TabIndex = 2;
            this.emulateMouseButton.Text = "Włącz emulację myszki";
            this.emulateMouseButton.UseVisualStyleBackColor = true;
            // 
            // turnOnGraphicalInterfaceButton
            // 
            this.turnOnGraphicalInterfaceButton.Location = new System.Drawing.Point(336, 198);
            this.turnOnGraphicalInterfaceButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.turnOnGraphicalInterfaceButton.Name = "turnOnGraphicalInterfaceButton";
            this.turnOnGraphicalInterfaceButton.Size = new System.Drawing.Size(285, 46);
            this.turnOnGraphicalInterfaceButton.TabIndex = 3;
            this.turnOnGraphicalInterfaceButton.Text = "Włącz edytor graficzny";
            this.turnOnGraphicalInterfaceButton.UseVisualStyleBackColor = true;
            this.turnOnGraphicalInterfaceButton.Click += new System.EventHandler(this.turnOnGraphicalInterfaceButton_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.turnOnGraphicalInterfaceButton);
            this.Controls.Add(this.emulateMouseButton);
            this.Controls.Add(this.testControllerButton);
            this.Controls.Add(this.detectedItemsListBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Text = "Menu ";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox detectedItemsListBox;
        private System.Windows.Forms.Button testControllerButton;
        private System.Windows.Forms.Button emulateMouseButton;
        private System.Windows.Forms.Button turnOnGraphicalInterfaceButton;
    }
}

