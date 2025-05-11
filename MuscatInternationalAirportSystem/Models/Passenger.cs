using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuscatInternationalAirportSystem.Models
{
    internal class Passenger
    {
        public int PassengerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public char Gender { get; set; }
        public string Nationality { get; set; }
        public string PassportNumber { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
    }
}
