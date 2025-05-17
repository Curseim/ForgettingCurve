namespace ForgettingCurve {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.main_Logo = new System.Windows.Forms.Label();
            this.user_Button = new System.Windows.Forms.Button();
            this.Panel = new System.Windows.Forms.Panel();
            this.recentFile_Text = new System.Windows.Forms.Label();
            this.calender_Button = new System.Windows.Forms.Button();
            this.home_Button = new System.Windows.Forms.Button();
            this.normal_Text = new System.Windows.Forms.Label();
            this.recentFIle_Panel = new System.Windows.Forms.Panel();
            this.trashBin_Button = new System.Windows.Forms.Button();
            this.newFile_Button = new System.Windows.Forms.Button();
            this.NoNamedLine = new System.Windows.Forms.Label();
            this.file_Text = new System.Windows.Forms.Label();
            this.share_Button = new System.Windows.Forms.Button();
            this.FileOpen_Button = new System.Windows.Forms.Button();
            this.close_Button = new System.Windows.Forms.Button();
            this.setting_Button = new System.Windows.Forms.Button();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_Logo
            // 
            this.main_Logo.AutoSize = true;
            this.main_Logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.main_Logo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.main_Logo.Location = new System.Drawing.Point(31, 60);
            this.main_Logo.Name = "main_Logo";
            this.main_Logo.Size = new System.Drawing.Size(363, 37);
            this.main_Logo.TabIndex = 12;
            this.main_Logo.Text = "FORGETTING CURVE";
            // 
            // user_Button
            // 
            this.user_Button.BackColor = System.Drawing.Color.Silver;
            this.user_Button.FlatAppearance.BorderSize = 0;
            this.user_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.user_Button.Font = new System.Drawing.Font("굴림", 8F);
            this.user_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.user_Button.Location = new System.Drawing.Point(1744, 52);
            this.user_Button.Name = "user_Button";
            this.user_Button.Size = new System.Drawing.Size(50, 50);
            this.user_Button.TabIndex = 12;
            this.user_Button.Text = "유저";
            this.user_Button.UseVisualStyleBackColor = false;
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Panel.Controls.Add(this.recentFile_Text);
            this.Panel.Controls.Add(this.calender_Button);
            this.Panel.Controls.Add(this.home_Button);
            this.Panel.Controls.Add(this.normal_Text);
            this.Panel.Controls.Add(this.recentFIle_Panel);
            this.Panel.Controls.Add(this.trashBin_Button);
            this.Panel.Controls.Add(this.newFile_Button);
            this.Panel.Controls.Add(this.NoNamedLine);
            this.Panel.Controls.Add(this.file_Text);
            this.Panel.Controls.Add(this.share_Button);
            this.Panel.Controls.Add(this.FileOpen_Button);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel.Location = new System.Drawing.Point(0, 118);
            this.Panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(1806, 942);
            this.Panel.TabIndex = 0;
            // 
            // recentFile_Text
            // 
            this.recentFile_Text.AutoSize = true;
            this.recentFile_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.recentFile_Text.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.recentFile_Text.Location = new System.Drawing.Point(296, 102);
            this.recentFile_Text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.recentFile_Text.Name = "recentFile_Text";
            this.recentFile_Text.Size = new System.Drawing.Size(124, 36);
            this.recentFile_Text.TabIndex = 12;
            this.recentFile_Text.Text = "최근 항목";
            // 
            // calender_Button
            // 
            this.calender_Button.FlatAppearance.BorderSize = 0;
            this.calender_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calender_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.calender_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.calender_Button.Location = new System.Drawing.Point(33, 280);
            this.calender_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calender_Button.Name = "calender_Button";
            this.calender_Button.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.calender_Button.Size = new System.Drawing.Size(227, 51);
            this.calender_Button.TabIndex = 11;
            this.calender_Button.Text = "        캘린더";
            this.calender_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.calender_Button.UseVisualStyleBackColor = true;
            this.calender_Button.Click += new System.EventHandler(this.calender_Button_Click);
            // 
            // home_Button
            // 
            this.home_Button.FlatAppearance.BorderSize = 0;
            this.home_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.home_Button.Image = global::ForgettingCurve.Properties.Resources.Home_Icon;
            this.home_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_Button.Location = new System.Drawing.Point(33, 148);
            this.home_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.home_Button.Name = "home_Button";
            this.home_Button.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.home_Button.Size = new System.Drawing.Size(227, 51);
            this.home_Button.TabIndex = 10;
            this.home_Button.Text = "        HOME";
            this.home_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_Button.UseVisualStyleBackColor = true;
            // 
            // normal_Text
            // 
            this.normal_Text.AutoSize = true;
            this.normal_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.normal_Text.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.normal_Text.Location = new System.Drawing.Point(40, 102);
            this.normal_Text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.normal_Text.Name = "normal_Text";
            this.normal_Text.Size = new System.Drawing.Size(42, 25);
            this.normal_Text.TabIndex = 9;
            this.normal_Text.Text = "일반";
            // 
            // recentFIle_Panel
            // 
            this.recentFIle_Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.recentFIle_Panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.recentFIle_Panel.Location = new System.Drawing.Point(289, 148);
            this.recentFIle_Panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.recentFIle_Panel.Name = "recentFIle_Panel";
            this.recentFIle_Panel.Size = new System.Drawing.Size(1481, 357);
            this.recentFIle_Panel.TabIndex = 8;
            // 
            // trashBin_Button
            // 
            this.trashBin_Button.FlatAppearance.BorderSize = 0;
            this.trashBin_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trashBin_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.trashBin_Button.Image = global::ForgettingCurve.Properties.Resources.Trash;
            this.trashBin_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.trashBin_Button.Location = new System.Drawing.Point(33, 496);
            this.trashBin_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trashBin_Button.Name = "trashBin_Button";
            this.trashBin_Button.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.trashBin_Button.Size = new System.Drawing.Size(227, 51);
            this.trashBin_Button.TabIndex = 7;
            this.trashBin_Button.Text = "        휴지통";
            this.trashBin_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.trashBin_Button.UseVisualStyleBackColor = true;
            // 
            // newFile_Button
            // 
            this.newFile_Button.FlatAppearance.BorderSize = 0;
            this.newFile_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newFile_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.newFile_Button.Image = global::ForgettingCurve.Properties.Resources.Icon;
            this.newFile_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newFile_Button.Location = new System.Drawing.Point(33, 334);
            this.newFile_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newFile_Button.Name = "newFile_Button";
            this.newFile_Button.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.newFile_Button.Size = new System.Drawing.Size(227, 51);
            this.newFile_Button.TabIndex = 6;
            this.newFile_Button.Text = "        새로 만들기";
            this.newFile_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newFile_Button.UseVisualStyleBackColor = true;
            this.newFile_Button.Click += new System.EventHandler(this.newFile_Button_Click);
            // 
            // NoNamedLine
            // 
            this.NoNamedLine.AutoSize = true;
            this.NoNamedLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NoNamedLine.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.NoNamedLine.Location = new System.Drawing.Point(20, 195);
            this.NoNamedLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NoNamedLine.Name = "NoNamedLine";
            this.NoNamedLine.Size = new System.Drawing.Size(189, 29);
            this.NoNamedLine.TabIndex = 5;
            this.NoNamedLine.Text = "───────────";
            // 
            // file_Text
            // 
            this.file_Text.AutoSize = true;
            this.file_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.file_Text.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.file_Text.Location = new System.Drawing.Point(40, 234);
            this.file_Text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.file_Text.Name = "file_Text";
            this.file_Text.Size = new System.Drawing.Size(42, 25);
            this.file_Text.TabIndex = 4;
            this.file_Text.Text = "파일";
            // 
            // share_Button
            // 
            this.share_Button.FlatAppearance.BorderSize = 0;
            this.share_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.share_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.share_Button.Image = global::ForgettingCurve.Properties.Resources.Share;
            this.share_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.share_Button.Location = new System.Drawing.Point(33, 442);
            this.share_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.share_Button.Name = "share_Button";
            this.share_Button.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.share_Button.Size = new System.Drawing.Size(227, 51);
            this.share_Button.TabIndex = 3;
            this.share_Button.Text = "        공유";
            this.share_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.share_Button.UseVisualStyleBackColor = true;
            // 
            // FileOpen_Button
            // 
            this.FileOpen_Button.FlatAppearance.BorderSize = 0;
            this.FileOpen_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FileOpen_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.FileOpen_Button.Image = ((System.Drawing.Image)(resources.GetObject("FileOpen_Button.Image")));
            this.FileOpen_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FileOpen_Button.Location = new System.Drawing.Point(33, 388);
            this.FileOpen_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FileOpen_Button.Name = "FileOpen_Button";
            this.FileOpen_Button.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.FileOpen_Button.Size = new System.Drawing.Size(227, 51);
            this.FileOpen_Button.TabIndex = 2;
            this.FileOpen_Button.Text = "        내 파일";
            this.FileOpen_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FileOpen_Button.UseVisualStyleBackColor = true;
            // 
            // close_Button
            // 
            this.close_Button.FlatAppearance.BorderSize = 0;
            this.close_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.close_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.close_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_Button.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.close_Button.Location = new System.Drawing.Point(1734, 0);
            this.close_Button.Name = "close_Button";
            this.close_Button.Size = new System.Drawing.Size(71, 38);
            this.close_Button.TabIndex = 15;
            this.close_Button.Text = "X";
            this.close_Button.UseVisualStyleBackColor = true;
            this.close_Button.Click += new System.EventHandler(this.close_Button_Click);
            // 
            // setting_Button
            // 
            this.setting_Button.BackColor = System.Drawing.Color.Silver;
            this.setting_Button.FlatAppearance.BorderSize = 0;
            this.setting_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setting_Button.Font = new System.Drawing.Font("굴림", 8F);
            this.setting_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.setting_Button.Location = new System.Drawing.Point(1689, 52);
            this.setting_Button.Name = "setting_Button";
            this.setting_Button.Size = new System.Drawing.Size(50, 50);
            this.setting_Button.TabIndex = 16;
            this.setting_Button.Text = "설정";
            this.setting_Button.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1806, 1060);
            this.Controls.Add(this.setting_Button);
            this.Controls.Add(this.close_Button);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.user_Button);
            this.Controls.Add(this.main_Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "MainForm";
            this.Text = "망각 곡선";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label main_Logo;
        private System.Windows.Forms.Button user_Button;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Button calender_Button;
        private System.Windows.Forms.Button home_Button;
        private System.Windows.Forms.Label normal_Text;
        private System.Windows.Forms.Button trashBin_Button;
        private System.Windows.Forms.Button newFile_Button;
        private System.Windows.Forms.Label NoNamedLine;
        private System.Windows.Forms.Label file_Text;
        private System.Windows.Forms.Button share_Button;
        private System.Windows.Forms.Button FileOpen_Button;
        private System.Windows.Forms.Label recentFile_Text;
        private System.Windows.Forms.Panel recentFIle_Panel;
        private System.Windows.Forms.Button close_Button;
        private System.Windows.Forms.Button setting_Button;
    }
}