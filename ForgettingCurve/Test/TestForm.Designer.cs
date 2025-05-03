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
            this.SuspendLayout();
            // 
            // Create_Json_Button
            // 
            this.Create_Json_Button.Location = new System.Drawing.Point(1139, 87);
            this.Create_Json_Button.Name = "Create_Json_Button";
            this.Create_Json_Button.Size = new System.Drawing.Size(75, 23);
            this.Create_Json_Button.TabIndex = 0;
            this.Create_Json_Button.Text = "파일 생성";
            this.Create_Json_Button.UseVisualStyleBackColor = true;
            this.Create_Json_Button.Click += new System.EventHandler(this.Create_Json_Button_Click);
            // 
            // Json_textBox
            // 
            this.Json_textBox.Location = new System.Drawing.Point(179, 50);
            this.Json_textBox.Multiline = true;
            this.Json_textBox.Name = "Json_textBox";
            this.Json_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Json_textBox.Size = new System.Drawing.Size(811, 417);
            this.Json_textBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Append_Json_Button
            // 
            this.Append_Json_Button.Location = new System.Drawing.Point(1139, 507);
            this.Append_Json_Button.Name = "Append_Json_Button";
            this.Append_Json_Button.Size = new System.Drawing.Size(95, 23);
            this.Append_Json_Button.TabIndex = 3;
            this.Append_Json_Button.Text = "데이터 추가";
            this.Append_Json_Button.UseVisualStyleBackColor = true;
            this.Append_Json_Button.Click += new System.EventHandler(this.Append_Json_Button_Click);
            // 
            // Json_AppendBox
            // 
            this.Json_AppendBox.Location = new System.Drawing.Point(179, 473);
            this.Json_AppendBox.Multiline = true;
            this.Json_AppendBox.Name = "Json_AppendBox";
            this.Json_AppendBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Json_AppendBox.Size = new System.Drawing.Size(811, 177);
            this.Json_AppendBox.TabIndex = 4;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 683);
            this.Controls.Add(this.Json_AppendBox);
            this.Controls.Add(this.Append_Json_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Json_textBox);
            this.Controls.Add(this.Create_Json_Button);
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}