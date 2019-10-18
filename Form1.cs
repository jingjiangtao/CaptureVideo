using Emgu.CV;
using Emgu.CV.CvEnum;
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
        private int saveImgIndex = 0; // 下拉框默认值为0

        private Action<double> setText; // 显示进度的委托

        public Form1()
        {
            InitializeComponent();
            saveImgFormat.SelectedIndex = saveImgIndex; // 设置下拉框默认值

            // 显示进度的委托绑定
            setText += progress =>
            {                
                this.message.Text = progress.ToString("P");
                this.progressBar1.Value = Convert.ToInt32(progress * 100);
            };

            ProgressControlsVisible(false);
        }

        private void ProgressControlsVisible(bool visible)
        {
            this.message.Visible = visible;
            this.progressBar1.Visible = visible;
            this.cancel.Visible = visible;
        }

        private void SelectVideoPath(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();     //显示选择文件对话框
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
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.saveDir = folderBrowserDialog1.SelectedPath;
                this.saveDirTxtBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        // “生成”按钮的点击事件
        private async void CaptureVideoFrame_Click(object sender, EventArgs e)
        {
            try
            {
                if (videoPath == string.Empty || saveDir == string.Empty || saveImgIndex >= saveImgFormat.Items.Count)
                {
                    return;
                }
                string imgFormat = saveImgFormat.Items[saveImgIndex].ToString();
                Task task = Task.Run(() => CaptureVideo(videoPath, saveDir, imgFormat));
                ProgressControlsVisible(true);
                await task;
                this.message.Text = "完成";
            }
            catch
            {
                this.message.Text = "失败";                
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {

        }

        // 读取视频每一帧并保存为图片
        private void CaptureVideo(string video, string saveDir, string imgFormat)
        {
            using (VideoCapture capture = new VideoCapture(video))
            {
                if (!capture.IsOpened)
                {
                    throw new Exception($"视频 [{video}] 打开失败");
                }
                double frameCount = Math.Floor(capture.GetCaptureProperty(CapProp.FrameCount));
                int index = 0;
                using (Mat mat = new Mat())
                {
                    capture.Read(mat);
                    while (!mat.IsEmpty)
                    {
                        if (imgFormat == "jpg")
                        {
                            mat.Bitmap.Save($"{System.IO.Path.Combine(saveDir, index.ToString())}.jpg",
                                System.Drawing.Imaging.ImageFormat.Jpeg);
                        }
                        else if (imgFormat == "png")
                        {
                            mat.Bitmap.Save($"{System.IO.Path.Combine(saveDir, index.ToString())}.png",
                                System.Drawing.Imaging.ImageFormat.Png);
                        }
                        else if (imgFormat == "bmp")
                        {
                            mat.Bitmap.Save($"{System.IO.Path.Combine(saveDir, index.ToString())}.bmp",
                                System.Drawing.Imaging.ImageFormat.Bmp);
                        }
                        else
                        {
                            mat.Bitmap.Save($"{System.IO.Path.Combine(saveDir, index.ToString())}.jpg",
                                System.Drawing.Imaging.ImageFormat.Jpeg);
                        }
                        double progress = (index + 1) / frameCount;
                        this.Invoke(setText, progress);
                        capture.Read(mat);
                        index++;
                    }
                }
            }
        }

        // 下拉框的值改变时获取改变后的值
        private void SaveImgFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            saveImgIndex = combo.SelectedIndex;
        }

    }
}
