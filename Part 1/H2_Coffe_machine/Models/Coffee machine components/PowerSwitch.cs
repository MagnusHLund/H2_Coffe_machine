using H2_Coffe_machine.Interfaces;

namespace H2_Coffe_machine.Models.Coffee_machine_components
{
	internal class PowerSwitch : IPowerSwitch
	{
		private bool TurnedOn { get; set; }

		public void SwitchPower()
		{
			TurnedOn = !TurnedOn;
		}
	}
}
