using ForgettingCurve.Control.Calender;
using ForgettingCurve.Control.FileEditor;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ForgettingCurve {
    public partial class MainForm : Form {


        TextEditor_Form textEditor = new TextEditor_Form();
        FileEditor fileEditor = new FileEditor();
        CalenderControl calenderControl = new CalenderControl();

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {

        }

        private void newFile_Button_Click(object sender, EventArgs e) {
            // 비Dialog 방식 : 자식 폼 상관 없이 부모 폼을 컨트롤 할 수 있음 : .Show() 사용
            // Dialog 방식   : 자식 폼이 꺼지지 않으면 부모 폼을 컨트롤 할 수 없음 : .ShowDialog() 사용
            textEditor.Show(); // 비Dialog 방식으로 fileEditor 폼을 오픈
        }

        private void close_Button_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void calender_Button_Click(object sender, EventArgs e)
        {
            recentFile_Text.Visible = false;
            recentFIle_Panel.Visible = false;
            if (!calenderControl.IsDisposed)
                calenderControl.Dispose();
            calenderControl = new CalenderControl();
            this.Controls.Add(calenderControl);
            calenderControl.Location = new Point(300, 200);
            calenderControl.BringToFront();
        }
    }
}
