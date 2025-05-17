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




        public CalenderContainer()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            DateTime _dateTime = DateTime.Now;

            _contributionsCalender = new ContributionsCalender(_dateTime.Year);
            _contributionsCalender.InnerDateButtonClick += Ctrl_DateClick;
            _contributionsCalender.InnerDateButtonMouseEnter += Ctrl_MouseEnter;
            this.Controls.Add(_contributionsCalender);

            this.Size = new Size(_contributionsCalender.Size.Width, _contributionsCalender.Size.Height);
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
            _contributionsCalender.AddContributionCount(p_dateTime, p_count);
        }
    }

    public class Key_EventArgs : EventArgs
    {
        public string Key { get; }
        public Key_EventArgs(DateTime p_dateTime) => Key = p_dateTime.ToString("yyyy-MM-dd-HH:mm:ss");
    };
}
