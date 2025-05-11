using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuscatInternationalAirportSystem.Models
{
    internal class Checkpoint
    {
        public int CheckpointId { get; set; }
        public int TerminalId { get; set; }
        public string TerminalName { get; set; }
        public int PassengerCapacity { get; set; }
        public string Location { get; set; }
    }
}
