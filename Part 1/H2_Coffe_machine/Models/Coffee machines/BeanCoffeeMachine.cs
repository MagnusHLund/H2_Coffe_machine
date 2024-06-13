using H2_Coffe_machine.Models.Coffee_machine_components;
using H2_Coffe_machine.Models.Coffee_machine_components.Filters;

namespace H2_Coffe_machine.Models.Coffee_machines
{
	internal class BeanCoffeeMachine : CoffeeMachine
	{
		private protected BeanStorage BeanStorage { get; private set; }
		private protected BeansFilter Filter { get; private set; }
		private protected Grinder Grinder { get; private set; }


		internal BeanCoffeeMachine(float maximumWater, PowerSwitch powerSwitch, Dispenser dispenser, Heater heater, WaterTank waterTank, BeanStorage beanStorage, BeansFilter filter, Grinder grinder) 
			: base (maximumWater, powerSwitch, dispenser, heater, waterTank) 
		{
			BeanStorage = beanStorage;
			Filter = filter;
			Grinder = grinder;
		}


		public void MakeCoffee(float waterLiters, int totalBeans)
		{
			WaterTank.AddWater(waterLiters);
			BeanStorage.AddBeans(totalBeans);
			PowerSwitch.SwitchPower();
			Heater.HeatWater(WaterTank.WaterInLiters);
			Grinder.GrindBeans((int)BeanStorage.CurrentCapacity);
			Filter.FilterCoffee();
			Dispenser.DispenseCoffee();
			PowerSwitch.SwitchPower();
		}
	}
}
