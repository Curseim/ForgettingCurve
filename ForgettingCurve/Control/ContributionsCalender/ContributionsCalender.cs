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




        private List<DateButton> _buttonList;
        private List<int> _contribCountList;

        private double _avrgContribCount = 0;
        private int _ValidcontribCount = 0;


        private DateTime _dateTime;

        private object _selectedDateButtonTag= null;



        public event EventHandler<DateBoxClickedEventArgs> DateBoxClicked;
        public event EventHandler<DateBoxMouseHoveredEventArgs> DateBoxMouseHovered;



        public ContributionsCalender(int p_year = 2025)
        {
            InitializeComponent();


            _dateTime = new DateTime(p_year, 1, 1);

            this._buttonList = new List<DateButton>();
            this._contribCountList = new List<int>();



            Init_DateList(_dateTime.Year, _contribCountList);
            Init_DateButtonList();
        }


        public int Add_ContributionCount(DateTime p_dateTime, uint p_count = 1)
        {
            int _btnIdx;


            _btnIdx = GetDateButtonIndex(p_dateTime);

            int _r, _g, _b;

            _r = _buttonList[_btnIdx].BackColor.R;
            _g = _buttonList[_btnIdx].BackColor.G;
            _b = _buttonList[_btnIdx].BackColor.B;

            for (int i = 0; i < p_count; i++)
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

            _buttonList[_btnIdx].BackColor = Color.FromArgb(_r, _g, _b);

            if (_contribCountList[_btnIdx] == 0)
                _ValidcontribCount++;

            _contribCountList[_btnIdx] += (int)p_count;
            this._avrgContribCount += (double)p_count;
   //         Set_DateButtonColor(_buttonList[_btnIdx], _contribCountList[_btnIdx]);
            return 1;
        }

        public int Get_ContributionCount(DateTime p_dateTime)
        {
            return _contribCountList[GetDateButtonIndex(p_dateTime)];
        }





        // 윤년 판별.
        private static bool Is_LeapYear(int _year)
        {
            if (_year % 400 == 0 || (_year % 4 == 0 && _year % 100 != 0))
                return true;
            else
                return false;
        }


        

        // 날짜 리스트 채우기.
        private static void Init_DateList(int _year, List<int> _dateList)
        {
            int _dayCount = 365;
            if (Is_LeapYear(_year))
                _dayCount = 366;

            for (int i  = 0; i < _dayCount; i++)
            {
                _dateList.Add(0);

            }

            //for (int _month = 1; _month <= 12; _month++)
            //{
            //    list<int> _temp = new list<int>();

            //    switch (_month)
            //    {
            //        case 1:
            //        case 3:
            //        case 5:
            //        case 7:
            //        case 8:
            //        case 10:
            //        case 12:
            //            for (int i = 0; i < 31; i++)
            //                _temp.add(0);
            //            break;


            //        case 4:
            //        case 6:
            //        case 9:
            //        case 11:
            //            for (int i = 0; i < 30; i++)
            //                _temp.add(0);
            //            break;


            //        case 2:
            //            for (int i = 0; i < 28; i++)
            //                _temp.add(0);
            //            if (is_leapyear(_year))
            //                _temp.add(0);
            //            break;
            //    }

            //    _datelist.add(_temp);

            //}

        }




        private void Init_DateButtonList()
        {
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
  //              _label.Font = new Font(_label.Font.Name, 7);
                _label.Text = month.ToString();
                this.Controls.Add(_label);




                for (int day = 1; day <= DateTime.DaysInMonth(_dateTime.Year, month); day++)
                {
                    DateButton _button = new DateButton();

                    _dateTime = new DateTime(_dateTime.Year, month, day);

                    _button.FlatStyle = FlatStyle.Popup;
                    _button.FlatAppearance.BorderSize = 0;
                    _button.UseVisualStyleBackColor = false;

                    _button.Size = new Size(_widthDateButton, _heightDateButton);
                    _button.Margin = new Padding(_margDateButton);
                    _button.Padding = new Padding(_padDateButton);
                    _button.Location = new Point(_x_Shift * (_button.Size.Width + 1), ((int)_dateTime.DayOfWeek + _y_Shift) * (_button.Size.Height + 1));

                    _button.Tag = new DateButton().Tag = (_dateTime);
                    _button.date = _dateTime;
                    _button.Click += DateButton_Click;
                    _button.MouseHover += DateButton_MouseHover;

           //         _button.Click += (s, e) => {
           //             var dt = (DateTime)((DateButton)s).Tag;
           //            MessageBox.Show($"선택된 날짜: {dt:yyyy-MM-dd}");
           //                DateClicked?.Invoke(this, new DateClickedEventArgs(_dateTime));
           //
           //              };

                    this.Controls.Add(_button);
                    this._buttonList.Add(_button);

                    if (_dateTime.DayOfWeek == DayOfWeek.Saturday)
                        _x_Shift++;
                }

            }


            this.Size = new Size((_buttonList[0].Width + _margDateButton) * (_x_Shift + 1), (_buttonList[0].Height + _margDateButton) * (7 + _y_Shift));
        }


        private void DateButton_Click(object sender, EventArgs e)
        {
            var _button = sender as DateButton;
            if (_button == null) return;
            var dateInfo = (DateTime)_button.Tag;

            //          DateButtonDateComparer comparer = new DateButtonDateComparer();
            //         _buttonList.Sort(comparer);

            //         int idx = _buttonList.BinarySearch(_button, comparer);

            int idx = GetDateButtonIndex(dateInfo);

      //      MessageBox.Show($"내부 처리 | {idx}버튼 클릭: {dateInfo:yyyy-MM-dd}");
            DateBoxClicked?.Invoke(_button, new DateBoxClickedEventArgs(dateInfo));
        }


        private void DateButton_MouseHover(object sender, EventArgs e)
        {
            var _button = sender as DateButton;
            if (_button == null) return;
            var dateInfo = (DateTime)_button.Tag;

            int idx = GetDateButtonIndex(dateInfo);

            DateBoxMouseHovered?.Invoke(_button, new DateBoxMouseHoveredEventArgs(dateInfo));
        }

        private int GetDateButtonIndex(DateTime p_dateTime)
        {
            DateButton _button = new DateButton();
            _button.Tag = p_dateTime;

            DateButtonDateComparer comparer = new DateButtonDateComparer();
            _buttonList.Sort(comparer);

            return _buttonList.BinarySearch(_button, comparer);
        }


        public double avrgContribCount
        {
            get { return _avrgContribCount; }
            private set { _avrgContribCount = ((_avrgContribCount * 365) + value) / 365; }
        }

      

        private void Set_DateButtonColor(DateButton _button, int _CurContribCount)
        {
            Color _defaultColor = Color.FromArgb(220, 250, 200);
            Color _maxColor = Color.FromArgb(50, 220, 0);

            Color _btnColor;

            int _r, _g, _b;

            if (_CurContribCount == 0)
                return;

            if (_CurContribCount >= (int)_avrgContribCount)
            {
                _btnColor = _maxColor;
            }
            else if (_avrgContribCount > (_CurContribCount + 1))
            {
                _r = _maxColor.R + (_defaultColor.R - _maxColor.R) * (1 - ((int)_avrgContribCount + 1) / (_CurContribCount + 1));
                _g = (_maxColor.R - _defaultColor.R);
                _b = (_maxColor.R - _defaultColor.R);
                _btnColor = Color.FromArgb(_r, _g, _b);
            }
            else
            {
                _btnColor = _defaultColor;
            }
        }
        
    }

    public partial class DateButton : Button
    {
        public DateTime date { get; set; }
    }

    public class DateButtonDateComparer : IComparer<DateButton>
    {
        public int Compare(DateButton x, DateButton y)
        {
            // 널 체크
            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;

            // Tag를 DateTime으로 꺼내기
            var dx = (DateTime)x.Tag;
            var dy = (DateTime)y.Tag;

            // DateTime.CompareTo 사용
            return dx.CompareTo(dy);
        }
    }

    // DateClickedEventArgs 정의, DateBox클릭시 해당 DateBox의 DateTime을 보냄
    public class DateBoxClickedEventArgs : EventArgs
    {
        public DateTime Date { get; }
        public DateBoxClickedEventArgs(DateTime _date) => Date = _date;
    };

    public class DateBoxMouseHoveredEventArgs : EventArgs
    {
        public DateTime Date { get; }
        public DateBoxMouseHoveredEventArgs(DateTime _date) => Date = _date;

    };

}
