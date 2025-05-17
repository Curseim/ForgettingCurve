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

        public event EventHandler<FileDataModified_Event> FileDataModified;

        public DataDebugForm()
        {
            InitializeComponent();
            Init(Application.StartupPath, Application.ProductName);
        }
        public DataDebugForm(string p_dirPath, string p_fileName)
        {
            InitializeComponent();
            Init(p_dirPath, p_fileName);
        }
        public DataDebugForm(string p_dirPath, string p_fileName, DateTime p_dateTime)
        {
            InitializeComponent();
            Init(p_dirPath, p_fileName, p_dateTime);
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
        private void Init(string p_dirPath, string p_fileName, DateTime p_dateTime)
        {
            DirPathTextBox.Text = p_dirPath;
            FileNameTextBox.Text = p_fileName;
            FileFormetComboBox.Text = ".Json";
            _path = p_dirPath + "\\" + p_fileName + FileFormetComboBox.Text;
            FilePathLabel.Text = "설정 경로 및 이름 >> " + _path;

            TimeBindingCheckBox.Checked = false;
            if (SecondTimer.Enabled)
                SecondTimer.Stop();

            dateTimePicker.Value = p_dateTime;
            HourNumericUpDown.Value = p_dateTime.Hour;
            MinuteNumericUpDown.Value = p_dateTime.Minute;
            SecondNumericUpDown.Value = p_dateTime.Second;

            ReadEntry(p_dateTime);
        }

        private void SetFilePathButton_Click(object sender, EventArgs e)
        {
            _path = DirPathTextBox.Text + "\\" + FileNameTextBox.Text + FileFormetComboBox.Text;
            FilePathLabel.Text = "설정 경로 및 이름 >> " + _path;
        }

        private void AddFileDataButton_Click(object sender, EventArgs e)
        {
            DateTime _dateTime = GetAssembledDateTime();




            if (!IsValidEntry())
                return;




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

            FileDataModified?.Invoke(this, new FileDataModified_Event(_dateTime, 1));
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
            ReadEntry();
        }

        private void ModifyDataByDateTimeButton_Click(object sender, EventArgs e)
        {
            DateTime _dateTime = GetAssembledDateTime();

            DataRepository _repo = new DataRepository(_path);
            List<DataEntryModel> _dataEntries = _repo.Search(x => x.Key == _dateTime.ToString(DataEntryModel.KEY_FORMAT));
            DataEntryModel _dataEntry;

            if (!IsValidEntry())
                return;

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

            FileDataModified?.Invoke(this, new FileDataModified_Event(_dateTime, 0));
        }

        private void DeleteDataByDateTimeButton_Click(object sender, EventArgs e)
        {
            DateTime _dateTime = GetAssembledDateTime();

            DataRepository _repo = new DataRepository(_path);
            List<DataEntryModel> _dataEntries = _repo.Search(x => x.Key == _dateTime.ToString(DataEntryModel.KEY_FORMAT));

            if ( _dataEntries.Count < 1 )
            {
                MessageBox.Show(
                    "찾지 못함",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            _repo.Delete(x => x.Key == _dateTime.ToString(DataEntryModel.KEY_FORMAT));
            _repo.Save();

            FileDataModified?.Invoke(this, new FileDataModified_Event(_dateTime, -1));
        }

        private void ReadEntry()
        {
            DateTime _dateTime = GetAssembledDateTime();
            ReadEntry(_dateTime);
        }
        private void ReadEntry(DateTime p_dateTime)
        {
            DataRepository _repo = new DataRepository(_path);
            List<DataEntryModel> _dataEntries = _repo.Search(x => x.Key == p_dateTime.ToString(DataEntryModel.KEY_FORMAT));
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

        private DateTime GetAssembledDateTime()
        {
            DateTime _dateTime = dateTimePicker.Value.Date;

            _dateTime =
                _dateTime
                    .AddHours((double)HourNumericUpDown.Value)
                    .AddMinutes((double)MinuteNumericUpDown.Value)
                    .AddSeconds((double)SecondNumericUpDown.Value);

            return _dateTime;
        }

        private bool IsValidEntry()
        {
            if (Decimal.TryParse(ForgCurveScalarTextBox.Text, out decimal value))
            {
                if (!(0 <= value && value <= 100))
                {
                    MessageBox.Show(
                        ForgCurvScalarLabel.Text + " - 0 이상 100 이하 입력",
                        ForgCurvScalarLabel.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return false;
                }

            }
            else
            {
                MessageBox.Show(
                    ForgCurvScalarLabel.Text + " - 실수만 입력",
                    ForgCurvScalarLabel.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }

    public class FileDataModified_Event : EventArgs
    {
        public DateTime DateTime { get; }
        public int ChangedCount { get; }
        public FileDataModified_Event(DateTime p_dateTime, int p_changedCount = 0) { DateTime = p_dateTime; ChangedCount = p_changedCount; }
    }
}
