using System;

namespace InterfaceDemo
{
    public interface IGasVehicle
    {
        int FuelCapacity { get; set; }
        int FuelLevel { get; set; }
        void RefuelTank();
    }
}