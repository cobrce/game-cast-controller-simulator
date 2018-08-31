using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game_cast_controller_simulator
{
	public enum Actions
	{
		None,
		OpenPort,
		StartSimulator
	}
	public partial class frmSelectAction : Form
	{
		public Actions Action = Actions.None;

		public frmSelectAction()
		{
			InitializeComponent();
		}

		private void btnConnectPort_Click(object sender, EventArgs e)
		{
			Action = Actions.OpenPort;
			Close();
		}

		private void btnStartSimulator_Click(object sender, EventArgs e)
		{
			Action = Actions.StartSimulator;
			Close();
		}
	}
}
