namespace Sale_Price_Calculator
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.discPercentagePromptTextBox = new System.Windows.Forms.TextBox();
            this.originalPricePromptTextbox = new System.Windows.Forms.TextBox();
            this.salePriceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(67, 221);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(80, 44);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate Sale Price";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(185, 221);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(80, 44);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter the item\'s original price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter the discount percentage:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sale Price:";
            // 
            // discPercentagePromptTextBox
            // 
            this.discPercentagePromptTextBox.Location = new System.Drawing.Point(197, 71);
            this.discPercentagePromptTextBox.Multiline = true;
            this.discPercentagePromptTextBox.Name = "discPercentagePromptTextBox";
            this.discPercentagePromptTextBox.Size = new System.Drawing.Size(120, 34);
            this.discPercentagePromptTextBox.TabIndex = 5;
            // 
            // originalPricePromptTextbox
            // 
            this.originalPricePromptTextbox.Location = new System.Drawing.Point(197, 24);
            this.originalPricePromptTextbox.Multiline = true;
            this.originalPricePromptTextbox.Name = "originalPricePromptTextbox";
            this.originalPricePromptTextbox.Size = new System.Drawing.Size(120, 34);
            this.originalPricePromptTextbox.TabIndex = 6;
            // 
            // salePriceLabel
            // 
            this.salePriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salePriceLabel.Location = new System.Drawing.Point(197, 151);
            this.salePriceLabel.Name = "salePriceLabel";
            this.salePriceLabel.Size = new System.Drawing.Size(120, 32);
            this.salePriceLabel.TabIndex = 7;
            this.salePriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 284);
            this.Controls.Add(this.salePriceLabel);
            this.Controls.Add(this.originalPricePromptTextbox);
            this.Controls.Add(this.discPercentagePromptTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Name = "Form1";
            this.Text = "Sale Price Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox discPercentagePromptTextBox;
        private System.Windows.Forms.TextBox originalPricePromptTextbox;
        private System.Windows.Forms.Label salePriceLabel;
    }
}

