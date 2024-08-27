using AMS.Models;
using System.ComponentModel.DataAnnotations;

namespace AMS.Validations
{
    public class ValidReturnDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            var ticket = value as Ticket;
            if (ticket != null && ticket.ReturnDate <= ticket.DepartureDate)
            {
                return false;
            }
            return true;
        }
    }
}
