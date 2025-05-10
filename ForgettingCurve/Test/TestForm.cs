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

            _contributionsCalender = new ContributionsCalender(2025);
            _contributionsCalender.InnerDateButtonClick += Ctrl_DateClick;
            _contributionsCalender.InnerDateButtonMouseEnter += Ctrl_MouseEnter;
            this.Controls.Add(_contributionsCalender);
        }


        // 절차 생성
        private void Ctrl_DateClick(object sender, InnerDateButton_Click_EventArgs e)
        {
            _contributionsCalender.AddContributionCount(e.DateTime);
            labelDebug.Text = e.DateTime.ToString(DateButton.DATE_KEY_FORMAT) + " | " + _contributionsCalender.GetContributionCount((sender as DateButton).DateTime);
        }

        private void Ctrl_MouseEnter(object sender, InnerDateButton_MouseEnter_EventArgs e)
        {
            toolTip1.SetToolTip(sender as Button, e.DateTime.Date.ToString(DateButton.DATE_KEY_FORMAT));
        }


        // 사전 생성
        private void ContributionsCalender_InnerDateButtonClick(object sender, InnerDateButton_Click_EventArgs e)
        {
            ContributionsCalender.AddContributionCount(e.DateTime);
            labelDebug.Text = e.DateTime.ToString(DateButton.DATE_KEY_FORMAT) + " | " + ContributionsCalender.GetContributionCount((sender as DateButton).DateTime);
        }

        private void ContributionsCalender_InnerDateButtonMouseEnter(object sender, InnerDateButton_MouseEnter_EventArgs e)
        {
            toolTip1.SetToolTip(sender as Button, e.DateTime.Date.ToString(DateButton.DATE_KEY_FORMAT));
        }
    }
}

