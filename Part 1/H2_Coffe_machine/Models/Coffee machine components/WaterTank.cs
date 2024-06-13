namespace H2_Coffe_machine.Models.Coffee_machine_components
{
	internal class WaterTank
	{
		private float _maxCapacityInLiters {get; set;}
		internal float WaterInLiters { get; set; }

		public WaterTank(float maxCapacityInLiters) 
		{
			_maxCapacityInLiters = maxCapacityInLiters;
			WaterInLiters = 0;
		}

		public void AddWater(float waterToAddInLiters)
		{
			if(WaterInLiters + waterToAddInLiters > _maxCapacityInLiters)
			{
				WaterInLiters += waterToAddInLiters;
			}
			else
			{
				WaterInLiters = _maxCapacityInLiters;
			}
		}
	}
}
	