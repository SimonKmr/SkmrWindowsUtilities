using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileManager;

namespace SkmrFileManager
{
    public partial class MainForm : Form
    {
        DirectoryAdv[] directoryArr;
        public MainForm()
        {
            InitializeComponent();
            cbbDrives.Items.AddRange(Drives.GetDriveNames());
            cbbDrives.SelectedIndex = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            pgbDefault.Value = 0;
            string selectedDrive = cbbDrives.SelectedItem.ToString();
            if (!bgwIndexFolders.IsBusy)
                bgwIndexFolders.RunWorkerAsync(selectedDrive);
        }

        private void bgwIndexFolders_DoWork(object sender, DoWorkEventArgs e)
        {
            var progress = new Progress<int>();
            progress.ProgressChanged += Progress_ProgressChanged;

            DirectoryAdv directory = new DirectoryAdv(e.Argument.ToString(),0);

            directory.GetAllElements(progress);
            directory.GetDirInfoRek(progress);
            directoryArr = directory.ToArray();

            for (int i = 0; i < directoryArr.Length; i++)
            {
                string[] r = { directoryArr[i].Path, directoryArr[i].Size.ToString() };
                double PrzntProgress = (i + 1) * 100 / directoryArr.Length;
                bgwIndexFolders.ReportProgress((int)PrzntProgress, r);
            }
        }

        private void Progress_ProgressChanged(object sender, int e)
        {
            bgwIndexFolders.ReportProgress(e);
        }

        private void bgwIndexFolders_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if(e.UserState != null)dgvBase.Rows.Add((string[]) e.UserState);
            if (e.ProgressPercentage % 5 == 0) pgbDefault.Value = e.ProgressPercentage;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if(directoryArr == null)
            {
                MessageBox.Show("Start once, before trying to filter or wait until the scan has finished", "Invalid Option");
                return;
            }
            if (!bgwFilterFolders.IsBusy)
            {
                dgvFilter.Rows.Clear();
                bgwFilterFolders.RunWorkerAsync();
            }
        }

        private void bgwFilterFolders_DoWork(object sender, DoWorkEventArgs e)
        {
            DirectoryAdv[] filterDirectoryArr = Indexer.Filter(directoryArr, (double)nudFileSize.Value);
            for (int i = 0; i < filterDirectoryArr.Length; i++)
            {
                string[] row = { filterDirectoryArr[i].Path, filterDirectoryArr[i].Size.ToString() };
                double progress = (i + 1) * 100 / filterDirectoryArr.Length;
                bgwFilterFolders.ReportProgress((int)progress, row);
            }
        }

        private void bgwFilterFolders_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            dgvFilter.Rows.Add((string[])e.UserState);
            if(e.ProgressPercentage % 5 == 0) pgbDefault.Value = e.ProgressPercentage;
        }

        private void bgwStructureInfo_DoWork(object sender, DoWorkEventArgs e)
        {
            bgwStructureInfo.ReportProgress(100, Indexer.GetInfo(directoryArr));
        }

        private void bgwStructureInfo_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            StructureInfo result = e.UserState as StructureInfo;
            txtFiles.Text = result.FileCount.ToString();
            txtFolder.Text = result.FolderCount.ToString();
            txtGB.Text = Math.Round(result.Size,2).ToString();
        }

        private void bgwIndexFolders_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bgwStructureInfo.RunWorkerAsync();
        }
    }
}
