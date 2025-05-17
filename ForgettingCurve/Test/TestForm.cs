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
        private CalenderControl _calenderControl;

        public TestForm()
        {
            InitializeComponent();

            this.Controls.Add(_calenderControl = new CalenderControl());
            _calenderControl.Location = new Point(50,50);
        }

    }
}

