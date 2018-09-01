using System.Runtime.InteropServices;

namespace game_cast_controller_simulator.usercontrol.helpers
{
	class NativeFunctions
	{
		[DllImport("user32.dll")]
		internal static extern short VkKeyScan(char ch);
	}
}
