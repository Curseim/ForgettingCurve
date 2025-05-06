using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForgettingCurve.Control.FileEditor {
    public partial class FileEditor : Form {
        public FileEditor() {
            InitializeComponent();
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e) {

            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.Filter = "텍스트 파일(*.txt)|*.txt|모든 파일|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                try {
                    File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e) {

            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "텍스트 파일(*.txt)|*.txt|모든 파일|*.*";
            saveFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                try {
                    textBox1.Text = File.ReadAllText(openFileDialog1.FileName);
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        // 폼이 꺼졌을 때 다시 호출하기 위해서 숨김 (Close할 시 불러올 수 없음)
        private void FileEditor_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = true;
            this.Hide();
        }
    }
}
