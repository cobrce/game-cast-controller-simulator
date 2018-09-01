using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using game_cast_controller_simulator.usercontrol;

namespace game_cast_controller_simulator
{
	class Config
	{
		static Dictionary<ControllerIndex, Dictionary<NesKeys, Keys>> KeyMapConfig { get; set; }

		static Dictionary<ControllerIndex, Dictionary<NesKeys, Keys>> _defaultKeyMapConfig = new Dictionary<ControllerIndex, Dictionary<NesKeys, Keys>>
		{
			{
				ControllerIndex.First,
				new Dictionary<NesKeys, Keys>()
				{
					{ NesKeys.b, Keys.O },
					{ NesKeys.a, Keys.P },
					{ NesKeys.select, Keys.Space },
					{ NesKeys.start, Keys.Escape },
					{ NesKeys.up, Keys.E },
					{ NesKeys.down, Keys.D },
					{ NesKeys.left, Keys.S },
					{ NesKeys.right, Keys.F }
				}
			},
			{
				ControllerIndex.Second,
				new Dictionary<NesKeys, Keys>()
				{
					{ NesKeys.b, Keys.NumPad7 },
					{ NesKeys.a, Keys.NumPad8 },
					{ NesKeys.select, Keys.NumPad9 },
					{ NesKeys.start, Keys.NumPad0 },
					{ NesKeys.up, Keys.NumPad5 },
					{ NesKeys.down, Keys.NumPad2 },
					{ NesKeys.left, Keys.NumPad1 },
					{ NesKeys.right, Keys.NumPad3 }
				}
			}
		};

		internal static Keys GetKeyMapConfig(ControllerIndex index, NesKeys neskey)
		{
			if (KeyMapConfig?.ContainsKey(index) == true && KeyMapConfig[index].ContainsKey(neskey))
				return KeyMapConfig[index][neskey];
			else
				return _defaultKeyMapConfig[index][neskey];
		}
	}
}
