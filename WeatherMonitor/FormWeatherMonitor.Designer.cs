namespace WeatherMonitor
{
    partial class FormWeatherMonitor
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
            this.WindNowTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WindMaxTextBox = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.WindAvgTextBox = new System.Windows.Forms.TextBox();
            this.WindGroupBox = new System.Windows.Forms.GroupBox();
            this.CloudGroupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CloudMaxTextBox = new System.Windows.Forms.TextBox();
            this.CloudAvgTextBox = new System.Windows.Forms.TextBox();
            this.CloudNowTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RainGroupBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.RainMaxTextBox = new System.Windows.Forms.TextBox();
            this.RainAvgTextBox = new System.Windows.Forms.TextBox();
            this.RainNowTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.SinceDateTimeBox = new System.Windows.Forms.TextBox();
            this.WindGroupBox.SuspendLayout();
            this.CloudGroupBox.SuspendLayout();
            this.RainGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // WindNowTextBox
            // 
            this.WindNowTextBox.Location = new System.Drawing.Point(64, 19);
            this.WindNowTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.WindNowTextBox.Name = "WindNowTextBox";
            this.WindNowTextBox.Size = new System.Drawing.Size(57, 20);
            this.WindNowTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Maximum";
            // 
            // WindMaxTextBox
            // 
            this.WindMaxTextBox.Location = new System.Drawing.Point(64, 44);
            this.WindMaxTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.WindMaxTextBox.Name = "WindMaxTextBox";
            this.WindMaxTextBox.Size = new System.Drawing.Size(57, 20);
            this.WindMaxTextBox.TabIndex = 2;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(71, 348);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(62, 27);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Average";
            // 
            // WindAvgTextBox
            // 
            this.WindAvgTextBox.Location = new System.Drawing.Point(64, 70);
            this.WindAvgTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.WindAvgTextBox.Name = "WindAvgTextBox";
            this.WindAvgTextBox.Size = new System.Drawing.Size(57, 20);
            this.WindAvgTextBox.TabIndex = 5;
            // 
            // WindGroupBox
            // 
            this.WindGroupBox.Controls.Add(this.label3);
            this.WindGroupBox.Controls.Add(this.WindMaxTextBox);
            this.WindGroupBox.Controls.Add(this.WindAvgTextBox);
            this.WindGroupBox.Controls.Add(this.WindNowTextBox);
            this.WindGroupBox.Controls.Add(this.label1);
            this.WindGroupBox.Controls.Add(this.label2);
            this.WindGroupBox.ForeColor = System.Drawing.Color.White;
            this.WindGroupBox.Location = new System.Drawing.Point(7, 3);
            this.WindGroupBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.WindGroupBox.Name = "WindGroupBox";
            this.WindGroupBox.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.WindGroupBox.Size = new System.Drawing.Size(128, 97);
            this.WindGroupBox.TabIndex = 7;
            this.WindGroupBox.TabStop = false;
            this.WindGroupBox.Text = "Wind";
            // 
            // CloudGroupBox
            // 
            this.CloudGroupBox.Controls.Add(this.label4);
            this.CloudGroupBox.Controls.Add(this.CloudMaxTextBox);
            this.CloudGroupBox.Controls.Add(this.CloudAvgTextBox);
            this.CloudGroupBox.Controls.Add(this.CloudNowTextBox);
            this.CloudGroupBox.Controls.Add(this.label5);
            this.CloudGroupBox.Controls.Add(this.label6);
            this.CloudGroupBox.ForeColor = System.Drawing.Color.White;
            this.CloudGroupBox.Location = new System.Drawing.Point(7, 106);
            this.CloudGroupBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CloudGroupBox.Name = "CloudGroupBox";
            this.CloudGroupBox.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CloudGroupBox.Size = new System.Drawing.Size(128, 100);
            this.CloudGroupBox.TabIndex = 8;
            this.CloudGroupBox.TabStop = false;
            this.CloudGroupBox.Text = "Clouds";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Average";
            // 
            // CloudMaxTextBox
            // 
            this.CloudMaxTextBox.Location = new System.Drawing.Point(64, 46);
            this.CloudMaxTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CloudMaxTextBox.Name = "CloudMaxTextBox";
            this.CloudMaxTextBox.Size = new System.Drawing.Size(57, 20);
            this.CloudMaxTextBox.TabIndex = 2;
            // 
            // CloudAvgTextBox
            // 
            this.CloudAvgTextBox.Location = new System.Drawing.Point(64, 72);
            this.CloudAvgTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CloudAvgTextBox.Name = "CloudAvgTextBox";
            this.CloudAvgTextBox.Size = new System.Drawing.Size(57, 20);
            this.CloudAvgTextBox.TabIndex = 5;
            // 
            // CloudNowTextBox
            // 
            this.CloudNowTextBox.Location = new System.Drawing.Point(64, 20);
            this.CloudNowTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CloudNowTextBox.Name = "CloudNowTextBox";
            this.CloudNowTextBox.Size = new System.Drawing.Size(57, 20);
            this.CloudNowTextBox.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Current";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Maximum";
            // 
            // RainGroupBox
            // 
            this.RainGroupBox.Controls.Add(this.label7);
            this.RainGroupBox.Controls.Add(this.RainMaxTextBox);
            this.RainGroupBox.Controls.Add(this.RainAvgTextBox);
            this.RainGroupBox.Controls.Add(this.RainNowTextBox);
            this.RainGroupBox.Controls.Add(this.label8);
            this.RainGroupBox.Controls.Add(this.label9);
            this.RainGroupBox.ForeColor = System.Drawing.Color.White;
            this.RainGroupBox.Location = new System.Drawing.Point(7, 212);
            this.RainGroupBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.RainGroupBox.Name = "RainGroupBox";
            this.RainGroupBox.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.RainGroupBox.Size = new System.Drawing.Size(128, 96);
            this.RainGroupBox.TabIndex = 8;
            this.RainGroupBox.TabStop = false;
            this.RainGroupBox.Text = "Rain";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 71);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Average";
            // 
            // RainMaxTextBox
            // 
            this.RainMaxTextBox.Location = new System.Drawing.Point(64, 42);
            this.RainMaxTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.RainMaxTextBox.Name = "RainMaxTextBox";
            this.RainMaxTextBox.Size = new System.Drawing.Size(57, 20);
            this.RainMaxTextBox.TabIndex = 2;
            // 
            // RainAvgTextBox
            // 
            this.RainAvgTextBox.Location = new System.Drawing.Point(64, 68);
            this.RainAvgTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.RainAvgTextBox.Name = "RainAvgTextBox";
            this.RainAvgTextBox.Size = new System.Drawing.Size(57, 20);
            this.RainAvgTextBox.TabIndex = 5;
            // 
            // RainNowTextBox
            // 
            this.RainNowTextBox.Location = new System.Drawing.Point(64, 16);
            this.RainNowTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.RainNowTextBox.Name = "RainNowTextBox";
            this.RainNowTextBox.Size = new System.Drawing.Size(57, 20);
            this.RainNowTextBox.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 19);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Current";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 45);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "Maximum";
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ResetButton.ForeColor = System.Drawing.Color.White;
            this.ResetButton.Location = new System.Drawing.Point(5, 348);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(62, 27);
            this.ResetButton.TabIndex = 9;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(4, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Since";
            // 
            // SinceDateTimeBox
            // 
            this.SinceDateTimeBox.Location = new System.Drawing.Point(53, 318);
            this.SinceDateTimeBox.Name = "SinceDateTimeBox";
            this.SinceDateTimeBox.Size = new System.Drawing.Size(82, 20);
            this.SinceDateTimeBox.TabIndex = 11;
            this.SinceDateTimeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormWeatherMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(141, 387);
            this.ControlBox = false;
            this.Controls.Add(this.SinceDateTimeBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.RainGroupBox);
            this.Controls.Add(this.CloudGroupBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.WindGroupBox);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "FormWeatherMonitor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather Monitor";
            this.WindGroupBox.ResumeLayout(false);
            this.WindGroupBox.PerformLayout();
            this.CloudGroupBox.ResumeLayout(false);
            this.CloudGroupBox.PerformLayout();
            this.RainGroupBox.ResumeLayout(false);
            this.RainGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WindNowTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox WindMaxTextBox;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox WindAvgTextBox;
        private System.Windows.Forms.GroupBox WindGroupBox;
        private System.Windows.Forms.GroupBox CloudGroupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CloudMaxTextBox;
        private System.Windows.Forms.TextBox CloudAvgTextBox;
        private System.Windows.Forms.TextBox CloudNowTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox RainGroupBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox RainMaxTextBox;
        private System.Windows.Forms.TextBox RainAvgTextBox;
        private System.Windows.Forms.TextBox RainNowTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox SinceDateTimeBox;
    }
}

