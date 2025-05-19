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
            this.setting_Button = new System.Windows.Forms.Button();
            this.windows_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.hide_button = new System.Windows.Forms.Button();
            this.windows_Button = new System.Windows.Forms.Button();
            this.close_Button = new System.Windows.Forms.Button();
            this.Panel.SuspendLayout();
            this.windows_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_Logo
            // 
            this.main_Logo.AutoSize = true;
            this.main_Logo.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_Logo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.main_Logo.Location = new System.Drawing.Point(26, 67);
            this.main_Logo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.main_Logo.Name = "main_Logo";
            this.main_Logo.Size = new System.Drawing.Size(217, 30);
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
            this.user_Button.Location = new System.Drawing.Point(1218, 64);
            this.user_Button.Margin = new System.Windows.Forms.Padding(2);
            this.user_Button.Name = "user_Button";
            this.user_Button.Size = new System.Drawing.Size(35, 33);
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
            this.Panel.Location = new System.Drawing.Point(0, 109);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(1264, 598);
            this.Panel.TabIndex = 0;
            // 
            // recentFile_Text
            // 
            this.recentFile_Text.AutoSize = true;
            this.recentFile_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.recentFile_Text.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.recentFile_Text.Location = new System.Drawing.Point(207, 68);
            this.recentFile_Text.Name = "recentFile_Text";
            this.recentFile_Text.Size = new System.Drawing.Size(78, 25);
            this.recentFile_Text.TabIndex = 12;
            this.recentFile_Text.Text = "최근 항목";
            // 
            // calender_Button
            // 
            this.calender_Button.FlatAppearance.BorderSize = 0;
            this.calender_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calender_Button.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.calender_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.calender_Button.Location = new System.Drawing.Point(23, 187);
            this.calender_Button.Name = "calender_Button";
            this.calender_Button.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.calender_Button.Size = new System.Drawing.Size(159, 34);
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
            this.home_Button.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.home_Button.Image = global::ForgettingCurve.Properties.Resources.Home_Icon;
            this.home_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_Button.Location = new System.Drawing.Point(23, 99);
            this.home_Button.Name = "home_Button";
            this.home_Button.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.home_Button.Size = new System.Drawing.Size(159, 34);
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
            this.normal_Text.Location = new System.Drawing.Point(28, 68);
            this.normal_Text.Name = "normal_Text";
            this.normal_Text.Size = new System.Drawing.Size(32, 17);
            this.normal_Text.TabIndex = 9;
            this.normal_Text.Text = "일반";
            // 
            // recentFIle_Panel
            // 
            this.recentFIle_Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.recentFIle_Panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.recentFIle_Panel.Location = new System.Drawing.Point(202, 99);
            this.recentFIle_Panel.Name = "recentFIle_Panel";
            this.recentFIle_Panel.Size = new System.Drawing.Size(1037, 238);
            this.recentFIle_Panel.TabIndex = 8;
            // 
            // trashBin_Button
            // 
            this.trashBin_Button.FlatAppearance.BorderSize = 0;
            this.trashBin_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trashBin_Button.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.trashBin_Button.Image = global::ForgettingCurve.Properties.Resources.Trash;
            this.trashBin_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.trashBin_Button.Location = new System.Drawing.Point(23, 331);
            this.trashBin_Button.Name = "trashBin_Button";
            this.trashBin_Button.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.trashBin_Button.Size = new System.Drawing.Size(159, 34);
            this.trashBin_Button.TabIndex = 7;
            this.trashBin_Button.Text = "        휴지통";
            this.trashBin_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.trashBin_Button.UseVisualStyleBackColor = true;
            // 
            // newFile_Button
            // 
            this.newFile_Button.FlatAppearance.BorderSize = 0;
            this.newFile_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newFile_Button.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.newFile_Button.Image = global::ForgettingCurve.Properties.Resources.Icon;
            this.newFile_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newFile_Button.Location = new System.Drawing.Point(23, 223);
            this.newFile_Button.Name = "newFile_Button";
            this.newFile_Button.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.newFile_Button.Size = new System.Drawing.Size(159, 34);
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
            this.NoNamedLine.Location = new System.Drawing.Point(14, 130);
            this.NoNamedLine.Name = "NoNamedLine";
            this.NoNamedLine.Size = new System.Drawing.Size(129, 18);
            this.NoNamedLine.TabIndex = 5;
            this.NoNamedLine.Text = "───────────";
            // 
            // file_Text
            // 
            this.file_Text.AutoSize = true;
            this.file_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.file_Text.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.file_Text.Location = new System.Drawing.Point(28, 156);
            this.file_Text.Name = "file_Text";
            this.file_Text.Size = new System.Drawing.Size(32, 17);
            this.file_Text.TabIndex = 4;
            this.file_Text.Text = "파일";
            // 
            // share_Button
            // 
            this.share_Button.FlatAppearance.BorderSize = 0;
            this.share_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.share_Button.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.share_Button.Image = global::ForgettingCurve.Properties.Resources.Share;
            this.share_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.share_Button.Location = new System.Drawing.Point(23, 295);
            this.share_Button.Name = "share_Button";
            this.share_Button.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.share_Button.Size = new System.Drawing.Size(159, 34);
            this.share_Button.TabIndex = 3;
            this.share_Button.Text = "        공유";
            this.share_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.share_Button.UseVisualStyleBackColor = true;
            // 
            // FileOpen_Button
            // 
            this.FileOpen_Button.FlatAppearance.BorderSize = 0;
            this.FileOpen_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FileOpen_Button.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FileOpen_Button.Image = ((System.Drawing.Image)(resources.GetObject("FileOpen_Button.Image")));
            this.FileOpen_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FileOpen_Button.Location = new System.Drawing.Point(23, 259);
            this.FileOpen_Button.Name = "FileOpen_Button";
            this.FileOpen_Button.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.FileOpen_Button.Size = new System.Drawing.Size(159, 34);
            this.FileOpen_Button.TabIndex = 2;
            this.FileOpen_Button.Text = "        내 파일";
            this.FileOpen_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FileOpen_Button.UseVisualStyleBackColor = true;
            // 
            // setting_Button
            // 
            this.setting_Button.BackColor = System.Drawing.Color.Silver;
            this.setting_Button.FlatAppearance.BorderSize = 0;
            this.setting_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setting_Button.Font = new System.Drawing.Font("굴림", 8F);
            this.setting_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.setting_Button.Location = new System.Drawing.Point(1179, 64);
            this.setting_Button.Margin = new System.Windows.Forms.Padding(2);
            this.setting_Button.Name = "setting_Button";
            this.setting_Button.Size = new System.Drawing.Size(35, 33);
            this.setting_Button.TabIndex = 16;
            this.setting_Button.Text = "설정";
            this.setting_Button.UseVisualStyleBackColor = false;
            // 
            // windows_panel
            // 
            this.windows_panel.BackColor = System.Drawing.SystemColors.Highlight;
            this.windows_panel.Controls.Add(this.label1);
            this.windows_panel.Controls.Add(this.hide_button);
            this.windows_panel.Controls.Add(this.windows_Button);
            this.windows_panel.Controls.Add(this.close_Button);
            this.windows_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.windows_panel.Location = new System.Drawing.Point(0, 0);
            this.windows_panel.Margin = new System.Windows.Forms.Padding(0);
            this.windows_panel.Name = "windows_panel";
            this.windows_panel.Size = new System.Drawing.Size(1264, 46);
            this.windows_panel.TabIndex = 17;
            this.windows_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.windows_panel_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "망각 곡선";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hide_button
            // 
            this.hide_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.hide_button.FlatAppearance.BorderSize = 0;
            this.hide_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.hide_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hide_button.Font = new System.Drawing.Font("Webdings", 12F);
            this.hide_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hide_button.Location = new System.Drawing.Point(1114, 0);
            this.hide_button.Margin = new System.Windows.Forms.Padding(0);
            this.hide_button.Name = "hide_button";
            this.hide_button.Size = new System.Drawing.Size(50, 46);
            this.hide_button.TabIndex = 2;
            this.hide_button.Text = "0";
            this.hide_button.UseVisualStyleBackColor = true;
            this.hide_button.Click += new System.EventHandler(this.hide_button_Click);
            // 
            // windows_Button
            // 
            this.windows_Button.Dock = System.Windows.Forms.DockStyle.Right;
            this.windows_Button.FlatAppearance.BorderSize = 0;
            this.windows_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.windows_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.windows_Button.Font = new System.Drawing.Font("Webdings", 12F);
            this.windows_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.windows_Button.Location = new System.Drawing.Point(1164, 0);
            this.windows_Button.Margin = new System.Windows.Forms.Padding(0);
            this.windows_Button.Name = "windows_Button";
            this.windows_Button.Size = new System.Drawing.Size(50, 46);
            this.windows_Button.TabIndex = 1;
            this.windows_Button.Text = "1";
            this.windows_Button.UseVisualStyleBackColor = true;
            this.windows_Button.Click += new System.EventHandler(this.windows_Button_Click);
            // 
            // close_Button
            // 
            this.close_Button.Dock = System.Windows.Forms.DockStyle.Right;
            this.close_Button.FlatAppearance.BorderSize = 0;
            this.close_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.close_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_Button.Font = new System.Drawing.Font("Webdings", 12F);
            this.close_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.close_Button.Location = new System.Drawing.Point(1214, 0);
            this.close_Button.Margin = new System.Windows.Forms.Padding(0);
            this.close_Button.Name = "close_Button";
            this.close_Button.Size = new System.Drawing.Size(50, 46);
            this.close_Button.TabIndex = 0;
            this.close_Button.Text = "r";
            this.close_Button.UseVisualStyleBackColor = true;
            this.close_Button.Click += new System.EventHandler(this.close_Button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 707);
            this.Controls.Add(this.windows_panel);
            this.Controls.Add(this.setting_Button);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.user_Button);
            this.Controls.Add(this.main_Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "망각 곡선";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.windows_panel.ResumeLayout(false);
            this.windows_panel.PerformLayout();
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
        private System.Windows.Forms.Button setting_Button;
        private System.Windows.Forms.Panel windows_panel;
        private System.Windows.Forms.Button hide_button;
        private System.Windows.Forms.Button windows_Button;
        private System.Windows.Forms.Button close_Button;
        private System.Windows.Forms.Label label1;
    }
}