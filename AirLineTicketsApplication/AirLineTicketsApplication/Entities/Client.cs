using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AirLineTicketsApplication.Entities
{
    public class Client
    {
        public Client()
        {
            this.Reservations = new HashSet<Reservation>();
        }
        public int Id { get; set; }
        [Required]

        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Address { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
    }
}
