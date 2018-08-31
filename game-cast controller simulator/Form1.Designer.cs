﻿namespace game_cast_controller_simulator
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
			this.btnDisconnectPort = new System.Windows.Forms.Button();
			this.btnConnect = new System.Windows.Forms.Button();
			this.gpActions = new System.Windows.Forms.GroupBox();
			this.lblPort = new System.Windows.Forms.Label();
			this.gpActions.SuspendLayout();
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
			this.lvPorts.Location = new System.Drawing.Point(6, 56);
			this.lvPorts.MultiSelect = false;
			this.lvPorts.Name = "lvPorts";
			this.lvPorts.Size = new System.Drawing.Size(388, 132);
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
			this.btnPorts.Location = new System.Drawing.Point(6, 21);
			this.btnPorts.Name = "btnPorts";
			this.btnPorts.Size = new System.Drawing.Size(99, 29);
			this.btnPorts.TabIndex = 4;
			this.btnPorts.Text = "Read ports";
			this.btnPorts.UseVisualStyleBackColor = true;
			this.btnPorts.Click += new System.EventHandler(this.btnPorts_Click);
			// 
			// btnDisconnectPort
			// 
			this.btnDisconnectPort.Location = new System.Drawing.Point(272, 21);
			this.btnDisconnectPort.Name = "btnDisconnectPort";
			this.btnDisconnectPort.Size = new System.Drawing.Size(122, 29);
			this.btnDisconnectPort.TabIndex = 4;
			this.btnDisconnectPort.Text = "Close port";
			this.btnDisconnectPort.UseVisualStyleBackColor = true;
			this.btnDisconnectPort.Click += new System.EventHandler(this.btnDisconnectPort_Click);
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
			this.gpActions.Controls.Add(this.btnDisconnectPort);
			this.gpActions.Enabled = false;
			this.gpActions.Location = new System.Drawing.Point(4, 44);
			this.gpActions.Name = "gpActions";
			this.gpActions.Size = new System.Drawing.Size(405, 200);
			this.gpActions.TabIndex = 6;
			this.gpActions.TabStop = false;
			// 
			// lblPort
			// 
			this.lblPort.AutoSize = true;
			this.lblPort.Location = new System.Drawing.Point(7, 252);
			this.lblPort.Name = "lblPort";
			this.lblPort.Size = new System.Drawing.Size(0, 17);
			this.lblPort.TabIndex = 7;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(416, 278);
			this.Controls.Add(this.lblPort);
			this.Controls.Add(this.gpActions);
			this.Controls.Add(this.btnConnect);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtURL);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "game-cast controller simulator";
			this.gpActions.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtURL;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListView lvPorts;
		private System.Windows.Forms.Button btnPorts;
		private System.Windows.Forms.Button btnDisconnectPort;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.GroupBox gpActions;
		private System.Windows.Forms.Label lblPort;
	}
}

