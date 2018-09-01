namespace game_cast_controller_simulator.usercontrol
{
	partial class Controller
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label3 = new game_cast_controller_simulator.usercontrol.hiLabel();
			this.lblCustomize = new game_cast_controller_simulator.usercontrol.hiLabel();
			this.lblStart = new game_cast_controller_simulator.usercontrol.hiLabel();
			this.lblSelect = new game_cast_controller_simulator.usercontrol.hiLabel();
			this.lblA = new game_cast_controller_simulator.usercontrol.hiLabel();
			this.lblLeft = new game_cast_controller_simulator.usercontrol.hiLabel();
			this.lblRight = new game_cast_controller_simulator.usercontrol.hiLabel();
			this.lblDown = new game_cast_controller_simulator.usercontrol.hiLabel();
			this.lblUp = new game_cast_controller_simulator.usercontrol.hiLabel();
			this.lblB = new game_cast_controller_simulator.usercontrol.hiLabel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::game_cast_controller_simulator.Properties.Resources.nes;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(769, 319);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Resize += new System.EventHandler(this.pictureBox1_Resize);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Hilight = false;
			this.label3.Location = new System.Drawing.Point(862, -201);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 17);
			this.label3.TabIndex = 3;
			this.label3.Text = "label1";
			// 
			// lblCustomize
			// 
			this.lblCustomize.AutoSize = true;
			this.lblCustomize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.lblCustomize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCustomize.Hilight = false;
			this.lblCustomize.Location = new System.Drawing.Point(676, 34);
			this.lblCustomize.Name = "lblCustomize";
			this.lblCustomize.Size = new System.Drawing.Size(73, 17);
			this.lblCustomize.TabIndex = 2;
			this.lblCustomize.Text = "Customize";
			this.lblCustomize.Click += new System.EventHandler(this.lblCustomize_Click);
			// 
			// lblStart
			// 
			this.lblStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.lblStart.Hilight = false;
			this.lblStart.Location = new System.Drawing.Point(371, 239);
			this.lblStart.Name = "lblStart";
			this.lblStart.Size = new System.Drawing.Size(73, 18);
			this.lblStart.TabIndex = 2;
			this.lblStart.Text = "#Start";
			this.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblSelect
			// 
			this.lblSelect.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.lblSelect.Hilight = false;
			this.lblSelect.Location = new System.Drawing.Point(264, 239);
			this.lblSelect.Name = "lblSelect";
			this.lblSelect.Size = new System.Drawing.Size(82, 18);
			this.lblSelect.TabIndex = 2;
			this.lblSelect.Text = "#Select";
			this.lblSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblA
			// 
			this.lblA.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
			this.lblA.ForeColor = System.Drawing.Color.White;
			this.lblA.Hilight = false;
			this.lblA.Location = new System.Drawing.Point(602, 161);
			this.lblA.Name = "lblA";
			this.lblA.Size = new System.Drawing.Size(74, 17);
			this.lblA.TabIndex = 2;
			this.lblA.Text = "#A";
			this.lblA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblLeft
			// 
			this.lblLeft.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.lblLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
			this.lblLeft.ForeColor = System.Drawing.Color.White;
			this.lblLeft.Hilight = false;
			this.lblLeft.Location = new System.Drawing.Point(26, 143);
			this.lblLeft.Name = "lblLeft";
			this.lblLeft.Size = new System.Drawing.Size(77, 17);
			this.lblLeft.TabIndex = 2;
			this.lblLeft.Text = "#Left";
			this.lblLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblRight
			// 
			this.lblRight.AutoSize = true;
			this.lblRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
			this.lblRight.ForeColor = System.Drawing.Color.White;
			this.lblRight.Hilight = false;
			this.lblRight.Location = new System.Drawing.Point(156, 143);
			this.lblRight.Name = "lblRight";
			this.lblRight.Size = new System.Drawing.Size(49, 17);
			this.lblRight.TabIndex = 2;
			this.lblRight.Text = "#Right";
			// 
			// lblDown
			// 
			this.lblDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
			this.lblDown.ForeColor = System.Drawing.Color.White;
			this.lblDown.Hilight = false;
			this.lblDown.Location = new System.Drawing.Point(87, 263);
			this.lblDown.Name = "lblDown";
			this.lblDown.Size = new System.Drawing.Size(82, 17);
			this.lblDown.TabIndex = 2;
			this.lblDown.Text = "#Down";
			this.lblDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblUp
			// 
			this.lblUp.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
			this.lblUp.ForeColor = System.Drawing.Color.White;
			this.lblUp.Hilight = false;
			this.lblUp.Location = new System.Drawing.Point(97, 93);
			this.lblUp.Name = "lblUp";
			this.lblUp.Size = new System.Drawing.Size(65, 17);
			this.lblUp.TabIndex = 2;
			this.lblUp.Text = "#Up";
			this.lblUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblB
			// 
			this.lblB.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
			this.lblB.ForeColor = System.Drawing.Color.White;
			this.lblB.Hilight = false;
			this.lblB.Location = new System.Drawing.Point(503, 161);
			this.lblB.Name = "lblB";
			this.lblB.Size = new System.Drawing.Size(74, 17);
			this.lblB.TabIndex = 2;
			this.lblB.Text = "#B";
			this.lblB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Controller
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblCustomize);
			this.Controls.Add(this.lblStart);
			this.Controls.Add(this.lblSelect);
			this.Controls.Add(this.lblA);
			this.Controls.Add(this.lblLeft);
			this.Controls.Add(this.lblRight);
			this.Controls.Add(this.lblDown);
			this.Controls.Add(this.lblUp);
			this.Controls.Add(this.lblB);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Controller";
			this.Size = new System.Drawing.Size(769, 319);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private usercontrol.hiLabel lblB;
		private usercontrol.hiLabel lblA;
		private usercontrol.hiLabel lblSelect;
		private usercontrol.hiLabel lblStart;
		private usercontrol.hiLabel lblUp;
		private usercontrol.hiLabel lblRight;
		private usercontrol.hiLabel lblLeft;
		private usercontrol.hiLabel lblDown;
		private usercontrol.hiLabel lblCustomize;
		private usercontrol.hiLabel label3;
	}
}
