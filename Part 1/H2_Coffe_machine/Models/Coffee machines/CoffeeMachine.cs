using H2_Coffe_machine.Interfaces;
using H2_Coffe_machine.Models.Coffee_machine_components;

namespace H2_Coffe_machine.Models
{
	internal abstract class CoffeeMachine
	{
		private protected IPowerSwitch PowerSwitch { get; private set; }
		private protected IDispense Dispenser { get; private set; }
		private protected IHeater Heater { get; private set; }
		private protected ICapacity WaterTank { get; private set; }
		private protected float MaximumWater { get; private set; }

		internal CoffeeMachine(float maximumWater, IPowerSwitch powerSwitch, IDispense dispenser, IHeater heater, ICapacity waterTank)
		{
			MaximumWater = maximumWater;
			PowerSwitch = powerSwitch;
			Dispenser = dispenser;
			Heater = heater;
			WaterTank = waterTank;
		}
	}
}
