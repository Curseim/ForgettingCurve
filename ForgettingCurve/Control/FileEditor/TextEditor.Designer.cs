﻿namespace ForgettingCurve.Control.FileEditor {
    partial class TextEditor_Form {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditor_Form));
            this.windows_panel = new System.Windows.Forms.Panel();
            this.LOGO = new System.Windows.Forms.Button();
            this.windows_text = new System.Windows.Forms.Label();
            this.hide_button = new System.Windows.Forms.Button();
            this.windows_button = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tab_view_Color = new System.Windows.Forms.Panel();
            this.tab_view_Button = new System.Windows.Forms.Button();
            this.tab_design_Color = new System.Windows.Forms.Panel();
            this.tab_design_Button = new System.Windows.Forms.Button();
            this.tab_edit_Color = new System.Windows.Forms.Panel();
            this.tab_edit_Button = new System.Windows.Forms.Button();
            this.tab_file_Color = new System.Windows.Forms.Panel();
            this.tab_file_Button = new System.Windows.Forms.Button();
            this.tab_toolBox = new System.Windows.Forms.Panel();
            this.control_Panel = new ForgettingCurve.Control.FileEditor.Tab.Control_File();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.windows_panel.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.tab_view_Color.SuspendLayout();
            this.tab_design_Color.SuspendLayout();
            this.tab_edit_Color.SuspendLayout();
            this.tab_file_Color.SuspendLayout();
            this.tab_toolBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // windows_panel
            // 
            this.windows_panel.BackColor = System.Drawing.SystemColors.Highlight;
            this.windows_panel.Controls.Add(this.LOGO);
            this.windows_panel.Controls.Add(this.windows_text);
            this.windows_panel.Controls.Add(this.hide_button);
            this.windows_panel.Controls.Add(this.windows_button);
            this.windows_panel.Controls.Add(this.close_button);
            this.windows_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.windows_panel.Location = new System.Drawing.Point(0, 0);
            this.windows_panel.Margin = new System.Windows.Forms.Padding(0);
            this.windows_panel.Name = "windows_panel";
            this.windows_panel.Size = new System.Drawing.Size(1279, 69);
            this.windows_panel.TabIndex = 0;
            // 
            // LOGO
            // 
            this.LOGO.Dock = System.Windows.Forms.DockStyle.Left;
            this.LOGO.FlatAppearance.BorderSize = 0;
            this.LOGO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LOGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LOGO.ForeColor = System.Drawing.SystemColors.Control;
            this.LOGO.Image = ((System.Drawing.Image)(resources.GetObject("LOGO.Image")));
            this.LOGO.Location = new System.Drawing.Point(0, 0);
            this.LOGO.Margin = new System.Windows.Forms.Padding(0);
            this.LOGO.Name = "LOGO";
            this.LOGO.Size = new System.Drawing.Size(71, 69);
            this.LOGO.TabIndex = 4;
            this.LOGO.UseVisualStyleBackColor = true;
            // 
            // windows_text
            // 
            this.windows_text.BackColor = System.Drawing.Color.Transparent;
            this.windows_text.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.windows_text.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.windows_text.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.windows_text.Location = new System.Drawing.Point(71, 4);
            this.windows_text.Margin = new System.Windows.Forms.Padding(0);
            this.windows_text.Name = "windows_text";
            this.windows_text.Size = new System.Drawing.Size(993, 60);
            this.windows_text.TabIndex = 3;
            this.windows_text.Text = "텍스트 편집기 - 새 텍스트";
            this.windows_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.windows_text.MouseDown += new System.Windows.Forms.MouseEventHandler(this.windows_text_MouseDown);
            // 
            // hide_button
            // 
            this.hide_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.hide_button.FlatAppearance.BorderSize = 0;
            this.hide_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.hide_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hide_button.Font = new System.Drawing.Font("Webdings", 12F);
            this.hide_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hide_button.Location = new System.Drawing.Point(1066, 0);
            this.hide_button.Margin = new System.Windows.Forms.Padding(0);
            this.hide_button.Name = "hide_button";
            this.hide_button.Size = new System.Drawing.Size(71, 69);
            this.hide_button.TabIndex = 2;
            this.hide_button.Text = "0";
            this.hide_button.UseVisualStyleBackColor = true;
            this.hide_button.Click += new System.EventHandler(this.hide_button_Click);
            // 
            // windows_button
            // 
            this.windows_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.windows_button.FlatAppearance.BorderSize = 0;
            this.windows_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.windows_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.windows_button.Font = new System.Drawing.Font("Webdings", 12F);
            this.windows_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.windows_button.Location = new System.Drawing.Point(1137, 0);
            this.windows_button.Margin = new System.Windows.Forms.Padding(0);
            this.windows_button.Name = "windows_button";
            this.windows_button.Size = new System.Drawing.Size(71, 69);
            this.windows_button.TabIndex = 1;
            this.windows_button.Text = "1";
            this.windows_button.UseVisualStyleBackColor = true;
            this.windows_button.Click += new System.EventHandler(this.windows_button_Click);
            // 
            // close_button
            // 
            this.close_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.close_button.FlatAppearance.BorderSize = 0;
            this.close_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.Font = new System.Drawing.Font("Webdings", 12F);
            this.close_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.close_button.Location = new System.Drawing.Point(1208, 0);
            this.close_button.Margin = new System.Windows.Forms.Padding(0);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(71, 69);
            this.close_button.TabIndex = 0;
            this.close_button.Text = "r";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // textBox
            // 
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox.Location = new System.Drawing.Point(0, 263);
            this.textBox.Margin = new System.Windows.Forms.Padding(0);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(1279, 987);
            this.textBox.TabIndex = 1;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel.ColumnCount = 10;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel.Controls.Add(this.tab_view_Color, 6, 0);
            this.tableLayoutPanel.Controls.Add(this.tab_design_Color, 4, 0);
            this.tableLayoutPanel.Controls.Add(this.tab_edit_Color, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.tab_file_Color, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 69);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1279, 50);
            this.tableLayoutPanel.TabIndex = 2;
            // 
            // tab_view_Color
            // 
            this.tab_view_Color.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tab_view_Color.Controls.Add(this.tab_view_Button);
            this.tab_view_Color.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_view_Color.Location = new System.Drawing.Point(267, 0);
            this.tab_view_Color.Margin = new System.Windows.Forms.Padding(0);
            this.tab_view_Color.Name = "tab_view_Color";
            this.tab_view_Color.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.tab_view_Color.Size = new System.Drawing.Size(86, 50);
            this.tab_view_Color.TabIndex = 3;
            // 
            // tab_view_Button
            // 
            this.tab_view_Button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tab_view_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_view_Button.FlatAppearance.BorderSize = 0;
            this.tab_view_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tab_view_Button.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tab_view_Button.Location = new System.Drawing.Point(0, 0);
            this.tab_view_Button.Margin = new System.Windows.Forms.Padding(0);
            this.tab_view_Button.Name = "tab_view_Button";
            this.tab_view_Button.Size = new System.Drawing.Size(86, 42);
            this.tab_view_Button.TabIndex = 0;
            this.tab_view_Button.Text = "보기";
            this.tab_view_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tab_view_Button.UseVisualStyleBackColor = false;
            this.tab_view_Button.Click += new System.EventHandler(this.tab_view_Button_Click);
            // 
            // tab_design_Color
            // 
            this.tab_design_Color.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tab_design_Color.Controls.Add(this.tab_design_Button);
            this.tab_design_Color.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_design_Color.Location = new System.Drawing.Point(178, 0);
            this.tab_design_Color.Margin = new System.Windows.Forms.Padding(0);
            this.tab_design_Color.Name = "tab_design_Color";
            this.tab_design_Color.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.tab_design_Color.Size = new System.Drawing.Size(86, 50);
            this.tab_design_Color.TabIndex = 2;
            // 
            // tab_design_Button
            // 
            this.tab_design_Button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tab_design_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_design_Button.FlatAppearance.BorderSize = 0;
            this.tab_design_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tab_design_Button.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tab_design_Button.Location = new System.Drawing.Point(0, 0);
            this.tab_design_Button.Margin = new System.Windows.Forms.Padding(0);
            this.tab_design_Button.Name = "tab_design_Button";
            this.tab_design_Button.Size = new System.Drawing.Size(86, 42);
            this.tab_design_Button.TabIndex = 0;
            this.tab_design_Button.Text = "서식";
            this.tab_design_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tab_design_Button.UseVisualStyleBackColor = false;
            this.tab_design_Button.Click += new System.EventHandler(this.tab_design_Button_Click);
            // 
            // tab_edit_Color
            // 
            this.tab_edit_Color.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tab_edit_Color.Controls.Add(this.tab_edit_Button);
            this.tab_edit_Color.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_edit_Color.Location = new System.Drawing.Point(89, 0);
            this.tab_edit_Color.Margin = new System.Windows.Forms.Padding(0);
            this.tab_edit_Color.Name = "tab_edit_Color";
            this.tab_edit_Color.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.tab_edit_Color.Size = new System.Drawing.Size(86, 50);
            this.tab_edit_Color.TabIndex = 1;
            // 
            // tab_edit_Button
            // 
            this.tab_edit_Button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tab_edit_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_edit_Button.FlatAppearance.BorderSize = 0;
            this.tab_edit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tab_edit_Button.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tab_edit_Button.Location = new System.Drawing.Point(0, 0);
            this.tab_edit_Button.Margin = new System.Windows.Forms.Padding(0);
            this.tab_edit_Button.Name = "tab_edit_Button";
            this.tab_edit_Button.Size = new System.Drawing.Size(86, 42);
            this.tab_edit_Button.TabIndex = 0;
            this.tab_edit_Button.Text = "편집";
            this.tab_edit_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tab_edit_Button.UseVisualStyleBackColor = false;
            this.tab_edit_Button.Click += new System.EventHandler(this.tab_edit_Button_Click);
            // 
            // tab_file_Color
            // 
            this.tab_file_Color.BackColor = System.Drawing.Color.DodgerBlue;
            this.tab_file_Color.Controls.Add(this.tab_file_Button);
            this.tab_file_Color.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_file_Color.Location = new System.Drawing.Point(0, 0);
            this.tab_file_Color.Margin = new System.Windows.Forms.Padding(0);
            this.tab_file_Color.Name = "tab_file_Color";
            this.tab_file_Color.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.tab_file_Color.Size = new System.Drawing.Size(86, 50);
            this.tab_file_Color.TabIndex = 0;
            // 
            // tab_file_Button
            // 
            this.tab_file_Button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tab_file_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_file_Button.FlatAppearance.BorderSize = 0;
            this.tab_file_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tab_file_Button.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tab_file_Button.Location = new System.Drawing.Point(0, 0);
            this.tab_file_Button.Margin = new System.Windows.Forms.Padding(0);
            this.tab_file_Button.Name = "tab_file_Button";
            this.tab_file_Button.Size = new System.Drawing.Size(86, 42);
            this.tab_file_Button.TabIndex = 0;
            this.tab_file_Button.Text = "파일";
            this.tab_file_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tab_file_Button.UseVisualStyleBackColor = false;
            this.tab_file_Button.Click += new System.EventHandler(this.tab_file_Button_Click);
            // 
            // tab_toolBox
            // 
            this.tab_toolBox.Controls.Add(this.control_Panel);
            this.tab_toolBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_toolBox.Location = new System.Drawing.Point(0, 119);
            this.tab_toolBox.Margin = new System.Windows.Forms.Padding(4);
            this.tab_toolBox.Name = "tab_toolBox";
            this.tab_toolBox.Size = new System.Drawing.Size(1279, 144);
            this.tab_toolBox.TabIndex = 3;
            // 
            // control_Panel
            // 
            this.control_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.control_Panel.Location = new System.Drawing.Point(0, 0);
            this.control_Panel.Margin = new System.Windows.Forms.Padding(6);
            this.control_Panel.Name = "control_Panel";
            this.control_Panel.Size = new System.Drawing.Size(1279, 144);
            this.control_Panel.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TextEditor_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1279, 1250);
            this.Controls.Add(this.tab_toolBox);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.windows_panel);
            this.Controls.Add(this.textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TextEditor_Form";
            this.Text = "TextEditor";
            this.Load += new System.EventHandler(this.TextEditor_Form_Load);
            this.windows_panel.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tab_view_Color.ResumeLayout(false);
            this.tab_design_Color.ResumeLayout(false);
            this.tab_edit_Color.ResumeLayout(false);
            this.tab_file_Color.ResumeLayout(false);
            this.tab_toolBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel windows_panel;
        private System.Windows.Forms.Button LOGO;
        public System.Windows.Forms.Label windows_text;
        private System.Windows.Forms.Button hide_button;
        private System.Windows.Forms.Button windows_button;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel tab_toolBox;
        private System.Windows.Forms.Panel tab_file_Color;
        private System.Windows.Forms.Button tab_file_Button;
        private System.Windows.Forms.Panel tab_view_Color;
        private System.Windows.Forms.Button tab_view_Button;
        private System.Windows.Forms.Panel tab_design_Color;
        private System.Windows.Forms.Button tab_design_Button;
        private System.Windows.Forms.Panel tab_edit_Color;
        private System.Windows.Forms.Button tab_edit_Button;
        private Tab.Control_File control_Panel;
        public System.Windows.Forms.SaveFileDialog saveFileDialog1;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}