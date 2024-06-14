using H2_Coffe_machine.Interfaces;

namespace H2_Coffe_machine.Models.Coffee_machine_components
{
	internal class BeanStorage : ICapacity
	{
		public float MaxCapacity { get; set; }
		public float CurrentCapacity { get; set; }

		internal BeanStorage(int maxCapacity) 
		{
			MaxCapacity = maxCapacity;
			CurrentCapacity = 0;
		}

		public void AddAmount(float beansToAdd)
		{
			if (CurrentCapacity + beansToAdd < MaxCapacity)
			{
				CurrentCapacity += beansToAdd;
			}
			else
			{
				CurrentCapacity = MaxCapacity;
			}
		}
	}
}
