namespace Autle.Components.Model
{
    public class FictionalCar
    {
        public int CID { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string Class { get; set; }
        public int Seats { get; set; }
        public double TopSpeed { get; set; }
        public string UpdateName { get; set; }
        public int UpdateYear { get; set; }
        public string PlaceToBuy { get; set; }

        public FictionalCar(int cid, string name, string manufacturer, string inputclass, int seats, double topspeed, string updatename, int updateyear, string placetobuy) 
        { 
            CID = cid;
            Name = name;
            Manufacturer = manufacturer;
            Class = inputclass;
            Seats = seats;
            TopSpeed = topspeed;
            UpdateName = updatename;
            UpdateYear = updateyear;
            PlaceToBuy = placetobuy;
        }
        public FictionalCar(string name)
        {
            Name = name;
        }
    }
}
