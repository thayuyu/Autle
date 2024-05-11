namespace Autle.Components.Model
{
    public class CarManufacturer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string PathStage1 { get; set; }
        public string PathStage2 { get; set; }
        public string PathStage3 { get; set; }
        // TODO: How many pictures per Brand?

        public CarManufacturer(int id, string name, string path1, string path2, string path3) 
        {
            ID = id;
            Name = name;
            PathStage1 = path1;
            PathStage2 = path2;
            PathStage3 = path3;
        }

        public CarManufacturer(string name)
        {
            Name = name;
        }
    }
}
