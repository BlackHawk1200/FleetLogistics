using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FleetLogistics.Models
{
    public class FleetVehicle
    {
        public int Id { get; set; }
        public int FleetId { get; set; }
        public string VehicleRegNumber { get; set; }
    }
}
