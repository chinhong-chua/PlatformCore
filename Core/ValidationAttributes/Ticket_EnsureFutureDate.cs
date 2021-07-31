using System.ComponentModel.DataAnnotations;
using Core.Models;

namespace Core.ValidationAttributes
{
    public class Ticket_EnsureFutureDate : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var ticket= validationContext.ObjectInstance as Ticket;
            if(!ticket.ValidateFutureDate()) return new ValidationResult("Future Date is required");
            return ValidationResult.Success;
        }
    }
}