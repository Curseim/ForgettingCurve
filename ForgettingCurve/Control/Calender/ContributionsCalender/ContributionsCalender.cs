using ForgettingCurve.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForgettingCurve.Control
{

    public partial class ContributionsCalender : UserControl
    {
        public DateTime DateTime { get; set; }

        private List<DateButton> InnerDateButtonList;



        public event EventHandler<InnerDateButton_Click_EventArgs> InnerDateButtonClick;

        public event EventHandler<InnerDateButton_MouseEnter_EventArgs> InnerDateButtonMouseEnter;




        public ContributionsCalender()
            : this(2025)
        { }

        public ContributionsCalender(int p_year = 2025)
        {
            InitializeComponent();


            DateTime = new DateTime(p_year, 1, 1);
            this.InnerDateButtonList = new List<DateButton>();
            Init_DateInnerDateButtonList();
        }


        public int AddContributionCount(DateTime p_year, int p_count = 1)
        {
            InnerDateButtonList[GetInnerDateButtonIndex(p_year)].AddValue(p_count);
            return 0;
        }

        public int GetContributionCount(DateTime p_dateTime)
        {
            return InnerDateButtonList[GetInnerDateButtonIndex(p_dateTime)].Value;
        }



        private void Init_DateInnerDateButtonList()
        {
            DateTime _dateTime;

            int _x_Shift = 0;
            int _y_Shift = 0;
            int _widthDateButton = 20;
            int _heightDateButton = 20;
            int _margDateButton = 1;
            int _padDateButton = 1;

            _y_Shift++;

            label_Sunday.Location = new Point(_x_Shift, (_heightDateButton + (_margDateButton * 2)) * (0 + _y_Shift));
            label_Wednesday.Location = new Point(_x_Shift, (_heightDateButton + (_margDateButton * 2)) * (3 + _y_Shift));
            label_Saturday.Location = new Point(_x_Shift, (_heightDateButton + (_margDateButton * 2)) * (6 + _y_Shift));
            _x_Shift++;


            for (int month = 1; month <= 12; month++)
            {

                System.Windows.Forms.Label _label = new System.Windows.Forms.Label();

                _label.Location = new Point(_x_Shift * (_widthDateButton + _margDateButton), _y_Shift - 1);
                _label.Size = new Size(_widthDateButton * 2, _heightDateButton);
                _label.Text = month.ToString();
                this.Controls.Add(_label);




                for (int day = 1; day <= DateTime.DaysInMonth(DateTime.Year, month); day++)
                {
                    _dateTime = new DateTime(DateTime.Year, month, day);
                    DateButton _button = new DateButton(_dateTime);


                    _button.Location = new Point(_x_Shift * (_button.Size.Width + 1), ((int)_dateTime.DayOfWeek + _y_Shift) * (_button.Size.Height + 1));
                    _button.DateTime = new DateTime(_dateTime.Year, month, day).Date;
                    _button.DateButtonOnClick += DateButton_Click;
                    _button.DateButtonOnMouseEnter += DateButton_MouseHover;


                    this.Controls.Add(_button);
                    this.InnerDateButtonList.Add(_button);


                    if (_dateTime.DayOfWeek == DayOfWeek.Saturday)
                        _x_Shift++;
                }

            }


            this.Size = new Size((InnerDateButtonList[0].Width + _margDateButton) * (_x_Shift + 1), (InnerDateButtonList[0].Height + _margDateButton) * (7 + _y_Shift));
        }


        private int GetInnerDateButtonIndex(DateTime p_year)
        {
            DateButton _button = new DateButton();
            _button.DateTime = p_year.Date;

            DateButton_DateComparer _comparer = new DateButton_DateComparer();
            InnerDateButtonList.Sort(_comparer);

            return InnerDateButtonList.BinarySearch(_button, _comparer);
        }


        private void DateButton_Click(object sender, EventArgs e)
        {
            InnerDateButtonClick?.Invoke(sender, new InnerDateButton_Click_EventArgs((sender as DateButton).DateTime.Date));
        }


        private void DateButton_MouseHover(object sender, EventArgs e)
        {
            InnerDateButtonMouseEnter?.Invoke(sender, new InnerDateButton_MouseEnter_EventArgs((sender as DateButton).DateTime.Date));
        }

    }




    // 내부의 DateButton클릭시, 해당 DateButton의 DateTime을 보냄.
    public class InnerDateButton_Click_EventArgs : EventArgs
    {
        public DateTime DateTime { get; }
        public InnerDateButton_Click_EventArgs(DateTime p_dateTime) => DateTime = p_dateTime;
    };

    public class InnerDateButton_MouseEnter_EventArgs : EventArgs
    {
        public DateTime DateTime { get; }
        public InnerDateButton_MouseEnter_EventArgs(DateTime p_dateTime) => DateTime = p_dateTime;

    };

}
