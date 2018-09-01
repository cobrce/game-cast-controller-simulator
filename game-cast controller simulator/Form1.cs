using game_cast_controller_simulator.formatters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace game_cast_controller_simulator
{
	public partial class Form1 : Form
	{
		Connector _connector;
		public Form1()
		{
			InitializeComponent();
		}

		private bool IsConnected(bool silent = false)
		{
			if (_connector == null)
			{
				if (!silent)
					MessageBox.Show(this, "Error occured, try disconnect/connect");
				return false;
			}
			return true;
		}

		private void PopulateListView(IEnumerable<IPortsInfo> ports)
		{
			lvPorts.Items.Clear();
			foreach (var port in ports)
				lvPorts.Items.Add(port.GenerateListViewItem());
		}

		private void btnConnect_Click(object sender, EventArgs e)
		{
			gpActions.Enabled = false;
			lblPort.Text = "";

			string status = Connector.Create(txtURL.Text, DefaultFormatter.instance, out _connector);

			if (_connector == null)
			{
				MessageBox.Show(status);
			}
			else
			{
				EnableActions(true);
				ReadPorts();
				UpdateConnectedPort();
			}
		}

		private void UpdateConnectedPort()
		{
			lblPort.Text = _connector.GetConnectedPort();
		}

		private void EnableActions(bool enabled)
		{
			gpActions.Enabled = enabled;
			txtURL.Enabled = !enabled;

			if (enabled)
			{
				btnConnect.Click -= btnConnect_Click;
				btnConnect.Click += btnConnectDisconnect_Click;
				btnConnect.Text = "Disconnect";
			}
			else
			{
				btnConnect.Click -= btnConnectDisconnect_Click;
				btnConnect.Click += btnConnect_Click;
				btnConnect.Text = "Connect";
				lvPorts.Items.Clear();
			}
		}

		private void btnConnectDisconnect_Click(object sender, EventArgs e)
		{
			_connector = null;
			EnableActions(false);
		}

		private void btnPorts_Click(object sender, EventArgs e)
		{
			ReadPorts();
		}

		private void ReadPorts()
		{

			CheckedCall(() =>
			{
				PopulateListView(_connector.GetPorts());
			});
		}

		private void ConnectPort()
		{
			CheckedCall(() =>
			{
				if (lvPorts.SelectedItems?.Count > 0)
					_connector.ConnectToPort(GetSelectedPort());
				else
					MessageBox.Show(this, "Please select a port");
			});
		}

		private string GetSelectedPort()
		{
			return lvPorts.SelectedItems[0].SubItems[0].Text;
		}

		private void btnDisconnectPort_Click(object sender, EventArgs e)
		{
			CheckedCall(() =>
			{
				_connector.DisconnectPort();
			});
		}

		private void CheckedCall(Action action)
		{
			try
			{
				if (IsConnected())
				{
					action();
					UpdateConnectedPort();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(this, ex.Message);
			}
		}

		private void lvPorts_DoubleClick(object sender, EventArgs e)
		{
			using (frmSelectAction frm = new frmSelectAction())
			{
				frm.ShowDialog();
				switch (frm.Action)
				{
					case Actions.OpenPort:
						ConnectPort();
						break;
					case Actions.StartSimulator:
						StartSimulator();
						break;
				}

			}

		}

		private void StartSimulator()
		{
			//try
			//{
				using (SerialWriter writer = new SerialWriter(GetSelectedPort()))
				using (frmSimulator sim = new frmSimulator(writer))
				{
					this.Hide();
					sim.ShowDialog();
				}
			//}
			//catch (Exception ex) { this.Show(); MessageBox.Show(this, ex.Message); }
			this.Show();
		}
	}
}
