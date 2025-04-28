using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ForgettingCurve
{
    public partial class MainForm : Form
    {

        FileEditor FileEditor = new FileEditor();
        

        public MainForm()
        {
            InitializeComponent();
        }

        private void newFile_Click(object sender, EventArgs e) {
            mainPanel.Controls.Add(FileEditor);
        }

        private void MainForm_Load(object sender, EventArgs e) {

        }
    }
}
