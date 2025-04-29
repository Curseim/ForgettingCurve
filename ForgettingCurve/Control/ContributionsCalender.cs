using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForgettingCurve.Control
{
    public partial class ContributionsCalender : UserControl
    {

        private List<Button> _buttons;
        private int _year;
        private int[][] _monthDayArray;
        private int[] _daysEachMonth;
        private bool _isLeapYear;


        public ContributionsCalender(int _p_year)
        {
            InitializeComponent();




            this._year = _p_year;

            _buttons = new List<Button>();

            _monthDayArray = new int[12][];

            // 월별 일수 배열 선언.
            _daysEachMonth = new int[12];




            // 월별 일수 배열에 값 대입.
            Set_DaysEachMonth(_year, _daysEachMonth);

            for (int i = 0; i < 12; i++)
            {
      //          _monthDayArray[i] = new int[i][];
        //        for (int j = 0; j < _daysEachMonth[i]; j++)
            }






            




            for (int i = 0; i < 52; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    var _btn = new Button();
                    // 위치·크기 설정…
                    _btn.Size = new Size(20, 20);
                    _btn.Location = new Point(i * (21 + 0), j * (21 + 0));
                    this.Controls.Add(_btn);
                    _buttons.Add(_btn);        // 리스트에도 추가
                                               // Flat 스타일 적용
                    _btn.FlatStyle = FlatStyle.Popup;
                    // 테두리 제거
                    _btn.FlatAppearance.BorderSize = 0;
                    // BackColor가 제대로 반영되도록
                    _btn.UseVisualStyleBackColor = false;


                    // 여백 없이 딱 맞게
                    _btn.Margin = new Padding(1);
                    _btn.Padding = new Padding(1);

                }

            }

        }




        // 월별 일수 배열에 값 대입.
        private static void Set_DaysEachMonth(int _year, int[] _daysEachMonth)
        {
            _daysEachMonth[1] = 31;
            _daysEachMonth[2] = 28;
            _daysEachMonth[3] = 31;
            _daysEachMonth[4] = 30;
            _daysEachMonth[5] = 31;
            _daysEachMonth[6] = 30;
            _daysEachMonth[7] = 31;
            _daysEachMonth[8] = 31;
            _daysEachMonth[9] = 30;
            _daysEachMonth[10] = 31;
            _daysEachMonth[11] = 30;
            _daysEachMonth[12] = 31;

            // 윤년 판별.
            if (_year % 400 == 0 || (_year % 4 != 0 && _year % 100 != 0))
                _daysEachMonth[2] = 29;
        }
    }

}
