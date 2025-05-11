using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuscatInternationalAirportSystem.Models
{
    internal class Flight
    {
        public int FlightId { get; set; }
        public int AirlineId { get; set; }
        public string DepartureCity { get; set; }
        public string DestinationCity { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public string Status { get; set; }
        public int GateID { get; set; }
    }
}
