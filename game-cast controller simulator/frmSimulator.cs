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
	public partial class frmSimulator : Form
	{
		

		public frmSimulator(SerialWriter serialWriter)
		{

			InitializeComponent();
			KeyPreview = true;

			controller1.SerialWriter = serialWriter;
			controller1.InitKeyMapDictionary(ControllerIndex.First);
			controller1.OnCustomize += ControllerN_OnCustomize;

			controller2.SerialWriter = serialWriter;
			controller2.InitKeyMapDictionary(ControllerIndex.Second);
			controller2.OnCustomize += ControllerN_OnCustomize;
		}


		// make sure that only one on is being customized
		private void ControllerN_OnCustomize(object sender, EventArgs e)
		{
			if (sender is usercontrol.Controller controller)
			{
				switch (controller.Index)
				{
					case ControllerIndex.First:
						controller2.CustomizeStop();
						break;
					case ControllerIndex.Second:
						controller1.CustomizeStop();
						break;
				}
			}
		}

		private void frmSimulator_KeyDown(object sender, KeyEventArgs e)
		{
			if (!controller1.Customizing && !controller2.Customizing)
			{
				controller1.KeyDown(e.KeyCode);
				controller2.KeyDown(e.KeyCode);
			}
		}

		private void frmSimulator_KeyUp(object sender, KeyEventArgs e)
		{
			if (!controller1.Customizing && !controller2.Customizing)
			{
				controller1.KeyUp(e.KeyCode);
				controller2.KeyUp(e.KeyCode);
			}
		}


		private void frmSimulator_Load(object sender, EventArgs e)
		{
			controller1.AllButtonsUp();
			controller2.AllButtonsUp();
		}

		private void frmSimulator_KeyPress(object sender, KeyPressEventArgs e)
		{
			controller1.KeyPress(e.KeyChar);
			controller2.KeyPress(e.KeyChar);
		}
	}
}
