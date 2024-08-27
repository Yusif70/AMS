using System.ComponentModel.DataAnnotations;

namespace AMS.Validations
{
    public class ValidDateAttribute : ValidationAttribute
    {
        private readonly DateTime _currentDate;
        public ValidDateAttribute()
        {
            _currentDate = DateTime.Now;
        }
        public override bool IsValid(object? value)
        {
            var date = (DateTime?)value;
            if (date <= _currentDate)
            {
                return false;
            }
            return true;
        }
    }
}
