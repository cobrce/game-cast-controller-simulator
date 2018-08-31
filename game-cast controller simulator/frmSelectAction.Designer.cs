namespace game_cast_controller_simulator
{
	partial class frmSelectAction
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
			this.btnConnectPort = new System.Windows.Forms.Button();
			this.btnStartSimulator = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnConnectPort
			// 
			this.btnConnectPort.Location = new System.Drawing.Point(12, 12);
			this.btnConnectPort.Name = "btnConnectPort";
			this.btnConnectPort.Size = new System.Drawing.Size(197, 39);
			this.btnConnectPort.TabIndex = 0;
			this.btnConnectPort.Text = "Open by server";
			this.btnConnectPort.UseVisualStyleBackColor = true;
			this.btnConnectPort.Click += new System.EventHandler(this.btnConnectPort_Click);
			// 
			// btnStartSimulator
			// 
			this.btnStartSimulator.Location = new System.Drawing.Point(12, 57);
			this.btnStartSimulator.Name = "btnStartSimulator";
			this.btnStartSimulator.Size = new System.Drawing.Size(197, 39);
			this.btnStartSimulator.TabIndex = 1;
			this.btnStartSimulator.Text = "Start simulator";
			this.btnStartSimulator.UseVisualStyleBackColor = true;
			this.btnStartSimulator.Click += new System.EventHandler(this.btnStartSimulator_Click);
			// 
			// frmSelectAction
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(220, 108);
			this.Controls.Add(this.btnStartSimulator);
			this.Controls.Add(this.btnConnectPort);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSelectAction";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Select action";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnConnectPort;
		private System.Windows.Forms.Button btnStartSimulator;
	}
}