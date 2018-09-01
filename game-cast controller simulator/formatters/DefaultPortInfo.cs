using System.Windows.Forms;

namespace game_cast_controller_simulator.formatters
{
	class DefaultPortInfo : IPortsInfo
	{
		public string comName, manufacturer, pnpId, locationId;

		public ListViewItem GenerateListViewItem()
		{
			return new ListViewItem(new string[] { comName, manufacturer });
		}
	}
}
