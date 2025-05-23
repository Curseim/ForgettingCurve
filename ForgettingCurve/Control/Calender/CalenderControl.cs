﻿using ForgettingCurve.Class.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForgettingCurve.Control.Calender
{
    public partial class CalenderControl : UserControl
    {
        private CalenderContainer _calenderContainer;
        private DataRepository _repo;
        private string _dirPath;
        private string _fileName = "Data";

        public CalenderControl()
        {
            InitializeComponent();

            init();
        }

        private void init()
        {
            List<DataEntryModel> _entries = new List<DataEntryModel>();

            this.Controls.Add(_calenderContainer = new CalenderContainer());
            _calenderContainer.KeyEvent += Key_Event;

            this.Size = new Size(_calenderContainer.Size.Width, _calenderContainer.Size.Height + 800);

            DateLabel.Text = DateTime.Now.ToString("yyyy년 M월 d일");
            DateLabel.Location = new Point(50, _calenderContainer.Height + 50);
            DebugButton.Location = new Point(DateLabel.Location.X + DateLabel.Width + 200, _calenderContainer.Height + 40);

            _dirPath = Application.StartupPath;
            _repo = new DataRepository(_dirPath + "\\" + _fileName + ".Json");
            _entries = _repo.GetAll();
            foreach (DataEntryModel entry in _entries)
                _calenderContainer.AddContributionCount(DateTime.ParseExact(entry.Key, DataEntryModel.KEY_FORMAT, CultureInfo.InvariantCulture).Date);
        }

        private void Key_Event(object sender, Key_EventArgs e)
        {
            DateLabel.Text = DateTime.ParseExact(e.Key, DataEntryModel.KEY_FORMAT, CultureInfo.InvariantCulture).ToString("yyyy년 M월 d일");

            flowLayoutPanel.Controls.Clear();

            List<DataEntryModel> _entries = _repo.Search(x => DateTime.ParseExact(x.Key, DataEntryModel.KEY_FORMAT, CultureInfo.InvariantCulture).Date == DateTime.ParseExact(e.Key, DataEntryModel.KEY_FORMAT, CultureInfo.InvariantCulture).Date);
            foreach (DataEntryModel _entry in _entries)
            {
                EntryBox _entryBox = new EntryBox(DateTime.ParseExact(_entry.Key, DataEntryModel.KEY_FORMAT, CultureInfo.InvariantCulture), _entry.Title);
                flowLayoutPanel.Controls.Add(_entryBox);
                _entryBox.EntryBoxOnClick += EntryBox_Click;
            }
        }

        private void EntryBox_Click(object sender, EntryBox_Click_EventArgs e)
        {
            DataDebugForm _dataDebugForm = new DataDebugForm(_dirPath, _fileName, e.DateTime);
            _dataDebugForm.FileDataModified += DataModified;
            _dataDebugForm.Show();
        }

        private void DebugButton_Click(object sender, EventArgs e)
        {
            DataDebugForm _dataDebugForm = new DataDebugForm(_dirPath, _fileName);
            _dataDebugForm.FileDataModified += DataModified;
            _dataDebugForm.Show();
        }

        private void DataModified(object sender, FileDataModified_Event e)
        {
            _calenderContainer.AddContributionCount(e.DateTime, e.ChangedCount);
            _repo = new DataRepository(_dirPath + "\\" + _fileName + ".Json");
        }
    }
}
