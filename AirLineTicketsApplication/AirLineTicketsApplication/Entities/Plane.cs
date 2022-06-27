using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AirLineTicketsApplication.Entities
{
    public class Plane
    {
        public Plane()
        {
            this.Flights = new HashSet<Flight>();
        }
        public int Id { get; set; }
        [Required]

        public string PlaneCode { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Image { get; set; }

        [Required]
        public int Luggage { get; set; }
        [Required]
        public string BarOnBoard { get; set; }
        [Required]
        public int NumbrerOfSeats { get; set; }
        public ICollection<Flight> Flights { get; set; }
    }
}
