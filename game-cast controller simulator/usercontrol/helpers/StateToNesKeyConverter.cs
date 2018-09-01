using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_cast_controller_simulator.usercontrol.helpers
{
	class StateToNesKeyConverter
	{
		public CustomizeKeysStates State { get; }
		public NesKeys Neskey { get => (NesKeys)(State - 1); }

		public StateToNesKeyConverter(CustomizeKeysStates state)
		{
			State = state;
		}
	}
}
