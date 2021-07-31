// using System.ComponentModel.DataAnnotations;
// using PlatformDemo2.Controllers;

// namespace PlatformDemo2.ModelValidations
// {
//     public class Ticket_EnsureDueDateForOwner : ValidationAttribute
//     {
//         protected override ValidationResult IsValid(object value, ValidationContext validationContext)
//         {
//             var ticket = validationContext.ObjectInstance as Ticket;
//             if(ticket!=null && !string.IsNullOrWhiteSpace(ticket.Owner)){
//                 if(!ticket.DueDate.HasValue)
//                 return new ValidationResult("Date is required when there's owner!");
//             }
//             return ValidationResult.Success;

//         }
//     }
// }