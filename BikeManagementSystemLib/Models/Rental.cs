﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BikeManagementSystemLib.Models
{
    public class Rental: BaseEntity<long>
    {
        [Required]
        public long ClientID { get; set; }

        [Required]
        public int TerrainID { get; set; }

        [Required]
        public DateTime RentedFrom { get; set; }

        [Required]
        public DateTime RentedTo { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool AllBikesReturned { get; set; }
        public virtual Client Client { get; set; }
        public virtual Terrain Terrain { get; set; }
        public virtual ICollection<RentedBike> RentedBikes { get; set; } = [];

        public Rental() : base(0) { }

        public Rental(long clientID,int terrainID, DateTime rentedFrom, DateTime rentedTo) : this(0, clientID, terrainID, rentedFrom, rentedTo, false) {}

        public Rental(long id,long clientID, int terrainID, DateTime rentedFrom, DateTime rentedTo, bool allBikesReturned): base(id)
        {
            ClientID = clientID;
            TerrainID = terrainID;
            RentedFrom = rentedFrom;
            RentedTo = rentedTo;
            AllBikesReturned = allBikesReturned;
        }

        public Rental(Client client, Terrain terrain, DateTime rentedFrom,DateTime rentedTo): base(0)
        {
            Client = client;
            Terrain = terrain;
            RentedFrom = rentedFrom;
            RentedTo = rentedTo;
        }
    }
}
