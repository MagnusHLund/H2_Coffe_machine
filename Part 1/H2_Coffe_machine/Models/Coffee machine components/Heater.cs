namespace H2_Coffe_machine.Models.Coffee_machine_components
{
	internal class Heater
	{
		private protected int Wattage {  get; set; }
		private protected float MaxCelsius { get; set; }
		internal Heater(int wattage, float maxCelsius) 
		{
			Wattage = wattage;
			MaxCelsius = maxCelsius;
		}

		internal void HeatWater(float waterInTankInLiters)
		{
		}
	}
}
