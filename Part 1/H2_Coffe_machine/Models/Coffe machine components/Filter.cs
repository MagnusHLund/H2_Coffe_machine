using H2_Coffe_machine.Interfaces;

namespace H2_Coffe_machine.Models
{
	internal class Filter : ICoffeeFilter
	{
		private readonly int _maximumAmountOfBeans;
		public int CurrentAmountOfBeans { get; set; }

		public Filter(int maximumAmountOfBeans) 
		{
			_maximumAmountOfBeans = maximumAmountOfBeans;
		}

		public void FilterBeans()
		{

		}
	}
}
