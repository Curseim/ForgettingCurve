using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForgettingCurve.Class.Data
{
    public partial class DataDebugForm : Form
    {
        static public string _filePath;

        public DataDebugForm(string p_filePath)
        {
            InitializeComponent();

            _filePath = p_filePath;
            FilePathLabel.Text = "경로 : " + _filePath;
        }

        private void AddFileDataButton_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dateTimePicker.Value.Date;

            dateTime =
                dateTime
                    .AddHours((double)HourNumericUpDown.Value)
                    .AddMinutes((double)MinuteNumericUpDown.Value)
                    .AddSeconds((double)SecondNumericUpDown.Value);

            DataEntryModel _data = new DataEntryModel()
            {
                FirstEntryTime = dateTime.ToString("yyyy-MM-dd-HH:mm:ss"),
                LastEntryTime = dateTime.ToString("yyyy-MM-dd-HH:mm:ss"),
                ForgCurvLevel = 1,
                ForgCurvScalar = 25,
                RemembrRatio = 100,
                Title = TitleTextBox.Text,
                Contents = ContentTextBox.Text
            };

            FileManager.AppendToFile(_filePath, _data);

            TitleTextBox.Text = "";
            ContentTextBox.Text = "";
            SecondNumericUpDown.Value++;
            SecondNumericUpDown_ValueChanged(sender, e);
        }

        private void HourNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (HourNumericUpDown.Value > 23)
            {
                HourNumericUpDown.Value = 0;
                dateTimePicker.Value = dateTimePicker.Value.AddDays(1);

            } else if (HourNumericUpDown.Value < 0)
            {
                HourNumericUpDown.Value = 23;
                dateTimePicker.Value = dateTimePicker.Value.AddDays(-1);
            }
        }

        private void MinuteNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (MinuteNumericUpDown.Value > 59)
            {
                MinuteNumericUpDown.Value = 0;
                HourNumericUpDown.Value++;
                HourNumericUpDown_ValueChanged(sender, e);

            } else if (MinuteNumericUpDown.Value < 0)
            {
                MinuteNumericUpDown.Value = 59;
                HourNumericUpDown.Value--;
                HourNumericUpDown_ValueChanged(sender, e);
            }
        }

        private void SecondNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (SecondNumericUpDown.Value > 59)
            {
                SecondNumericUpDown.Value = 0;
                MinuteNumericUpDown.Value++;
                MinuteNumericUpDown_ValueChanged(sender, e);

            }
            else if (SecondNumericUpDown.Value < 0)
            {
                SecondNumericUpDown.Value = 59;
                MinuteNumericUpDown.Value--;
                MinuteNumericUpDown_ValueChanged(sender, e);
            }
        }
    }
}
