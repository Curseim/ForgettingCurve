namespace ForgettingCurve.Control
{
    partial class ContributionsCalender
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
            this.label_Sunday = new System.Windows.Forms.Label();
            this.label_Saturday = new System.Windows.Forms.Label();
            this.label_Wednesday = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Sunday
            // 
            this.label_Sunday.AutoSize = true;
            this.label_Sunday.Font = new System.Drawing.Font("굴림", 7F);
            this.label_Sunday.Location = new System.Drawing.Point(3, 0);
            this.label_Sunday.Name = "label_Sunday";
            this.label_Sunday.Size = new System.Drawing.Size(21, 14);
            this.label_Sunday.TabIndex = 0;
            this.label_Sunday.Text = "일";
            // 
            // label_Saturday
            // 
            this.label_Saturday.AutoSize = true;
            this.label_Saturday.Font = new System.Drawing.Font("굴림", 7F);
            this.label_Saturday.Location = new System.Drawing.Point(3, 129);
            this.label_Saturday.Name = "label_Saturday";
            this.label_Saturday.Size = new System.Drawing.Size(21, 14);
            this.label_Saturday.TabIndex = 1;
            this.label_Saturday.Text = "토";
            // 
            // label_Wednesday
            // 
            this.label_Wednesday.AutoSize = true;
            this.label_Wednesday.Font = new System.Drawing.Font("굴림", 7F);
            this.label_Wednesday.Location = new System.Drawing.Point(3, 61);
            this.label_Wednesday.Name = "label_Wednesday";
            this.label_Wednesday.Size = new System.Drawing.Size(21, 14);
            this.label_Wednesday.TabIndex = 2;
            this.label_Wednesday.Text = "수";
            // 
            // ContributionsCalender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.label_Wednesday);
            this.Controls.Add(this.label_Saturday);
            this.Controls.Add(this.label_Sunday);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ContributionsCalender";
            this.Size = new System.Drawing.Size(1112, 147);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Sunday;
        private System.Windows.Forms.Label label_Saturday;
        private System.Windows.Forms.Label label_Wednesday;
    }
}
