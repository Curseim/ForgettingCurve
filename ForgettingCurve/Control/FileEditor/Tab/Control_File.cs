using System;
using System.Windows.Forms;

namespace ForgettingCurve.Control.FileEditor.Tab {
    public partial class Control_File : UserControl {
        public Control_File() {
            InitializeComponent();
        }

        private void tool_newFIle_Click(object sender, EventArgs e) {

            if (TextEditor_Form.Instance.TB.Text != "") {
                DialogResult dr =  MessageBox.Show("작성한 글이 초기화 됩니다.", "새로 만들기", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes) {
                    TextEditor_Form.Instance.TB.Text = "";
                } else { }
            }
            else TextEditor_Form.Instance.TB.Text = "";
        }

        private void tool_fileOpen_Click(object sender, EventArgs e) {
            TextEditor_Form.Instance.openFileDialog1.Filter = "텍스트 파일|*.txt|모든 파일|*.*";
            TextEditor_Form.Instance.openFileDialog1.FilterIndex = 0;
            TextEditor_Form.Instance.openFileDialog1.InitialDirectory 
                = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            TextEditor_Form.Instance.openFileDialog1.FileName = "";

            if (TextEditor_Form.Instance.openFileDialog1.ShowDialog() == DialogResult.OK) {
                TextEditor_Form.Instance.windows_text.Text = TextEditor_Form.Instance.openFileDialog1.FileName + " - 텍스트 편집기";
            }
        }

        private void tool_saveFile_Click(object sender, EventArgs e) {
            TextEditor_Form.Instance.saveFileDialog1.AddExtension = true;
            TextEditor_Form.Instance.saveFileDialog1.DefaultExt = "txt";
            TextEditor_Form.Instance.saveFileDialog1.OverwritePrompt = true;
            TextEditor_Form.Instance.saveFileDialog1.FileName = "";
            TextEditor_Form.Instance.saveFileDialog1.InitialDirectory
                = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            TextEditor_Form.Instance.saveFileDialog1.FileName = "";

            if (TextEditor_Form.Instance.saveFileDialog1.ShowDialog() == DialogResult.OK) {
                TextEditor_Form.Instance.windows_text.Text = TextEditor_Form.Instance.saveFileDialog1.FileName + " - 텍스트 편집기";
            }
        }
    }
}
