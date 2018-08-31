using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace game_cast_controller_simulator
{
	public class SerialWriter
	{
		public string PortName { get; }
		private SerialPort _serialPort;

		public SerialWriter(string portName)
		{
			this.PortName = portName;
			this._serialPort = new SerialPort(portName);
			_serialPort.Open();
		}

		internal void WriteState(byte state)
		{
			byte[] data = new byte[] { 00, 01, state };
			_serialPort.Write(data, 0, data.Length);
		}

		~SerialWriter()
		{
			_serialPort.Close();
			_serialPort.Dispose();
		}
	}
}
