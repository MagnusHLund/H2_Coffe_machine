using H2_Coffe_machine.Interfaces;

namespace H2_Coffe_machine.Models.Coffee_machines
{
	internal class BeanCoffeeMachine : CoffeeMachine
	{
		private protected ICapacity BeanStorage { get; private set; }
		private protected IFilter Filter { get; private set; }
		private protected IGrinder Grinder { get; private set; }


		internal BeanCoffeeMachine(float maximumWater, IPowerSwitch powerSwitch, IDispense dispenser, IHeater heater, ICapacity waterTank, ICapacity beanStorage, IFilter filter, IGrinder grinder) 
			: base (maximumWater, powerSwitch, dispenser, heater, waterTank) 
		{
			BeanStorage = beanStorage;
			Filter = filter;
			Grinder = grinder;
		}


		public void MakeCoffee(float waterLiters, int totalBeans)
		{
			WaterTank.AddAmount(waterLiters);
			BeanStorage.AddAmount(totalBeans);
			PowerSwitch.SwitchPower();
			Heater.HeatWater(WaterTank.CurrentCapacity);
			Grinder.GrindBeans((int)BeanStorage.CurrentCapacity);
			Filter.FilterCoffee();
			Dispenser.Dispense();
			PowerSwitch.SwitchPower();
		}
	}
}
