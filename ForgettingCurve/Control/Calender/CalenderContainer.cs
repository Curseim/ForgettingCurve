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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ForgettingCurve.Control.Calender
{
    public partial class CalenderContainer : UserControl
    {
        public event EventHandler<Key_EventArgs> KeyEvent;

        private ContributionsCalender _contributionsCalender;
        private List<ContributionsCalender> ContributionsCalenderList;

        private int YearMax;
        private int YearMin;



        public CalenderContainer()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            DateTime _dateTime = DateTime.Now;
            YearMax = _dateTime.Year;
            YearMin = _dateTime.Year;

            _contributionsCalender = new ContributionsCalender(_dateTime.Year);
            ContributionsCalenderList = new List<ContributionsCalender>();
            ContributionsCalenderList.Insert(0, _contributionsCalender);
            _contributionsCalender.InnerDateButtonClick += Ctrl_DateClick;
            _contributionsCalender.InnerDateButtonMouseEnter += Ctrl_MouseEnter;


            CalenderflowLayoutPanel.Controls.Add(_contributionsCalender);
            CalenderflowLayoutPanel.Size = new Size(_contributionsCalender.Width + 50, _contributionsCalender.Height + 60);

            this.Size = CalenderflowLayoutPanel.Size;
            this.Location = new Point(0, 0);
        }

        private void Ctrl_DateClick(object sender, InnerDateButton_Click_EventArgs e)
        {
            KeyEvent?.Invoke(sender, new Key_EventArgs(e.DateTime));
        }

        private void Ctrl_MouseEnter(object sender, InnerDateButton_MouseEnter_EventArgs e)
        {
            toolTip1.SetToolTip(sender as DateButton, e.DateTime.Date.ToString(DateButton.DATE_KEY_FORMAT));
        }

        public void AddContributionCount(DateTime p_dateTime, int p_count = 1)
        {
            if (YearMin <= p_dateTime.Year && p_dateTime.Year <= YearMax)
            {
                GetContributionsCalender(p_dateTime.Year).AddContributionCount(p_dateTime, p_count);
                return;
            }


            while (p_dateTime.Year < YearMin)
            {
                ContributionsCalender _calender = new ContributionsCalender(--YearMin);
                ContributionsCalenderList.Insert(0, _calender);
                _calender.InnerDateButtonClick += Ctrl_DateClick;
                _calender.InnerDateButtonMouseEnter += Ctrl_MouseEnter;
                CalenderflowLayoutPanel.Controls.Add(_calender);
                CalenderflowLayoutPanel.Controls.SetChildIndex(_calender, 0);
            }

            while (p_dateTime.Year > YearMax)
            {
                ContributionsCalender _calender = new ContributionsCalender(++YearMax);
                ContributionsCalenderList.Add(_calender);
                _calender.InnerDateButtonClick += Ctrl_DateClick;
                _calender.InnerDateButtonMouseEnter += Ctrl_MouseEnter;
                CalenderflowLayoutPanel.Controls.Add(_calender);
            }

            GetContributionsCalender(p_dateTime.Year).AddContributionCount(p_dateTime, p_count);
        }

        private ContributionsCalender GetContributionsCalender(int p_year)
        {
            foreach (ContributionsCalender i in ContributionsCalenderList)
                if (i.DateTime.Year == p_year) return i;
            return null;
        }
    }

    public class Key_EventArgs : EventArgs
    {
        public string Key { get; }
        public Key_EventArgs(DateTime p_dateTime) => Key = p_dateTime.ToString("yyyy-MM-dd-HH:mm:ss");
    };
}
