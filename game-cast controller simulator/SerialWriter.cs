using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace game_cast_controller_simulator
{
	public class SerialWriter:IDisposable
	{
		public string PortName { get; }
		private SerialPort _serialPort;

		public SerialWriter(string portName)
		{
			this.PortName = portName;
			this._serialPort = new SerialPort(portName);
			_serialPort.Open();
		}

		internal void WriteState(byte controller,byte state)
		{
			byte[] data = new byte[] { controller, 01, state };
			_serialPort.Write(data, 0, data.Length);
		}

		public void Dispose()
		{
			_serialPort.Close();
			_serialPort.Dispose();
		}
	}
}
