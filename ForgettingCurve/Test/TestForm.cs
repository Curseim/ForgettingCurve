using ForgettingCurve.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForgettingCurve.Test
{
    public partial class TestForm : Form
    {
        ContributionsCalender _contributionsCalender;

        public TestForm()
        {
            InitializeComponent();

            _contributionsCalender = new ContributionsCalender();

            _contributionsCalender.Location = new Point(20, 20);

            _contributionsCalender.DateClicked += Ctrl_DateClicked;
            _contributionsCalender.DateMouseHovered += Ctrl_MouseHovered;
            this.Controls.Add(_contributionsCalender);
        }


        private void Ctrl_DateClicked(object sender, DateClickedEventArgs e)
        {
            // 컨트롤에서 전달된 날짜 사용
            labelDebug.Text = "dateInfo.ToString();";
            Button _button = sender as Button;
            if (_button == null)
            {
                labelDebug.Text = "NULL";
                return;
            }
            var dateInfo = (DateTime)_button.Tag;

            //            MessageBox.Show($"선택된 날짜: {e.Date:yyyy-MM-dd}");
            //            MessageBox.Show($"버튼 클릭: {dateInfo:yyyy-MM-dd}");

            _contributionsCalender.Add_ContributionCount(dateInfo, 1);
            labelDebug.Text = dateInfo.ToString() + " | " +  _contributionsCalender.Get_ContributionCount(dateInfo).ToString();
        }

        private void Ctrl_MouseHovered(object sender, EventArgs e)
        {
            Button _button = sender as Button;
            if (_button == null)
            {
                return;
            }

            var dateInfo = _button.Tag;

            toolTip1.SetToolTip(_button, dateInfo.ToString());
        }

    }
}

