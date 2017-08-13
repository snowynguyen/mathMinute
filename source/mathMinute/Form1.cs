using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mathMinute
{
	public partial class MainForm : Form
	{
		List<string> rules = new List<string>()
		{
			"Khi bấm nút \"Bắt đầu\", thời gian sẽ đếm ngược ngay lập tức",
			"Bấm Tab đễ di chuyển đến ô kế tiếp, Shift-Tab để về ô trước",
			"Để nộp kết quả lập tức mà không cần đợi hết giờ, nhấn Enter"
		};
		public int curRule = 0;
		public int curLang = 0;
		public Languages Lang = new Languages();

		public MainForm()
		{
			InitializeComponent();
			lblRules.Text = rules[curRule];
			timerRule.Start();
		}

		private void nudMin_ValueChanged(object sender, EventArgs e)
		{
			nudMax.Minimum = nudMin.Value + 1;
		}

		private void nudMax_ValueChanged(object sender, EventArgs e)
		{
			nudMin.Maximum = nudMax.Value - 1;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int max = Convert.ToInt32(nudMax.Value);
			int min = Convert.ToInt32(nudMin.Value);
			int time = Convert.ToInt32(nudTime.Value);
			int counts = Convert.ToInt32(nudCount.Value);
			List<bool> operators = new List<bool> { ckbAdd.Checked, ckbSubtract.Checked, ckbMultip.Checked, ckbDivide.Checked };
			List<bool> allFalse = new List<bool> { false, false, false, false };
			if (operators == allFalse)
			{
				MessageBox.Show("Cần chọn ít nhất 1 phép tính", "Không hợp lệ");
			}
			else
			{
				Gameplay gameplay = new Gameplay(max, min, time, counts, operators, curLang);
			}
		}

		private void ChangeRule(object sender, EventArgs e)
		{
			curRule = (curRule + 1) % rules.Count;
			lblRules.Text = rules[curRule];
		}

		private void MainForm_SizeChanged(object sender, EventArgs e)
		{
			this.Size = new Size(384, 358);
		}

		private void changeToEnglish()
		{
			label2.Text = Lang.textCalculationRange.English;
			lblMin.Text = Lang.textMin.English;
			lblMax.Text = Lang.textMax.English;
			lblTime.Text = Lang.textTime.English;
			lblCounts.Text = Lang.textCount.English;
			label3.Text = Lang.textOpeators.English;
			ckbAdd.Text = Lang.textAdd.English;
			ckbSubtract.Text = Lang.textSubtract.English;
			ckbMultip.Text = Lang.textMuliply.English;
			ckbDivide.Text = Lang.textDivide.English;
			btnPlay.Text = Lang.textStart.English;
			rules = new List<string>();
			for (int i = 0; i < Lang.textRules.Count; i++)
			{
				rules.Add(Lang.textRules[i].English);
			}
		}

		private void changeToVietnamese()
		{
			label2.Text = Lang.textCalculationRange.Vietnamese;
			lblMin.Text = Lang.textMin.Vietnamese;
			lblMax.Text = Lang.textMax.Vietnamese;
			lblTime.Text = Lang.textTime.Vietnamese;
			lblCounts.Text = Lang.textCount.Vietnamese;
			label3.Text = Lang.textOpeators.Vietnamese;
			ckbAdd.Text = Lang.textAdd.Vietnamese;
			ckbSubtract.Text = Lang.textSubtract.Vietnamese;
			ckbMultip.Text = Lang.textMuliply.Vietnamese;
			ckbDivide.Text = Lang.textDivide.Vietnamese;
			btnPlay.Text = Lang.textStart.Vietnamese;
			rules = new List<string>();
			for (int i = 0; i < Lang.textRules.Count; i++)
			{
				rules.Add(Lang.textRules[i].Vietnamese);
			}
		}

		private void changeLang_Click(object sender, EventArgs e)
		{
			curLang = (curLang + 1) % 2;
			if (curLang == 0)
			{
				changeToVietnamese();
				changeLang.Text = "English interface";
			}
			else
			{
				changeToEnglish();
				changeLang.Text = "Giao diện tiếng Việt";
			}
		}
	}
}
