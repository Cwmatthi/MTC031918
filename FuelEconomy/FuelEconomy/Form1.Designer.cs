namespace FuelEconomy
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
            this.milesPromptLabel = new System.Windows.Forms.Label();
            this.gallonsPromptLabel = new System.Windows.Forms.Label();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.milesTextBox = new System.Windows.Forms.TextBox();
            this.gallonsTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.mpgLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // milesPromptLabel
            // 
            this.milesPromptLabel.AutoSize = true;
            this.milesPromptLabel.Location = new System.Drawing.Point(-1, 15);
            this.milesPromptLabel.Name = "milesPromptLabel";
            this.milesPromptLabel.Size = new System.Drawing.Size(163, 13);
            this.milesPromptLabel.TabIndex = 0;
            this.milesPromptLabel.Text = "Enter the Number of miles driven:";
            // 
            // gallonsPromptLabel
            // 
            this.gallonsPromptLabel.AutoSize = true;
            this.gallonsPromptLabel.Location = new System.Drawing.Point(11, 52);
            this.gallonsPromptLabel.Name = "gallonsPromptLabel";
            this.gallonsPromptLabel.Size = new System.Drawing.Size(147, 13);
            this.gallonsPromptLabel.TabIndex = 1;
            this.gallonsPromptLabel.Text = "Enter the gallons of gas used:";
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(74, 97);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(84, 13);
            this.outputDescriptionLabel.TabIndex = 2;
            this.outputDescriptionLabel.Text = "Your car\'s MPG:";
            // 
            // milesTextBox
            // 
            this.milesTextBox.Location = new System.Drawing.Point(168, 12);
            this.milesTextBox.Multiline = true;
            this.milesTextBox.Name = "milesTextBox";
            this.milesTextBox.Size = new System.Drawing.Size(144, 26);
            this.milesTextBox.TabIndex = 3;
            // 
            // gallonsTextBox
            // 
            this.gallonsTextBox.Location = new System.Drawing.Point(168, 49);
            this.gallonsTextBox.Multiline = true;
            this.gallonsTextBox.Name = "gallonsTextBox";
            this.gallonsTextBox.Size = new System.Drawing.Size(144, 27);
            this.gallonsTextBox.TabIndex = 4;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(85, 151);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(73, 34);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate MPG";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(177, 151);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(73, 34);
            this.exitbutton.TabIndex = 7;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // mpgLabel
            // 
            this.mpgLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mpgLabel.Location = new System.Drawing.Point(168, 91);
            this.mpgLabel.Name = "mpgLabel";
            this.mpgLabel.Size = new System.Drawing.Size(144, 25);
            this.mpgLabel.TabIndex = 8;
            this.mpgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 203);
            this.Controls.Add(this.mpgLabel);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.gallonsTextBox);
            this.Controls.Add(this.milesTextBox);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.gallonsPromptLabel);
            this.Controls.Add(this.milesPromptLabel);
            this.Name = "Form1";
            this.Text = "Fuel Economy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label milesPromptLabel;
        private System.Windows.Forms.Label gallonsPromptLabel;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.TextBox milesTextBox;
        private System.Windows.Forms.TextBox gallonsTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Label mpgLabel;
    }
}

