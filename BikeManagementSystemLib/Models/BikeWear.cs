using System.ComponentModel.DataAnnotations;

namespace BikeManagementSystemLib.Models
{
    public class BikeWear: BaseEntity<BikeWearKey>
    {
        public int BikeTypeId { get => Id.BikeTypeId; set { Id.BikeTypeId = value; } }
        public int TerrainId { get => Id.TerrainId; set { Id.TerrainId = value; } }
        [Range(0,(double)decimal.MaxValue)]
        public decimal WearRatio { get; set; }

        public virtual BikeType BikeType { get; set; }
        public virtual Terrain Terrain { get; set; }

        public BikeWear(int bikeTypeId, int terrainId, decimal wearRatio) : this(new BikeWearKey(bikeTypeId, terrainId),wearRatio) { }

        public BikeWear(BikeWearKey id,decimal wearRatio): base(id)
        {
            WearRatio = wearRatio;
        }
    }
}
