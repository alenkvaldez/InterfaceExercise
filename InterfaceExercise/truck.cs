using System;
namespace InterfaceExercise
{
	public class truck : IVehicle, ICompany
	{
		public truck()
		{
		}
        public string Make { get; set; } = "toyota";
        public string Model { get; set; } = "tacoma";
        public string FuelType { get; set; } = "gasoline";
        public bool AutoTrans { get; set; } = true;
        public string DriveType { get; set; } = "4wd";
        public decimal NumberOfEmployees { get; set; } = 1.5m;
        public bool HasChangedGears { get; set; } = true;

        public bool IsFamilyFriendly { get; set; } = true;
        public int NumberOfWheels { get; set; }
        public double NetWorth { get; set; }
        decimal ICompany.NetWorth { get; set; }

        public void Drive()
        {
            if (IsFamilyFriendly == true)
            {
                Console.WriteLine($"4 wheel drive {GetType().Name} now driving forward");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} now driving forward");
            }
        } 
             

        public void Reverse()
        {
            if (HasChangedGears == true)
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

        bool IVehicle.ChangeGears(bool isChanged)
        {
            throw new NotImplementedException();
        }

        public void Park()
        {
            throw new NotImplementedException();
        }
    }
}