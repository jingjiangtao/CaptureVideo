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
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.videoPathTxtBox = new System.Windows.Forms.TextBox();
			this.saveDirTxtBox = new System.Windows.Forms.TextBox();
			this.SelectSaveDirBtn = new System.Windows.Forms.Button();
			this.CaptureVideoFrame = new System.Windows.Forms.Button();
			this.message = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(462, 38);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(94, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "选择";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.SelectVideoPath);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			// 
			// videoPathTxtBox
			// 
			this.videoPathTxtBox.Location = new System.Drawing.Point(39, 38);
			this.videoPathTxtBox.Name = "videoPathTxtBox";
			this.videoPathTxtBox.Size = new System.Drawing.Size(391, 21);
			this.videoPathTxtBox.TabIndex = 1;
			this.videoPathTxtBox.Text = "选择视频";
			// 
			// saveDirTxtBox
			// 
			this.saveDirTxtBox.Location = new System.Drawing.Point(39, 109);
			this.saveDirTxtBox.Name = "saveDirTxtBox";
			this.saveDirTxtBox.Size = new System.Drawing.Size(391, 21);
			this.saveDirTxtBox.TabIndex = 2;
			this.saveDirTxtBox.Text = "选择保存图片的目录";
			// 
			// SelectSaveDirBtn
			// 
			this.SelectSaveDirBtn.Location = new System.Drawing.Point(462, 106);
			this.SelectSaveDirBtn.Name = "SelectSaveDirBtn";
			this.SelectSaveDirBtn.Size = new System.Drawing.Size(94, 23);
			this.SelectSaveDirBtn.TabIndex = 3;
			this.SelectSaveDirBtn.Text = "选择";
			this.SelectSaveDirBtn.UseVisualStyleBackColor = true;
			this.SelectSaveDirBtn.Click += new System.EventHandler(this.SelectSaveDirBtn_Click);
			// 
			// CaptureVideoFrame
			// 
			this.CaptureVideoFrame.Location = new System.Drawing.Point(156, 190);
			this.CaptureVideoFrame.Name = "CaptureVideoFrame";
			this.CaptureVideoFrame.Size = new System.Drawing.Size(274, 23);
			this.CaptureVideoFrame.TabIndex = 4;
			this.CaptureVideoFrame.Text = "生成视频帧图片";
			this.CaptureVideoFrame.UseVisualStyleBackColor = true;
			this.CaptureVideoFrame.Click += new System.EventHandler(this.CaptureVideoFrame_Click);
			// 
			// message
			// 
			this.message.AutoSize = true;
			this.message.Location = new System.Drawing.Point(264, 235);
			this.message.Name = "message";
			this.message.Size = new System.Drawing.Size(0, 12);
			this.message.TabIndex = 5;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(594, 266);
			this.Controls.Add(this.message);
			this.Controls.Add(this.CaptureVideoFrame);
			this.Controls.Add(this.SelectSaveDirBtn);
			this.Controls.Add(this.saveDirTxtBox);
			this.Controls.Add(this.videoPathTxtBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox videoPathTxtBox;
		private System.Windows.Forms.TextBox saveDirTxtBox;
		private System.Windows.Forms.Button SelectSaveDirBtn;
		private System.Windows.Forms.Button CaptureVideoFrame;
		private System.Windows.Forms.Label message;
	}
}

