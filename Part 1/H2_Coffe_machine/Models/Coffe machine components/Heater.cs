using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Coffe_machine.Models
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
