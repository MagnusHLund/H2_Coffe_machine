using H2_Coffe_machine.Models.Coffee_machine_components;
using H2_Coffe_machine.Models.Coffee_machine_components.Filters;

namespace H2_Coffe_machine.Models
{
	internal abstract class CoffeeMachine
	{
		private protected PowerSwitch PowerSwitch { get; private set; }
		private protected Dispenser Dispenser { get; private set; }
		private protected Heater Heater { get; private set; }
		private protected WaterTank WaterTank { get; private set; }
		private protected float MaximumWater { get; private set; }

		internal CoffeeMachine(float maximumWater, PowerSwitch powerSwitch, Dispenser dispenser, Heater heater, WaterTank waterTank)
		{
			MaximumWater = maximumWater;
			PowerSwitch = powerSwitch;
			Dispenser = dispenser;
			Heater = heater;
			WaterTank = waterTank;
		}
	}

}
