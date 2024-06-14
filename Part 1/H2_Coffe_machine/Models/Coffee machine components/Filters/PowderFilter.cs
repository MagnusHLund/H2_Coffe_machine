using H2_Coffe_machine.Interfaces;

namespace H2_Coffe_machine.Models.Coffee_machine_components.Filters
{
	internal class PowderFilter : IFilter, ICapacity
	{
		public float MaxCapacity { get; set; }
		public float CurrentCapacity { get; set; }
		public void FilterCoffee()
		{

		}

		public void AddAmount(float amount)
		{

		}
	}
}
