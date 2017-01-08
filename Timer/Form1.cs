using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
	public partial class Form1 : Form
	{
		private int hh, mm, ss, totTime;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			TbMinutes.Focus();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if(totTime > 0)
			{
				totTime -= 1;
				int lblHH, lblMM, lblSS;
				lblHH = (totTime / 3600);
				lblMM = (totTime / 60) - (60 * lblHH);
				lblSS = totTime - ((lblHH * 3600) + (lblMM * 60));
				LblTime.Text = lblHH.ToString("0#") + ":" + lblMM.ToString("0#") + ":" + lblSS.ToString("0#");
			}
			else
			{
				timer1.Enabled = false;
				resetForm();
				makeAlert();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{

			hh = TbHour.Text != "" ? 60 * 60 * int.Parse(TbHour.Text) : 0;
			mm = TbMinutes.Text != "" ? 60 * int.Parse(TbMinutes.Text) : 0;
			ss = TbSec.Text != "" ? int.Parse(TbSec.Text) : 0;

			totTime = hh + mm + ss;
			timer1.Enabled = !timer1.Enabled;
			BtnStart.Text = timer1.Enabled ? "Stop" : "Start";

			if (timer1.Enabled)
			{
				TbHour.Enabled = false;
				TbMinutes.Enabled = false;
				TbSec.Enabled = false;
			}
			else
			{
				TbHour.Enabled = true;
				TbMinutes.Enabled = true;
				TbSec.Enabled = true;
			}

		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{

			if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Q)
			{
				Application.Exit();
			}else if(e.KeyCode == Keys.Enter){
				button1_Click(sender, e);
			}
			
		}

		private void Btn_Keyboard_Click(object sender, EventArgs e)
		{
			this.Height = 450;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			resetForm();
			timer1.Enabled = false;
		}

		private void resetForm()
		{
			TbHour.Text = "0";
			TbMinutes.Text = "0";
			TbSec.Text = "0";
			totTime = 0;
			LblTime.Text = "00:00:00";
			BtnStart.Text = "Start";
			TbHour.Enabled = true;
			TbMinutes.Enabled = true;
			TbSec.Enabled = true;
		}

		private void makeAlert()
		{
			System.Media.SoundPlayer player = new System.Media.SoundPlayer(Timer.Properties.Resources.Alarm02);
			player.Play();
		}
	}
}
