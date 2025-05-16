namespace ForgettingCurve.Class.Data
{
    partial class DataDebugForm
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
            this.AddFileDataButton = new System.Windows.Forms.Button();
            this.FilePathLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.ContentTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HourNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MinuteNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SecondNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.HourLabel = new System.Windows.Forms.Label();
            this.MinuteLabel = new System.Windows.Forms.Label();
            this.SecondLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HourNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinuteNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // AddFileDataButton
            // 
            this.AddFileDataButton.Location = new System.Drawing.Point(938, 121);
            this.AddFileDataButton.Name = "AddFileDataButton";
            this.AddFileDataButton.Size = new System.Drawing.Size(171, 51);
            this.AddFileDataButton.TabIndex = 0;
            this.AddFileDataButton.Text = "파일데이터 추가";
            this.AddFileDataButton.UseVisualStyleBackColor = true;
            this.AddFileDataButton.Click += new System.EventHandler(this.AddFileDataButton_Click);
            // 
            // FilePathLabel
            // 
            this.FilePathLabel.AutoSize = true;
            this.FilePathLabel.Location = new System.Drawing.Point(54, 36);
            this.FilePathLabel.Name = "FilePathLabel";
            this.FilePathLabel.Size = new System.Drawing.Size(111, 18);
            this.FilePathLabel.TabIndex = 1;
            this.FilePathLabel.Text = "FilePathLabel";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(57, 258);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(837, 28);
            this.TitleTextBox.TabIndex = 2;
            // 
            // ContentTextBox
            // 
            this.ContentTextBox.Location = new System.Drawing.Point(57, 292);
            this.ContentTextBox.Multiline = true;
            this.ContentTextBox.Name = "ContentTextBox";
            this.ContentTextBox.Size = new System.Drawing.Size(837, 766);
            this.ContentTextBox.TabIndex = 3;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(57, 169);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(440, 28);
            this.dateTimePicker.TabIndex = 4;
            // 
            // HourNumericUpDown
            // 
            this.HourNumericUpDown.Location = new System.Drawing.Point(503, 169);
            this.HourNumericUpDown.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.HourNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.HourNumericUpDown.Name = "HourNumericUpDown";
            this.HourNumericUpDown.Size = new System.Drawing.Size(93, 28);
            this.HourNumericUpDown.TabIndex = 5;
            this.HourNumericUpDown.ValueChanged += new System.EventHandler(this.HourNumericUpDown_ValueChanged);
            // 
            // MinuteNumericUpDown
            // 
            this.MinuteNumericUpDown.Location = new System.Drawing.Point(602, 169);
            this.MinuteNumericUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.MinuteNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.MinuteNumericUpDown.Name = "MinuteNumericUpDown";
            this.MinuteNumericUpDown.Size = new System.Drawing.Size(93, 28);
            this.MinuteNumericUpDown.TabIndex = 6;
            this.MinuteNumericUpDown.ValueChanged += new System.EventHandler(this.MinuteNumericUpDown_ValueChanged);
            // 
            // SecondNumericUpDown
            // 
            this.SecondNumericUpDown.Location = new System.Drawing.Point(701, 169);
            this.SecondNumericUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.SecondNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.SecondNumericUpDown.Name = "SecondNumericUpDown";
            this.SecondNumericUpDown.Size = new System.Drawing.Size(93, 28);
            this.SecondNumericUpDown.TabIndex = 7;
            this.SecondNumericUpDown.ValueChanged += new System.EventHandler(this.SecondNumericUpDown_ValueChanged);
            // 
            // HourLabel
            // 
            this.HourLabel.AutoSize = true;
            this.HourLabel.Location = new System.Drawing.Point(531, 148);
            this.HourLabel.Name = "HourLabel";
            this.HourLabel.Size = new System.Drawing.Size(26, 18);
            this.HourLabel.TabIndex = 8;
            this.HourLabel.Text = "시";
            // 
            // MinuteLabel
            // 
            this.MinuteLabel.AutoSize = true;
            this.MinuteLabel.Location = new System.Drawing.Point(638, 148);
            this.MinuteLabel.Name = "MinuteLabel";
            this.MinuteLabel.Size = new System.Drawing.Size(26, 18);
            this.MinuteLabel.TabIndex = 9;
            this.MinuteLabel.Text = "분";
            // 
            // SecondLabel
            // 
            this.SecondLabel.AutoSize = true;
            this.SecondLabel.Location = new System.Drawing.Point(734, 148);
            this.SecondLabel.Name = "SecondLabel";
            this.SecondLabel.Size = new System.Drawing.Size(26, 18);
            this.SecondLabel.TabIndex = 10;
            this.SecondLabel.Text = "초";
            // 
            // DataDebugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 1095);
            this.Controls.Add(this.SecondLabel);
            this.Controls.Add(this.MinuteLabel);
            this.Controls.Add(this.HourLabel);
            this.Controls.Add(this.SecondNumericUpDown);
            this.Controls.Add(this.MinuteNumericUpDown);
            this.Controls.Add(this.HourNumericUpDown);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.ContentTextBox);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.FilePathLabel);
            this.Controls.Add(this.AddFileDataButton);
            this.Name = "DataDebugForm";
            this.Text = "DataDebugForm";
            ((System.ComponentModel.ISupportInitialize)(this.HourNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinuteNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddFileDataButton;
        private System.Windows.Forms.Label FilePathLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox ContentTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.NumericUpDown HourNumericUpDown;
        private System.Windows.Forms.NumericUpDown MinuteNumericUpDown;
        private System.Windows.Forms.NumericUpDown SecondNumericUpDown;
        private System.Windows.Forms.Label HourLabel;
        private System.Windows.Forms.Label MinuteLabel;
        private System.Windows.Forms.Label SecondLabel;
    }
}