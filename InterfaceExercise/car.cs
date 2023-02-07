using System;
namespace InterfaceExercise
{
	public class car : IVehicle , ICompany
	{
		public car()
		{
		}

        public string Make { get; set; } = "acura";
        public string Model { get; set; } = "tlx";
        public string FuelType { get; set; } = "gasoline";
        public bool AutoTrans { get; set; } = true;
        public string DriveType { get; set; } = "awd";
        public decimal NumberOfEmployees { get; set; } = 1.5m;
        public bool HasChangedGears { get; set; } = true;
        public int NumberOfWheels { get; set; } = 4;
        decimal ICompany.NumberOfEmployees { get; set; } = 1.5m;
        public decimal NetWorth { get; set; } = 200.5m;

        public void Drive()
        {
            Console.WriteLine($"the {GetType().Name} now driving forward");
        }
        public void Reverse()
        {
            if(HasChangedGears == true)
            {
                Console.WriteLine($"the {GetType().Name} now driving forward");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("cant reverse until we change gears");
            }
        }
        public void Park(bool v)
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"the {GetType().Name} now in park");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("cant park until we change gears");
            }
        }

        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }

        public void Park()
        {
            throw new NotImplementedException();
        }

        bool IVehicle.ChangeGears(bool isChanged)
        {
            throw new NotImplementedException();
        }
    }
}

