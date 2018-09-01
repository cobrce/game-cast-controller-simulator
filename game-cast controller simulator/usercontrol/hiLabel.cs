using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game_cast_controller_simulator.usercontrol
{
	public partial class hiLabel : Label
	{
		static Dictionary<Color, Color> colors = new Dictionary<Color, Color>()
		{
			{ Color.Black,Color.Blue },
			{ Color.Blue,Color.Red },
			{ Color.Red,Color.Yellow },
			{ Color.Yellow,Color.Green },
			{ Color.Green,Color.Violet },
			{ Color.Violet,Color.White },
			{ Color.White,Color.Black }
		};


		public hiLabel()
		{
			InitializeComponent();
		}

		Color _defaultColor;

		bool _hilite;
		public bool Hilight
		{
			get => _hilite;
			set
			{
				if (value && !_hilite)
				{
					_defaultColor = ForeColor;
					ForeColor = Color.Black; // first value in dictionary
					timer1.Start();
				}
				else if (!value && _hilite)
				{
					timer1.Stop();
					ForeColor = _defaultColor;
				}
				_hilite = value;
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			Invoke(new Action(() =>
			{
				if (colors.ContainsKey(ForeColor))
					ForeColor = colors[ForeColor];
				else
					ForeColor = Color.Black;
			}));
		}
	}
}
