namespace BikeManagementSystemLib.Models
{
    public class BikeWearKey
    {
        public int BikeTypeId { get; set; }
        public int TerrainId { get; set; }

        public BikeWearKey(int bikeTypeId, int terrainId)
        {
            BikeTypeId = bikeTypeId;
            TerrainId = terrainId;
        }
    }
}
