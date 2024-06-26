﻿namespace Autle.Components.Model
{
    public class Car
    {
        public int CID { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string CarType { get; set; }
        public double HorsePwr { get; set; }
        public string Engine { get; set; }
        public int Doors { get; set; }
        public int ModelYear { get; set; }
        public double ZeroToHundred { get; set; }

        public Car(int cid, string name, string manufacturer, string cartype, double horsepwr, string engine, int doors, int modelyear, double zerotohundred)
        {
            CID = cid;
            Name = name;
            Manufacturer = manufacturer;
            CarType = cartype;
            HorsePwr = horsepwr;
            Engine = engine;
            Doors = doors;
            ModelYear = modelyear;
            ZeroToHundred = zerotohundred;
        }
        public Car (string name)
        {
            Name = name;
        }
    }
}
