using System;

namespace InterfacesIntro
{
    public class Zero : IVehicle, IElectricVehicle
    {
        public int BatterykWh { get; set; }

        public void ChargeBattery()
        {
            BatterykWh = 150;
        }

        public void Drive()
        {
            Console.WriteLine("Wooooosh!");
        }
    }
}