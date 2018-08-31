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
		private SerialWriter _serialWriter;

		int state = 0xff;


		enum NesKeys
		{
			a,
			b,
			select,
			start,
			up,
			down,
			left,
			right
		}

		Dictionary<Keys, NesKeys> KeyBitindex = new Dictionary<Keys, NesKeys>()
		{
			{Keys.R, NesKeys.a },
			{Keys.E, NesKeys.b},
			{Keys.Space, NesKeys.select},
			{Keys.Escape, NesKeys.start},
			{Keys.Up, NesKeys.up },
			{Keys.Down, NesKeys.down},
			{Keys.Left, NesKeys.left},
			{Keys.Right, NesKeys.right}
		};


		public frmSimulator(SerialWriter serialWriter)
		{
			_serialWriter = serialWriter;
			InitializeComponent();
		}

		private void frmSimulator_KeyDown(object sender, KeyEventArgs e)
		{
			if (TryGetKeyMask(e.KeyCode, true, out int mask))
			{
				state &= mask;
				SendKey();
			}
		}

		private void frmSimulator_KeyUp(object sender, KeyEventArgs e)
		{
			if (TryGetKeyMask(e.KeyCode, false, out int mask))
			{
				state |= mask;
				SendKey();
			}
		}

		private bool TryGetKeyMask(Keys key, bool negatif, out int mask)
		{
			mask = 0;
			if (KeyBitindex.TryGetValue(key, out NesKeys value))
			{
				mask = 1 << (int)value;
				if (negatif)
					mask = ~mask;
				return true;
			}
			return false;
		}

		private void SendKey()
		{
			_serialWriter.WriteState((byte)state);
		}

		private void frmSimulator_Load(object sender, EventArgs e)
		{
			SendKey();
		}
	}
}
