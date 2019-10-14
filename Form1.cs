﻿using Emgu.CV;
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
        private int saveImgIndex = 0;

        private delegate void SetText(string progress);
        private SetText st;

        private void SetTextProgress(string progress)
        {
            this.message.Text = progress;
        }

        public Form1()
        {
            InitializeComponent();
            saveImgFormat.SelectedIndex = saveImgIndex;
            st = new SetText(SetTextProgress);
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

                await task;
                this.message.Text = "完成";
            }
            catch
            {
                this.message.Text = "失败";
                return;
            }
        }
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
                        else if(imgFormat == "png")
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
                        string progress = ((index + 1) / frameCount).ToString("P");
                        this.Invoke(st, progress);
                        capture.Read(mat);
                        index++;
                    }
                }
                Console.WriteLine("视频读取完毕");

            }
        }

        private void SaveImgFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            saveImgIndex = combo.SelectedIndex;
        }
    }
}
