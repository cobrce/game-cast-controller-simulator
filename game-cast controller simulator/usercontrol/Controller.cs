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
	public partial class Controller : UserControl
	{
		byte buttons = 0xff;

		class StateToConverter
		{
			public CustomizeKeysStates State { get; }
			public NesKeys Neskey { get => (NesKeys)(State - 1); }

			public StateToConverter(CustomizeKeysStates state)
			{
				State = state;
			}

		}

		hiLabel[] hiLabels;

		List<StateToConverter> States = new List<StateToConverter>() {
			new StateToConverter(CustomizeKeysStates.None ),
			new StateToConverter(CustomizeKeysStates.A),
			new StateToConverter(CustomizeKeysStates.B),
			new StateToConverter(CustomizeKeysStates.Select),
			new StateToConverter(CustomizeKeysStates.Start),
			new StateToConverter(CustomizeKeysStates.Up),
			new StateToConverter(CustomizeKeysStates.Down),
			new StateToConverter(CustomizeKeysStates.Left),
			new StateToConverter(CustomizeKeysStates.Right)
		};
		private List<StateToConverter>.Enumerator state;

		Dictionary<NesKeys, KeyMap> KeyMapDictionary;

		public event EventHandler OnCustomize;

		public bool Customizing { get; private set; }

		public SerialWriter SerialWriter { get; set; }

		public ControllerIndex Index { get; set; }


		public Controller()
		{
			InitializeComponent();
			InitState();
			InitHiLabelsArray();
		}

		private void InitHiLabelsArray()
		{
			hiLabels = new hiLabel[]
			{
				lblA,
				lblB,
				lblSelect,
				lblStart,
				lblUp,
				lblDown,
				lblLeft,
				lblRight
			};
		}

		public void InitKeyMapDictionary(ControllerIndex index)
		{
			Index = index;
			KeyMapDictionary = new Dictionary<NesKeys, KeyMap>()
			{
				{NesKeys.a ,KeyMap.A(
						Config.GetKeyMapConfig(index,NesKeys.a),
						lblA
					)},
				{NesKeys.b,KeyMap.B(
						Config.GetKeyMapConfig(index,NesKeys.b),
						lblB
					)},
				{NesKeys.select,KeyMap.Select(
						Config.GetKeyMapConfig(index,NesKeys.select),
						lblSelect
					)},
				{NesKeys.start,KeyMap.Start(
						Config.GetKeyMapConfig(index,NesKeys.start),
						lblStart
					)},
				{NesKeys.up, KeyMap.Up(
						Config.GetKeyMapConfig(index,NesKeys.up),
						lblUp
					)},
				{NesKeys.down, KeyMap.Down(
						Config.GetKeyMapConfig(index,NesKeys.down),
						lblDown
					)},
				{NesKeys.left, KeyMap.Left(
						Config.GetKeyMapConfig(index,NesKeys.left),
						lblLeft
					)},
				{NesKeys.right, KeyMap.Right(
						Config.GetKeyMapConfig(index,NesKeys.right),
						lblRight
					)}
			};
		}

		private void InitState()
		{
			state = States.GetEnumerator();
			state.MoveNext();
		}

		private void pictureBox1_Resize(object sender, EventArgs e)
		{
			this.Size = pictureBox1.Size;
		}

		public new void KeyDown(Keys key)
		{
			KeyEvent(key, true);
		}

		public new void KeyUp(Keys key)
		{
			KeyEvent(key, false);
		}

		private void KeyEvent(Keys key, bool down)
		{
			foreach (var keyMap in KeyMapDictionary.Values)
			{
				if (keyMap.KeyboardKey == key)
				{
					UpdateButtonsState(down, keyMap.GetKeyMask(down));

					SerialWriter.WriteState((byte)Index, buttons);
					break;
				}
			}
		}

		private void UpdateButtonsState(bool down, byte mask)
		{
			buttons = (byte)(down ? buttons & mask : buttons | mask);
		}

		// used when customizing keys
		public new void KeyPress(char keyChar)
		{
			// are we customizing?
			if (state.Current.State != CustomizeKeysStates.None)
			{
				Keys keyboardkey = (Keys)(VkKeyScan(keyChar) & 0xff);

				KeyMapDictionary[state.Current.Neskey].KeyboardKey = keyboardkey;

				// continue customization?
				if (!state.MoveNext())
					CustomizeStop();
				else
					UpdateHilite();
			}
		}

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern short VkKeyScan(char ch);

		internal void AllButtonsUp()
		{
			SerialWriter.WriteState((byte)Index, 0xff);
		}

		private void lblCustomize_Click(object sender, EventArgs e)
		{
			OnCustomize?.Invoke(this, null);

			lblCustomize.Click -= lblCustomize_Click;
			lblCustomize.Click += lblCustomize_Stop;

			Customizing = true;
			lblCustomize.Text = "Stop";
			state.MoveNext();

			UpdateHilite();
		}

		private void lblCustomize_Stop(object sender, EventArgs e)
		{
			lblCustomize.Click -= lblCustomize_Stop;
			lblCustomize.Click += lblCustomize_Click;

			CustomizeStop();
		}


		private void UpdateHilite()
		{
			StopHiLite();

			if (KeyMapDictionary.TryGetValue(state.Current.Neskey, out KeyMap keymap))
				keymap.Label.Hilight = true;
		}

		private void StopHiLite()
		{
			foreach (var hilbl in hiLabels)
				hilbl.Hilight = false;
		}

		public void CustomizeStop()
		{
			Customizing = false;
			lblCustomize.Text = "Customize";
			InitState();
			StopHiLite();
		}


		class KeyMap
		{
			public static KeyMap A(Keys keyboardKey, hiLabel label) => new KeyMap(NesKeys.a, keyboardKey/*, "A"*/, label);

			public static KeyMap B(Keys keyboardKey, hiLabel label) => new KeyMap(NesKeys.b, keyboardKey/*, "B"*/, label);

			public static KeyMap Select(Keys keyboardKey, hiLabel label) => new KeyMap(NesKeys.select, keyboardKey/*, "SELECT"*/, label);

			public static KeyMap Start(Keys keyboardKey, hiLabel label) => new KeyMap(NesKeys.start, keyboardKey/*, "START"*/, label);

			public static KeyMap Up(Keys keyboardKey, hiLabel label) => new KeyMap(NesKeys.up, keyboardKey/*, "UP"*/, label);

			public static KeyMap Down(Keys keyboardKey, hiLabel label) => new KeyMap(NesKeys.down, keyboardKey/*, "DOWN"*/, label);

			public static KeyMap Left(Keys keyboardKey, hiLabel label) => new KeyMap(NesKeys.left, keyboardKey/*, "LEFT"*/, label);

			public static KeyMap Right(Keys keyboardKey, hiLabel label) => new KeyMap(NesKeys.right, keyboardKey/*, "RIGHT"*/, label);


			public NesKeys NesKey { get; private set; }
			public CustomizeKeysStates CustomizeKeysState { get => (CustomizeKeysStates)NesKey + 1; }
			//public string Message { get; private set; }
			public hiLabel Label { get; private set; }

			private Keys _keyboardkey;
			public Keys KeyboardKey
			{
				get => _keyboardkey;
				set
				{
					_keyboardkey = value; Label.Text = value.ToString();
				}
			}


			public KeyMap(NesKeys neskey, Keys keyboardKey/*, string message*/, hiLabel label)
			{
				Label = label;
				NesKey = neskey;
				//Message = message;
				KeyboardKey = keyboardKey;
			}

			public byte GetKeyMask(bool negatif)
			{
				int mask = 1 << (int)NesKey;
				return (byte)(negatif ? ~mask : mask);
			}
		}
	}
}
