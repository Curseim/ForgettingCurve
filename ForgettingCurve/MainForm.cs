using ForgettingCurve.Control.FileEditor;
using System;
using System.Windows.Forms;

namespace ForgettingCurve
{
    public partial class MainForm : Form
    {
        FileEditor fileEditor = new FileEditor();

        public MainForm()
        {
            InitializeComponent();
        }

        private void newFile_Click(object sender, EventArgs e) {
            
        }

        private void MainForm_Load(object sender, EventArgs e) {

        }

        private void close_Button_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void newFile_Button_Click(object sender, EventArgs e) {
            // 비Dialog 방식 : 자식 폼 상관 없이 부모 폼을 컨트롤 할 수 있음 : .Show() 사용
            // Dialog 방식   : 자식 폼이 꺼지지 않으면 부모 폼을 컨트롤 할 수 없음 : .ShowDialog() 사용
            fileEditor.Show(); // 비Dialog 방식으로 fileEditor 폼을 오픈
        }
    }
}
