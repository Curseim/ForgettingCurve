using ForgettingCurve.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForgettingCurve
{
    internal static class Program
    {
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 모니터 해상도가 달라질 때 윈도우 창이 흐리게 보이는 현상을 수정했습니다.
            if (Environment.OSVersion.Version.Major >= 6) {
                SetProcessDPIAware();
            }
            #if TEST
                Application.Run(new TestForm());
            #else
                Application.Run(new MainForm());
            #endif
        }

        // 윈도우 폼 DPI를 직접 설정
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

    }
}
