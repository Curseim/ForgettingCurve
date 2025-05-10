using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForgettingCurve.Control
{
    public partial class DateButton : Button
    {

        public event EventHandler<DateButton_Click_EventArgs> DateButtonOnClick;

        public event EventHandler<DateButton_MouseEnter_EventArgs> DateButtonOnMouseEnter;




        public static string DATE_KEY_FORMAT = "yyyy-MM-dd";

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

            int _r, _g, _b;

            _r = this.BackColor.R;
            _g = this.BackColor.G;
            _b = this.BackColor.B;

            for (int i = 0; i < p_val; i++)
            {
                _r -= 15;
                _g -= 6;
                _b -= 20;

                if (_r < 0 || _b < 0 || _b < 0)
                {
                    _r += 15;
                    _g += 6;
                    _b += 20;
                }
            }

            this.BackColor = Color.FromArgb(_r, _g, _b);
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
