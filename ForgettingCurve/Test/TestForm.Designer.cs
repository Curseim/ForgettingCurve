namespace ForgettingCurve.Test
{
    partial class TestForm
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
            this.Create_Json_Button = new System.Windows.Forms.Button();
            this.Json_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Append_Json_Button = new System.Windows.Forms.Button();
            this.Json_AppendBox = new System.Windows.Forms.TextBox();
            this.DataScan = new System.Windows.Forms.Button();
            this.DataMetaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Create_Json_Button
            // 
            this.Create_Json_Button.Location = new System.Drawing.Point(1627, 130);
            this.Create_Json_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Create_Json_Button.Name = "Create_Json_Button";
            this.Create_Json_Button.Size = new System.Drawing.Size(107, 34);
            this.Create_Json_Button.TabIndex = 0;
            this.Create_Json_Button.Text = "파일 생성";
            this.Create_Json_Button.UseVisualStyleBackColor = true;
            this.Create_Json_Button.Click += new System.EventHandler(this.Create_Json_Button_Click);
            // 
            // Json_textBox
            // 
            this.Json_textBox.Location = new System.Drawing.Point(256, 75);
            this.Json_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Json_textBox.Multiline = true;
            this.Json_textBox.Name = "Json_textBox";
            this.Json_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Json_textBox.Size = new System.Drawing.Size(1157, 624);
            this.Json_textBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Append_Json_Button
            // 
            this.Append_Json_Button.Location = new System.Drawing.Point(1627, 760);
            this.Append_Json_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Append_Json_Button.Name = "Append_Json_Button";
            this.Append_Json_Button.Size = new System.Drawing.Size(136, 34);
            this.Append_Json_Button.TabIndex = 3;
            this.Append_Json_Button.Text = "데이터 추가";
            this.Append_Json_Button.UseVisualStyleBackColor = true;
            this.Append_Json_Button.Click += new System.EventHandler(this.Append_Json_Button_Click);
            // 
            // Json_AppendBox
            // 
            this.Json_AppendBox.Location = new System.Drawing.Point(256, 710);
            this.Json_AppendBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Json_AppendBox.Multiline = true;
            this.Json_AppendBox.Name = "Json_AppendBox";
            this.Json_AppendBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Json_AppendBox.Size = new System.Drawing.Size(1157, 264);
            this.Json_AppendBox.TabIndex = 4;
            // 
            // DataScan
            // 
            this.DataScan.Location = new System.Drawing.Point(1628, 932);
            this.DataScan.Name = "DataScan";
            this.DataScan.Size = new System.Drawing.Size(135, 42);
            this.DataScan.TabIndex = 5;
            this.DataScan.Text = "테이터 스캔";
            this.DataScan.UseVisualStyleBackColor = true;
            this.DataScan.Click += new System.EventHandler(this.DataScan_Click);
            // 
            // DataMetaLabel
            // 
            this.DataMetaLabel.AutoSize = true;
            this.DataMetaLabel.Location = new System.Drawing.Point(1659, 890);
            this.DataMetaLabel.Name = "DataMetaLabel";
            this.DataMetaLabel.Size = new System.Drawing.Size(54, 18);
            this.DataMetaLabel.TabIndex = 6;
            this.DataMetaLabel.Text = "label2";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1899, 1024);
            this.Controls.Add(this.DataMetaLabel);
            this.Controls.Add(this.DataScan);
            this.Controls.Add(this.Json_AppendBox);
            this.Controls.Add(this.Append_Json_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Json_textBox);
            this.Controls.Add(this.Create_Json_Button);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Create_Json_Button;
        private System.Windows.Forms.TextBox Json_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Append_Json_Button;
        private System.Windows.Forms.TextBox Json_AppendBox;
        private System.Windows.Forms.Button DataScan;
        private System.Windows.Forms.Label DataMetaLabel;
    }
}