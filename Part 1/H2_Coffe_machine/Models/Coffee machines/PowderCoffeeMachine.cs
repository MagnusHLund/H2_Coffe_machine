using H2_Coffe_machine.Interfaces;
using H2_Coffe_machine.Models.Coffee_machine_components.Filters;

namespace H2_Coffe_machine.Models.Coffee_machines
{
	internal class PowderCoffeeMachine : CoffeeMachine
	{
		private protected PowderFilter Filter { get; private set; }

		internal PowderCoffeeMachine(float maximumWater, IPowerSwitch powerSwitch, IDispense dispenser, IHeater heater, ICapacity waterTank, PowderFilter filter)
			: base(maximumWater, powerSwitch, dispenser, heater, waterTank)
		{
			Filter = filter;
		}

		public void MakeCoffee(float waterLiters, float powderToAdd)
		{
			WaterTank.AddAmount(waterLiters);
			PowerSwitch.SwitchPower();
			Heater.HeatWater(WaterTank.CurrentCapacity);
			Filter.AddAmount(powderToAdd);
			Filter.FilterCoffee();
			Dispenser.Dispense();
			PowerSwitch.SwitchPower();
		}
	}
}
