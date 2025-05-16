using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ForgettingCurve.Class.Data
{
    public partial class DataDebugForm : Form
    {
        private string _path;

        public DataDebugForm()
        {
            InitializeComponent();
            Init(Directory.GetCurrentDirectory(), Application.ProductName);
        }
        public DataDebugForm(string p_dirPath, string p_fileName)
        {
            InitializeComponent();
            Init(p_dirPath, p_fileName);
        }

        private void Init(string p_dirPath, string p_fileName)
        {
            DateTime _dateTime = DateTime.Now;

            DirPathTextBox.Text = p_dirPath;
            FileNameTextBox.Text = p_fileName;
            FileFormetComboBox.Text = ".Json";
            _path = p_dirPath + "\\" + p_fileName + FileFormetComboBox.Text;
            FilePathLabel.Text = "설정 경로 및 이름 >> " + _path;

            dateTimePicker.Value = _dateTime;
            HourNumericUpDown.Value = _dateTime.Hour;
            MinuteNumericUpDown.Value = _dateTime.Minute;
            SecondNumericUpDown.Value = _dateTime.Second;

            if (TimeBindingCheckBox.Checked)
                SecondTimer.Start();
        }

        private void SetFilePathButton_Click(object sender, EventArgs e)
        {
            _path = DirPathTextBox.Text + "\\" + FileNameTextBox.Text + FileFormetComboBox.Text;
            FilePathLabel.Text = "설정 경로 및 이름 >> " + _path;
        }

        private void AddFileDataButton_Click(object sender, EventArgs e)
        {
            DateTime _dateTime = dateTimePicker.Value.Date;




            if (Decimal.TryParse(ForgCurveScalarTextBox.Text, out decimal value))
            {
                if (!(0 <= value && value <= 100))
                {
                    MessageBox.Show(
                        ForgCurvScalarLabel.Text + " - 0 이상 100 이하 입력",
                        ForgCurvScalarLabel.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

            }
            else
            {
                MessageBox.Show(
                    ForgCurvScalarLabel.Text + " - 실수만 입력",
                    ForgCurvScalarLabel.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }




            _dateTime =
                _dateTime
                    .AddHours((double)HourNumericUpDown.Value)
                    .AddMinutes((double)MinuteNumericUpDown.Value)
                    .AddSeconds((double)SecondNumericUpDown.Value);

            DataEntryModel _data = new DataEntryModel()
            {
                FirstEntryTime = _dateTime.ToString(DataEntryModel.KEY_FORMAT),
                LastEntryTime = _dateTime.ToString(DataEntryModel.KEY_FORMAT),
                ForgCurvLevel = (int)Decimal.Parse(ForgCurvLevelComboBox.Text),
                ForgCurvScalar = (int)Decimal.Parse(ForgCurveScalarTextBox.Text),
                RemembrRatio = (double)RememberRatioNumericUpDown.Value,
                Title = TitleTextBox.Text,
                Contents = ContentTextBox.Text
            };


            
            FileManager.AppendToFile(_path, _data);

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

        private void SecondTimer_Tick(object sender, EventArgs e)
        {
            DateTime _dateTime = DateTime.Now;

            dateTimePicker.Value = _dateTime;
            HourNumericUpDown.Value = _dateTime.Hour;
            MinuteNumericUpDown.Value = _dateTime.Minute;
            SecondNumericUpDown.Value = _dateTime.Second;
        }

        private void TimeBindingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (TimeBindingCheckBox.Checked)
                SecondTimer.Start();
            else
                SecondTimer.Stop();
        }

        private void ReadDataByDateTimeButton_Click(object sender, EventArgs e)
        {
            DateTime _dateTime = dateTimePicker.Value.Date;

            _dateTime =
                _dateTime
                    .AddHours((double)HourNumericUpDown.Value)
                    .AddMinutes((double)MinuteNumericUpDown.Value)
                    .AddSeconds((double)SecondNumericUpDown.Value);

            DataRepository _repo = new DataRepository(_path);
            List<DataEntryModel> _dataEntries = _repo.Search(x => x.Key == _dateTime.ToString(DataEntryModel.KEY_FORMAT));
            DataEntryModel _dataEntry;

            if (_dataEntries.Count < 1)
            {
                MessageBox.Show(
                    "찾지 못함",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            else
                _dataEntry = _dataEntries[0];

            ForgCurvLevelComboBox.Text = _dataEntry.ForgCurvLevel.ToString();
            ForgCurveScalarTextBox.Text = _dataEntry.ForgCurvScalar.ToString();
            RememberRatioNumericUpDown.Value = (decimal)_dataEntry.RemembrRatio;
            TitleTextBox.Text = _dataEntry.Title;
            ContentTextBox.Text = _dataEntry.Contents;
        }

        private void ModifyDataByDateTimeButton_Click(object sender, EventArgs e)
        {
            DateTime _dateTime = dateTimePicker.Value.Date;

            _dateTime =
                _dateTime
                    .AddHours((double)HourNumericUpDown.Value)
                    .AddMinutes((double)MinuteNumericUpDown.Value)
                    .AddSeconds((double)SecondNumericUpDown.Value);

            DataRepository _repo = new DataRepository(_path);
            List<DataEntryModel> _dataEntries = _repo.Search(x => x.Key == _dateTime.ToString(DataEntryModel.KEY_FORMAT));
            DataEntryModel _dataEntry;


            if (_dataEntries.Count < 1)
            {
                MessageBox.Show(
                    "찾지 못함",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }


            _dataEntry = new DataEntryModel()
            {
                FirstEntryTime = _dateTime.ToString(DataEntryModel.KEY_FORMAT),
                LastEntryTime = _dateTime.ToString(DataEntryModel.KEY_FORMAT),
                ForgCurvLevel = (int)Decimal.Parse(ForgCurvLevelComboBox.Text),
                ForgCurvScalar = (int)Decimal.Parse(ForgCurveScalarTextBox.Text),
                RemembrRatio = (double)RememberRatioNumericUpDown.Value,
                Title = TitleTextBox.Text,
                Contents = ContentTextBox.Text
            };

            _repo.Modify(x => x.Key == _dataEntry.Key, _dataEntry);
            _repo.Save();
        }
    }
}
