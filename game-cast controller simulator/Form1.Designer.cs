namespace game_cast_controller_simulator
{
	partial class Form1
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
			this.txtURL = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lvPorts = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnPorts = new System.Windows.Forms.Button();
			this.btnConnect = new System.Windows.Forms.Button();
			this.gpActions = new System.Windows.Forms.GroupBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.stlblPort = new System.Windows.Forms.ToolStripStatusLabel();
			this.btnClosePort = new System.Windows.Forms.ToolStripDropDownButton();
			this.closePortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gpActions.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtURL
			// 
			this.txtURL.Location = new System.Drawing.Point(54, 12);
			this.txtURL.Name = "txtURL";
			this.txtURL.Size = new System.Drawing.Size(261, 22);
			this.txtURL.TabIndex = 0;
			this.txtURL.Text = "http://localhost:3000";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "URL";
			// 
			// lvPorts
			// 
			this.lvPorts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this.lvPorts.FullRowSelect = true;
			this.lvPorts.Location = new System.Drawing.Point(6, 12);
			this.lvPorts.MultiSelect = false;
			this.lvPorts.Name = "lvPorts";
			this.lvPorts.Size = new System.Drawing.Size(394, 152);
			this.lvPorts.TabIndex = 3;
			this.lvPorts.UseCompatibleStateImageBehavior = false;
			this.lvPorts.View = System.Windows.Forms.View.Details;
			this.lvPorts.DoubleClick += new System.EventHandler(this.lvPorts_DoubleClick);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "COM Name";
			this.columnHeader1.Width = 100;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Manufacturer";
			this.columnHeader2.Width = 250;
			// 
			// btnPorts
			// 
			this.btnPorts.Location = new System.Drawing.Point(301, 170);
			this.btnPorts.Name = "btnPorts";
			this.btnPorts.Size = new System.Drawing.Size(99, 24);
			this.btnPorts.TabIndex = 4;
			this.btnPorts.Text = "Refresh";
			this.btnPorts.UseVisualStyleBackColor = true;
			this.btnPorts.Click += new System.EventHandler(this.btnPorts_Click);
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(319, 9);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(90, 29);
			this.btnConnect.TabIndex = 5;
			this.btnConnect.Text = "Connect";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// gpActions
			// 
			this.gpActions.Controls.Add(this.lvPorts);
			this.gpActions.Controls.Add(this.btnPorts);
			this.gpActions.Enabled = false;
			this.gpActions.Location = new System.Drawing.Point(4, 44);
			this.gpActions.Name = "gpActions";
			this.gpActions.Size = new System.Drawing.Size(405, 200);
			this.gpActions.TabIndex = 6;
			this.gpActions.TabStop = false;
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stlblPort,
            this.btnClosePort});
			this.statusStrip1.Location = new System.Drawing.Point(0, 245);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(416, 25);
			this.statusStrip1.TabIndex = 8;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// stlblPort
			// 
			this.stlblPort.Name = "stlblPort";
			this.stlblPort.Size = new System.Drawing.Size(65, 20);
			this.stlblPort.Text = "              ";
			// 
			// btnClosePort
			// 
			this.btnClosePort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnClosePort.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closePortToolStripMenuItem});
			this.btnClosePort.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnClosePort.Name = "btnClosePort";
			this.btnClosePort.Size = new System.Drawing.Size(14, 23);
			this.btnClosePort.Text = "toolStripDropDownButton1";
			this.btnClosePort.Visible = false;
			// 
			// closePortToolStripMenuItem
			// 
			this.closePortToolStripMenuItem.Name = "closePortToolStripMenuItem";
			this.closePortToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.closePortToolStripMenuItem.Text = "Close port";
			this.closePortToolStripMenuItem.Click += new System.EventHandler(this.closePortToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(416, 270);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.gpActions);
			this.Controls.Add(this.btnConnect);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtURL);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "game-cast controller simulator";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.gpActions.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtURL;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListView lvPorts;
		private System.Windows.Forms.Button btnPorts;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.GroupBox gpActions;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel stlblPort;
		private System.Windows.Forms.ToolStripDropDownButton btnClosePort;
		private System.Windows.Forms.ToolStripMenuItem closePortToolStripMenuItem;
	}
}

