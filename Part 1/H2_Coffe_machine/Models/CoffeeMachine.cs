using H2_Coffe_machine.Interfaces;

namespace H2_Coffe_machine.Models
{
	internal abstract class CoffeeMachine : ICoffeeMachine
	{
		private protected Filter filter;
		private protected PowerSwitch powerSwitch;
		private protected WaterTank waterTank;
		private protected float BeansPerCup {  get; set; }

		internal CoffeeMachine(int maximumAmountOfBeans, float maximumAmountOfWater, float beansPerCup) 
		{
			BeansPerCup = beansPerCup;

			filter = new Filter(maximumAmountOfBeans);
			waterTank = new WaterTank(maximumAmountOfWater);
			powerSwitch = new PowerSwitch();
		}

		private protected virtual void MakeCoffee(int cupsToMake)
		{
			float waterPerCup = 0.24f;
			int beansPerCup = 200;
			float waterToAdd = waterPerCup * cupsToMake;
			float beansToAdd = beansPerCup * cupsToMake;
		}
	}
}
