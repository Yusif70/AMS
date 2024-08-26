using AMS.Validations;
using System.ComponentModel.DataAnnotations;

namespace AMS.Models
{
    [ValidDestination(ErrorMessage = "Departing city and destination city cannot be the same")]
    [ValidReturnDate(ErrorMessage = "Return date must be later than the departure date")]
    public class Ticket
    {
        [Length(7, 7)]
        public required string Fincode { get; set; }
        [RegularExpression("(?:0|994)(?:12|51|50|55|70|77)[^\\w]{0,2}[2-9][0-9]{2}[^\\w]{0,2}[0-9]{2}[^\\w]{0,2}[0-9]{2}")]
        public required string Phone { get; set; }
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public required DateTime DepartureDate { get; set; }
        public required DateTime ReturnDate { get; set; }
        public required string DepartingCity { get; set; }
        public required string DestinationCity { get; set; }
        public required string Airline { get; set; }
    }
}
