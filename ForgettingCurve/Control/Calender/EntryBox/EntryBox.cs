using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForgettingCurve.Control
{
    public partial class EntryBox : Button
    {
        private DateTime DateTime;
        public Label TimeText;
        public Label TitleText;

        public string TIME_TEXT_FORMET = "tt h시 m분";

        public event EventHandler<EntryBox_Click_EventArgs> EntryBoxOnClick;


        public EntryBox()
        {
            InitializeComponent();
            init(DateTime.Now, "TitleText");
        }
        public EntryBox(DateTime p_dateTime, string p_titleString)
        {
            InitializeComponent();
            init(p_dateTime, p_titleString);
        }
        ~EntryBox()
        {
            TimeText.Dispose();
            TitleText.Dispose();
        }

        void init(DateTime p_dateTime, string p_titleString)
        {
            DateTime = p_dateTime;

            TimeText = new Label() { AutoSize = true, Text = DateTime.ToString(this.TIME_TEXT_FORMET) };
            TimeText.Location = new Point(ClientSize.Width - TimeText.Width - 50, (ClientSize.Height - TimeText.Height) / 2);
            TimeText.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            TitleText = new Label() { AutoSize = true, Text = p_titleString };
            TitleText.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            TitleText.Location = new Point(20, (ClientSize.Height - TimeText.Height) / 2);

            this.Controls.Add(TimeText);
            this.Controls.Add(TitleText);
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            EntryBoxOnClick?.Invoke(this, new EntryBox_Click_EventArgs(DateTime));
        }
    }

    public class EntryBox_Click_EventArgs : EventArgs
    {
        public DateTime DateTime { get; }
        public EntryBox_Click_EventArgs(DateTime p_dateTime) { DateTime = p_dateTime; }
    }
}
