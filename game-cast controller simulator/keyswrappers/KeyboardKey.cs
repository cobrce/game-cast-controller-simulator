using System;
using System.Windows.Forms;

namespace game_cast_controller_simulator.keyswrappers
{
	class KeyboardKey
	{
		public event EventHandler ValueChanged;

		Keys _key;
		public Keys Key
		{
			get => _key;
			set
			{
				_key = value;
				ValueChanged?.Invoke(this, null);
			}
		}

		public KeyboardKey(Keys key)
		{
			Key = key;
		}

		public KeyboardKey Clone()
		{
			return new KeyboardKey(this.Key);
		}
	}
}
