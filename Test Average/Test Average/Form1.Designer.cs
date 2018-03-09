namespace Test_Average
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
            this.calcualteButton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.test1TextBox = new System.Windows.Forms.TextBox();
            this.test2TextBox = new System.Windows.Forms.TextBox();
            this.test3TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calcualteButton
            // 
            this.calcualteButton.Location = new System.Drawing.Point(12, 237);
            this.calcualteButton.Name = "calcualteButton";
            this.calcualteButton.Size = new System.Drawing.Size(70, 36);
            this.calcualteButton.TabIndex = 0;
            this.calcualteButton.Text = "Calculate Average";
            this.calcualteButton.UseVisualStyleBackColor = true;
            this.calcualteButton.Click += new System.EventHandler(this.calcualteButton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(100, 237);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(70, 36);
            this.clearbutton.TabIndex = 1;
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(187, 237);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(70, 36);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Test 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Test 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Test 3:";
            // 
            // averageLabel
            // 
            this.averageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageLabel.Location = new System.Drawing.Point(152, 154);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(105, 29);
            this.averageLabel.TabIndex = 6;
            this.averageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // test1TextBox
            // 
            this.test1TextBox.Location = new System.Drawing.Point(136, 20);
            this.test1TextBox.Name = "test1TextBox";
            this.test1TextBox.Size = new System.Drawing.Size(121, 20);
            this.test1TextBox.TabIndex = 7;
            // 
            // test2TextBox
            // 
            this.test2TextBox.Location = new System.Drawing.Point(136, 61);
            this.test2TextBox.Name = "test2TextBox";
            this.test2TextBox.Size = new System.Drawing.Size(121, 20);
            this.test2TextBox.TabIndex = 8;
            // 
            // test3TextBox
            // 
            this.test3TextBox.Location = new System.Drawing.Point(136, 102);
            this.test3TextBox.Name = "test3TextBox";
            this.test3TextBox.Size = new System.Drawing.Size(121, 20);
            this.test3TextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Average Test Score";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 290);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.test3TextBox);
            this.Controls.Add(this.test2TextBox);
            this.Controls.Add(this.test1TextBox);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.calcualteButton);
            this.Name = "Form1";
            this.Text = "Test Average";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcualteButton;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.TextBox test1TextBox;
        private System.Windows.Forms.TextBox test2TextBox;
        private System.Windows.Forms.TextBox test3TextBox;
        private System.Windows.Forms.Label label5;
    }
}

