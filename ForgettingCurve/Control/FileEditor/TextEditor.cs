using ForgettingCurve.Control.FileEditor.Tab;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ForgettingCurve.Control.FileEditor {
    public partial class TextEditor_Form : Form {
        public TextEditor_Form() {
            InitializeComponent();
        }

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

        private void windows_text_MouseDown(object sender, MouseEventArgs e) {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        #endregion

        #region ◆ 외부 코드 접근 영역

        static TextEditor_Form textEditor;

        private void TextEditor_Form_Load(object sender, EventArgs e) {
            textEditor = this;
        }

        public static TextEditor_Form Instance {

            get {

                if (textEditor == null) {
                    textEditor = new TextEditor_Form();
                }

                return textEditor;
            }
        }

        public TextBox TB {
            get { return textBox; }
            set { textBox = value; }
        }

        #endregion

        #region 윈도우 창 버튼 코드 영역

        // 현재 윈도우의 최대화/기본 상태 표시 (false시 최대화)
        private bool normalSize = true;

        private void close_button_Click(object sender, EventArgs e) {
            this.Hide();
        }

        private void windows_button_Click(object sender, EventArgs e) {

            if (normalSize) {
                this.WindowState = FormWindowState.Maximized;
                windows_button.Text = "2";
            }

            else {
                this.WindowState = FormWindowState.Normal; 
                windows_button.Text = "1";
            }

            normalSize = !normalSize;
        }

        private void hide_button_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region 탭 버튼 코드 영역

        private void tab_file_Button_Click(object sender, EventArgs e) {
            tabColorInit();
            tab_file_Color.BackColor = Color.DodgerBlue;
            Control_File control = new Control_File();
            addUserControl(control);
        }

        private void tab_edit_Button_Click(object sender, EventArgs e) {
            tabColorInit();
            tab_edit_Color.BackColor = Color.DodgerBlue;
            Control_Edit control = new Control_Edit();
            addUserControl(control);
        }

        private void tab_design_Button_Click(object sender, EventArgs e) {
            tabColorInit();
            tab_design_Color.BackColor = Color.DodgerBlue;
            Control_Design control = new Control_Design();
            addUserControl(control);
        }

        private void tab_view_Button_Click(object sender, EventArgs e) {
            tabColorInit();
            tab_view_Color.BackColor = Color.DodgerBlue;
            Control_View control = new Control_View();
            addUserControl(control);
        }
        private void tabColorInit() {
            tab_file_Color.BackColor = System.Drawing.SystemColors.ButtonFace;
            tab_design_Color.BackColor = System.Drawing.SystemColors.ButtonFace;
            tab_edit_Color.BackColor = System.Drawing.SystemColors.ButtonFace;
            tab_view_Color.BackColor = System.Drawing.SystemColors.ButtonFace;
        }

        private void addUserControl(UserControl uc) {
            uc.Dock = DockStyle.Fill;
            control_Panel.Controls.Clear();
            control_Panel.Controls.Add(uc);
            uc.BringToFront();
        }



        #endregion

        
    }
}
