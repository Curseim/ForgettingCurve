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
            this.DubugFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DubugFormButton
            // 
            this.DubugFormButton.Location = new System.Drawing.Point(1625, 52);
            this.DubugFormButton.Margin = new System.Windows.Forms.Padding(4);
            this.DubugFormButton.Name = "DubugFormButton";
            this.DubugFormButton.Size = new System.Drawing.Size(172, 34);
            this.DubugFormButton.TabIndex = 7;
            this.DubugFormButton.Text = "디버그창 열기";
            this.DubugFormButton.UseVisualStyleBackColor = true;
            this.DubugFormButton.Click += new System.EventHandler(this.DubugFormButton_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1899, 1024);
            this.Controls.Add(this.DubugFormButton);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button DubugFormButton;
    }
}