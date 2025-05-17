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
            this.components = new System.ComponentModel.Container();
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
            this.DirPathTextBox = new System.Windows.Forms.TextBox();
            this.DirPathLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FileNameTextBox = new System.Windows.Forms.TextBox();
            this.SetFilePathButton = new System.Windows.Forms.Button();
            this.FileFormetComboBox = new System.Windows.Forms.ComboBox();
            this.TimeBindingCheckBox = new System.Windows.Forms.CheckBox();
            this.SecondTimer = new System.Windows.Forms.Timer(this.components);
            this.ForgCurvLevelComboBox = new System.Windows.Forms.ComboBox();
            this.ForgCurvLevelLabel = new System.Windows.Forms.Label();
            this.ForgCurvScalarLabel = new System.Windows.Forms.Label();
            this.RememberRatioLabel = new System.Windows.Forms.Label();
            this.RememberRatioNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ForgCurveScalarTextBox = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ReadDataByDateTimeButton = new System.Windows.Forms.Button();
            this.ModifyDataByDateTimeButton = new System.Windows.Forms.Button();
            this.DeleteDataByDateTimeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HourNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinuteNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RememberRatioNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // AddFileDataButton
            // 
            this.AddFileDataButton.Location = new System.Drawing.Point(970, 338);
            this.AddFileDataButton.Name = "AddFileDataButton";
            this.AddFileDataButton.Size = new System.Drawing.Size(171, 51);
            this.AddFileDataButton.TabIndex = 0;
            this.AddFileDataButton.Text = "데이터 추가";
            this.AddFileDataButton.UseVisualStyleBackColor = true;
            this.AddFileDataButton.Click += new System.EventHandler(this.AddFileDataButton_Click);
            // 
            // FilePathLabel
            // 
            this.FilePathLabel.AutoSize = true;
            this.FilePathLabel.Location = new System.Drawing.Point(12, 19);
            this.FilePathLabel.Name = "FilePathLabel";
            this.FilePathLabel.Size = new System.Drawing.Size(111, 18);
            this.FilePathLabel.TabIndex = 1;
            this.FilePathLabel.Text = "FilePathLabel";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(57, 338);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(894, 28);
            this.TitleTextBox.TabIndex = 2;
            // 
            // ContentTextBox
            // 
            this.ContentTextBox.Location = new System.Drawing.Point(57, 372);
            this.ContentTextBox.Multiline = true;
            this.ContentTextBox.Name = "ContentTextBox";
            this.ContentTextBox.Size = new System.Drawing.Size(894, 686);
            this.ContentTextBox.TabIndex = 3;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(57, 198);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(440, 28);
            this.dateTimePicker.TabIndex = 4;
            // 
            // HourNumericUpDown
            // 
            this.HourNumericUpDown.Location = new System.Drawing.Point(503, 198);
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
            this.MinuteNumericUpDown.Location = new System.Drawing.Point(602, 198);
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
            this.SecondNumericUpDown.Location = new System.Drawing.Point(701, 198);
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
            this.HourLabel.Location = new System.Drawing.Point(570, 177);
            this.HourLabel.Name = "HourLabel";
            this.HourLabel.Size = new System.Drawing.Size(26, 18);
            this.HourLabel.TabIndex = 8;
            this.HourLabel.Text = "시";
            // 
            // MinuteLabel
            // 
            this.MinuteLabel.AutoSize = true;
            this.MinuteLabel.Location = new System.Drawing.Point(669, 177);
            this.MinuteLabel.Name = "MinuteLabel";
            this.MinuteLabel.Size = new System.Drawing.Size(26, 18);
            this.MinuteLabel.TabIndex = 9;
            this.MinuteLabel.Text = "분";
            // 
            // SecondLabel
            // 
            this.SecondLabel.AutoSize = true;
            this.SecondLabel.Location = new System.Drawing.Point(768, 177);
            this.SecondLabel.Name = "SecondLabel";
            this.SecondLabel.Size = new System.Drawing.Size(26, 18);
            this.SecondLabel.TabIndex = 10;
            this.SecondLabel.Text = "초";
            // 
            // DirPathTextBox
            // 
            this.DirPathTextBox.Location = new System.Drawing.Point(163, 54);
            this.DirPathTextBox.Name = "DirPathTextBox";
            this.DirPathTextBox.Size = new System.Drawing.Size(788, 28);
            this.DirPathTextBox.TabIndex = 11;
            // 
            // DirPathLabel
            // 
            this.DirPathLabel.AutoSize = true;
            this.DirPathLabel.Location = new System.Drawing.Point(35, 57);
            this.DirPathLabel.Name = "DirPathLabel";
            this.DirPathLabel.Size = new System.Drawing.Size(122, 18);
            this.DirPathLabel.TabIndex = 12;
            this.DirPathLabel.Text = "디렉토리 경로";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "파일 이름";
            // 
            // FileNameTextBox
            // 
            this.FileNameTextBox.Location = new System.Drawing.Point(163, 92);
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.Size = new System.Drawing.Size(334, 28);
            this.FileNameTextBox.TabIndex = 14;
            // 
            // SetFilePathButton
            // 
            this.SetFilePathButton.Location = new System.Drawing.Point(970, 57);
            this.SetFilePathButton.Name = "SetFilePathButton";
            this.SetFilePathButton.Size = new System.Drawing.Size(171, 63);
            this.SetFilePathButton.TabIndex = 15;
            this.SetFilePathButton.Text = "경로/이름 재설정";
            this.SetFilePathButton.UseVisualStyleBackColor = true;
            this.SetFilePathButton.Click += new System.EventHandler(this.SetFilePathButton_Click);
            // 
            // FileFormetComboBox
            // 
            this.FileFormetComboBox.FormattingEnabled = true;
            this.FileFormetComboBox.Items.AddRange(new object[] {
            ".Json"});
            this.FileFormetComboBox.Location = new System.Drawing.Point(503, 94);
            this.FileFormetComboBox.Name = "FileFormetComboBox";
            this.FileFormetComboBox.Size = new System.Drawing.Size(121, 26);
            this.FileFormetComboBox.TabIndex = 16;
            // 
            // TimeBindingCheckBox
            // 
            this.TimeBindingCheckBox.Checked = true;
            this.TimeBindingCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TimeBindingCheckBox.Location = new System.Drawing.Point(810, 199);
            this.TimeBindingCheckBox.Name = "TimeBindingCheckBox";
            this.TimeBindingCheckBox.Size = new System.Drawing.Size(154, 27);
            this.TimeBindingCheckBox.TabIndex = 17;
            this.TimeBindingCheckBox.Text = "현재시간 추적";
            this.TimeBindingCheckBox.UseVisualStyleBackColor = true;
            this.TimeBindingCheckBox.CheckedChanged += new System.EventHandler(this.TimeBindingCheckBox_CheckedChanged);
            // 
            // SecondTimer
            // 
            this.SecondTimer.Tick += new System.EventHandler(this.SecondTimer_Tick);
            // 
            // ForgCurvLevelComboBox
            // 
            this.ForgCurvLevelComboBox.FormatString = "N2";
            this.ForgCurvLevelComboBox.FormattingEnabled = true;
            this.ForgCurvLevelComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.ForgCurvLevelComboBox.Location = new System.Drawing.Point(57, 292);
            this.ForgCurvLevelComboBox.Name = "ForgCurvLevelComboBox";
            this.ForgCurvLevelComboBox.Size = new System.Drawing.Size(155, 26);
            this.ForgCurvLevelComboBox.TabIndex = 18;
            this.ForgCurvLevelComboBox.Text = "1";
            // 
            // ForgCurvLevelLabel
            // 
            this.ForgCurvLevelLabel.AutoSize = true;
            this.ForgCurvLevelLabel.Location = new System.Drawing.Point(54, 271);
            this.ForgCurvLevelLabel.Name = "ForgCurvLevelLabel";
            this.ForgCurvLevelLabel.Size = new System.Drawing.Size(122, 18);
            this.ForgCurvLevelLabel.TabIndex = 21;
            this.ForgCurvLevelLabel.Text = "망각곡선 단계";
            // 
            // ForgCurvScalarLabel
            // 
            this.ForgCurvScalarLabel.AutoSize = true;
            this.ForgCurvScalarLabel.Location = new System.Drawing.Point(215, 271);
            this.ForgCurvScalarLabel.Name = "ForgCurvScalarLabel";
            this.ForgCurvScalarLabel.Size = new System.Drawing.Size(136, 18);
            this.ForgCurvScalarLabel.TabIndex = 22;
            this.ForgCurvScalarLabel.Text = "망각곡선 Scalar";
            // 
            // RememberRatioLabel
            // 
            this.RememberRatioLabel.AutoSize = true;
            this.RememberRatioLabel.Location = new System.Drawing.Point(376, 271);
            this.RememberRatioLabel.Name = "RememberRatioLabel";
            this.RememberRatioLabel.Size = new System.Drawing.Size(86, 18);
            this.RememberRatioLabel.TabIndex = 23;
            this.RememberRatioLabel.Text = "기억 비율";
            // 
            // RememberRatioNumericUpDown
            // 
            this.RememberRatioNumericUpDown.Location = new System.Drawing.Point(379, 292);
            this.RememberRatioNumericUpDown.Name = "RememberRatioNumericUpDown";
            this.RememberRatioNumericUpDown.Size = new System.Drawing.Size(118, 28);
            this.RememberRatioNumericUpDown.TabIndex = 25;
            this.RememberRatioNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // ForgCurveScalarTextBox
            // 
            this.ForgCurveScalarTextBox.Location = new System.Drawing.Point(218, 292);
            this.ForgCurveScalarTextBox.Name = "ForgCurveScalarTextBox";
            this.ForgCurveScalarTextBox.Size = new System.Drawing.Size(155, 28);
            this.ForgCurveScalarTextBox.TabIndex = 26;
            this.ForgCurveScalarTextBox.Text = "25.0";
            // 
            // ReadDataByDateTimeButton
            // 
            this.ReadDataByDateTimeButton.Location = new System.Drawing.Point(970, 182);
            this.ReadDataByDateTimeButton.Name = "ReadDataByDateTimeButton";
            this.ReadDataByDateTimeButton.Size = new System.Drawing.Size(171, 64);
            this.ReadDataByDateTimeButton.TabIndex = 27;
            this.ReadDataByDateTimeButton.Text = "해당 경로,날짜\r\n데이터 읽기";
            this.ReadDataByDateTimeButton.UseVisualStyleBackColor = true;
            this.ReadDataByDateTimeButton.Click += new System.EventHandler(this.ReadDataByDateTimeButton_Click);
            // 
            // ModifyDataByDateTimeButton
            // 
            this.ModifyDataByDateTimeButton.Location = new System.Drawing.Point(970, 395);
            this.ModifyDataByDateTimeButton.Name = "ModifyDataByDateTimeButton";
            this.ModifyDataByDateTimeButton.Size = new System.Drawing.Size(171, 64);
            this.ModifyDataByDateTimeButton.TabIndex = 28;
            this.ModifyDataByDateTimeButton.Text = "해당 경로,날짜\r\n데이터 수정 저장";
            this.ModifyDataByDateTimeButton.UseVisualStyleBackColor = true;
            this.ModifyDataByDateTimeButton.Click += new System.EventHandler(this.ModifyDataByDateTimeButton_Click);
            // 
            // DeleteDataByDateTimeButton
            // 
            this.DeleteDataByDateTimeButton.Location = new System.Drawing.Point(970, 994);
            this.DeleteDataByDateTimeButton.Name = "DeleteDataByDateTimeButton";
            this.DeleteDataByDateTimeButton.Size = new System.Drawing.Size(171, 64);
            this.DeleteDataByDateTimeButton.TabIndex = 29;
            this.DeleteDataByDateTimeButton.Text = "해당 경로,날짜\r\n데이터 삭제";
            this.DeleteDataByDateTimeButton.UseVisualStyleBackColor = true;
            this.DeleteDataByDateTimeButton.Click += new System.EventHandler(this.DeleteDataByDateTimeButton_Click);
            // 
            // DataDebugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 1095);
            this.Controls.Add(this.DeleteDataByDateTimeButton);
            this.Controls.Add(this.ModifyDataByDateTimeButton);
            this.Controls.Add(this.ReadDataByDateTimeButton);
            this.Controls.Add(this.ForgCurveScalarTextBox);
            this.Controls.Add(this.RememberRatioNumericUpDown);
            this.Controls.Add(this.RememberRatioLabel);
            this.Controls.Add(this.ForgCurvScalarLabel);
            this.Controls.Add(this.ForgCurvLevelLabel);
            this.Controls.Add(this.ForgCurvLevelComboBox);
            this.Controls.Add(this.TimeBindingCheckBox);
            this.Controls.Add(this.FileFormetComboBox);
            this.Controls.Add(this.SetFilePathButton);
            this.Controls.Add(this.FileNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DirPathLabel);
            this.Controls.Add(this.DirPathTextBox);
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
            ((System.ComponentModel.ISupportInitialize)(this.RememberRatioNumericUpDown)).EndInit();
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
        private System.Windows.Forms.TextBox DirPathTextBox;
        private System.Windows.Forms.Label DirPathLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FileNameTextBox;
        private System.Windows.Forms.Button SetFilePathButton;
        private System.Windows.Forms.ComboBox FileFormetComboBox;
        private System.Windows.Forms.CheckBox TimeBindingCheckBox;
        private System.Windows.Forms.Timer SecondTimer;
        private System.Windows.Forms.ComboBox ForgCurvLevelComboBox;
        private System.Windows.Forms.Label ForgCurvLevelLabel;
        private System.Windows.Forms.Label ForgCurvScalarLabel;
        private System.Windows.Forms.Label RememberRatioLabel;
        private System.Windows.Forms.NumericUpDown RememberRatioNumericUpDown;
        private System.Windows.Forms.TextBox ForgCurveScalarTextBox;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button ReadDataByDateTimeButton;
        private System.Windows.Forms.Button ModifyDataByDateTimeButton;
        private System.Windows.Forms.Button DeleteDataByDateTimeButton;
    }
}