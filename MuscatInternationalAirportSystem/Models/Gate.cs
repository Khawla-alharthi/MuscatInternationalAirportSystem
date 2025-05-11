using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuscatInternationalAirportSystem.Models
{
    internal class Gate
    {
        public int GateID { get; set; }
        public int TerminalId { get; set; }
        public string GateNumber { get; set; }
        public int AirlineId { get; set; }
        public string AvailabilityStatus { get; set; }
    }
}
