namespace mathMinute
{
	partial class Gameplay
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
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.pnlGameplay = new System.Windows.Forms.Panel();
			this.timing = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// timer
			// 
			this.timer.Tick += new System.EventHandler(this.stopTime);
			// 
			// pnlGameplay
			// 
			this.pnlGameplay.AutoScroll = true;
			this.pnlGameplay.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pnlGameplay.Location = new System.Drawing.Point(0, 0);
			this.pnlGameplay.Name = "pnlGameplay";
			this.pnlGameplay.Size = new System.Drawing.Size(270, 400);
			this.pnlGameplay.TabIndex = 0;
			// 
			// timing
			// 
			this.timing.Interval = 25;
			this.timing.Tick += new System.EventHandler(this.timing_Tick);
			// 
			// Gameplay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(271, 401);
			this.Controls.Add(this.pnlGameplay);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Gameplay";
			this.Text = "Gameplay";
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.Panel pnlGameplay;
		private System.Windows.Forms.Timer timing;
	}
}