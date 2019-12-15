using System;
using System.Collections.Generic;
using System.Text;

namespace Ferrari
{
    public class Ferrari : ICar
    {
        private string model;
        private string driversName;

        public Ferrari(string driversName)
        {
            Model = "488-Spider";
            DriversName = driversName;
        }

        public string Model { get => model; set => model = value; }
        public string DriversName { get => driversName; set => driversName = value; }

        public string PushBrakes()
        {
            return "Brakes!";
        }

        public string PushGas()
        {
            return "Zadu6avam sA!";
        }

        public override string ToString()
        {
            return $"{Model}/{PushBrakes()}/{PushGas()}/{DriversName}";
        }
    }
}
