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

            _contributionsCalender.DateBoxClicked += Ctrl_DateClicked;
            _contributionsCalender.DateBoxMouseHovered += Ctrl_MouseHovered;
            this.Controls.Add(_contributionsCalender);
        }


        // 절차 생성
        private void Ctrl_DateClicked(object sender, DateBoxClickedEventArgs e)
        {
            // 컨트롤에서 전달된 날짜 사용
            DateTime date = e.Date;
            DateButton _button = sender as DateButton;
            if (_button == null)
            {
                labelDebug.Text = "NULL";
                return;
            }
            var dateInfo = (DateTime)_button.Tag;

            //            MessageBox.Show($"선택된 날짜: {e.Date:yyyy-MM-dd}");
            //            MessageBox.Show($"버튼 클릭: {dateInfo:yyyy-MM-dd}");

            _contributionsCalender.AddContributionCount(dateInfo, 1);
            labelDebug.Text = e.Date.ToString("yyyy-MM-dd") + " | " +  _contributionsCalender.GetContributionCount(dateInfo).ToString();
        }

        private void Ctrl_MouseHovered(object sender, EventArgs e)
        {
            DateButton _button = sender as DateButton;
            if (_button == null)
            {
                return;
            }

            var dateInfo = _button.Tag;

            toolTip1.SetToolTip(_button, dateInfo.ToString());
        }



        // 디자이너 생성
        private void ContributionsCalender_DateBoxClicked(object sender, DateBoxClickedEventArgs e)
        {
            ContributionsCalender.AddContributionCount(e.Date, 1);
            labelDebug.Text = e.Date.ToString("yyyy-MM-dd") + " | " + ContributionsCalender.GetContributionCount(e.Date).ToString();
        }

        private void ContributionsCalender_DateBoxMouseHovered(object sender, DateBoxMouseHoveredEventArgs e)
        {
            toolTip1.SetToolTip(ContributionsCalender, e.Date.ToString("yyyy-MM-dd"));
        }
    }
}

