using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

/* 
 * 본 코드는 [테두리가 없는 윈도우 창] 에 그림자를 표현해주는 코드. (즉, FormborderStyle : None인 경우)
 * FormBorderStyle이 None일 경우 윈도우의 테두리가 없어지는데, 그와 동시에 원래 있던 그림자도 함께 사라지기 때문에
 * 본 코드의 ApplyShadows()를 이용해서 없어진 윈도우 창에 그림자 효과를 줄 수 있게됨.
 * 
 * 제작 중인 코드에 (new Core.DropShadow()).ApplyShadows(this); 로 사용함.
 */

namespace Core {
    public class DropShadow {
        #region Shadowing

        #region Fields

        private const int WM_NCHITTEST = 0x84;
        private const int WS_MINIMIZEBOX = 0x20000;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        private const int CS_DBLCLKS = 0x8;
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        #endregion

        #region Structures

        [EditorBrowsable(EditorBrowsableState.Never)]
        public struct MARGINS {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }

        #endregion

        #region Methods

        #region Public

        [DllImport("dwmapi.dll")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [DllImport("dwmapi.dll")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        #endregion

        #region Overrides

        /// <summary>
        /// 그림자를 표시합니다.
        /// </summary>
        /// <param name="form"> 현재 Form </param>
        public void ApplyShadows(Form form) {
            var v = 2;

            DwmSetWindowAttribute(form.Handle, 2, ref v, 4);

            MARGINS margins = new MARGINS() {
                bottomHeight = 1,
                leftWidth = 1,
                rightWidth = 1,
                topHeight = 1
            };
            
            DwmExtendFrameIntoClientArea(form.Handle, ref margins);
        }

        #endregion

        #endregion

        #endregion
    }
}