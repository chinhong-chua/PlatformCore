using System.ComponentModel.DataAnnotations;
using Core.Models;

namespace Core.ValidationAttributes
{
    public class Ticket_EnsureDueDateAfterReportDate:ValidationAttribute
    {
          protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var ticket= validationContext.ObjectInstance as Ticket;
            if(!ticket.ValidateDueDateAfterReportDate()) return new ValidationResult("Due Date has to be after Report Date");
            return ValidationResult.Success;
        }
    }
}