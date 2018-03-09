namespace Birthdate
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
            this.dayofWeekTextBox = new System.Windows.Forms.TextBox();
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.dayofMonthTextBox = new System.Windows.Forms.TextBox();
            this.yeartextbox = new System.Windows.Forms.TextBox();
            this.dayofWeekromptLabel = new System.Windows.Forms.Label();
            this.monthPromptLabel = new System.Windows.Forms.Label();
            this.dayofmonthPromptLabel = new System.Windows.Forms.Label();
            this.yearPromptLabel = new System.Windows.Forms.Label();
            this.dateoutputlabel = new System.Windows.Forms.Label();
            this.showDateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dayofWeekTextBox
            // 
            this.dayofWeekTextBox.Location = new System.Drawing.Point(275, 12);
            this.dayofWeekTextBox.Multiline = true;
            this.dayofWeekTextBox.Name = "dayofWeekTextBox";
            this.dayofWeekTextBox.Size = new System.Drawing.Size(146, 35);
            this.dayofWeekTextBox.TabIndex = 0;
            // 
            // monthTextBox
            // 
            this.monthTextBox.Location = new System.Drawing.Point(275, 57);
            this.monthTextBox.Multiline = true;
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(146, 34);
            this.monthTextBox.TabIndex = 1;
            // 
            // dayofMonthTextBox
            // 
            this.dayofMonthTextBox.Location = new System.Drawing.Point(275, 97);
            this.dayofMonthTextBox.Multiline = true;
            this.dayofMonthTextBox.Name = "dayofMonthTextBox";
            this.dayofMonthTextBox.Size = new System.Drawing.Size(146, 32);
            this.dayofMonthTextBox.TabIndex = 2;
            // 
            // yeartextbox
            // 
            this.yeartextbox.Location = new System.Drawing.Point(275, 135);
            this.yeartextbox.Multiline = true;
            this.yeartextbox.Name = "yeartextbox";
            this.yeartextbox.Size = new System.Drawing.Size(146, 31);
            this.yeartextbox.TabIndex = 3;
            // 
            // dayofWeekromptLabel
            // 
            this.dayofWeekromptLabel.AutoSize = true;
            this.dayofWeekromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dayofWeekromptLabel.Location = new System.Drawing.Point(79, 29);
            this.dayofWeekromptLabel.Name = "dayofWeekromptLabel";
            this.dayofWeekromptLabel.Size = new System.Drawing.Size(174, 18);
            this.dayofWeekromptLabel.TabIndex = 4;
            this.dayofWeekromptLabel.Text = "Enter the day of the week";
            // 
            // monthPromptLabel
            // 
            this.monthPromptLabel.AutoSize = true;
            this.monthPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.monthPromptLabel.Location = new System.Drawing.Point(60, 73);
            this.monthPromptLabel.Name = "monthPromptLabel";
            this.monthPromptLabel.Size = new System.Drawing.Size(195, 18);
            this.monthPromptLabel.TabIndex = 5;
            this.monthPromptLabel.Text = "Enter the name of the month";
            // 
            // dayofmonthPromptLabel
            // 
            this.dayofmonthPromptLabel.AutoSize = true;
            this.dayofmonthPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dayofmonthPromptLabel.Location = new System.Drawing.Point(12, 111);
            this.dayofmonthPromptLabel.Name = "dayofmonthPromptLabel";
            this.dayofmonthPromptLabel.Size = new System.Drawing.Size(241, 18);
            this.dayofmonthPromptLabel.TabIndex = 6;
            this.dayofmonthPromptLabel.Text = "Enter the Numeric day of the month";
            // 
            // yearPromptLabel
            // 
            this.yearPromptLabel.AutoSize = true;
            this.yearPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.yearPromptLabel.Location = new System.Drawing.Point(152, 148);
            this.yearPromptLabel.Name = "yearPromptLabel";
            this.yearPromptLabel.Size = new System.Drawing.Size(101, 18);
            this.yearPromptLabel.TabIndex = 7;
            this.yearPromptLabel.Text = "Enter the Year";
            // 
            // dateoutputlabel
            // 
            this.dateoutputlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateoutputlabel.Location = new System.Drawing.Point(28, 196);
            this.dateoutputlabel.Name = "dateoutputlabel";
            this.dateoutputlabel.Size = new System.Drawing.Size(393, 34);
            this.dateoutputlabel.TabIndex = 8;
            this.dateoutputlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showDateButton
            // 
            this.showDateButton.Location = new System.Drawing.Point(38, 255);
            this.showDateButton.Name = "showDateButton";
            this.showDateButton.Size = new System.Drawing.Size(87, 30);
            this.showDateButton.TabIndex = 9;
            this.showDateButton.Text = "Show Date";
            this.showDateButton.UseVisualStyleBackColor = true;
            this.showDateButton.Click += new System.EventHandler(this.showDateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(168, 255);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(87, 30);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(304, 255);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(87, 30);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 298);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.showDateButton);
            this.Controls.Add(this.dateoutputlabel);
            this.Controls.Add(this.yearPromptLabel);
            this.Controls.Add(this.dayofmonthPromptLabel);
            this.Controls.Add(this.monthPromptLabel);
            this.Controls.Add(this.dayofWeekromptLabel);
            this.Controls.Add(this.yeartextbox);
            this.Controls.Add(this.dayofMonthTextBox);
            this.Controls.Add(this.monthTextBox);
            this.Controls.Add(this.dayofWeekTextBox);
            this.Name = "Form1";
            this.Text = "Birthdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dayofWeekTextBox;
        private System.Windows.Forms.TextBox monthTextBox;
        private System.Windows.Forms.TextBox dayofMonthTextBox;
        private System.Windows.Forms.TextBox yeartextbox;
        private System.Windows.Forms.Label dayofWeekromptLabel;
        private System.Windows.Forms.Label monthPromptLabel;
        private System.Windows.Forms.Label dayofmonthPromptLabel;
        private System.Windows.Forms.Label yearPromptLabel;
        private System.Windows.Forms.Label dateoutputlabel;
        private System.Windows.Forms.Button showDateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

