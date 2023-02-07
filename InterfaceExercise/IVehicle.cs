using System;
namespace InterfaceExercise
{
	public interface IVehicle
	{
		public int NumberOfWheels { get; set; }
		public string FuelType { get; set; }
		public bool AutoTrans { get; set; }
		public string DriveType { get; set; }
		public bool HasChangedGears { get; set; }

		public void Drive();
		public void Reverse();
		public void Park();
        bool ChangeGears(bool isChanged);
    }
}
