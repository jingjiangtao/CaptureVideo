namespace CaptureVideo
{
	partial class Form1
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
            this.selectVideo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.videoPathTxtBox = new System.Windows.Forms.TextBox();
            this.saveDirTxtBox = new System.Windows.Forms.TextBox();
            this.SelectSaveDirBtn = new System.Windows.Forms.Button();
            this.CaptureVideoFrame = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.Label();
            this.saveImgFormat = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectVideo
            // 
            this.selectVideo.Location = new System.Drawing.Point(539, 54);
            this.selectVideo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.selectVideo.Name = "selectVideo";
            this.selectVideo.Size = new System.Drawing.Size(110, 23);
            this.selectVideo.TabIndex = 0;
            this.selectVideo.Text = "选择";
            this.selectVideo.UseVisualStyleBackColor = true;
            this.selectVideo.Click += new System.EventHandler(this.SelectVideoPath);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 33);
            this.label1.TabIndex = 0;
            // 
            // videoPathTxtBox
            // 
            this.videoPathTxtBox.Location = new System.Drawing.Point(45, 54);
            this.videoPathTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.videoPathTxtBox.Name = "videoPathTxtBox";
            this.videoPathTxtBox.ReadOnly = true;
            this.videoPathTxtBox.Size = new System.Drawing.Size(455, 23);
            this.videoPathTxtBox.TabIndex = 1;
            this.videoPathTxtBox.Text = "选择视频";
            // 
            // saveDirTxtBox
            // 
            this.saveDirTxtBox.Location = new System.Drawing.Point(45, 118);
            this.saveDirTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveDirTxtBox.Name = "saveDirTxtBox";
            this.saveDirTxtBox.ReadOnly = true;
            this.saveDirTxtBox.Size = new System.Drawing.Size(455, 23);
            this.saveDirTxtBox.TabIndex = 2;
            this.saveDirTxtBox.Text = "选择保存图片的目录";
            // 
            // SelectSaveDirBtn
            // 
            this.SelectSaveDirBtn.Location = new System.Drawing.Point(539, 114);
            this.SelectSaveDirBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SelectSaveDirBtn.Name = "SelectSaveDirBtn";
            this.SelectSaveDirBtn.Size = new System.Drawing.Size(110, 27);
            this.SelectSaveDirBtn.TabIndex = 3;
            this.SelectSaveDirBtn.Text = "选择";
            this.SelectSaveDirBtn.UseVisualStyleBackColor = true;
            this.SelectSaveDirBtn.Click += new System.EventHandler(this.SelectSaveDirBtn_Click);
            // 
            // CaptureVideoFrame
            // 
            this.CaptureVideoFrame.Location = new System.Drawing.Point(539, 183);
            this.CaptureVideoFrame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CaptureVideoFrame.Name = "CaptureVideoFrame";
            this.CaptureVideoFrame.Size = new System.Drawing.Size(110, 25);
            this.CaptureVideoFrame.TabIndex = 4;
            this.CaptureVideoFrame.Text = "生成";
            this.CaptureVideoFrame.UseVisualStyleBackColor = true;
            this.CaptureVideoFrame.Click += new System.EventHandler(this.CaptureVideoFrame_Click);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(260, 284);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(32, 17);
            this.message.TabIndex = 5;
            this.message.Text = "进度";
            // 
            // saveImgFormat
            // 
            this.saveImgFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.saveImgFormat.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.saveImgFormat.FormattingEnabled = true;
            this.saveImgFormat.Items.AddRange(new object[] {
            "jpg",
            "png",
            "bmp"});
            this.saveImgFormat.Location = new System.Drawing.Point(45, 183);
            this.saveImgFormat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveImgFormat.Name = "saveImgFormat";
            this.saveImgFormat.Size = new System.Drawing.Size(455, 25);
            this.saveImgFormat.TabIndex = 6;
            this.saveImgFormat.SelectedIndexChanged += new System.EventHandler(this.SaveImgFormat_SelectedIndexChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(45, 251);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(455, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(539, 251);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(110, 23);
            this.cancel.TabIndex = 8;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 310);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.saveImgFormat);
            this.Controls.Add(this.message);
            this.Controls.Add(this.CaptureVideoFrame);
            this.Controls.Add(this.SelectSaveDirBtn);
            this.Controls.Add(this.saveDirTxtBox);
            this.Controls.Add(this.videoPathTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectVideo);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "生成视频帧";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button selectVideo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox videoPathTxtBox;
		private System.Windows.Forms.TextBox saveDirTxtBox;
		private System.Windows.Forms.Button SelectSaveDirBtn;
		private System.Windows.Forms.Button CaptureVideoFrame;
		private System.Windows.Forms.Label message;
        private System.Windows.Forms.ComboBox saveImgFormat;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button cancel;
    }
}

