using H2_Coffe_machine.Interfaces;

namespace H2_Coffe_machine.Models
{
	internal class WaterTank : IWaterTank
	{
		private float _maxCapacityInLiters;
		private Heater _heater;
		private protected float WaterInTankInLiters { get; set; }

		public WaterTank(float maxCapacityInLiters) 
		{
			_maxCapacityInLiters = maxCapacityInLiters;
			WaterInTankInLiters = 0;

			int wattage = 1500;
			int maxCelsius = 94;
			_heater = new Heater(wattage, maxCelsius);
		}

		public void AddWater(float waterToAddInLiters)
		{
			if(WaterInTankInLiters + waterToAddInLiters > _maxCapacityInLiters)
			{
				WaterInTankInLiters += waterToAddInLiters;
			}
			else
			{
				WaterInTankInLiters = _maxCapacityInLiters;
			}
		}
	}
}
	