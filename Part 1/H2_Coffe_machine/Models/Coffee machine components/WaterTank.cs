using H2_Coffe_machine.Interfaces;

namespace H2_Coffe_machine.Models.Coffee_machine_components
{
	internal class WaterTank : ICapacity
	{
		public float MaxCapacity {get; set;}
		public float CurrentCapacity { get; set; }

		public WaterTank(float maxCapacityInLiters) 
		{
			MaxCapacity = maxCapacityInLiters;
			CurrentCapacity = 0;
		}

		public void AddAmount(float waterToAddInLiters)
		{
			if(CurrentCapacity + waterToAddInLiters > MaxCapacity)
			{
				CurrentCapacity += waterToAddInLiters;
			}
			else
			{
				CurrentCapacity = MaxCapacity;
			}
		}
	}
}
	