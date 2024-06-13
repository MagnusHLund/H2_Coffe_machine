using H2_Coffe_machine.Models.Coffee_machine_components;
using H2_Coffe_machine.Models.Coffee_machine_components.Filters;

namespace H2_Coffe_machine.Models.Coffee_machines
{
	internal class PowderCoffeeMachine : CoffeeMachine
	{
		private protected PowderFilter Filter { get; private set; }

		internal PowderCoffeeMachine(float maximumWater, PowerSwitch powerSwitch, Dispenser dispenser, Heater heater, WaterTank waterTank, PowderFilter filter)
			: base(maximumWater, powerSwitch, dispenser, heater, waterTank)
		{
			Filter = filter;
		}

		public void MakeCoffee(float waterLiters, float totalPowder)
		{
			WaterTank.AddWater(waterLiters);
			PowerSwitch.SwitchPower();
			Heater.HeatWater(WaterTank.WaterInLiters);
			Filter.Powder = totalPowder;
			Filter.FilterCoffee();
			Dispenser.DispenseCoffee();
			PowerSwitch.SwitchPower();
		}
	}
}
