using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace ForgettingCurve.Control.FileEditor {
    public partial class TextEditor_Form : Form {

        public TextEditor_Form() {
            InitializeComponent();
        }

        private bool normalSize = true;


        #region 윈도우 창 버튼 코드 영역

        private void close_button_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void windows_button_Click(object sender, EventArgs e) {

            if (normalSize) {
                this.WindowState = FormWindowState.Maximized; }

            else {
                this.WindowState = FormWindowState.Normal; }

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
        }

        private void tab_edit_Button_Click(object sender, EventArgs e) {
            tabColorInit();
            tab_edit_Color.BackColor = Color.DodgerBlue;
        }

        private void tab_design_Button_Click(object sender, EventArgs e) {
            tabColorInit();
            tab_design_Color.BackColor = Color.DodgerBlue;
        }

        private void tab_show_Button_Click(object sender, EventArgs e) {
            tabColorInit();
            tab_show_Color.BackColor = Color.DodgerBlue;
        }
        private void tabColorInit() {
            tab_file_Color.BackColor = System.Drawing.SystemColors.ButtonFace;
            tab_design_Color.BackColor = System.Drawing.SystemColors.ButtonFace;
            tab_edit_Color.BackColor = System.Drawing.SystemColors.ButtonFace;
            tab_show_Color.BackColor = System.Drawing.SystemColors.ButtonFace;
        }

        #endregion
    }
}
