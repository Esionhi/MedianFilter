namespace MedianFilter
{
	partial class FormMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.filteredPictureBox = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.originalPictureBox = new System.Windows.Forms.PictureBox();
			this.radiusTrackBar = new System.Windows.Forms.TrackBar();
			this.loadFileButton = new System.Windows.Forms.Button();
			this.radiusLabel = new System.Windows.Forms.Label();
			this.ofd = new System.Windows.Forms.OpenFileDialog();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.status = new System.Windows.Forms.ToolStripStatusLabel();
			this.worker = new System.ComponentModel.BackgroundWorker();
			this.tableLayoutPanel1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.filteredPictureBox)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radiusTrackBar)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(680, 357);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.filteredPictureBox);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(343, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(334, 351);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Filtered";
			// 
			// filteredPictureBox
			// 
			this.filteredPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.filteredPictureBox.Location = new System.Drawing.Point(3, 16);
			this.filteredPictureBox.Name = "filteredPictureBox";
			this.filteredPictureBox.Size = new System.Drawing.Size(328, 332);
			this.filteredPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.filteredPictureBox.TabIndex = 0;
			this.filteredPictureBox.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.originalPictureBox);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(334, 351);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Original";
			// 
			// originalPictureBox
			// 
			this.originalPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.originalPictureBox.Location = new System.Drawing.Point(3, 16);
			this.originalPictureBox.Name = "originalPictureBox";
			this.originalPictureBox.Size = new System.Drawing.Size(328, 332);
			this.originalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.originalPictureBox.TabIndex = 0;
			this.originalPictureBox.TabStop = false;
			// 
			// radiusTrackBar
			// 
			this.radiusTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.radiusTrackBar.AutoSize = false;
			this.radiusTrackBar.LargeChange = 2;
			this.radiusTrackBar.Location = new System.Drawing.Point(118, 391);
			this.radiusTrackBar.Name = "radiusTrackBar";
			this.radiusTrackBar.Size = new System.Drawing.Size(574, 25);
			this.radiusTrackBar.TabIndex = 1;
			this.radiusTrackBar.Value = 3;
			this.radiusTrackBar.Scroll += new System.EventHandler(this.RaiusTrackBarScroll);
			// 
			// loadFileButton
			// 
			this.loadFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.loadFileButton.Location = new System.Drawing.Point(12, 375);
			this.loadFileButton.Name = "loadFileButton";
			this.loadFileButton.Size = new System.Drawing.Size(100, 41);
			this.loadFileButton.TabIndex = 2;
			this.loadFileButton.Text = "Load file";
			this.loadFileButton.UseVisualStyleBackColor = true;
			this.loadFileButton.Click += new System.EventHandler(this.LoadFileButtonClick);
			// 
			// radiusLabel
			// 
			this.radiusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.radiusLabel.AutoSize = true;
			this.radiusLabel.Location = new System.Drawing.Point(115, 375);
			this.radiusLabel.Name = "radiusLabel";
			this.radiusLabel.Size = new System.Drawing.Size(66, 13);
			this.radiusLabel.TabIndex = 3;
			this.radiusLabel.Text = "Radius: 3 px";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
			this.statusStrip1.Location = new System.Drawing.Point(0, 419);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(704, 22);
			this.statusStrip1.TabIndex = 4;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// status
			// 
			this.status.Name = "status";
			this.status.Size = new System.Drawing.Size(157, 17);
			this.status.Text = "Click load file button to start";
			// 
			// worker
			// 
			this.worker.WorkerReportsProgress = true;
			this.worker.WorkerSupportsCancellation = true;
			this.worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DoFilter);
			this.worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.FilterCompleted);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(704, 441);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.radiusLabel);
			this.Controls.Add(this.loadFileButton);
			this.Controls.Add(this.radiusTrackBar);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Median filter";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.filteredPictureBox)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radiusTrackBar)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.PictureBox filteredPictureBox;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox originalPictureBox;
		private System.Windows.Forms.TrackBar radiusTrackBar;
		private System.Windows.Forms.Button loadFileButton;
		private System.Windows.Forms.Label radiusLabel;
		private System.Windows.Forms.OpenFileDialog ofd;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel status;
		private System.ComponentModel.BackgroundWorker worker;
	}
}

