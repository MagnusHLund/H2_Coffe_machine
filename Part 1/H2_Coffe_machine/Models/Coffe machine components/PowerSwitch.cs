using H2_Coffe_machine.Interfaces;

namespace H2_Coffe_machine.Models
{
	internal class PowerSwitch : IPowerSwitch
	{
		public bool TurnedOn { get; set; }
	}
}
