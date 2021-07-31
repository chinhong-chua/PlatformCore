// using System;
// using System.ComponentModel.DataAnnotations;
// using Microsoft.AspNetCore.Mvc;
// using PlatformDemo2.ModelValidations;

// namespace PlatformDemo2.Controllers
// {
//     public class Ticket
//     {
//         [FromQuery(Name = "tid")]
//         public int? TicketId { get; set; }
//         [Required]
//         public int? ProjectId { get; set; }
//         [Required]
//         public string Title { get; set; }
//         public string Description { get; set; }

//         public string Owner { get; set; }
//         [Ticket_EnsureDueDateForOwner]
//         [Ticket_EnsureDueDateInFuture]
//         public DateTime? DueDate { get; set; }
//         public DateTime? EnteredDate { get; set; }
//     }
// }