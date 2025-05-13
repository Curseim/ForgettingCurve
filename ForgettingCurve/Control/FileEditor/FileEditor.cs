using System;
using System.IO;
using System.Windows.Forms;

namespace ForgettingCurve.Control.FileEditor {
    public partial class FileEditor : Form {

        /// <summary> 불러온 파일의 날짜 </summary>
        public static string File_date { get; private set; }

        /// <summary> 불러온 파일의 이름 </summary>
        public static string File_name { get; private set; }


        public FileEditor() {
            InitializeComponent();
        }

        /// <summary>
        /// 폼 초기화
        /// </summary>
        private void InitForm() {
            text_Box.Text = "";
        }

        // 폼이 꺼지기 전에 확인
        private void FileEditor_FormClosing(object sender, FormClosingEventArgs e) {

            DialogResult result = MessageBox.Show(this, "정말 종료하겠습니까?", "종료", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // 폼을 끄지 않고 숨김처리 (끄면 다시 불러올 수 없음)
            if (result == DialogResult.No) {
                e.Cancel = true;
            }
            else {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void FileEditor_Load(object sender, EventArgs e) {
            InitForm();
        }

        // 단축키 : Ctrl + S
        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e) {

            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.Filter = "텍스트 파일(*.txt)|*.txt|모든 파일|*.*";
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.OverwritePrompt = true;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                try {
                    File.WriteAllText(saveFileDialog1.FileName, text_Box.Text);
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        // 단축키 : Ctrl + Shift + S
        private void 다른이름으로저장ToolStripMenuItem_Click(object sender, EventArgs e) {

            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.Filter = "텍스트 파일(*.txt)|*.txt|모든 파일|*.*";
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.OverwritePrompt = true;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                try {
                    File.WriteAllText(saveFileDialog1.FileName, text_Box.Text);
                }

                catch (Exception ex) {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        // 단축키 : Ctrl + O
        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e) {

            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "텍스트 파일(*.txt)|*.txt|모든 파일|*.*";
            saveFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                try {
                    text_Box.Text = File.ReadAllText(openFileDialog1.FileName);
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        // 단축키 : Ctrl + N 
        private void 새로만들기NToolStripMenuItem_Click(object sender, EventArgs e) {
            // TextBox에 글이 써져있다면 MessageBox를 띄워 새로 만들기 여부 결정\
            // 25-05-09) comment : MessageBox가 부모 폼 중앙에 뜨지 않는 문제 발생 커스텀 폼으로 해결 예정
            if (text_Box.Text != "") {
                DialogResult result = MessageBox.Show(this, "정말 새로 만듭니까?", "확인",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes) {
                    InitForm();
                }

            }
        }


    }
}
