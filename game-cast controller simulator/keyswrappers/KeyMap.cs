using game_cast_controller_simulator.usercontrol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game_cast_controller_simulator.keyswrappers
{
	class KeyMap
	{
		public static KeyMap A(KeyboardKey keyboardKey, hiLabel label) => new KeyMap(NesKeys.a, keyboardKey/*, "A"*/, label);

		public static KeyMap B(KeyboardKey keyboardKey, hiLabel label) => new KeyMap(NesKeys.b, keyboardKey/*, "B"*/, label);

		public static KeyMap Select(KeyboardKey keyboardKey, hiLabel label) => new KeyMap(NesKeys.select, keyboardKey/*, "SELECT"*/, label);

		public static KeyMap Start(KeyboardKey keyboardKey, hiLabel label) => new KeyMap(NesKeys.start, keyboardKey/*, "START"*/, label);

		public static KeyMap Up(KeyboardKey keyboardKey, hiLabel label) => new KeyMap(NesKeys.up, keyboardKey/*, "UP"*/, label);

		public static KeyMap Down(KeyboardKey keyboardKey, hiLabel label) => new KeyMap(NesKeys.down, keyboardKey/*, "DOWN"*/, label);

		public static KeyMap Left(KeyboardKey keyboardKey, hiLabel label) => new KeyMap(NesKeys.left, keyboardKey/*, "LEFT"*/, label);

		public static KeyMap Right(KeyboardKey keyboardKey, hiLabel label) => new KeyMap(NesKeys.right, keyboardKey/*, "RIGHT"*/, label);


		public NesKeys NesKey { get; private set; }
		public CustomizeKeysStates CustomizeKeysState { get => (CustomizeKeysStates)NesKey + 1; }
		//public string Message { get; private set; }
		public hiLabel Label { get; private set; }

		private KeyboardKey _keyboardkey;
		public KeyboardKey KeyboardKey
		{
			get => _keyboardkey;
			set
			{
				_keyboardkey = value; Label.Text = value.Key.ToString();
			}
		}

		public Keys Key { get => KeyboardKey.Key; set => KeyboardKey.Key = value; }


		public KeyMap(NesKeys neskey, KeyboardKey keyboardKey/*, string message*/, hiLabel label)
		{
			Label = label;
			NesKey = neskey;
			//Message = message;
			KeyboardKey = keyboardKey;
			KeyboardKey.ValueChanged += KeyboardKey_ValueChanged;
		}

		private void KeyboardKey_ValueChanged(object sender, EventArgs e)
		{
			Label.Text = KeyboardKey.Key.ToString();
		}

		public byte GetKeyMask(bool negatif)
		{
			int mask = 1 << (int)NesKey;
			return (byte)(negatif ? ~mask : mask);
		}
	}
}
