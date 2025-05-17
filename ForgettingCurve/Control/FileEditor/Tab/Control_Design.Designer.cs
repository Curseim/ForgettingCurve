namespace ForgettingCurve.Control.FileEditor.Tab {
    partial class Control_Design {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control_Design));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tool_font = new System.Windows.Forms.Button();
            this.tool_fontSize = new System.Windows.Forms.Button();
            this.tool_textAlign = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 13;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 242F));
            this.tableLayoutPanel1.Controls.Add(this.tool_font, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tool_fontSize, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tool_textAlign, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(895, 97);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tool_font
            // 
            this.tool_font.BackColor = System.Drawing.SystemColors.Control;
            this.tool_font.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tool_font.FlatAppearance.BorderSize = 0;
            this.tool_font.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tool_font.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.tool_font.Image = ((System.Drawing.Image)(resources.GetObject("tool_font.Image")));
            this.tool_font.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tool_font.Location = new System.Drawing.Point(4, 4);
            this.tool_font.Margin = new System.Windows.Forms.Padding(1);
            this.tool_font.Name = "tool_font";
            this.tool_font.Size = new System.Drawing.Size(68, 68);
            this.tool_font.TabIndex = 0;
            this.tool_font.Text = "글씨체";
            this.tool_font.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tool_font.UseVisualStyleBackColor = false;
            this.tool_font.Click += new System.EventHandler(this.tool_font_Click);
            // 
            // tool_fontSize
            // 
            this.tool_fontSize.BackColor = System.Drawing.SystemColors.Control;
            this.tool_fontSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tool_fontSize.FlatAppearance.BorderSize = 0;
            this.tool_fontSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tool_fontSize.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.tool_fontSize.Image = ((System.Drawing.Image)(resources.GetObject("tool_fontSize.Image")));
            this.tool_fontSize.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tool_fontSize.Location = new System.Drawing.Point(74, 4);
            this.tool_fontSize.Margin = new System.Windows.Forms.Padding(1);
            this.tool_fontSize.Name = "tool_fontSize";
            this.tool_fontSize.Size = new System.Drawing.Size(68, 68);
            this.tool_fontSize.TabIndex = 1;
            this.tool_fontSize.Text = "글꼴 크기";
            this.tool_fontSize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tool_fontSize.UseVisualStyleBackColor = false;
            this.tool_fontSize.Click += new System.EventHandler(this.tool_fontSize_Click);
            // 
            // tool_textAlign
            // 
            this.tool_textAlign.BackColor = System.Drawing.SystemColors.Control;
            this.tool_textAlign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tool_textAlign.FlatAppearance.BorderSize = 0;
            this.tool_textAlign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tool_textAlign.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.tool_textAlign.Image = ((System.Drawing.Image)(resources.GetObject("tool_textAlign.Image")));
            this.tool_textAlign.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tool_textAlign.Location = new System.Drawing.Point(144, 4);
            this.tool_textAlign.Margin = new System.Windows.Forms.Padding(1);
            this.tool_textAlign.Name = "tool_textAlign";
            this.tool_textAlign.Size = new System.Drawing.Size(68, 68);
            this.tool_textAlign.TabIndex = 2;
            this.tool_textAlign.Text = "문자 정렬";
            this.tool_textAlign.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tool_textAlign.UseVisualStyleBackColor = false;
            this.tool_textAlign.Click += new System.EventHandler(this.tool_textAlign_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(73, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "글씨 설정";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Control_Design
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Control_Design";
            this.Size = new System.Drawing.Size(895, 97);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button tool_font;
        private System.Windows.Forms.Button tool_fontSize;
        private System.Windows.Forms.Button tool_textAlign;
        private System.Windows.Forms.Label label1;
    }
}
