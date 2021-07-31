using System.ComponentModel.DataAnnotations;
using Core.Models;

namespace Core.ValidationAttributes
{
    public class Ticket_EnsureDueDate: ValidationAttribute
    {
          protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var ticket= validationContext.ObjectInstance as Ticket;
            if(!ticket.ValidateDueDatePresence()) return new ValidationResult("Due Date is required");
            return ValidationResult.Success;
        }
    }
}