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
		string ConnectedFormat(string result, out bool connected);
	}	
}
