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
	public partial class Gameplay : Form
	{
		private int Max, Min, Time, Counts, Score;
		DateTime beginTime, endTime;
		TimeSpan timeLeft;
		private List<char> Operators;
		private List<List<int>> Questions;
		private List<TextBox> Answers;
		private List<Label> Quess;
		static Languages lang = new Languages();
		static int lan = 0;
		Random rd;

		public Gameplay(int max, int min, int time, int counts, List<bool> operators, int lang)
		{
			InitializeComponent();
			beginTime = new DateTime();
			endTime = new DateTime();
			timeLeft = new TimeSpan();
			Max = max; Min = min; Time = time; Counts = counts; Score = 0; lan = lang;
			Operators = new List<char>();
			Questions = new List<List<int>>();
			Answers = new List<TextBox>();
			Quess = new List<Label>();
			if (operators[0]) Operators.Add('+');
			if (operators[1]) Operators.Add('-');
			if (operators[2]) Operators.Add('*');
			if (operators[3]) Operators.Add('/');
			QuestionsGenerator();
			go();
		}

		private void HandleEnter(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Return)
			{
				stopTime();
			}
		}

		private void Gameplay_SizeChanged(object sender, EventArgs e)
		{
			this.Size = new Size(287, 435);
		}

		private void timing_Tick(object sender, EventArgs e)
		{
			if (DateTime.Now >= endTime)
			{
				stopTime();
			}
			else
			{
				timeLeft = endTime - DateTime.Now;
				this.Text = "Gameplay (" + timeLeft.Minutes.ToString() + ":" + timeLeft.Seconds.ToString() + "." + (timeLeft.Milliseconds / 100).ToString() + "s)";
			}
		}

		private void QuestionsGenerator() {
			rd = new Random();
			
			for (int i = 0; i < Counts; i++)
			{
				List<int> question = new List<int>();
				int firstOperand = -1;
				int secondOperand = -1;
				int result = -1;
				char operation = Operators[rd.Next(0, Operators.Count)];
				switch (operation) {
					case '+':
						question.Add(0);
						firstOperand = rd.Next(Min, Max + 1);
						secondOperand = rd.Next(Min, Max + 1);
						result = firstOperand + secondOperand;
						break;
					case '-':
						question.Add(1);
						firstOperand = rd.Next(Min, Max + 1);
						secondOperand = rd.Next(Min, firstOperand + 1);
						result = firstOperand - secondOperand;
						break;
					case '*':
						question.Add(2);
						firstOperand = rd.Next(Min, Max + 1);
						secondOperand = rd.Next(Min, Max + 1);
						result = firstOperand * secondOperand;
						break;
					case '/':
						question.Add(3);
						secondOperand = rd.Next(1, Max + 1);
						result = rd.Next(Min > 2 ? Min - 1 : 1, Max + 1);
						firstOperand = secondOperand * result;
						break;
				}
				question.Add(firstOperand);
				question.Add(secondOperand);
				question.Add(result);
				Questions.Add(question);
			}
		}

		private void stopTime()
		{
			timing.Stop();
			int wrongs = 0, Answered = Counts; double ExpectedTime = 0;
			for (int i = 0; i < Counts; i++)
			{
				Answers[i].Enabled = false;
				Quess[i].Location = new Point(Quess[i].Location.X, Quess[i].Location.Y + wrongs * 25);
				Answers[i].Location = new Point(Answers[i].Location.X, Answers[i].Location.Y + wrongs * 25);
				if (Answers[i].Text == "" || Answers[i].Text == null)
				{
					Answered--;
				}
				if (Answers[i].Text == Questions[i][3].ToString())
				{
					Score++;
					Answers[i].BackColor = Color.LightGreen;
				}
				else
				{
					Answers[i].BackColor = Color.FromArgb(255, 96, 80);
					Label correctAns = new Label();
					correctAns.Text = Questions[i][3].ToString();
					correctAns.ForeColor = Color.Green;
					correctAns.Location = new Point(Answers[i].Location.X + 3, Answers[i].Location.Y + 30);
					pnlGameplay.Controls.Add(correctAns);
					wrongs++;
				}
				switch (Questions[i][0]) {
					case 0:
						ExpectedTime += 1.0 * Math.Log10((Max * 2 - Min + Questions[i][0] + Questions[i][1]) / 4);
						break;
					case 1:
						ExpectedTime += 1.0 * Math.Log10((Max * 3 - Min * 1.5 + Questions[i][0] + Questions[i][1]) / 5);
						break;
					case 2:
						ExpectedTime += 1.5 * Math.Sqrt(Math.Log10(Questions[i][1]) * Math.Log10(Questions[i][2]) * Math.Log10(Max) * Math.Log10(Max - Min));
						break;
					case 3:
						ExpectedTime += 1.5 * Math.Sqrt(Math.Log10(Questions[i][1]) * Math.Log10(Questions[i][2]) * Math.Log10(Max) * Math.Log10(Max - Min / 2));
						break;
				}
			}
			double YourTimeLeft = -1, YourTime = -1;
			try
			{
				YourTimeLeft = timeLeft.Ticks / 10000000.0;
			}
			catch (OverflowException)
			{
				YourTimeLeft = short.MaxValue;
			}
			YourTime = Time - YourTimeLeft;
			double Accurate = Answered > 0 ? 1.0 * Score / Answered : 0;
			double timeBonus = ((0.25 * Time * Answered / Counts + 0.75 * ExpectedTime) - YourTime) * Score / Counts;
			timeBonus = timeBonus < 0 ? 0 : timeBonus;
			double FinalScore = (Score + timeBonus) * Accurate;
			this.Text += ". Correct: " + Score.ToString() + "/" + Counts.ToString() + ". Score: " + FinalScore.ToString("#0.00");
			MessageBox.Show(
				(lan == 0 ? lang.textAnswered.Vietnamese : lang.textAnswered.English) + ": " + Answered.ToString() + "\n" +
				(lan == 0 ? lang.textCorrect.Vietnamese : lang.textCorrect.English) + ": " + Score.ToString() + "\n" +
				(lan == 0 ? lang.textAccuracy.Vietnamese : lang.textAccuracy.English) + ": " + Accurate.ToString("#0.0#%") + "\n" +
				(lan == 0 ? lang.textTimeLeft.Vietnamese : lang.textTimeLeft.English) + ": " + YourTimeLeft.ToString("#0.0") + "s\n" +
				(lan == 0 ? lang.textTimeBonus.Vietnamese : lang.textTimeBonus.English) + ": " + timeBonus.ToString("#0.00") + "\n" +
				(lan == 0 ? lang.textFinalScore.Vietnamese : lang.textFinalScore.English) + ": " + FinalScore.ToString("#0.00"),
				"Score"
			);
		}

		private void displayQuestions()
		{
			int currentHeight = 10;
			for (int i = 0; i < Counts; i++)
			{
				Label lbl = new Label();
				TextBox txb = new TextBox();
				Answers.Add(txb);
				Quess.Add(lbl);
				lbl.Text = Questions[i][1].ToString();
				switch (Questions[i][0]) {
					case 0: lbl.Text += " + "; break;
					case 1: lbl.Text += " - "; break;
					case 2: lbl.Text += " * "; break;
					case 3: lbl.Text += " / "; break;
				}
				lbl.Text += Questions[i][2].ToString() + " = ";
				lbl.Location = new Point(10, currentHeight);
				lbl.Size = new Size(80, 20);
				Answers[i].Location = new Point(210, currentHeight - 3);
				Answers[i].Size = new Size(70, 20);
				Answers[i].TabIndex = i;
				Answers[i].KeyPress += HandleEnter;
				pnlGameplay.Controls.Add(lbl);
				pnlGameplay.Controls.Add(Answers[i]);
				currentHeight += 30;
			}
		}

		private void go()
		{
			this.Show();
			displayQuestions();
			beginTime = DateTime.Now;
			endTime = beginTime.AddSeconds(Time);
			timing.Start();
		}
	}
}
