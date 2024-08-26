using AMS.Models;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace AMS.Validations
{
    public class ValidDestinationAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            var ticket = value as Ticket;
            if (ticket != null && ticket.DepartingCity == ticket.DestinationCity)
            {
                return false;
            }
            return true;
        }
    }
}
