using game_cast_controller_simulator.keyswrappers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace game_cast_controller_simulator
{
	class Config
	{
		// actual config 
		static Dictionary<ControllerIndex, Dictionary<NesKeys, KeyboardKey>> _keyMapConfig;
		static Dictionary<ControllerIndex, Dictionary<NesKeys, KeyboardKey>> KeyMapConfig
		{
			get
			{
				return _keyMapConfig ?? (_keyMapConfig = LoadFromFile());

			}
			set => _keyMapConfig = value;
		}


		static string _keymapConfigFile;
		public static string KeyMapConfigFile
		{
			get
			{
				return _keymapConfigFile ?? (_keymapConfigFile = Path.Combine(
														Path.GetDirectoryName(typeof(Config).Assembly.Location),
														"KeyMapConfig.json"
														));
			}
		}

		// default config
		static Dictionary<ControllerIndex, Dictionary<NesKeys, KeyboardKey>> _defaultKeyMapConfig = new Dictionary<ControllerIndex, Dictionary<NesKeys, KeyboardKey>>
		{
			{
				ControllerIndex.First,
				new Dictionary<NesKeys, KeyboardKey>()
				{
					{ NesKeys.b, new KeyboardKey(Keys.O)},
					{ NesKeys.a, new KeyboardKey(Keys.P )},
					{ NesKeys.select, new KeyboardKey(Keys.Space )},
					{ NesKeys.start, new KeyboardKey(Keys.Escape )},
					{ NesKeys.up, new KeyboardKey(Keys.E )},
					{ NesKeys.down, new KeyboardKey(Keys.D )},
					{ NesKeys.left, new KeyboardKey(Keys.S )},
					{ NesKeys.right, new KeyboardKey(Keys.F ) }
				}
			},
			{
				ControllerIndex.Second,
				new Dictionary<NesKeys, KeyboardKey>()
				{
					{ NesKeys.b, new KeyboardKey(Keys.NumPad7)},
					{ NesKeys.a, new KeyboardKey(Keys.NumPad8)},
					{ NesKeys.select, new KeyboardKey(Keys.NumPad9)},
					{ NesKeys.start, new KeyboardKey(Keys.NumPad0)},
					{ NesKeys.up, new KeyboardKey(Keys.NumPad5)},
					{ NesKeys.down, new KeyboardKey(Keys.NumPad2)},
					{ NesKeys.left, new KeyboardKey(Keys.NumPad1)},
					{ NesKeys.right, new KeyboardKey(Keys.NumPad3)}
				}
			}
		};

		internal static KeyboardKey GetKeyMapConfig(ControllerIndex index, NesKeys neskey)
		{
			CheckConfigForNull();
			CheckConfigController(index);
			CheckConfigNesKey(index, neskey);

			return KeyMapConfig[index][neskey];
		}

		private static void CheckConfigNesKey(ControllerIndex index, NesKeys neskey)
		{
			if (!KeyMapConfig[index].ContainsKey(neskey))
				KeyMapConfig[index][neskey] = _defaultKeyMapConfig[index][neskey].Clone();
		}

		private static void CheckConfigController(ControllerIndex index)
		{
			if (!KeyMapConfig.ContainsKey(index))
				KeyMapConfig[index] = new Dictionary<NesKeys, KeyboardKey>();
		}

		private static void CheckConfigForNull()
		{
			if (KeyMapConfig == null)
				KeyMapConfig = new Dictionary<ControllerIndex, Dictionary<NesKeys, KeyboardKey>>();
		}

		internal static void SaveToFile()
		{
			try
			{
				string json = JsonConvert.SerializeObject(KeyMapConfig, Formatting.Indented);
				File.WriteAllText(KeyMapConfigFile, json);
			}
			catch { }
		}

		private static Dictionary<ControllerIndex, Dictionary<NesKeys, KeyboardKey>> LoadFromFile()
		{
			Dictionary<ControllerIndex, Dictionary<NesKeys, KeyboardKey>> config;
			try
			{
				config = JsonConvert.DeserializeObject<Dictionary<ControllerIndex, Dictionary<NesKeys, KeyboardKey>>>(File.ReadAllText(KeyMapConfigFile));
			}
			catch
			{
				// this case will yield a clone of the default config
				config = new Dictionary<ControllerIndex, Dictionary<NesKeys, KeyboardKey>>();
			}
			CompleteConfig(config);
			return config;
		}

		private static void CompleteConfig(Dictionary<ControllerIndex, Dictionary<NesKeys, KeyboardKey>> config)
		{
			foreach (var key in _defaultKeyMapConfig.Keys)
			{
				if (!config.ContainsKey(key))
					config[key] = new Dictionary<NesKeys, KeyboardKey>();

				foreach (var subkey in _defaultKeyMapConfig[key].Keys)
					if (!config[key].ContainsKey(subkey))
						config[key][subkey] = _defaultKeyMapConfig[key][subkey].Clone();
			}
		}
	}
}
