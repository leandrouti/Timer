namespace Timer
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.BtnStart = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.LblTime = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.TbSec = new System.Windows.Forms.TextBox();
			this.TbMinutes = new System.Windows.Forms.TextBox();
			this.TbHour = new System.Windows.Forms.TextBox();
			this.Btn_Keyboard = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// BtnStart
			// 
			this.BtnStart.Location = new System.Drawing.Point(14, 171);
			this.BtnStart.Name = "BtnStart";
			this.BtnStart.Size = new System.Drawing.Size(75, 23);
			this.BtnStart.TabIndex = 3;
			this.BtnStart.TabStop = false;
			this.BtnStart.Text = "Start";
			this.BtnStart.UseVisualStyleBackColor = true;
			this.BtnStart.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(171, 171);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 4;
			this.button2.TabStop = false;
			this.button2.Text = "Reset";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// LblTime
			// 
			this.LblTime.AutoSize = true;
			this.LblTime.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.LblTime.Location = new System.Drawing.Point(3, 3);
			this.LblTime.Name = "LblTime";
			this.LblTime.Size = new System.Drawing.Size(254, 64);
			this.LblTime.TabIndex = 2;
			this.LblTime.Text = "00:00:00";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.TbSec);
			this.groupBox1.Controls.Add(this.TbMinutes);
			this.groupBox1.Controls.Add(this.TbHour);
			this.groupBox1.Location = new System.Drawing.Point(12, 76);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(234, 74);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Time";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(173, 23);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 12);
			this.label4.TabIndex = 14;
			this.label4.Text = "Second:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(87, 23);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 12);
			this.label3.TabIndex = 13;
			this.label3.Text = "Minute:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 12);
			this.label2.TabIndex = 12;
			this.label2.Text = "Hour:";
			// 
			// TbSec
			// 
			this.TbSec.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.TbSec.Location = new System.Drawing.Point(175, 38);
			this.TbSec.Name = "TbSec";
			this.TbSec.Size = new System.Drawing.Size(50, 26);
			this.TbSec.TabIndex = 2;
			this.TbSec.Text = "0";
			// 
			// TbMinutes
			// 
			this.TbMinutes.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.TbMinutes.Location = new System.Drawing.Point(89, 38);
			this.TbMinutes.Name = "TbMinutes";
			this.TbMinutes.Size = new System.Drawing.Size(50, 26);
			this.TbMinutes.TabIndex = 1;
			this.TbMinutes.Text = "0";
			// 
			// TbHour
			// 
			this.TbHour.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.TbHour.Location = new System.Drawing.Point(6, 38);
			this.TbHour.Name = "TbHour";
			this.TbHour.Size = new System.Drawing.Size(50, 26);
			this.TbHour.TabIndex = 0;
			this.TbHour.Text = "0";
			// 
			// Btn_Keyboard
			// 
			this.Btn_Keyboard.Location = new System.Drawing.Point(92, 212);
			this.Btn_Keyboard.Name = "Btn_Keyboard";
			this.Btn_Keyboard.Size = new System.Drawing.Size(75, 23);
			this.Btn_Keyboard.TabIndex = 10;
			this.Btn_Keyboard.Text = "Keyboard";
			this.Btn_Keyboard.UseVisualStyleBackColor = true;
			this.Btn_Keyboard.Click += new System.EventHandler(this.Btn_Keyboard_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(261, 241);
			this.Controls.Add(this.Btn_Keyboard);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.LblTime);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.BtnStart);
			this.KeyPreview = true;
			this.Name = "Form1";
			this.Text = "Timer";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BtnStart;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label LblTime;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TbSec;
		private System.Windows.Forms.TextBox TbMinutes;
		private System.Windows.Forms.TextBox TbHour;
		private System.Windows.Forms.Button Btn_Keyboard;
	}
}

