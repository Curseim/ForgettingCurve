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
            this.components = new System.ComponentModel.Container();
            this.labelDebug = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ContributionsCalender = new ForgettingCurve.Control.ContributionsCalender();
            this.SuspendLayout();
            // 
            // labelDebug
            // 
            this.labelDebug.AutoSize = true;
            this.labelDebug.Location = new System.Drawing.Point(621, 586);
            this.labelDebug.Name = "labelDebug";
            this.labelDebug.Size = new System.Drawing.Size(54, 18);
            this.labelDebug.TabIndex = 0;
            this.labelDebug.Text = "label1";
            // 
            // ContributionsCalender
            // 
            this.ContributionsCalender.BackColor = System.Drawing.SystemColors.Control;
            this.ContributionsCalender.Location = new System.Drawing.Point(360, 755);
            this.ContributionsCalender.Margin = new System.Windows.Forms.Padding(4);
            this.ContributionsCalender.Name = "ContributionsCalender";
            this.ContributionsCalender.Size = new System.Drawing.Size(1134, 168);
            this.ContributionsCalender.TabIndex = 1;
            this.ContributionsCalender.DateBoxClicked += new System.EventHandler<ForgettingCurve.Control.DateBoxClickedEventArgs>(this.ContributionsCalender_DateBoxClicked);
            this.ContributionsCalender.DateBoxMouseHovered += new System.EventHandler<ForgettingCurve.Control.DateBoxMouseHoveredEventArgs>(this.ContributionsCalender_DateBoxMouseHovered);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.ContributionsCalender);
            this.Controls.Add(this.labelDebug);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDebug;
        private System.Windows.Forms.ToolTip toolTip1;
        private Control.ContributionsCalender ContributionsCalender;
    }
}