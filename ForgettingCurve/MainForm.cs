using ForgettingCurve.Control.Calender;
using ForgettingCurve.Control.FileEditor;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ForgettingCurve {
    public partial class MainForm : Form {

        #region ◆ 윈도우 dll 선언 부분 (Sub 부분)
        /* Form의 설정 중 FormBorderStyle(폼 테두리 스타일)을 None(없음)으로 설정 시 폼의 테두리가 없어져서
         * 드래그를 통해 폼의 위치를 옮길 수가 없는데 윈도우의 내장 dll파일을 이용하여 테두리가 없어도
         * 폼의 아무 부분을 클릭하고 드래그하면 이동 시킬 수 있는 형식으로 만들기 위해
         * dll을 Import한 SendMessage()와 ReleaseCapture()를 선언함
         * [요약] => 테두리가 없어진 윈도우 폼을 드래그로 이동시키기 위해 선언됨 */
        [DllImport("user32.dll")] public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")] public static extern bool ReleaseCapture();

        // Windows의 메시지 상수
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        private void windows_panel_MouseDown(object sender, MouseEventArgs e) {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
        #endregion

        TextEditor_Form textEditor = new TextEditor_Form();
        CalenderControl calenderControl = new CalenderControl();

        public MainForm() {
            InitializeComponent();
            // 윈도우 폼에 그림자를 추가하는 코드
            (new Core.DropShadow()).ApplyShadows(this);
        }

        private void MainForm_Load(object sender, EventArgs e) {
            this.Controls.Add(calenderControl);
            calenderControl.Visible = false;
        }

        private void newFile_Button_Click(object sender, EventArgs e) {
            // 비Dialog 방식 : 자식 폼 상관 없이 부모 폼을 컨트롤 할 수 있음 : .Show() 사용
            // Dialog 방식   : 자식 폼이 꺼지지 않으면 부모 폼을 컨트롤 할 수 없음 : .ShowDialog() 사용
            textEditor.Show(); // 비Dialog 방식으로 fileEditor 폼을 오픈
        }

        private void calender_Button_Click(object sender, EventArgs e)
        {
            calenderControl.Visible = true;
            recentFile_Text.Visible = false;
            recentFIle_Panel.Visible = false;
            //if (!calenderControl.IsDisposed)
            //    calenderControl.Dispose();
            calenderControl.Location = new Point(300, 200);
            calenderControl.BringToFront();
        }

        #region # 윈도우 창 버튼 코드 영역
        private void close_Button_Click(object sender, EventArgs e) {
            this.Close();
        }

        private bool normalSize = true;

        private void windows_Button_Click(object sender, EventArgs e) {
            if (normalSize) {
                this.WindowState = FormWindowState.Maximized;
                windows_Button.Text = "2";
            }

            else {
                this.WindowState = FormWindowState.Normal;
                windows_Button.Text = "1";
            }

            normalSize = !normalSize;
        }

        private void hide_button_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }


        #endregion

        private void home_Button_Click(object sender, EventArgs e) {
            calenderControl.Visible = false;
            recentFile_Text.Visible = true;
            recentFIle_Panel.Visible = true;
        }
    }
}
