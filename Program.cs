using System;
using System.Collections.Generic;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IGasVehicle> gasGarage = new List<IGasVehicle>();
            List<IVehicle> testDriveLot = new List<IVehicle>();
            List<IElectricVehicle> chargingStation = new List<IElectricVehicle>();

            var myTesla = new Tesla();
            var myCessna = new Cessna();
            var myRam = new Ram();
            var bobbysRam = new Ram();
            var myZero = new Zero();
            var myPrius = new Prius();

            gasGarage.Add(myRam);
            gasGarage.Add(bobbysRam);
            gasGarage.Add(myCessna);
            gasGarage.Add(myPrius);

            chargingStation.Add(myTesla);
            chargingStation.Add(myZero);
            chargingStation.Add(myPrius);

            testDriveLot.Add(myTesla);
            testDriveLot.Add(myRam);
            testDriveLot.Add(myCessna);
            testDriveLot.Add(myZero);
            testDriveLot.Add(bobbysRam);
            testDriveLot.Add(myPrius);

            foreach (var vehicle in chargingStation)
            {
                vehicle.ChargeBattery();
            }

            foreach (var vehicle in testDriveLot)
            {
                vehicle.Drive();
            }
        }
    }
}