using System;
using System.Collections.Generic;
using System.Text;

namespace WorkAtHome
{
    internal class Car:Vehicle
    {
        public int FuelCapacity;
        public int CurrentCapacity;
        public Car(int fuelCapacity, int currentCapacity)
        {
            FuelCapacity = fuelCapacity;
            CurrentCapacity = currentCapacity;
        }

        public void AddFuel(int litr)
        {
            if (CurrentCapacity+litr > FuelCapacity)
            {
                Console.WriteLine("Bakın hecmini aşırsınız");
            }
            else
            {
                CurrentCapacity += litr;
            }
        }
    }
}
