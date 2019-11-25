using System;

namespace InterfaceDemo
{
    public class Prius : IVehicle, IGasVehicle, IElectricVehicle
    {
        public int BatterykWh { get; set; }
        public int FuelCapacity { get; set; }
        public int FuelLevel { get; set; }

        public void ChargeBattery()
        {
            BatterykWh = 100;
        }

        public void Drive()
        {
            Console.WriteLine("zzzzzzzzzzzZZZZzzz");
        }

        public void RefuelTank()
        {
            FuelLevel = FuelCapacity;
        }
    }
}