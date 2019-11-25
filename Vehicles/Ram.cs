using System;

namespace InterfaceDemo
{
    public class Ram : IVehicle, IGasVehicle
    {
        public int FuelCapacity { get; set; }
        public int FuelLevel { get; set; }

        public void Drive()
        {
            Console.WriteLine("Roarrrr!!!");
        }

        public void RefuelTank()
        {
            FuelLevel = FuelCapacity;
        }
    }
}