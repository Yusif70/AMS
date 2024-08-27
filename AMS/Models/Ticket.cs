using AMS.Validations;
using System.ComponentModel.DataAnnotations;

namespace AMS.Models
{
    [ValidDestination(ErrorMessage = "Departing city and destination city cannot be the same")]
    [ValidReturnDate(ErrorMessage = "Return date must be later than the departure date")]
    public class Ticket
    {
        [Length(7, 7,ErrorMessage ="Length must be exactly 7 characters")]
        [RegularExpression("^[a-zA-Z0-9]*$",ErrorMessage ="No special characters are allowed")]
        public required string Fincode { get; set; }
        [RegularExpression("(?:0|994)(?:12|51|50|55|70|77)[^\\w]{0,2}[2-9][0-9]{2}[^\\w]{0,2}[0-9]{2}[^\\w]{0,2}[0-9]{2}",ErrorMessage ="Phone format is invalid")]
        public required string Phone { get; set; }
        [RegularExpression("^[A-Za-z]+$",ErrorMessage = "Only latin alphabets are allowed")]
        public required string Name { get; set; }
        [RegularExpression("^[A-Za-z]+$",ErrorMessage = "Only latin alphabets are allowed")]
        public required string Surname { get; set; }
        [ValidDate(ErrorMessage ="Invalid date")]
        public required DateTime DepartureDate { get; set; }
        public required DateTime ReturnDate { get; set; }
        public required string DepartingCity { get; set; }
        public required string DestinationCity { get; set; }
        public required string Airline { get; set; }
    }
}
