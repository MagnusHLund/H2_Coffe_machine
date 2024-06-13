using H2_Coffe_machine.Models.Coffee_machine_components;
using H2_Coffe_machine.Models.Coffee_machine_components.Filters;
using H2_Coffe_machine.Models.Coffee_machines;

namespace H2_Coffe_machine.Controllers
{
	internal class CoffeeController
	{
		internal void MakeBeanCoffee()
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

			int cupsToMake = 4;

			float waterToAdd = CalculateWaterLiters(cupsToMake);
			int beansToAdd = CalculateBeansAmount(cupsToMake);

			beanCoffeeMachine.MakeCoffee(waterToAdd, beansToAdd);
		}

		internal void MakePowderCoffee()
		{
			float maxWaterInLiters = 2.1f;
			int heaterWattage = 1550;
			int heaterMaxTempCelsius = 95;

			PowerSwitch powerSwitch = new PowerSwitch();
			Dispenser dispenser = new Dispenser();
			Heater heater = new Heater(heaterWattage, heaterMaxTempCelsius);
			WaterTank waterTank = new WaterTank(maxWaterInLiters);
			PowderFilter filter = new PowderFilter();

			PowderCoffeeMachine beanCoffeeMachine = new PowderCoffeeMachine(maxWaterInLiters, powerSwitch, dispenser, heater, waterTank, filter);

			int cupsToMake = 5;

			float waterToAdd = CalculateWaterLiters(cupsToMake);
			float powderToAdd = CalculatePowderGrams(cupsToMake);

			beanCoffeeMachine.MakeCoffee(waterToAdd, powderToAdd);
		}

		private int CalculateBeansAmount(int cupsToMake)
		{
			int beansPerCup = 200;
			return beansPerCup * cupsToMake;
		}

		private float CalculateWaterLiters(int cupsToMake) 
		{
			float waterPerCup = 0.236f;
			return waterPerCup * cupsToMake;
		}

		private float CalculatePowderGrams(int cupsToMake)
		{
			float gramsPerCup = 8.3f;
			return gramsPerCup * cupsToMake;
		}
	}
}
