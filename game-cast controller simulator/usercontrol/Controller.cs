using System;
using System.Collections.Generic;
using System.Windows.Forms;
using game_cast_controller_simulator.keyswrappers;
using game_cast_controller_simulator.usercontrol.helpers;

namespace game_cast_controller_simulator.usercontrol
{
	public partial class Controller : UserControl
	{
		byte buttons = 0xff;
		

		hiLabel[] hiLabels;

		List<StateToNesKeyConverter> States = new List<StateToNesKeyConverter>() {
			new StateToNesKeyConverter(CustomizeKeysStates.None ),
			new StateToNesKeyConverter(CustomizeKeysStates.A),
			new StateToNesKeyConverter(CustomizeKeysStates.B),
			new StateToNesKeyConverter(CustomizeKeysStates.Select),
			new StateToNesKeyConverter(CustomizeKeysStates.Start),
			new StateToNesKeyConverter(CustomizeKeysStates.Up),
			new StateToNesKeyConverter(CustomizeKeysStates.Down),
			new StateToNesKeyConverter(CustomizeKeysStates.Left),
			new StateToNesKeyConverter(CustomizeKeysStates.Right)
		};
		private List<StateToNesKeyConverter>.Enumerator state;

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
				if (keyMap.KeyboardKey.Key == key)
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
				Keys keyboardkey = (Keys)(NativeFunctions.VkKeyScan(keyChar) & 0xff);

				KeyMapDictionary[state.Current.Neskey].KeyboardKey.Key = keyboardkey;

				// continue customization?
				if (!state.MoveNext())
					CustomizeStop();
				else
					UpdateHilite();
			}
		}
				
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
	}
}
