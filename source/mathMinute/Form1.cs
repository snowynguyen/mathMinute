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
		int curRule = 0;

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
				Gameplay gameplay = new Gameplay(max, min, time, counts, operators);
			}
		}

		private void ChangeRule(object sender, EventArgs e)
		{
			curRule = (curRule + 1) % rules.Count;
			lblRules.Text = rules[curRule];
		}
	}
}
