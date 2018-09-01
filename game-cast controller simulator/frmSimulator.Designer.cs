namespace game_cast_controller_simulator
{
	partial class frmSimulator
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
			this.controller2 = new game_cast_controller_simulator.usercontrol.Controller();
			this.controller1 = new game_cast_controller_simulator.usercontrol.Controller();
			this.SuspendLayout();
			// 
			// controller2
			// 
			this.controller2.Index = game_cast_controller_simulator.ControllerIndex.First;
			this.controller2.Location = new System.Drawing.Point(0, 325);
			this.controller2.Name = "controller2";
			this.controller2.SerialWriter = null;
			this.controller2.Size = new System.Drawing.Size(769, 319);
			this.controller2.TabIndex = 2;
			// 
			// controller1
			// 
			this.controller1.Index = game_cast_controller_simulator.ControllerIndex.First;
			this.controller1.Location = new System.Drawing.Point(0, 0);
			this.controller1.Name = "controller1";
			this.controller1.SerialWriter = null;
			this.controller1.Size = new System.Drawing.Size(769, 319);
			this.controller1.TabIndex = 2;
			// 
			// frmSimulator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(769, 644);
			this.Controls.Add(this.controller2);
			this.Controls.Add(this.controller1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "frmSimulator";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmController";
			this.Load += new System.EventHandler(this.frmSimulator_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSimulator_KeyDown);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmSimulator_KeyPress);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmSimulator_KeyUp);
			this.ResumeLayout(false);

		}

		#endregion
		private usercontrol.Controller controller1;
		private usercontrol.Controller controller2;
	}
}