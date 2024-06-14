using H2_Coffe_machine.Interfaces;

namespace H2_Coffe_machine.Models.Coffee_machine_components
{
	internal class Heater : IHeater
	{
		private protected int Wattage {  get; set; }
		private protected float MaxCelsius { get; set; }
		internal Heater(int wattage, float maxCelsius) 
		{
			Wattage = wattage;
			MaxCelsius = maxCelsius;
		}

		public void HeatWater(float waterInTankInLiters)
		{
		}
	}
}
