using System.ComponentModel.DataAnnotations;
using Core.Models;

namespace Core.ValidationAttributes
{
    public class Ticket_EnsureReportDate : ValidationAttribute
    {
          protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var ticket= validationContext.ObjectInstance as Ticket;
            if(!ticket.ValidateReportDatePresence()) return new ValidationResult("Report Date is required");
            return ValidationResult.Success;
        }
    }
}