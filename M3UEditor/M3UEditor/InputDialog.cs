using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M3UEditor
{
    public partial class InputDialog : Form
    {
        public InputDialog()
        {
            InitializeComponent();
        }

        public string GroupName
        {
            get { return txtGroupName.Text; }
        }

        private void InputDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(GroupName))
            {
                e.Cancel = true;
            }
        }
    }
}
