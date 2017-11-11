using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace MedianFilter
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		void LoadFileButtonClick(object sender, EventArgs e)
		{
			if (ofd.ShowDialog(this) == DialogResult.OK)
				Filter();
		}

		void RaiusTrackBarScroll(object sender, EventArgs e)
		{
			radiusLabel.Text = $"Radius: {radiusTrackBar.Value} px";
			if (originalPictureBox.Image != null)
				Filter();
		}

		void Filter()
		{
			var bitmap = new Bitmap(Image.FromFile(ofd.FileName));
			originalPictureBox.Image = bitmap;

			int[,] pixels = new int[bitmap.Width, bitmap.Height];
			for (int x = 0; x < bitmap.Width; x++)
				for (int y = 0; y < bitmap.Height; y++)
					pixels[x, y] = bitmap.GetPixel(x, y).ToArgb();

			radiusTrackBar.Enabled = false;
			loadFileButton.Enabled = false;
			status.Text = "Processing...";
			var r = radiusTrackBar.Value;
			worker.RunWorkerAsync(new FilterModel
			{
				Pixels = pixels,
				Radius = r
			});
		}

		void DoFilter(object sender, DoWorkEventArgs e)
		{
			var arg = (FilterModel)e.Argument;
			var pixels = arg.Pixels;
			var r = arg.Radius;
			var w = pixels.GetLongLength(0);
			var h = pixels.GetLongLength(1);

			var newPixels = Median.Filter(pixels, r);
			e.Result = newPixels;
		}

		void FilterCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			var resultPixels = (int[,])e.Result;
			var w = resultPixels.GetLength(0);
			var h = resultPixels.GetLength(1);

			var newBitmap = new Bitmap(w, h, PixelFormat.Format32bppArgb);
			for (int x = 0; x < w; x++)
				for (int y = 0; y < h; y++)
					newBitmap.SetPixel(x, y, Color.FromArgb(resultPixels[x, y]));

			filteredPictureBox.Image = newBitmap;
			status.Text = "Done";
			radiusTrackBar.Enabled = true;
			loadFileButton.Enabled = true;
		}
	}

	class FilterModel
	{
		public int[,] Pixels { get; set; }

		public long Radius { get; set; }
	}
}