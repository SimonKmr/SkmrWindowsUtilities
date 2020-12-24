namespace SkmrFileManager
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.bgwIndexFolders = new System.ComponentModel.BackgroundWorker();
            this.btnStart = new System.Windows.Forms.Button();
            this.dgvBase = new System.Windows.Forms.DataGridView();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nudFileSize = new System.Windows.Forms.NumericUpDown();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFilter = new System.Windows.Forms.DataGridView();
            this.fPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbbDrives = new System.Windows.Forms.ComboBox();
            this.pgbDefault = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.txtFiles = new System.Windows.Forms.TextBox();
            this.txtGB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bgwFilterFolders = new System.ComponentModel.BackgroundWorker();
            this.bgwStructureInfo = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFileSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilter)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgwIndexFolders
            // 
            this.bgwIndexFolders.WorkerReportsProgress = true;
            this.bgwIndexFolders.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwIndexFolders_DoWork);
            this.bgwIndexFolders.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwIndexFolders_ProgressChanged);
            this.bgwIndexFolders.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwIndexFolders_RunWorkerCompleted);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 40);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(87, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // dgvBase
            // 
            this.dgvBase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Path,
            this.Size});
            this.dgvBase.Location = new System.Drawing.Point(3, 3);
            this.dgvBase.Name = "dgvBase";
            this.dgvBase.Size = new System.Drawing.Size(424, 473);
            this.dgvBase.TabIndex = 1;
            // 
            // Path
            // 
            this.Path.HeaderText = "Path";
            this.Path.Name = "Path";
            this.Path.ReadOnly = true;
            this.Path.Width = 280;
            // 
            // Size
            // 
            this.Size.HeaderText = "Size";
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            // 
            // nudFileSize
            // 
            this.nudFileSize.DecimalPlaces = 1;
            this.nudFileSize.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudFileSize.Location = new System.Drawing.Point(12, 112);
            this.nudFileSize.Name = "nudFileSize";
            this.nudFileSize.Size = new System.Drawing.Size(87, 20);
            this.nudFileSize.TabIndex = 2;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(12, 138);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(87, 23);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Minimum File Size";
            // 
            // dgvFilter
            // 
            this.dgvFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fPath,
            this.fSize});
            this.dgvFilter.Location = new System.Drawing.Point(433, 3);
            this.dgvFilter.Name = "dgvFilter";
            this.dgvFilter.Size = new System.Drawing.Size(424, 473);
            this.dgvFilter.TabIndex = 8;
            // 
            // fPath
            // 
            this.fPath.HeaderText = "Path";
            this.fPath.Name = "fPath";
            this.fPath.ReadOnly = true;
            this.fPath.Width = 280;
            // 
            // fSize
            // 
            this.fSize.HeaderText = "Size";
            this.fSize.Name = "fSize";
            this.fSize.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvBase, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvFilter, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(106, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(860, 479);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // cbbDrives
            // 
            this.cbbDrives.FormattingEnabled = true;
            this.cbbDrives.Location = new System.Drawing.Point(12, 15);
            this.cbbDrives.Name = "cbbDrives";
            this.cbbDrives.Size = new System.Drawing.Size(87, 21);
            this.cbbDrives.TabIndex = 10;
            // 
            // pgbDefault
            // 
            this.pgbDefault.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgbDefault.Location = new System.Drawing.Point(106, 497);
            this.pgbDefault.Name = "pgbDefault";
            this.pgbDefault.Size = new System.Drawing.Size(860, 23);
            this.pgbDefault.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Folder Count";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "File Count";
            // 
            // txtFolder
            // 
            this.txtFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFolder.Location = new System.Drawing.Point(12, 390);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(64, 20);
            this.txtFolder.TabIndex = 14;
            // 
            // txtFiles
            // 
            this.txtFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFiles.Location = new System.Drawing.Point(12, 429);
            this.txtFiles.Name = "txtFiles";
            this.txtFiles.Size = new System.Drawing.Size(64, 20);
            this.txtFiles.TabIndex = 15;
            // 
            // txtGB
            // 
            this.txtGB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtGB.Location = new System.Drawing.Point(12, 468);
            this.txtGB.Name = "txtGB";
            this.txtGB.Size = new System.Drawing.Size(64, 20);
            this.txtGB.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 452);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "GB Used";
            // 
            // bgwFilterFolders
            // 
            this.bgwFilterFolders.WorkerReportsProgress = true;
            this.bgwFilterFolders.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwFilterFolders_DoWork);
            this.bgwFilterFolders.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwFilterFolders_ProgressChanged);
            // 
            // bgwStructureInfo
            // 
            this.bgwStructureInfo.WorkerReportsProgress = true;
            this.bgwStructureInfo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwStructureInfo_DoWork);
            this.bgwStructureInfo.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwStructureInfo_ProgressChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 532);
            this.Controls.Add(this.txtGB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFiles);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pgbDefault);
            this.Controls.Add(this.cbbDrives);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.nudFileSize);
            this.Controls.Add(this.btnStart);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFileSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilter)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bgwIndexFolders;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.DataGridView dgvBase;
        private System.Windows.Forms.NumericUpDown nudFileSize;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFilter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbbDrives;
        private System.Windows.Forms.ProgressBar pgbDefault;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.TextBox txtFiles;
        private System.Windows.Forms.TextBox txtGB;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker bgwFilterFolders;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn fPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn fSize;
        private System.ComponentModel.BackgroundWorker bgwStructureInfo;
    }
}

