using MuscatInternationalAirportSystem.Context;
using MuscatInternationalAirportSystem.Models;

namespace MuscatInternationalAirportSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //initilize all entities
            // Airline
            var airline = new Airline
            {
                Name = "Oman Air",
                ContactNumber = "968-2453-1111",
                ContactEmail = "support@omanair.om",
                Person = "Ahmed Al Balushi"
            };

            // Terminal
            var terminal = new Terminal
            {
                TerminalName = "Terminal 1",
                Capacity = 5000,
                Location = "North Wing"
            };

            // Gate
            var gate = new Gate
            {
                TerminalId = 1,
                GateNumber = "A1",
                AirlineId = 1,
                AvailabilityStatus = "Available"
            };

            // Flight
            var flight = new Flight
            {
                AirlineId = 1,
                DepartureCity = "Muscat",
                DestinationCity = "Dubai",
                DepartureTime = DateTime.Now.AddHours(2),
                ArrivalTime = DateTime.Now.AddHours(4),
                Status = "On Time",
                GateID = 1
            };

            // Passenger
            var passenger = new Passenger
            {
                FirstName = "Salim",
                LastName = "Al Mamari",
                BirthDate = new DateTime(1995, 3, 15),
                Gender = 'M',
                Nationality = "Omani",
                PassportNumber = "A1234567",
                ContactPhone = "968-91234567",
                ContactEmail = "salim.mamari@example.om"
            };

            // Baggage
            var baggage = new Baggage
            {
                PassengerId = 1,
                Weight = 23.5,
                TrackingNumber = "OM12345"
            };

            // Security Checkpoint
            var checkpoint = new Checkpoint
            {
                TerminalId = 1,
                TerminalName = terminal.TerminalName,
                PassengerCapacity = 1000,
                Location = "North Entrance"
            };

            // Officer
            var officer = new Officer
            {
                FirstName = "Fatima",
                LastName = "Al Zadjali",
                Position = "Security Officer",
                Department = "Security",
                ContactPhone = "968-99887766",
                ContactEmail = "fatima.zadjali@airport.om",
            };

            // create object to DbContext
            ApplicatonDbContext context = new ApplicatonDbContext();
            context.Airlines.Add(airline);
            context.Terminals.Add(terminal);
            context.Gates.Add(gate);
            context.Flights.Add(flight);
            context.Passengers.Add(passenger);
            context.Baggages.Add(baggage);
            context.Checkpoints.Add(checkpoint);
            context.Officers.Add(officer);
            
            //save changes in DB
            context.SaveChanges();
        }
    }
}
