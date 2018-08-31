using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace game_cast_controller_simulator.formatters
{
	interface IFormatter
	{
		IEnumerable<IPortsInfo> PortsFormat(string jsonFormattedPorts);
		string ConnectedFormat(string result);
	}

	class DefaultFormatter : IFormatter
	{
		public static DefaultFormatter instance = new DefaultFormatter();

		class ConnectedJson
		{
			public string path;
			public bool connected;
		}

		public string ConnectedFormat(string result)
		{
			try
			{
				var connectedJson = JsonConvert.DeserializeObject<ConnectedJson>(result);
				if (connectedJson.connected)
					return $"Port : {connectedJson.path}";
				return "Port : None";
			}
			catch { }
			return "Can't read port";
		}

		public IEnumerable<IPortsInfo> PortsFormat(string jsonFormattedPorts)
		{
			return JsonConvert.DeserializeObject<ICollection<PortInfo>>(jsonFormattedPorts);
		}
	}


	interface IPortsInfo
	{
		ListViewItem GenerateListViewItem();
	}
	class PortInfo : IPortsInfo
	{
		public string comName, manufacturer, pnpId, locationId;
		
		public ListViewItem GenerateListViewItem()
		{
			return new ListViewItem(new string[] { comName, manufacturer });
		}
	}
}
