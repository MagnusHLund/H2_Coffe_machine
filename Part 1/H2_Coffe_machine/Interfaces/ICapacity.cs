namespace H2_Coffe_machine.Interfaces
{
	internal interface ICapacity
	{
		float MaxCapacity { get; set; }
		float CurrentCapacity { get; set; }
		void AddAmount(float amount);
	}
}
