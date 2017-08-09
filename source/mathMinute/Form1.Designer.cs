namespace mathMinute
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.pnlMainMenu = new System.Windows.Forms.Panel();
			this.lblRules = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.onlSelectOperator = new System.Windows.Forms.Panel();
			this.ckbDivide = new System.Windows.Forms.CheckBox();
			this.ckbMultip = new System.Windows.Forms.CheckBox();
			this.ckbSubtract = new System.Windows.Forms.CheckBox();
			this.ckbAdd = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.pnlSelectOperand = new System.Windows.Forms.Panel();
			this.nudCount = new System.Windows.Forms.NumericUpDown();
			this.nudTime = new System.Windows.Forms.NumericUpDown();
			this.nudMax = new System.Windows.Forms.NumericUpDown();
			this.nudMin = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.trkbMin = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.timerRule = new System.Windows.Forms.Timer(this.components);
			this.pnlMainMenu.SuspendLayout();
			this.onlSelectOperator.SuspendLayout();
			this.pnlSelectOperand.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudTime)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(125, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(117, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "MATH MINUTE";
			// 
			// pnlMainMenu
			// 
			this.pnlMainMenu.Controls.Add(this.lblRules);
			this.pnlMainMenu.Controls.Add(this.button1);
			this.pnlMainMenu.Controls.Add(this.onlSelectOperator);
			this.pnlMainMenu.Controls.Add(this.pnlSelectOperand);
			this.pnlMainMenu.Controls.Add(this.label1);
			this.pnlMainMenu.Location = new System.Drawing.Point(0, 0);
			this.pnlMainMenu.Name = "pnlMainMenu";
			this.pnlMainMenu.Size = new System.Drawing.Size(367, 318);
			this.pnlMainMenu.TabIndex = 1;
			// 
			// lblRules
			// 
			this.lblRules.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblRules.AutoSize = true;
			this.lblRules.Location = new System.Drawing.Point(22, 285);
			this.lblRules.Name = "lblRules";
			this.lblRules.Size = new System.Drawing.Size(58, 15);
			this.lblRules.TabIndex = 3;
			this.lblRules.Text = "Rule label";
			this.lblRules.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(104, 240);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(166, 36);
			this.button1.TabIndex = 2;
			this.button1.Text = "Bắt đầu!";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// onlSelectOperator
			// 
			this.onlSelectOperator.Controls.Add(this.ckbDivide);
			this.onlSelectOperator.Controls.Add(this.ckbMultip);
			this.onlSelectOperator.Controls.Add(this.ckbSubtract);
			this.onlSelectOperator.Controls.Add(this.ckbAdd);
			this.onlSelectOperator.Controls.Add(this.label3);
			this.onlSelectOperator.Location = new System.Drawing.Point(196, 55);
			this.onlSelectOperator.Name = "onlSelectOperator";
			this.onlSelectOperator.Size = new System.Drawing.Size(167, 179);
			this.onlSelectOperator.TabIndex = 1;
			// 
			// ckbDivide
			// 
			this.ckbDivide.AutoSize = true;
			this.ckbDivide.Checked = true;
			this.ckbDivide.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ckbDivide.Location = new System.Drawing.Point(19, 125);
			this.ckbDivide.Name = "ckbDivide";
			this.ckbDivide.Size = new System.Drawing.Size(50, 19);
			this.ckbDivide.TabIndex = 8;
			this.ckbDivide.Text = "Chia";
			this.ckbDivide.UseVisualStyleBackColor = true;
			// 
			// ckbMultip
			// 
			this.ckbMultip.AutoSize = true;
			this.ckbMultip.Checked = true;
			this.ckbMultip.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ckbMultip.Location = new System.Drawing.Point(19, 98);
			this.ckbMultip.Name = "ckbMultip";
			this.ckbMultip.Size = new System.Drawing.Size(55, 19);
			this.ckbMultip.TabIndex = 7;
			this.ckbMultip.Text = "Nhân";
			this.ckbMultip.UseVisualStyleBackColor = true;
			// 
			// ckbSubtract
			// 
			this.ckbSubtract.AutoSize = true;
			this.ckbSubtract.Checked = true;
			this.ckbSubtract.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ckbSubtract.Location = new System.Drawing.Point(19, 72);
			this.ckbSubtract.Name = "ckbSubtract";
			this.ckbSubtract.Size = new System.Drawing.Size(44, 19);
			this.ckbSubtract.TabIndex = 6;
			this.ckbSubtract.Text = "Trừ";
			this.ckbSubtract.UseVisualStyleBackColor = true;
			// 
			// ckbAdd
			// 
			this.ckbAdd.AutoSize = true;
			this.ckbAdd.Checked = true;
			this.ckbAdd.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ckbAdd.Location = new System.Drawing.Point(19, 45);
			this.ckbAdd.Name = "ckbAdd";
			this.ckbAdd.Size = new System.Drawing.Size(55, 19);
			this.ckbAdd.TabIndex = 5;
			this.ckbAdd.Text = "Cộng";
			this.ckbAdd.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(15, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 15);
			this.label3.TabIndex = 0;
			this.label3.Text = "Phép toán";
			// 
			// pnlSelectOperand
			// 
			this.pnlSelectOperand.Controls.Add(this.nudCount);
			this.pnlSelectOperand.Controls.Add(this.nudTime);
			this.pnlSelectOperand.Controls.Add(this.nudMax);
			this.pnlSelectOperand.Controls.Add(this.nudMin);
			this.pnlSelectOperand.Controls.Add(this.label4);
			this.pnlSelectOperand.Controls.Add(this.label6);
			this.pnlSelectOperand.Controls.Add(this.label5);
			this.pnlSelectOperand.Controls.Add(this.trkbMin);
			this.pnlSelectOperand.Controls.Add(this.label2);
			this.pnlSelectOperand.Location = new System.Drawing.Point(3, 55);
			this.pnlSelectOperand.Name = "pnlSelectOperand";
			this.pnlSelectOperand.Size = new System.Drawing.Size(185, 179);
			this.pnlSelectOperand.TabIndex = 1;
			// 
			// nudCount
			// 
			this.nudCount.Location = new System.Drawing.Point(107, 148);
			this.nudCount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.nudCount.Name = "nudCount";
			this.nudCount.Size = new System.Drawing.Size(55, 23);
			this.nudCount.TabIndex = 4;
			this.nudCount.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
			// 
			// nudTime
			// 
			this.nudTime.Location = new System.Drawing.Point(107, 113);
			this.nudTime.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
			this.nudTime.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nudTime.Name = "nudTime";
			this.nudTime.Size = new System.Drawing.Size(55, 23);
			this.nudTime.TabIndex = 3;
			this.nudTime.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
			// 
			// nudMax
			// 
			this.nudMax.Location = new System.Drawing.Point(107, 78);
			this.nudMax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nudMax.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.nudMax.Name = "nudMax";
			this.nudMax.Size = new System.Drawing.Size(55, 23);
			this.nudMax.TabIndex = 2;
			this.nudMax.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nudMax.ValueChanged += new System.EventHandler(this.nudMax_ValueChanged);
			// 
			// nudMin
			// 
			this.nudMin.Location = new System.Drawing.Point(107, 44);
			this.nudMin.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.nudMin.Name = "nudMin";
			this.nudMin.Size = new System.Drawing.Size(55, 23);
			this.nudMin.TabIndex = 1;
			this.nudMin.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
			this.nudMin.ValueChanged += new System.EventHandler(this.nudMin_ValueChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(10, 153);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(74, 15);
			this.label4.TabIndex = 2;
			this.label4.Text = "Số phép tính";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(10, 119);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(57, 15);
			this.label6.TabIndex = 2;
			this.label6.Text = "Thời gian";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(10, 84);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 15);
			this.label5.TabIndex = 2;
			this.label5.Text = "Max";
			// 
			// trkbMin
			// 
			this.trkbMin.AutoSize = true;
			this.trkbMin.Location = new System.Drawing.Point(10, 50);
			this.trkbMin.Name = "trkbMin";
			this.trkbMin.Size = new System.Drawing.Size(28, 15);
			this.trkbMin.TabIndex = 2;
			this.trkbMin.Text = "Min";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(10, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 15);
			this.label2.TabIndex = 0;
			this.label2.Text = "Phạm vi tính toán";
			// 
			// timerRule
			// 
			this.timerRule.Interval = 5000;
			this.timerRule.Tick += new System.EventHandler(this.ChangeRule);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(368, 320);
			this.Controls.Add(this.pnlMainMenu);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "MainForm";
			this.Text = "Math Minute";
			this.pnlMainMenu.ResumeLayout(false);
			this.pnlMainMenu.PerformLayout();
			this.onlSelectOperator.ResumeLayout(false);
			this.onlSelectOperator.PerformLayout();
			this.pnlSelectOperand.ResumeLayout(false);
			this.pnlSelectOperand.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudTime)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel pnlMainMenu;
		private System.Windows.Forms.Panel onlSelectOperator;
		private System.Windows.Forms.CheckBox ckbDivide;
		private System.Windows.Forms.CheckBox ckbMultip;
		private System.Windows.Forms.CheckBox ckbSubtract;
		private System.Windows.Forms.CheckBox ckbAdd;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel pnlSelectOperand;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label trkbMin;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown nudCount;
		private System.Windows.Forms.NumericUpDown nudTime;
		private System.Windows.Forms.NumericUpDown nudMax;
		private System.Windows.Forms.NumericUpDown nudMin;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label lblRules;
		private System.Windows.Forms.Timer timerRule;
	}
}

