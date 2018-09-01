using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using game_cast_controller_simulator.formatters;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace game_cast_controller_simulator
{
	class Connector
	{
		public Uri URI { get; }
		public IFormatter Formatter { get; }


		private static HttpClient httpClient = new HttpClient();


		Uri _apiSerials;
		Uri ApiSerials { get => _apiSerials ?? (_apiSerials = new Uri(URI, "api/serials/")); }

		Uri _apiConnect;
		Uri ApiConnect { get => _apiConnect ?? (_apiConnect = new Uri(ApiSerials, "connect/")); }

		Uri _apiDisconnect;
		Uri ApiDisconnect { get => _apiDisconnect ?? (_apiDisconnect = new Uri(ApiSerials, "disconnect/")); }

		Uri _apiConnected;
		Uri ApiConnected { get => _apiConnected ?? (_apiConnected = new Uri(ApiSerials, "connected/")); }

		private Connector(Uri uri, IFormatter formatter)
		{
			URI = uri;
			Formatter = formatter;
		}

		internal static string Create(string url, IFormatter formatter, out Connector connector)
		{
			connector = null;
			try
			{
				WebRequest.Create(url).GetResponse();
				connector = new Connector(new Uri(url), formatter);
				return "Created";
			}
			catch (UriFormatException)
			{
				return "Provided URL has a wrong format";
			}
			catch (Exception ex) { return ex.Message; }
		}

		internal IEnumerable<IPortsInfo> GetPorts()
		{
			var res = httpClient.GetAsync(ApiSerials).Result;
			if (res.IsSuccessStatusCode)
				return Formatter.PortsFormat(res.Content.ReadAsStringAsync().Result);
			else
				throw new HttpRequestException();
		}

		internal bool ConnectToPort(string port)
		{
			string json = JsonConvert.SerializeObject(new Dictionary<string, string> { { "comName", port } });
			var stringContent = new StringContent(json, Encoding.UTF8, "application/json");
			var resp = httpClient.PostAsync(ApiConnect, stringContent).Result;
			return resp.IsSuccessStatusCode;
		}
		internal void DisconnectPort()
		{
			httpClient.PostAsync(ApiConnect, null);
		}

		internal string GetConnectedPort(out bool connected)
		{
			connected = false;
			var res = httpClient.GetAsync(ApiConnected).Result;
			if (res.IsSuccessStatusCode)
				return Formatter.ConnectedFormat(res.Content.ReadAsStringAsync().Result,out connected);
			else
			{
				return "N/A";
			}
		}
	}
}
