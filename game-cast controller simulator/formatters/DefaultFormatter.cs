using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_cast_controller_simulator.formatters
{
	class DefaultFormatter : IFormatter
	{
		public static DefaultFormatter instance = new DefaultFormatter();

		class ConnectedJson
		{
			public string path;
			public bool connected;
		}

		public string ConnectedFormat(string result, out bool connected)
		{
			connected = false;
			try
			{
				var connectedJson = JsonConvert.DeserializeObject<ConnectedJson>(result);
				if (connectedJson.connected)
				{
					connected = true;
					return $"Port : {connectedJson.path}";
				}
				return "Port : None";
			}
			catch { }
			return "Can't read port";
		}

		public IEnumerable<IPortsInfo> PortsFormat(string jsonFormattedPorts)
		{
			return JsonConvert.DeserializeObject<IEnumerable<DefaultPortInfo>>(jsonFormattedPorts);
		}
	}
}
