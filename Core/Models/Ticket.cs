using System;
using System.ComponentModel.DataAnnotations;
using Core.ValidationAttributes;

namespace Core.Models
{
    public class Ticket
    {
        public int? TicketId { get; set; }
        [Required]
        public int? ProjectId { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        public string Description { get; set; }
        [StringLength(50)]
        public string Owner { get; set; }
        [Ticket_EnsureReportDate]
        public DateTime? ReportDate { get; set; }
        [Ticket_EnsureFutureDate] 
        [Ticket_EnsureDueDate]
        [Ticket_EnsureDueDateAfterReportDate]
        public DateTime? DueDate { get; set; }
        public Project Project { get; set; }

        // When Creating ticket, if due date present, it has to be in future
        public bool ValidateFutureDate()
        {
            if (TicketId.HasValue) return true;
            if (!DueDate.HasValue) return true;

            return (DueDate.Value > DateTime.Now);
        }
        //When owner is assigned, report data need to present
        public bool ValidateReportDatePresence()
        {
            if (string.IsNullOrWhiteSpace(Owner)) return true;

            return ReportDate.HasValue;
        }

        //When Owner is assigbed, due date need to present
        public bool ValidateDueDatePresence()
        {
            if (string.IsNullOrWhiteSpace(Owner)) return true;

            return DueDate.HasValue;
        }
        //When due date and report date present, due date has to be later or equal
        public bool ValidateDueDateAfterReportDate()
        {
            if (!DueDate.HasValue || !ReportDate.HasValue) return true;

            return DueDate.Value.Date >= ReportDate.Value.Date;
        }
    }
}