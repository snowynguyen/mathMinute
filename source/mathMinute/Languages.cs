using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mathMinute
{
	public class Translation
	{
		public string Vietnamese;
		public string English;

		public Translation(string Vietnamese, string English)
		{
			this.Vietnamese = Vietnamese;
			this.English = English;
		}
		
		public Translation(int LanguagerNo, string text)
		{
			if (LanguagerNo == 0) this.Vietnamese = text;
			else this.English = text;
		}

		public Translation()
		{

		}
	}

	public class Languages
	{
		public Translation textCalculationRange = new Translation("Phạm vi tính toán: ", "Calculation Range: ");
		public Translation textMax = new Translation("Max", "Maximum bound: ");
		public Translation textMin = new Translation("Min", "Minimum bound: ");
		public Translation textTime = new Translation("Thời gian: ", "Time (sec): ");
		public Translation textCount = new Translation("Số phép tính: ", "No. of operations:");
		public Translation textOpeators = new Translation("Phép toán: ", "Operators: ");
		public Translation textAdd = new Translation("Cộng", "Addition");
		public Translation textSubtract = new Translation("Trừ", "Subtraction");
		public Translation textMuliply = new Translation("Nhân", "Multiplication");
		public Translation textDivide = new Translation("Chia", "Division");
		public Translation textInvalidInput_Content = new Translation("Vui lòng chọn ít nhất 1 phép toán", "Please select at least 1 operator");
		public Translation textInvalidInput_Title = new Translation("Không hợp lệ", "Invalid input");
		public Translation textStart = new Translation("Bắt đầu!", "Play!");
		public List<Translation> textRules = new List<Translation>()
		{
			new Translation
			(
				"Khi bấm nút \"Bắt đầu\", thời gian sẽ đếm ngược ngay lập tức",
				"Timer will start immediately after pressing the Play! button"
			),
			new Translation
			(
				"Bấm Tab đễ di chuyển đến ô kế tiếp, Shift-Tab để về ô trước",
				"Tab = move to the next cell, Shift-Tab = to the previous one"
			),
			new Translation
			(
				"Để nộp kết quả lập tức mà không cần đợi hết giờ, nhấn Enter",
				"To submit your solutions before the timer ends, press Enter"
			)
		};
		public Translation textAnswered = new Translation("Đã trả lời", "Answered");
		public Translation textCorrect = new Translation("Số câu đúng", "Correct");
		public Translation textAccuracy = new Translation("Tỉ lệ đúng", "Accuracy");
		public Translation textTimeLeft = new Translation("Thời gian còn lại", "Time left");
		public Translation textTimeBonus = new Translation("Thưởng thời gian", "Time bonus");
		public Translation textFinalScore = new Translation("Điểm tổng", "Final score");
	}
}
