using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AirLineTicketsApplication.Entities
{
    public class Flight
    {
        public Flight()
        {
            this.Reservations = new HashSet<Reservation>();
        }
        public int Id { get; set; }
        [Required]

        public int FlightNumber { get; set; }

        [Required]
        public string StartingDestination { get; set; }
        [Required]
        public string EndingDestination { get; set; }

        [Required]
        public DateTime FlightDate { get; set; }
        [Required]
        public DateTime LandingDate { get; set; }

        [ForeignKey("Plane")]
        public int PlaneId { get; set; }
        public Plane Plane { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int PercentDiscount { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
    }
}
