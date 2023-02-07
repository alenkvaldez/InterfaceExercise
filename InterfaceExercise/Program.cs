using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new car();

            var truck = new truck();

            var vehicles = new List<IVehicle>() { car, truck};

            foreach (var vehicle in vehicles)
            {
                vehicle.Drive();
                vehicle.Reverse();
                vehicle.Park();
            }
        }
    }
}
