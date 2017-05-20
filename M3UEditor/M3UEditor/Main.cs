using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace M3UEditor
{
    public partial class Main : Form
    {
        #region Fields

        /// <summary>
        /// Saves the parser instance.
        /// </summary>
        M3UParser _parser = null;

        #endregion

        /// <summary>
        /// Default-Constructor without parameters.
        /// </summary>
        public Main()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var fileDialog = new OpenFileDialog())
            {
                fileDialog.Filter = "M3U-FILES|*.m3u";
                fileDialog.Multiselect = false;

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    var file = fileDialog.FileName;
                    _parser = new M3UParser(file);
                    RefreshGrid();
                }
            }
        }

        #region Private Methods

        /// <summary>
        /// Populates the grid with the streams.
        /// </summary>
        private void RefreshGrid()
        {
            if (_parser != null)
            {
                if (chkAllChannels.Checked)
                {
                    dgvData.DataSource = _parser.StreamsWithoutGroup;
                }
                else
                {
                    dgvData.DataSource = _parser.Streams;
                }
            }

            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.AutoResizeColumns();
        }

        #endregion

        private void addToGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var inputdialog = new InputDialog())
            {
                if (inputdialog.ShowDialog() == DialogResult.OK)
                {
                    var name = inputdialog.GroupName;

                    foreach (var row in dgvData.SelectedRows.OfType<DataGridViewRow>().ToList())
                    {
                        var obj = row.DataBoundItem as Stream;

                        if (obj != null)
                        {
                            obj.Group = name;
                        }
                    }
                    RefreshGrid();
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_parser != null)
            {
                if (chkCreateFilePerGroup.Checked)
                {
                    var groups = _parser.Streams.Select(x => x.Group).Distinct().ToList();

                    foreach (var group in groups)
                    {
                        var writer = new StreamWriter($"d:\\Channels_{group}.m3u");

                        writer.WriteLine("#EXTM3U");

                        foreach (var stream in _parser.Streams.Where(x => x.Group == group).ToList())
                        {
                            writer.WriteLine(stream.ToString());
                        }

                        writer.Close();
                    }
                }
                else
                {
                    var writer = new StreamWriter("d:\\newList.m3u");

                    writer.WriteLine("#EXTM3U");

                    foreach (var stream in _parser.Streams)
                    {
                        writer.WriteLine(stream.ToString());
                    }

                    writer.Close();
                }
            }
        }

        private void chkAllChannels_CheckedChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }
    }
}
