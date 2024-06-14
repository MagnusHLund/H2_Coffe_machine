using H2_Coffe_machine.Models.Coffee_machine_components.Filters;
using H2_Coffe_machine.Models.Coffee_machine_components;
using H2_Coffe_machine.Models.Coffee_machines;

namespace H2_Coffe_machine.Models.Factories
{
	internal class CoffeeMachineFactory
	{
		internal BeanCoffeeMachine CreateBeanCoffeeMachine()
		{
			float maxWaterInLiters = 1.5f;
			int heaterWattage = 1500;
			int heaterMaxTempCelsius = 94;
			int maxBeanCapacity = 1000;

			PowerSwitch powerSwitch = new PowerSwitch();
			Dispenser dispenser = new Dispenser();
			Heater heater = new Heater(heaterWattage, heaterMaxTempCelsius);
			WaterTank waterTank = new WaterTank(maxWaterInLiters);
			BeanStorage beanStorage = new BeanStorage(maxBeanCapacity);
			BeansFilter filter = new BeansFilter();
			Grinder grinder = new Grinder();

			BeanCoffeeMachine beanCoffeeMachine = new BeanCoffeeMachine(maxWaterInLiters, powerSwitch, dispenser, heater, waterTank, beanStorage, filter, grinder);

			return beanCoffeeMachine;
		}

		internal PowderCoffeeMachine CreatePowderCoffeeMachine()
		{
			float maxWaterInLiters = 2.1f;
			int heaterWattage = 1550;
			int heaterMaxTempCelsius = 95;

			PowerSwitch powerSwitch = new PowerSwitch();
			Dispenser dispenser = new Dispenser();
			Heater heater = new Heater(heaterWattage, heaterMaxTempCelsius);
			WaterTank waterTank = new WaterTank(maxWaterInLiters);
			PowderFilter filter = new PowderFilter();

			PowderCoffeeMachine powderCoffeeMachine = new PowderCoffeeMachine(maxWaterInLiters, powerSwitch, dispenser, heater, waterTank, filter);

			return powderCoffeeMachine;
		}
	}
}
