using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForgettingCurve.Control
{
    public partial class DateButton : Button
    {

        private Color COLOR_MAX = Color.FromArgb(0, 135, 0);
        private Color COLOR_MIN = Color.FromArgb(220, 250, 230);
        private Color INIT_COLOR;

        public static string DATE_KEY_FORMAT = "yyyy-MM-dd";


        public event EventHandler<DateButton_Click_EventArgs> DateButtonOnClick;

        public event EventHandler<DateButton_MouseEnter_EventArgs> DateButtonOnMouseEnter;




        public DateTime DateTime {  get; set; }
        public int Value { get; set; } 



        [ToolboxItem(true)]
        [Description("날짜 정보를 담는 버튼")]
        public DateButton()
        {
            InitializeComponent();
        }

        public DateButton(DateTime p_dateTime)
        {
            InitializeComponent();

            this.DateTime = p_dateTime;
        }


        public void AddValue(int p_val = 1)
        {
            Value += p_val;
            SetButtonColor();
        }

        public void SubtractValue(int p_val = 1)
        {
            Value -= p_val;
            SetButtonColor();
        }

        private void SetButtonColor()
        {
            this.BackColor = LerpColor(COLOR_MIN, COLOR_MAX, (double)Value / 10);

            if (this.Value <= 0)
            {
                this.BackColor = INIT_COLOR;
            }
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            DateButtonOnClick?.Invoke(this, new DateButton_Click_EventArgs(DateTime));
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            DateButtonOnMouseEnter?.Invoke(this, new DateButton_MouseEnter_EventArgs(DateTime));
        }


        public static Color LerpColor(Color start, Color end, double fraction)
        {
            // fraction을 0~1 사이로 클램프
            fraction = Math.Min(1, Math.Max(0, fraction));

            int r = (int)(start.R + (end.R - start.R) * fraction);
            int g = (int)(start.G + (end.G - start.G) * fraction);
            int b = (int)(start.B + (end.B - start.B) * fraction);
            int a = (int)(start.A + (end.A - start.A) * fraction);

            return Color.FromArgb(a, r, g, b);
        }

    }


    public class DateButton_DateComparer : IComparer<DateButton>
    {
        public int Compare(DateButton x, DateButton y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;

            return x.DateTime.CompareTo(y.DateTime);
        }
    }

    public class DateButton_Click_EventArgs : EventArgs
    {
        public DateTime DateTime { get; }
        public DateButton_Click_EventArgs(DateTime p_dateTime) => DateTime = p_dateTime;
    };

    public class DateButton_MouseEnter_EventArgs : EventArgs
    {
        public DateTime DateTime { get; }
        public DateButton_MouseEnter_EventArgs(DateTime p_dateTime) => DateTime = p_dateTime;

    };

}
