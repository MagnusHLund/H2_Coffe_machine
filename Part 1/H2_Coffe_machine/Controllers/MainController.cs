using H2_Coffe_machine.Models.Coffee_machines;
using H2_Coffe_machine.Models.Factories;

namespace H2_Coffe_machine.Controllers
{
	internal class MainController
	{
		internal void Main()
		{
			int cupsToMake = 4;
			MakeBeansCoffee(cupsToMake);
			MakePowderCoffee(cupsToMake);
		}

		private void MakePowderCoffee(int cupsToMake)
		{
			float waterToAdd = CalculateWaterLiters(cupsToMake);
			int beansToAdd = CalculateBeansAmount(cupsToMake);

			CoffeeMachineFactory factory = new CoffeeMachineFactory();
			BeanCoffeeMachine coffeeMachine = factory.CreateBeanCoffeeMachine();

			coffeeMachine.MakeCoffee(waterToAdd, beansToAdd);
		}

		private void MakeBeansCoffee(int cupsToMake)
		{
			float waterToAdd = CalculateWaterLiters(cupsToMake);
			float powderToAdd = CalculatePowderGrams(cupsToMake);

			CoffeeMachineFactory factory = new CoffeeMachineFactory();
			PowderCoffeeMachine coffeeMachine = factory.CreatePowderCoffeeMachine();
			coffeeMachine.MakeCoffee(waterToAdd, powderToAdd);
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
