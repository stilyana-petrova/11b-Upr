using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AirLineTicketsApplication.Entities
{
    public class Reservation
    {
        public int Id { get; set; }
        [Required]
        public int ClientId { get; set; }
        public Client Client { get; set; }
        [Required]
        public int FlightId { get; set; }
        public Flight Flight { get; set; }
        [Required]
        public DateTime ReservationDate { get; set; }
        [Required]
        public int NumberOfTickets { get; set; }
    }
}
