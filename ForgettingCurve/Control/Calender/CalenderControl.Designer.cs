namespace ForgettingCurve.Control.Calender
{
    partial class CalenderControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.DateLabel = new System.Windows.Forms.Label();
            this.DebugButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CalenderContainerDesignOnly = new ForgettingCurve.Control.Calender.CalenderContainer();
            this.SuspendLayout();
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(50, 270);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(218, 18);
            this.DateLabel.TabIndex = 1;
            this.DateLabel.Text = "날짜 \"yyyy년 MM월 dd일\"";
            // 
            // DebugButton
            // 
            this.DebugButton.Location = new System.Drawing.Point(367, 265);
            this.DebugButton.Name = "DebugButton";
            this.DebugButton.Size = new System.Drawing.Size(205, 38);
            this.DebugButton.TabIndex = 2;
            this.DebugButton.Text = "데이터 디버그";
            this.DebugButton.UseVisualStyleBackColor = true;
            this.DebugButton.Click += new System.EventHandler(this.DebugButton_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel.Location = new System.Drawing.Point(50, 350);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(1150, 877);
            this.flowLayoutPanel.TabIndex = 3;
            // 
            // CalenderContainerDesignOnly
            // 
            this.CalenderContainerDesignOnly.Enabled = false;
            this.CalenderContainerDesignOnly.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.CalenderContainerDesignOnly.Location = new System.Drawing.Point(50, 50);
            this.CalenderContainerDesignOnly.Name = "CalenderContainerDesignOnly";
            this.CalenderContainerDesignOnly.Size = new System.Drawing.Size(1134, 168);
            this.CalenderContainerDesignOnly.TabIndex = 0;
            this.CalenderContainerDesignOnly.TabStop = false;
            this.CalenderContainerDesignOnly.Visible = false;
            // 
            // CalenderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.DebugButton);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.CalenderContainerDesignOnly);
            this.Name = "CalenderControl";
            this.Size = new System.Drawing.Size(1253, 1275);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CalenderContainer CalenderContainerDesignOnly;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Button DebugButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
    }
}
