namespace BikeManagementSystemLib.Models
{
    public class Terrain: BaseEntity<int>
    {
        public string Name { get; set; }

        public Terrain(string name) : this(0, name) { }

        public Terrain(int id,string name): base(id)
        {
            Name = name;
        }
    }
}
