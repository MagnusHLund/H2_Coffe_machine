namespace H2_Coffe_machine.Controllers
{
	internal class MainController
	{
		internal void Main()
		{
			CoffeeController coffeeController = new CoffeeController();

			coffeeController.MakeBeanCoffee();
			coffeeController.MakePowderCoffee();
		}

	}
}
