using Emgu.CV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaptureVideo
{
	public partial class Form1 : Form
	{
		private string videoPath = string.Empty;
		private string saveDir = string.Empty;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void SelectVideoPath(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog1 = new OpenFileDialog();     //显示选择文件对话框
			openFileDialog1.InitialDirectory = "c:\\";
			openFileDialog1.Filter = "All files (*.*)|*.*|video files|*.mp4;*.wmv";
			openFileDialog1.FilterIndex = 2;
			openFileDialog1.RestoreDirectory = true;

			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				this.videoPath = openFileDialog1.FileName;
				this.videoPathTxtBox.Text = openFileDialog1.FileName;          //显示文件路径
			}
		}

		private void SelectSaveDirBtn_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
			folderBrowserDialog1.SelectedPath = "C:\\";
			if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				this.saveDir = folderBrowserDialog1.SelectedPath;
				this.saveDirTxtBox.Text = folderBrowserDialog1.SelectedPath;
			}
		}

		private async void CaptureVideoFrame_Click(object sender, EventArgs e)
		{

			try
			{
				if (videoPath == string.Empty || saveDir == string.Empty)
				{
					return;
				}
				Task task = Task.Run(() => CaptureVideo(videoPath, saveDir));
				this.message.Text = "处理中...";
				
				await task;
				this.message.Text = "完成";
			}catch
			{
				this.message.Text = "失败";
				return;
			}
		}
		private static void CaptureVideo(string video, string saveDir)
		{
			using (VideoCapture capture = new VideoCapture(video))
			{
				if (!capture.IsOpened)
				{
					throw new Exception($"视频 [{video}] 打开失败");
				}

				int index = 0;
				using (Mat mat = new Mat())
				{
					capture.Read(mat);
					while (!mat.IsEmpty)
					{
						mat.Bitmap.Save($"{System.IO.Path.Combine(saveDir, index.ToString())}.bmp");
						capture.Read(mat);
						index++;
					}
				}
				Console.WriteLine("视频读取完毕");

			}
		}
	}
}
