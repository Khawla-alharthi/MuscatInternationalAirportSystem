using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuscatInternationalAirportSystem.Models
{
    internal class Officer
    {
        public int OfficerId { get; set; }
        public int CheckpointId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }


    }
}
