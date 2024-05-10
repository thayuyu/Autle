namespace Autle.Components.Model
{
    public class CarManufacturer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string PathStage1 { get; set; }
        // TODO: How many pictures per Brand?

        public CarManufacturer(int id, string name, string path1) 
        {
            ID = id;
            Name = name;
            PathStage1 = path1;
        }

        public CarManufacturer(string name)
        {
            Name = name;
        }
    }
}
