using ForgettingCurve.Control;
using ForgettingCurve.Control.Calender;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;      // json
using Newtonsoft.Json.Linq; // json
using System.IO;            // 파일 관련
using ForgettingCurve.Class.Data;

namespace ForgettingCurve.Test
{
    public partial class TestForm : Form
    {

        ContributionsCalender _contributionsCalender;


        public TestForm()
        {
            InitializeComponent();

            CalenderContainer _calenderContainer = new CalenderContainer();
            this.Controls.Add(_calenderContainer);
            _calenderContainer.KeyEvent += KeyEvent;
        }

        private void KeyEvent(object sender, Key_EventArgs e)
        {
            labelDebug.Text = e.Key.ToString();
        }
    }
}

