using System;

namespace InterfaceDemo
{
    public class Cessna : IVehicle, IGasVehicle
    {
        public int FuelCapacity { get; set; }
        public int FuelLevel { get; set; }

        public void Drive()
        {
            Console.WriteLine("Zooommmm!!");
        }

        public void RefuelTank()
        {
            FuelLevel = FuelCapacity;
        }
    }
}