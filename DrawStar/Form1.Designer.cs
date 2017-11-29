namespace DrawStar
{
    partial class Form1
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
            this.drawButton = new System.Windows.Forms.Button();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.yCoordinatieTextBox = new System.Windows.Forms.TextBox();
            this.xCoordianatTextBox = new System.Windows.Forms.TextBox();
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(730, 196);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(75, 23);
            this.drawButton.TabIndex = 0;
            this.drawButton.Text = "Draw A Star";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.Location = new System.Drawing.Point(715, 142);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.sizeTextBox.TabIndex = 1;
            // 
            // yCoordinatieTextBox
            // 
            this.yCoordinatieTextBox.Location = new System.Drawing.Point(715, 91);
            this.yCoordinatieTextBox.Name = "yCoordinatieTextBox";
            this.yCoordinatieTextBox.Size = new System.Drawing.Size(100, 20);
            this.yCoordinatieTextBox.TabIndex = 3;
            // 
            // xCoordianatTextBox
            // 
            this.xCoordianatTextBox.Location = new System.Drawing.Point(715, 46);
            this.xCoordianatTextBox.Name = "xCoordianatTextBox";
            this.xCoordianatTextBox.Size = new System.Drawing.Size(100, 20);
            this.xCoordianatTextBox.TabIndex = 4;
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(598, 46);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(67, 13);
            this.xLabel.TabIndex = 5;
            this.xLabel.Text = "X coordinate";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(598, 98);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(67, 13);
            this.yLabel.TabIndex = 6;
            this.yLabel.Text = "Y coordinate";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(598, 145);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(27, 13);
            this.sizeLabel.TabIndex = 7;
            this.sizeLabel.Text = "Size";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 488);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.xCoordianatTextBox);
            this.Controls.Add(this.yCoordinatieTextBox);
            this.Controls.Add(this.sizeTextBox);
            this.Controls.Add(this.drawButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.TextBox sizeTextBox;
        private System.Windows.Forms.TextBox yCoordinatieTextBox;
        private System.Windows.Forms.TextBox xCoordianatTextBox;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label sizeLabel;
    }
}

